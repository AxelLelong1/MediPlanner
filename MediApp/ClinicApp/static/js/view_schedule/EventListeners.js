document.getElementById('slotDurationSelector').addEventListener('change', function () {
    const selectedValue = this.value;
    if (selectedValue === 'custom') {
        const customDuration = prompt("Veuillez entrer la durée sous la forme HH:MM:SS (ex: 00:20:00)");
        if (/^([0-1]\d|2[0-3]):[0-5]\d:[0-5]\d$/.test(customDuration)) {
            calendar.setOption('slotDuration', customDuration);
        } else {
            alert("Durée invalide. Assurez-vous d'utiliser le format HH:MM:SS.");
        }
    } else {
        calendar.setOption('slotDuration', selectedValue);
    }
});
document.addEventListener('DOMContentLoaded', function () {
    setupCentreMachineDependency('centre', 'machine'); // Pour le sélecteur principal
    setupCentreMachineDependency('editScheduleCentre', 'editMachine'); // Pour la surcouche d'édition
    setupCentreMachineDependency('addPopupCentre', 'add-popup-machine'); // Pour la surcouche d'ajout
});

export function setupCentreMachineDependency(centreSelectorId, machineSelectorId) {
    const centreSelect = document.getElementById(centreSelectorId);
    const machineSelect = document.getElementById(machineSelectorId);

    if (!centreSelect || !machineSelect) {
        console.error(`Les IDs ${centreSelectorId} ou ${machineSelectorId} sont introuvables.`);
        return;
    }

    // Ajout de l'événement de changement pour chaque centre spécifique
    centreSelect.addEventListener('change', function () {
        const centreId = this.value;

        // Désactive le select des machines avant d'envoyer la requête
        machineSelect.disabled = true;
        machineSelect.innerHTML = '<option value="" hidden>Chargement...</option>';

        if (centreId) {
            // Envoi de la requête Ajax pour récupérer les machines
            fetch(`/get_machines_for_centre/?centre_id=${centreId}`)
                .then(response => response.json())
                .then(data => {
                    const machines = data.machines;

                    // Réinitialisation et ajout des nouvelles options
                    machineSelect.innerHTML = '<option value="" hidden>Sélectionner une machine</option>';

                    if (machines.length > 0) {
                        machines.forEach(machine => {
                            const option = document.createElement('option');
                            option.value = machine.name.toUpperCase();
                            option.textContent = machine.id.toUpperCase();
                            machineSelect.appendChild(option);
                        });
                        machineSelect.disabled = false;
                    } else {
                        machineSelect.innerHTML = '<option value="" hidden>Aucune machine disponible</option>';
                    }
                })
                .catch(error => {
                    console.error('Erreur lors de la récupération des machines:', error);
                    machineSelect.innerHTML = '<option value="" hidden>Erreur de chargement</option>';
                });
        } else {
            // Réinitialisation en cas de sélection vide
            machineSelect.innerHTML = '<option value="" hidden>Sélectionner un centre d\'abord</option>';
            machineSelect.disabled = true;
        }
    });

    // Si un centre est déjà sélectionné au chargement de la page
    if (centreSelect.value) {
        centreSelect.dispatchEvent(new Event('change'));
    }
}