"""
Definition of urls for ClinicApp.
"""

from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('', include('patients.urls')),
    path('admin/', admin.site.urls),
]