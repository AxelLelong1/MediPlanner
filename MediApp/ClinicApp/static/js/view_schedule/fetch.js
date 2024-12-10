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
        .catch(error => console.error("Erreur lors de la r�cup�ration des �v�nements :", error));
}

// Fonction AJAX pour r�cup�rer les cr�neaux du patient
export function fetchSchedules(patientName) {
    // Assurez-vous que vous avez un endpoint dans Django pour obtenir les horaires
    fetch("{% url 'get_patient_schedules' %}", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({
            'patient_name': patientName  // Passer le nom du patient dans la requ�te
        })
    })
        .then(response => response.json())
        .then(data => {

            // Vider la liste actuelle des cr�neaux dans le popup
            const scheduleList = document.getElementById('scheduleList');
            scheduleList.innerHTML = '';  // Clear the previous schedule items

            // Si des cr�neaux sont retourn�s, les afficher
            if (data.schedules && data.schedules.length > 0) {
                data.schedules.forEach(schedule => {
                    const startDate = new Date(schedule.startTime);
                    const endDate = new Date(schedule.endTime);

                    const day = startDate.getDate().toString().padStart(2, '0'); // Jour avec un z�ro initial si n�cessaire
                    const month = (startDate.getMonth() + 1).toString().padStart(2, '0'); // Mois avec un z�ro initial si n�cessaire
                    const formattedDate = `${day}/${month}`;  // Format dd/mm

                    const startHour = startDate.toLocaleTimeString('fr-FR', { hour: '2-digit', minute: '2-digit' });
                    const endHour = endDate.toLocaleTimeString('fr-FR', { hour: '2-digit', minute: '2-digit' });

                    const scheduleItem = document.createElement('div');
                    scheduleItem.classList.add('schedule-item');

                    scheduleItem.innerHTML = `
                            <span>Jour: ${formattedDate}</span>
                            <span>Machine: ${schedule.machine}</span>
                            <span>D�but: ${startHour}</span>
                            <span>Fin: ${endHour}</span>
                            <button onclick='openEditScheduleOverlay(${JSON.stringify(schedule)})'><i class="fas fa-edit"></i> Modifier</button>
                            <button onclick="removeSchedule('${schedule.id}')"><i class="fas fa-trash"></i> Supprimer</button>
                            `;

                    scheduleList.appendChild(scheduleItem);  // Ajouter le cr�neau � la liste
                });
            } else {
                // Si aucun cr�neau n'est disponible
                scheduleList.innerHTML = '<p>Aucun cr�neau trouv� pour ce patient.</p>';
            }
        })
        .catch(error => {
            console.error('Erreur lors de la r�cup�ration des cr�neaux:', error);
        });
}

export function getCSRFToken() {
    return document.querySelector('[name=csrfmiddlewaretoken]').value;
}