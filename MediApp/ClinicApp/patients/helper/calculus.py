from datetime import datetime, timedelta
import json

# Formatage des horaires dans le planning
from datetime import datetime

# Calcule les dates de début et de fin de la semaine en fonction du décalage
def calculate_week_dates(week_offset):
    current_week_start = datetime.now().date() - timedelta(days=datetime.now().weekday())  # Lundi de la semaine en cours
    week_start = current_week_start + timedelta(weeks=week_offset)
    return week_start