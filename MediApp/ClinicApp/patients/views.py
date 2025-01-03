# -*- coding: utf-8 -*-

from tkinter import W
from django.shortcuts import render, redirect
from django.urls import reverse
from django.http import JsonResponse
from .forms import PatientForm, FeedbackForm, CentreForm, ResourceForm, MachineForm

from patients.helper.calculus import *
from patients.helper.cache import *
from patients.helper.fetch import *
from patients.helper.eventClass import *

import requests
import json
import pytz
import uuid

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

# Vue principale pour la page d'accueil
def home(request):
    request.session.flush()
    status, maintenance, number = fetch_machine_data()
    return render(request, 'patients/home.html', {
        'name': status,
        'machines_maintenance': maintenance,
        'numberPatient': number
    })

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

# Vue pour ajouter un patient
def add_patient(request):
    if request.method == 'POST':
        form = PatientForm(request.POST)
        require_hour = request.POST.get('require_hour') == 'on'

        if form.is_valid():
            # Extraire les données du formulaire
            urgence = form.cleaned_data['urgence']
            frac = form.cleaned_data['frac_per_week']
            week = form.cleaned_data['num_of_week']
            nom = form.cleaned_data['nom']
            prenom = form.cleaned_data['prenom']
            start_date = form.cleaned_data['start_date']
            localization = form.cleaned_data['localization']
            sizeX = form.cleaned_data['tumor_size_x']
            sizeY = form.cleaned_data['tumor_size_y']

            start_hour = form.cleaned_data['start_hour'] if require_hour else None

            # Redirection vers la page de choix de machine
            query_params = {
                'localization': localization,
                'start_date': start_date.isoformat(),
                'start_hour': start_hour,
                'sizeX': sizeX,
                'sizeY': sizeY,
                'name': nom,
                'surname': prenom,
                'urgence': urgence,
                'frac_per_week': frac,
                'num_of_week': week
            }

            return redirect(f"{reverse('choose_machine')}?{requests.compat.urlencode(query_params)}")
    else:
        form = PatientForm()
    return render(request, 'patients/add_patient.html', {'form': form})

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

# Vue pour choisir une machine
def choose_machine(request):
    # Récupérer les données passées via les paramètres GET
    urgence = request.GET.get('urgence')
    localization = request.GET.get('localization')
    
    frac = request.GET.get('frac_per_week')
    week = request.GET.get('num_of_week')

    start_date = request.GET.get('start_date')
    start_hour = request.GET.get('start_hour')
    
    sizeX = request.GET.get('sizeX')
    sizeY = request.GET.get('sizeY')
    
    name = request.GET.get('name')
    surname = request.GET.get('surname')
    current_centre = request.GET.get('centre')

    start_hour = start_hour if start_hour != "None" else None
    centres = get_centres_from_api()

    print(urgence, frac, week)

    if (current_centre != None):
        for c in centres:
            if (int(c.get('id')) == int(current_centre)):
                selected_centre = c
    else:
        selected_centre = None

    params = {
    'centerID': selected_centre.get('id') if selected_centre != None else 0,
    'localization': localization,
    'start_date': (datetime.strptime(start_date, "%Y-%m-%d")).isoformat(),
    'sizeX': sizeX,
    'sizeY': sizeY,
    'weeks': week
    }


    # Obtenir la machine préférée et les autres machines compatibles
    preferred_machine, other_machines = fetch_machines_choices(params)


    # Si le formulaire est soumis
    if request.method == 'POST':
        selected_machine = request.POST.get('machine')
        query_params = {
            'machine': selected_machine,
        }
        print(selected_machine)
        res = fetch_patient_schedule_from_api(name, surname, selected_machine, int(current_centre), start_date, start_hour, sizeX, sizeY, localization, frac, week)

        return redirect(f"{reverse('view_schedule')}?{requests.compat.urlencode(query_params)}")

    return render(request, 'patients/choose_machine.html', {
        'centres': centres,
        'selected_centre': selected_centre,
        'preferred_machine': preferred_machine,
        'other_machines': other_machines,
    })

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

def get_machines_for_centre(request):
    centre_id = request.GET.get('centre_id')
    
    if(centre_id):
        centre = get_centre_details(centre_id)
        if (centre != None):
            return JsonResponse({'machines': centre.get("machines")})

    return JsonResponse({'machines': []})

def view_schedule(request):
    params = get_form_view_param(request)
    selected_machine = params['selected_machine']
    selected_centre = params['selected_centre']

    print(params)

    form = PatientForm()

    centres = get_centres_from_api()

    return render(request, 'patients/view_schedule.html', {
        'form': form,
        'machines': [],
        'centres': centres,
        'selected_machine': selected_machine,
        'selected_centre': selected_centre
    })

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

