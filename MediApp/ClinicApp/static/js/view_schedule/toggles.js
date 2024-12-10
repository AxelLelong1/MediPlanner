export function toggleSidebar() {
    const sidebar = document.getElementById('patientSidebar');
    const calendarContainer = document.getElementById('calendar');
    sidebar.classList.toggle('active');

    if (sidebar.classList.contains("active")) {
        calendarContainer.style.marginLeft = "300px";
    } else {
        calendarContainer.style.marginLeft = "0";
    }
}

export function togglePatientList() {
    const patientSidebar = document.getElementById("patientListSidebar");
    patientSidebar.classList.toggle("show");
}

export function toggleTimeField() {
    const timeField = document.getElementById('time_field');
    const requireHour = document.getElementById('require_hour');

    // Si la case est cochée, affiche le champ de l'heure
    if (requireHour.checked) {
        timeField.style.display = 'block';
    } else {
        timeField.style.display = 'none';
    }
}

export function addSchedule(name, start, end, machine) {

    // Requête AJAX pour sauvegarder les modifications
    fetch('{% url "addSchedule" %}', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({
            name: name,
            start: start,
            end: end,
            machine: machine
        }),
    })
        .then((response) => {
            if (response.ok) {
                location.reload(); // Recharge la page pour afficher les modifications
            } else {
                alert('Erreur lors de la modification du créneau');
            }
        })
        .catch((error) => console.error('Erreur:', error));

}

export function deleteSchedule(id) {
    // Requête AJAX pour sauvegarder les modifications
    fetch('{% url "deleteSchedule" %}', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({
            id: id
        }),
    })
        .then((response) => {
            if (response.ok) {
                closeEditScheduleOverlay();
                location.reload(); // Recharge la page pour afficher les modifications
            } else {
                alert('Erreur lors de la modification du créneau');
            }
        })
        .catch((error) => console.error('Erreur:', error));

}

export function deletePatient(patientName) {
    console.log("DELETE PATIENT CALLED");
    fetch('{% url "deletePatient" %}', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({
            patientName: patientName
        }),
    })
        .then((response) => {
            if (response.ok) {
                location.reload(); // Recharge la page pour afficher les modifications
            } else {
                alert('Erreur lors de la modification du créneau');
            }
        })
        .catch((error) => console.error('Erreur:', error));
}