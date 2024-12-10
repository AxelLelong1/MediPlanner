export function displayPatients(patients) {
    const popupconent = document.getElementById('popupPatient')
    const patientList = document.getElementById('patientList');
    patientList.innerHTML = ''; // Vide la liste avant d'ajouter les nouveaux patients

    if (document.getElementsByClassName('add-schedule-btn').length == 0) {
        const button = document.createElement('div')
        button.innerHTML = `
                <!-- Bouton d'ajout de créneau -->
                <button class="add-schedule-btn" onclick="openAddSchedule('${patients[0].firstName} ${patients[0].lastName}')">
                    Ajouter créneau
                </button>
                `;
        popupconent.appendChild(button)
    }


    patients.forEach(patient => {
        const patientItem = document.createElement('div');
        patientItem.classList.add('patient-item');

        // Structure HTML pour chaque patient
        patientItem.innerHTML = `
            <div>
                <div class="patient-name">${patient.firstName} ${patient.lastName}</div>
                <div class="patient-info">Nombre de créneaux : ${patient.schedules.length}</div>
            </div>
            <div class="patient-actions">
                <button onclick="openEditPatientPopup('${patient.firstName} ${patient.lastName}')"><i class="fas fa-edit"></i></button>
                <button onclick="removePatient('${patient.firstName} ${patient.lastName}')"><i class="fas fa-trash"></i></button>
            </div>
        `;

        patientList.appendChild(patientItem);
    });
}