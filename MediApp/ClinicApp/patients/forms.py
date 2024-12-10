"""
Definition of forms.
"""

from django import forms
from .models import Patient, Feedback

class PatientForm(forms.ModelForm):
    class Meta:
        model = Patient
        fields = ['nom', 'prenom', 'start_date', 'start_hour', 'tumor_size_x', 'tumor_size_y', 'localization']
        widgets = {
            'nom': forms.TextInput(),
            'prenom': forms.TextInput(),
            'start_date': forms.DateInput(attrs={'type': 'date'}, format=["Y m d"]),
            'start_hour': forms.TimeInput(attrs={'type': 'time'}),
            'localization': forms.Select(),
            'tumor_size_x': forms.TextInput(attrs={'placeholder': 'Taille X en cm', 'size': '10'}),
            'tumor_size_y': forms.TextInput(attrs={'placeholder': 'Taille Y en cm', 'size': '10'}),
        }

class FeedbackForm(forms.ModelForm):
    class Meta:
        model = Feedback
        fields = ['name', 'email', 'message']
        widgets = {
            'message': forms.Textarea(attrs={'style':'width:100%; heigth:420px'})
            }

class CentreForm(forms.Form):
    name = forms.CharField(label="Nom du Centre", max_length=100)

class ResourceForm(forms.Form):
    def __init__(self, resource_choices, *args, **kwargs):
        super(ResourceForm, self).__init__(*args, **kwargs)
        self.fields['resources'].choices = resource_choices

    resources = forms.MultipleChoiceField(
        label="Selectionnez les ressources",
        widget=forms.CheckboxSelectMultiple,
        required=False
    )

class MachineForm(forms.Form):
    machines = forms.MultipleChoiceField(label='Selectionnez les machines', 
                                         widget=forms.CheckboxSelectMultiple, 
                                         required=True)

    def __init__(self, machine_choices, *args, **kwargs):
        super(MachineForm, self).__init__(*args, **kwargs)
        self.fields['machines'].choices = machine_choices