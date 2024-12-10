document.getElementById('slotDurationSelector').addEventListener('change', function () {
    const selectedValue = this.value;
    if (selectedValue === 'custom') {
        const customDuration = prompt("Veuillez entrer la dur�e sous la forme HH:MM:SS (ex: 00:20:00)");
        if (/^([0-1]\d|2[0-3]):[0-5]\d:[0-5]\d$/.test(customDuration)) {
            calendar.setOption('slotDuration', customDuration);
        } else {
            alert("Dur�e invalide. Assurez-vous d'utiliser le format HH:MM:SS.");
        }
    } else {
        calendar.setOption('slotDuration', selectedValue);
    }
});
document.addEventListener('DOMContentLoaded', function () {
    setupCentreMachineDependency('centre', 'machine'); // Pour le s�lecteur principal
    setupCentreMachineDependency('editScheduleCentre', 'editMachine'); // Pour la surcouche d'�dition
    setupCentreMachineDependency('addPopupCentre', 'add-popup-machine'); // Pour la surcouche d'ajout
});

export function setupCentreMachineDependency(centreSelectorId, machineSelectorId) {
    const centreSelect = document.getElementById(centreSelectorId);
    const machineSelect = document.getElementById(machineSelectorId);

    if (!centreSelect || !machineSelect) {
        console.error(`Les IDs ${centreSelectorId} ou ${machineSelectorId} sont introuvables.`);
        return;
    }

    // Ajout de l'�v�nement de changement pour chaque centre sp�cifique
    centreSelect.addEventListener('change', function () {
        const centreId = this.value;

        // D�sactive le select des machines avant d'envoyer la requ�te
        machineSelect.disabled = true;
        machineSelect.innerHTML = '<option value="" hidden>Chargement...</option>';

        if (centreId) {
            // Envoi de la requ�te Ajax pour r�cup�rer les machines
            fetch(`/get_machines_for_centre/?centre_id=${centreId}`)
                .then(response => response.json())
                .then(data => {
                    const machines = data.machines;

                    // R�initialisation et ajout des nouvelles options
                    machineSelect.innerHTML = '<option value="" hidden>S�lectionner une machine</option>';

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
                    console.error('Erreur lors de la r�cup�ration des machines:', error);
                    machineSelect.innerHTML = '<option value="" hidden>Erreur de chargement</option>';
                });
        } else {
            // R�initialisation en cas de s�lection vide
            machineSelect.innerHTML = '<option value="" hidden>S�lectionner un centre d\'abord</option>';
            machineSelect.disabled = true;
        }
    });

    // Si un centre est d�j� s�lectionn� au chargement de la page
    if (centreSelect.value) {
        centreSelect.dispatchEvent(new Event('change'));
    }
}