
from django.contrib import admin
from django.urls import path
from . import views

urlpatterns = [
    path('', views.home, name='home'),
    path('feedback/', views.feedback_view, name='feedback'),

    path('add_patient/', views.add_patient, name='add_patient'),
    path('choose_machine/', views.choose_machine, name='choose_machine'),

    path('view_schedule/', views.view_schedule, name='view_schedule'),
    path('deletePatient', views.deletepatient, name='deletePatient'),
    path('get_patient_schedules', views.fetchSchedulePatient, name='get_patient_schedules'),
    path('get_machines_for_centre/', views.get_machines_for_centre, name='get_machines_for_centre'),

    path('fetchEventsChanges', views.fetchEventsChanges, name='fetchEventsChanges'),
    path('updateEvents', views.updateEvents, name='updateEvents'),

    path('addSchedule', views.addSchedule, name='addSchedule'),
    path('deleteSchedule', views.removeSchedule, name='deleteSchedule'),
    path('updateSchedule', views.updateSchedule, name='updateSchedule'),
  
    path('admin/centres/', views.list_centres, name='list_centres'),
    path('admin/centres/create/', views.create_centre, name='create_centre'),
    path('admin/centres/edit/<int:centre_id>/', views.edit_centre, name='edit_centre'),
    path('admin/editMachinePreferences/<int:centre_id>/<str:machine_name>/', views.edit_machine_preferences, name='edit_machine_preferences'),
    path('admin/', admin.site.urls),

    path('import_centre_config/', views.import_centre_config, name='import_centre_config'),
    path('export_centre/', views.export_centre_config, name='export_centre'),
]
