# Generated by Django 2.2.28 on 2024-10-04 08:28

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('patients', '0001_initial'),
    ]

    operations = [
        migrations.RenameField(
            model_name='patient',
            old_name='name',
            new_name='nom',
        ),
        migrations.AddField(
            model_name='patient',
            name='prenom',
            field=models.CharField(default='default', max_length=100),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='patient',
            name='tumor_size_x',
            field=models.DecimalField(blank=True, decimal_places=2, max_digits=5, null=True),
        ),
        migrations.AddField(
            model_name='patient',
            name='tumor_size_y',
            field=models.DecimalField(blank=True, decimal_places=2, max_digits=5, null=True),
        ),
        migrations.AlterField(
            model_name='patient',
            name='treatment_type',
            field=models.CharField(choices=[('SeinLocal', 'Sein Local'), ('SeinRegional', 'Sein Regional'), ('SeinDIBH', 'Sein DIBH'), ('Hematologie', 'Hematologie'), ('Urologie', 'Urologie'), ('Gynecologie', 'Gynécologie'), ('Digestif', 'Digestif'), ('Thorax', 'Thorax'), ('Crane', 'Crâne'), ('Sarcome', 'Sarcome'), ('ORL', 'ORL'), ('Dermatologie', 'Dermatologie'), ('SpiroPoumon', 'Spiro Poumon'), ('Medulloblastomes', 'Medulloblastomes'), ('Membres', 'Membres'), ('Palliatif', 'Palliatif'), ('StereoIntraExtra', 'Stereo Intra/Extra')], default='SeinLocal', max_length=100),
        ),
    ]
