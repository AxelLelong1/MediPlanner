document.addEventListener('DOMContentLoaded', function () {
    const calendarEl = document.getElementById('calendar');
    const tooltip = document.getElementById('tooltip');

    // Initialisation du calendrier
    calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'timeGridWeek',
        firstDay: 1,
        hiddenDays: [0],
        locale: 'fr',
        timeZone: 'Europe/Paris',
        headerToolbar: {
            left: "prev,next today",
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay'
        },
        slotMinTime: "06:00:00",
        slotMaxTime: "24:00:00",

        // Classe dynamique pour les événements
        eventClassNames: function (info) {
            return [info.event.extendedProps.status];
        },

        eventMouseEnter: function (info) {
            tooltip.textContent = info.event.title + " - Description ici";
            const eventPosition = info.el.getBoundingClientRect();
            tooltip.style.top = eventPosition.top + window.scrollY - tooltip.offsetHeight - 5 + 'px';
            tooltip.style.left = eventPosition.left + window.scrollX + info.el.offsetWidth / 2 - tooltip.offsetWidth / 2 + 'px';
            tooltip.style.display = 'block';
        },

        eventMouseLeave: function () {
            tooltip.style.display = 'none';
        },

        eventDrop: function (info) {
            markUnsavedChanges(info);
        },

        eventResize: function (info) {
            markUnsavedChanges(info);
        },

        // Mise à jour du planning en fonction des dates sélectionnées
        datesSet: function (info) {
            fetchEventsFromDjango(info.startStr, info.endStr, info.view.type);
        },
    });

    calendar.render();
});

export function removePatient(patientName) {
    const confirmation = confirm(`Êtes-vous sûr de vouloir supprimer le patient : ${patientName} ?`);
    if (confirmation) {
        deletePatient(patientName);
    }
}

export function openEditPatientPopup(patientName) {
    document.getElementById('editPatientPopup').style.display = 'block';
    document.getElementById('patientName').textContent = patientName;

    fetchSchedules(patientName);
}

export function closeEditPatientPopup() {
    document.getElementById('editPatientPopup').style.display = 'none';
}

// Fonction pour afficher la surcouche avec les données du schedule
function openEditScheduleOverlay(schedule) {
    const overlay = document.getElementById('editScheduleOverlay');
    overlay.classList.remove('hidden');

    // Pré-remplir les champs du formulaire
    document.getElementById('editStart').value = schedule.startTime;
    document.getElementById('editEnd').value = schedule.endTime;
    document.getElementById('editMachine').value = schedule.machine;

    // Ajouter un événement de soumission pour sauvegarder les modifications
    const form = document.getElementById('editScheduleForm');
    form.onsubmit = function (event) {
        event.preventDefault();
        saveSchedule(schedule.id);
    };
}

// Fonction pour fermer la surcouche
export function closeEditScheduleOverlay() {
    const overlay = document.getElementById('editScheduleOverlay');
    overlay.classList.add('hidden');
}

export function removeSchedule(id) {
    deleteSchedule(id);
}

export function openAddSchedule(patientName) {
    // Affiche la surcouche et met à jour le nom du patient
    document.getElementById("add-popup-overlay").style.display = "flex";
    document.getElementById("add-popup-patient-name").textContent = patientName;
}

export function closeAddPopup() {
    // Ferme la surcouche
    document.getElementById("add-popup-overlay").style.display = "none";
}

export function saveAddPopup() {
    // Récupère les valeurs des champs
    const machine = document.getElementById("add-popup-machine").value;
    const startDateTime = document.getElementById("add-popup-start-datetime").value;
    const endDateTime = document.getElementById("add-popup-end-datetime").value;
    const patName = document.getElementById("add-popup-patient-name").innerHTML;

    if (!machine || !startDateTime || !endDateTime) {
        alert("Veuillez remplir tous les champs.");
        return;
    }

    // Test : Afficher les valeurs
    addSchedule(patName, startDateTime, endDateTime, machine)
    // alert(`Créneau ajouté :\nMachine : ${machine}\nDébut : ${startDateTime}\nFin : ${endDateTime} for ${patName}`);

    // Ferme la surcouche après validation
    closeAddPopup();
}