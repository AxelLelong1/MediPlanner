from datetime import datetime, timedelta

# Stocke le planning dans la session avec une durée d'expiration d'une heure
def cache_schedule(request, cache_key, schedule_data, selected_machine, max_weeks_to_store=10, cache_duration_minutes=60):
    session_keys = list(request.session.keys())
    relevant_keys = [key for key in session_keys if key.startswith(f"schedule_data_{selected_machine}_")]
    
    # Limiter le nombre de semaines stockées pour chaque machine
    if len(relevant_keys) >= max_weeks_to_store:
        keys_to_remove = relevant_keys[:len(relevant_keys) - max_weeks_to_store + 1]
        for key in keys_to_remove:
            del request.session[key]
    
    # Ajouter le planning avec l'horodatage dans la session
    request.session[cache_key] = {
        'data': schedule_data,
        'timestamp': datetime.now().isoformat()  # Stocker l'horodatage du cache
    }

# Vérifie si le cache est valide (moins d'une heure)
def is_cache_valid(cache_data, cache_duration_minutes=60):
    cache_timestamp = datetime.fromisoformat(cache_data['timestamp'])
    if datetime.now() - cache_timestamp < timedelta(minutes=cache_duration_minutes):
        return True