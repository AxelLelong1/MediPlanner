document.addEventListener('DOMContentLoaded', function () {
    const centreSelect = document.getElementById('centre');
    if (centreSelect.value) { // V�rifie qu'un centre est d�j� s�lectionn�
        centreSelect.dispatchEvent(new Event('change')); // D�clenche manuellement l'�v�nement change
    }
});

