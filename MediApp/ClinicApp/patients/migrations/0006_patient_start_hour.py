# Generated by Django 5.1.1 on 2024-10-09 09:06

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('patients', '0005_delete_patientrecord'),
    ]

    operations = [
        migrations.AddField(
            model_name='patient',
            name='start_hour',
            field=models.TimeField(blank=True, null=True),
        ),
    ]
