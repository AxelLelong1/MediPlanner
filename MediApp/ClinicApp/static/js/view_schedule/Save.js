export function saveSchedule(id) {
    const updatedStart = document.getElementById('editStart').value;
    const updatedEnd = document.getElementById('editEnd').value;
    const updatedMachine = document.getElementById('editMachine').value;

    // Requête AJAX pour sauvegarder les modifications
    fetch('{% url "updateSchedule" %}', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({
            id: id,
            start: updatedStart,
            end: updatedEnd,
            machine: updatedMachine
        }),
    })
        .then((response) => {
            if (response.ok) {
                // alert('Créneau modifié avec succès');
                closeEditScheduleOverlay();
                location.reload(); // Recharge la page pour afficher les modifications
            } else {
                alert('Erreur lors de la modification du créneau');
            }
        })
        .catch((error) => console.error('Erreur:', error));

}

export function markUnsavedChanges(info) {
    hasUnsavedChanges = true;
    const saveButton = document.getElementById('saveButton');
    saveButton.classList.add('glow');
    const event = info.event;
    if (updatedEvents.some(x => x.id == event.id)) {
        updatedEvents.pop(updatedEvents.indexOf(x => x.id == event.id))
    }
    updatedEvents.push(event)
}

export function saveChanges() {
    const saveButton = document.getElementById('saveButton');

    fetch("{% url 'updateEvents' %}", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-CSRFToken': getCSRFToken()
        },
        body: JSON.stringify({ events: updatedEvents })
    })
        .then(response => {
            if (!response.ok) throw new Error('Erreur lors de la sauvegarde des modifications.');
            return response.json();
        })
        .then(data => {
            console.log('Modifications sauvegardées:', data);
            hasUnsavedChanges = false;
            saveButton.classList.remove('glow');
            updatedEvents = [];
        })
        .catch(error => {
            console.error('Erreur:', error);
            updatedEvents = [];
        });
}