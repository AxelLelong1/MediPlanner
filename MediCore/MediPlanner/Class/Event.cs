using System;

namespace MediPlanner.Class
{
    public class Event
    {
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }
        public string Id { get; set; }

        public ExtendedProps ExtendedProps { get; set; }

        public Event() { }

        public Event(string title, DateTime start, DateTime end, bool allDay, string id, string source, string status)
        {
            Title = title;
            Start = start;
            End = end;
            AllDay = allDay;
            Id = id;
            ExtendedProps = new ExtendedProps(source, status);
        }
    }

    public class ExtendedProps
    {
        public string Source { get; set; }
        public string Status { get; set; }

        public ExtendedProps() { }

        public ExtendedProps(string source, string status)
        {
            Source = source;
            Status = status;
        }
    }
}