def parse_date(date_string):
    """Parse the date and adjust to the Europe/Paris timezone."""
    paris_tz = pytz.timezone('Europe/Paris')
    try:
        # Convertir la date ISO
        naive_date = datetime.fromisoformat(date_string)
        local_date = naive_date.replace(tzinfo=pytz.utc).astimezone(paris_tz)
        return local_date
    except ValueError:
        # Autre format de date
        naive_date = datetime.strptime(date_string, '%d/%m/%Y %H:%M:%S')
        local_date = paris_tz.localize(naive_date)
        return local_date

def event_exists(events, new_event):
    for event in events:
        # Parse event start time and new event start time
        event_start = parse_date(event['start'])
        new_event_start = parse_date(new_event['startTime'])

        if event['title'] == new_event['name'] and event_start == new_event_start:
            return True

    return False

def get_fullcalendar_events(schedule_data):
    new_events = []
    for day in schedule_data:
        for data in day:

            if (data['name'] != "Signal" and data['name'] != "Libre"):

                status = data.get('note','')

                new_events.append({'title':data['name'], 
                               'start':data['startTime'], 
                               'end':data['endTime'], 
                               'id': data['id'],
                               'editable': (status == "BOOKED"), # Only booked are editable
                               'extendedProps': {
                                   'source': 'existing', 
                                   'status': status
                                   }
                               })

    # Retourner les événements formatés pour FullCalendar
    return new_events

def fetchEventsChanges(request):

    if request.method == 'POST':
        data = json.loads(request.body)
        start_date_str = data.get('start')
        selected_machine = data.get('machine')

        print(data)

        # Faire la demande à l'API C#
        start_date = datetime.fromisoformat(start_date_str)
        formatted_start_date = start_date.strftime('%Y-%m-%dT%H:%M:%S')

        schedule_data = fetch_schedule_from_api(selected_machine, formatted_start_date)
        e = get_fullcalendar_events(schedule_data) #existing_events) # TODO: find another way to fecth data and keep / min-max too long at the moment
        added = getAddedPatient()

        return JsonResponse({'events': e, 'addedPatients': added})

def fetchSchedulePatient(request):
    if request.method == 'POST':
        # Récupérer le nom du patient à partir de la requête
        data = json.loads(request.body)
        patient_name = data.get('patient_name')

        schedules = getSchedulePatient(patient_name)[0]

        print(f"SCHEDULES = {schedules}")

        return JsonResponse({'schedules': schedules})

    return JsonResponse({'error': 'Non Authorized Method'}, status=405)

def updateEvents(request):
    if request.method == "POST":
        try:
            data = json.loads(request.body)
            updated_events_data = data.get('events', [])  # Fetch updated events data
            print(updated_events_data)

            updated_events = [
                Event(
                    title=event['title'],
                    start=datetime.fromisoformat(event['start']),
                    end=datetime.fromisoformat(event['end']),
                    all_day=event['allDay'],
                    event_id=event['id'],
                    source=event.get('extendedProps', {}).get('source', ''),
                    status=event.get('extendedProps', {}).get('status', '')
                ) for event in updated_events_data
            ]

            # Envoyer la mise à jour
            success = send_update_event(updated_events)
            
            return JsonResponse({'status':'success',
                                 'message':'successfully applied update'})

        except Exception as e:
            return JsonResponse({'status':'error',
                                 'message':f'Error: {str(e)}'},status=500)

    return JsonResponse({'status':'error',
                        'messege': 'Invalid Request'}, status=400)

def deletepatient(request):
    if request.method == 'POST':
        data = json.loads(request.body)
        patientName = data.get('patientName')

        try:
            send_remove_patient(patientName)
            return JsonResponse({'success': True})
        except Exception as e:
            return JsonResponse({'success': False, 'error': e}, status=404)

    return JsonResponse({'success': False, 'error': 'Invalid request'}, status=400)


# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

def updateSchedule(request):
    if request.method == 'POST':
        data = json.loads(request.body)
        schedule_id = data.get('id')
        new_start = data.get('start')
        new_end = data.get('end')
        new_machine = data.get('machine')

        # Mettre à jour le créneau dans la base de données
        try:
            
            send_update_schedule(schedule_id, new_start, new_end, new_machine)

            return JsonResponse({'success': True})
        except Exception as e:
            return JsonResponse({'success': False, 'error': e}, status=404)

    return JsonResponse({'success': False, 'error': 'Invalid request'}, status=400)

def addSchedule(request):
    if request.method == 'POST':
        data = json.loads(request.body)
        name = data.get('name')
        new_start = data.get('start')
        new_end = data.get('end')
        new_machine = data.get('machine')

        # Mettre à jour le créneau dans la base de données
        try:
            
            send_add_schedule(name, new_start, new_end, new_machine)

            return JsonResponse({'success': True})
        except Exception as e:
            return JsonResponse({'success': False, 'error': e}, status=404)

    return JsonResponse({'success': False, 'error': 'Invalid request'}, status=400)

