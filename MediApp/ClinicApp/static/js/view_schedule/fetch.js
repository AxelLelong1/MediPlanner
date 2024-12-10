export function fetchEventsFromDjango(startDate, endDate, viewType) {

    const urlParams = new URLSearchParams(window.location.search);

    // Extraire la valeur de "machine"
    const machineValue = urlParams.get('machine');

    fetch("{% url 'fetchEventsChanges' %}", {
        method: 'POST',
        headers: { 'Content-Type': 'application/json', 'X-CSRFToken': getCSRFToken() },
        body: JSON.stringify({ start: startDate, end: endDate, view: viewType, machine: machineValue })
    })
        .then(response => response.json())
        .then(data => {
            calendar.removeAllEvents();
            calendar.addEventSource(data.events);
            displayPatients(data.addedPatients);
        })
        .catch(error => console.error("Erreur lors de la récupération des événements :", error));
}

// Fonction AJAX pour récupérer les créneaux du patient
export function fetchSchedules(patientName) {
    // Assurez-vous que vous avez un endpoint dans Django pour obtenir les horaires
    fetch("{% url 'get_patient_schedules' %}", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({
            'patient_name': patientName  // Passer le nom du patient dans la requête
        })
    })
        .then(response => response.json())
        .then(data => {

            // Vider la liste actuelle des créneaux dans le popup
            const scheduleList = document.getElementById('scheduleList');
            scheduleList.innerHTML = '';  // Clear the previous schedule items

            // Si des créneaux sont retournés, les afficher
            if (data.schedules && data.schedules.length > 0) {
                data.schedules.forEach(schedule => {
                    const startDate = new Date(schedule.startTime);
                    const endDate = new Date(schedule.endTime);

                    const day = startDate.getDate().toString().padStart(2, '0'); // Jour avec un zéro initial si nécessaire
                    const month = (startDate.getMonth() + 1).toString().padStart(2, '0'); // Mois avec un zéro initial si nécessaire
                    const formattedDate = `${day}/${month}`;  // Format dd/mm

                    const startHour = startDate.toLocaleTimeString('fr-FR', { hour: '2-digit', minute: '2-digit' });
                    const endHour = endDate.toLocaleTimeString('fr-FR', { hour: '2-digit', minute: '2-digit' });

                    const scheduleItem = document.createElement('div');
                    scheduleItem.classList.add('schedule-item');

                    scheduleItem.innerHTML = `
                            <span>Jour: ${formattedDate}</span>
                            <span>Machine: ${schedule.machine}</span>
                            <span>Début: ${startHour}</span>
                            <span>Fin: ${endHour}</span>
                            <button onclick='openEditScheduleOverlay(${JSON.stringify(schedule)})'><i class="fas fa-edit"></i> Modifier</button>
                            <button onclick="removeSchedule('${schedule.id}')"><i class="fas fa-trash"></i> Supprimer</button>
                            `;

                    scheduleList.appendChild(scheduleItem);  // Ajouter le créneau à la liste
                });
            } else {
                // Si aucun créneau n'est disponible
                scheduleList.innerHTML = '<p>Aucun créneau trouvé pour ce patient.</p>';
            }
        })
        .catch(error => {
            console.error('Erreur lors de la récupération des créneaux:', error);
        });
}

export function getCSRFToken() {
    return document.querySelector('[name=csrfmiddlewaretoken]').value;
}