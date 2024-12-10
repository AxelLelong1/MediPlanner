from math import exp
from pickletools import read_stringnl_noescape_pair
from platform import machine
from xml.dom.expatbuilder import parseFragment

from datetime import datetime, timezone

import requests
import json
import pytz

apiurl = 'http://localhost:5001/'

# Helper pour obtenir les données de la machine depuis l'API
def fetch_machine_data():
    status = "Disconnected ..."
    maintenance = []
    number = 0

    # Récupérer le nombre de patients
    try:
        r = requests.get(apiurl + "Stats/numberPatient")
        if r.ok:
            status = "Connected !"
            number = r.text
    except:
        pass  # Ne rien faire en cas d'erreur

    # Récupérer les machines en maintenance
    try:
        r = requests.get(apiurl + "Stats/machinesMaintenance")
        if r.ok:
            maintenance = r.json()
            for m in maintenance:
                m['startDate'] = datetime.fromisoformat(m.get('startDate'))
                m['endDate'] = datetime.fromisoformat(m.get('endDate'))
    except:
        pass  # Ne rien faire en cas d'erreur

    return status, maintenance, number

# Helper pour récupérer la machine préférée et les compatibles
def fetch_machines_choices(params):
    preferred_machine = None
    other_machines = None

    try:
        r = requests.get(apiurl+"/Planning/preferredMachine", params=params)
        if r.ok:
            preferred_machine = r.json()
    except Exception as e:
        print(f'Erreur lors de la recuperation de la machine preferee: {e}')

    try:
        r = requests.get(apiurl+"/Planning/CompatibleMachines", params=params)
        if r.ok:
            other_machines = r.json()
    except Exception as e:
        print(f'Erreur lors de la recuperation des machines compatibles: {e}')

    return preferred_machine, other_machines


# Récupère les paramètres du formulaire
def get_form_view_param(request):
    return {
        'selected_machine': request.GET.get('machine'),
        'selected_centre': request.GET.get('centre')
    }

def get_centre_details(id):
    try:
        response = requests.get(apiurl + f"/Admin/centres/{id}")
        if response.ok:
            return response.json()
        else:
            print(f"Coudln't get machine of center {id}... - {response.text}")
            return None
    except Exception as e:
        print(f"Error while getting machines of center {id}... - {e}")
        return None

def get_centres_from_api():
    try:
        response = requests.get(apiurl + "/Admin/centres")
        if response.ok:
            return response.json()
        else:
            print(f"Coundln't get centres ... {response.text}")
            return []
    except Exception as e:
        print(f"Error while getting centres ... - {e}")
        return []

# Récupère le planning de la machine depuis l'API
def fetch_schedule_from_api(selected_machine, week_start):
    try:
        schedule_request = requests.get(apiurl + f"/Planning/schedule?machine={selected_machine}&startTime={week_start}")
        if schedule_request.ok:
            return schedule_request.json()
        else:
            print(f"{schedule_request.text}. CODE : {schedule_request.status_code}")
            return []
    except:
        return []

# Récupère le planning pour un patient
def fetch_patient_schedule_from_api(name, surname, selected_machine, selected_center_id, start_date, start_hour, tumor_size_x, tumor_size_y, localization):
    print("FETECHING")
    try:
        patient_params = {
            'machineName': selected_machine,
            'centreID': selected_center_id,
            'start_date': start_date,
            'start_hour': start_hour,
            'tumor_size_x': tumor_size_x,
            'tumor_size_y': tumor_size_y,
            'localization': localization,
            'name': name,
            'surname': surname
        }
        add_patient_request = requests.get(apiurl + "/Planning/AddPatient", params=patient_params)
        if add_patient_request.ok:
            return add_patient_request.json()
        else:
            print(f"An error occured while fetching patients {add_patient_request.text}")
            return []
    except:
            print(f"An error occured while fetching patients {add_patient_request.text}")
            return []