def removeSchedule(request):
    if (request.method) == 'POST':
        data = json.loads(request.body)
        schedule_id = data.get('id')

        try:
            send_remove_schedule(schedule_id)
            return JsonResponse({'success': True})

        except Exception as e:
            return JsonResponse({'success': False, 'error': e}, status=404)

    return JsonResponse({'success': False, 'error': 'Invalid request'}, status=400)

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

def feedback_view(request):
    if request.method == 'POST':
        form = FeedbackForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('home')  # Redirige vers la page d'accueil ou une autre page après envoi
    else:
        form = FeedbackForm()
    return render(request, 'patients/feedback.html', {'form': form})

# --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

def list_centres(request):
    
    centres = (requests.get(apiurl + "Admin/centres")).json()
    return render(request, 'admin/list_centres.html', {'centres': centres})

def create_centre(request):
    if request.method == 'POST':
        form = CentreForm(request.POST)
        if form.is_valid():
            name = form.cleaned_data['name']

            response = requests.post(apiurl + "Admin/createCentre", params={'centerName': name})
            if(response.ok):
                print(f"Centre créé : {name}")

            return redirect('list_centres')
    else:
        form = CentreForm()
    
    return render(request, 'admin/create_centre.html', {'form': form})

def edit_centre(request, centre_id):
    centre = requests.get(f"{apiurl}Admin/centres/{centre_id}").json()
    resources = requests.get(f"{apiurl}Admin/getRessources").json()

    resource_choices = [
        (str(resource['id']), f"{resource['firstName']} {resource['lastName']}")
        for resource in resources
    ]

    machines = requests.get(f"{apiurl}Admin/getMachines").json()
    machine_choices = [
        (str(machine['id']), machine['name'])
        for machine in machines
    ]
    
    if request.method == 'POST':
        form = ResourceForm(resource_choices, request.POST)
        machine_form = MachineForm(machine_choices, request.POST)

        # WANKY, you can put new guys without machines (and vice-versa)

        if form.is_valid() and machine_form.is_valid():
            selected_resources = form.cleaned_data['resources']
            selected_machines = machine_form.cleaned_data['machines']
            print(f"Centre {centre_id} mis à jour avec les ressources : {selected_resources} et les machines : {selected_machines}")  # Juste pour tester

            response = requests.post(f"{apiurl}Admin/editCentreResources/{centre_id}", json=selected_resources)
            print(response.status_code)
            if (response.ok):
                response2 = requests.post(f"{apiurl}Admin/editCentreMachines/{centre_id}", json=selected_machines)
                if(response2.ok):
                    return redirect('list_centres')

            return render(request, 'admin/edit_centre.html', {'form': form, 'machine_form': machine_form, 'centre': centre}) # something went wrong ...
    else:
        form = ResourceForm(resource_choices)
        machine_form = MachineForm(machine_choices)

    return render(request, 'admin/edit_centre.html', {'form': form, 'machine_form': machine_form, 'centre': centre})

def edit_machine_preferences(request, centre_id, machine_name):

    centre = requests.get(f"{apiurl}Admin/centres/{centre_id}").json()
    machine = requests.get(f'{apiurl}Admin/getMachineCenter/{centre_id}/{machine_name}').json()

    if request.method == "POST":
        data = (request.POST)
        print(f"DATA ARE {len(data)}")

        list_data = list(data)
        champs_x = data.get(list_data[1])
        champs_y = data.get(list_data[2])
        localisation = {} # Will store chosen setting

        item_1_done = False
        for i in range(3, len(list_data)):
            string = str(list_data[i])
            part, item = string.split('_')    

            if (localisation.get(part) != None):
                localisation[part] = (localisation.get(part)[0], (True if str(data.get(string)) == "on" else False))
            else:
                localisation[part] = (data.get(string), False)        
        
        print(localisation)
        send_machine_pref(centre_id, machine_name, champs_x, champs_y, localisation)

        return list_centres(request)

    return render(request, 'admin/edit_machine_pref.html', {
        'centre': centre,
        'machine': machine,
    })

def import_centre_config(request):
    if request.method == 'POST':
        config_file = json.loads(request.body)
        send_import_file(config_file)
        return JsonResponse({"Done": "Done"}, status=200)
    return JsonResponse({"error": "Invalid request"}, status=400)

def export_centre_config(request):
    try:
        centres = (requests.get(apiurl + "Admin/centres")).json()
        return JsonResponse(centres, safe=False)
    except Exception as e:
        return JsonResponse({"error": f'{e}'}, status=404)