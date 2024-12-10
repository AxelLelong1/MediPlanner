# -*- coding: utf-8 -*-

"""
Definition of models.
"""

from django.db import models

# Create your models here.

class Patient(models.Model):
    locations = [('SeinLocal',"Sein Local"),
                 ('SeinRegional',"Sein Regional"), 
                 ('SeinDIBH', 'Sein DIBH'), 
                 ('Hematologie', 'Hematologie'), 
                 ('Urologie', 'Urologie'),
                 ('Gynecologie', 'Gynécologie'),
                 ('Digestif','Digestif'),
                 ('Thorax','Thorax'),
                 ('Crane','Crâne'),
                 ('Sarcome', 'Sarcome'),
                 ('ORL', 'ORL'),
                 ('Dermatologie', 'Dermatologie'),
                 ('SpiroPoumon', 'Spiro Poumon'),
                 ('Medulloblastomes', 'Medulloblastomes'),
                 ('Membres', 'Membres'),
                 ('Palliatif', 'Palliatif'),
                 ('StereoIntraExtra', 'Stereo Intra/Extra')]
    nom = models.CharField(max_length=100)
    prenom = models.CharField(max_length=100)
    location = models.CharField(max_length=100)  # Localisation du traitement
    start_date = models.DateField()  # Date de début du traitement
    start_hour = models.TimeField(null=True, blank=True)
    tumor_size_x = models.DecimalField(max_digits=5, decimal_places=2, null=True, blank=True)  # Taille X de la tumeur
    tumor_size_y = models.DecimalField(max_digits=5, decimal_places=2, null=True, blank=True)  # Taille Y de la tumeur
    localization = models.CharField(max_length=100, choices=locations, default='SeinLocal')  # Type de traitement (exam, autre)
    
    def __str__(self):
        return self.nom

class Feedback(models.Model):
    name = models.CharField(max_length=100)
    email = models.EmailField()
    message = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)

    def __str__(self):
        return format("Feedback from {self.name} on {self.created_at}")