def send_update_event(events):
   
    events_data = [event.to_dict() for event in events]

    try:
        
        result = requests.post(apiurl + "/Planning/UpdateEvent", json=events_data, headers={"Content-Type": "application/json"})
        
        if result.ok:
            return True
        print(f"An error occurred while updating events - {result.content}")
        return False
    except Exception as e:
        print(f"An error occurred while updating events: {e}")
        return False

def send_add_schedule(name, start, end, machine):
   
    data = {
        "Name": name,
        "Start": start,
        "End": end,
        "Machine": machine
    }

    try:
        
        result = requests.post(apiurl + "/Planning/AddSchedule", json=data, headers={"Content-Type": "application/json"})
        if result.ok:
            return True
        print(f"An error occurred while adding event to {name} - {result.content}")
        return False
    except Exception as e:
        print(f"An error occurred while adding event to {name}: {e}")
        return False

def send_update_schedule(scheduleid, start, end, machine):
   
    data = {
        "scheduleId": scheduleid,
        "newStart": start,
        "newEnd": end,
        "machineName": machine
    }

    try:
        
        result = requests.post(apiurl + "/Planning/UpdateSchedule", json=data, headers={"Content-Type": "application/json"})
        
        if result.ok:
            return True
        print(f"An error occurred while updating events - {result.content}")
        return False
    except Exception as e:
        print(f"An error occurred while updating events: {e}")
        return False

def send_remove_schedule(scheduleid):
   
    data = {
        "ScheduleId": scheduleid,
    }

    try:
        
        result = requests.delete(apiurl + "/Planning/RemoveSchedule", json=data, headers={"Content-Type": "application/json"})
        
        if result.ok:
            return True
        print(f"An error occurred while removing event - {result.content}")
        return False
    except Exception as e:
        print(f"An error occurred while removing event: {e}")
        return False

def getAddedPatient():

    try:
        result = requests.get(apiurl + "/Planning/GetAddedPatients")
        if result.ok:
            return result.json()
        print(f"An error occurred while getting all added patient - {result.content}")
        return False
    except Exception as e:
        print(f"An error occurred while getting all added patient: {e}")
        return False

def send_remove_patient(patientName):
    data = {
        "PatientName": patientName,
    }

    try:
        result = requests.delete(apiurl + "/Planning/DeletePatient", json=data, headers={"Content-Type": "application/json"})
        
        if result.ok:
            return True
        print(f"An error occurred while removing patient {patientName} - {result.content}")
        return False
    except Exception as e:
        print(f"An error occurred while removing patient {patientName}: {e}")
        return False

def send_import_file(centerlist):
    try:
        result = requests.post(apiurl + "Admin/importCenters", json=centerlist, headers={"Content-Type": "application/json"})

        if result.ok:
            return True
        print(f'an error occured while importing centers {result.content}')
        return False
    except Exception as e:
        print(f'an error occured while importing centers {e}')
        return False

def send_machine_pref(centreid, machine_name, champs_x, champs_y, localisations):

    formatted_localisations = {
        key: {"Item1": value[0], "Item2": value[1]} for key, value in localisations.items()
    }

    data = {
        "champsX": int(champs_x),
        "champsY": int(champs_y),
        "localisations": formatted_localisations
    }

    try:

        result = requests.post(f"{apiurl}Admin/editMachinePref/{centreid}/{machine_name}", json=data, headers={"Content-Type": "application/json"})
        if result.ok:
            return True
        else:
            print(f"unable to update machine {machine_name} of center {centreid} because {result.text}")
    except Exception as e:
        print(f"unable to update machine {machine_name} of center {centreid} because {e}")
        return False



def getSchedulePatient(PatientName):

    params = {
        'patientName': PatientName
        }

    try:
        result = requests.get(apiurl + "/Planning/GetSchedulePatient", params=params)
       
        if (result.ok):
            return result.json()
        print(f"An error occured while fetching schedule for {PatientName} - {result.content}")
        return False
    except Exception as e:
        print(f"An error occured while fetching schedule for {PatientName}: {e}")
        return False