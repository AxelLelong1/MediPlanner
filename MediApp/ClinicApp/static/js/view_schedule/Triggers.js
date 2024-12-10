document.addEventListener('DOMContentLoaded', function () {
    const centreSelect = document.getElementById('centre');
    if (centreSelect.value) { // Vérifie qu'un centre est déjà sélectionné
        centreSelect.dispatchEvent(new Event('change')); // Déclenche manuellement l'événement change
    }
});

