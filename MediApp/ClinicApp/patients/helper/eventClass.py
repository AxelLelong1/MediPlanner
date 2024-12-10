
import json
import requests
from datetime import datetime

class Event:
    def __init__(self, title, start, end, all_day, event_id, source, status):
        self.title = title
        self.start = start
        self.end = end
        self.all_day = all_day
        self.id = event_id
        self.source = source
        self.status = status

    def to_dict(self):
        return {
            "Title": self.title,
            "Start": self.start.isoformat(),
            "End": self.end.isoformat(),
            "AllDay": self.all_day,
            "Id": self.id,
            "ExtendedProps": {
                "Source": self.source,
                "Status": self.status
            }
        }
