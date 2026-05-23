using System;
using System.Collections.Generic;
using System.Linq;
using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        private readonly List<Event> _events = new();
        private readonly Dictionary<Guid, List<Attendee>> _registrations = new();

        public UserSessionService()
        {
            _events.Add(new Event
            {
                Name = "Community Meetup",
                Date = DateTime.Today.AddDays(7),
                Location = "Community Hall",
                Description = "A meetup to discuss community projects.",
                Capacity = 100
            });

            _events.Add(new Event
            {
                Name = "Tech Talk: Blazor",
                Date = DateTime.Today.AddDays(14),
                Location = "Online",
                Description = "Deep dive into Blazor features.",
                Capacity = 200
            });

            _events.Add(new Event
            {
                Name = "Annual Conference",
                Date = DateTime.Today.AddMonths(1),
                Location = "Convention Center",
                Description = "Our biggest event of the year with multiple sessions.",
                Capacity = 500
            });

            _events.Add(new Event
            {
                Name = "Workshop: ASP.NET Core",
                Date = DateTime.Today.AddDays(10),
                Location = "Tech Hub",
                Description = "Hands-on workshop on building web apps with ASP.NET Core.",
                Capacity = 50
            });
        }

        public IEnumerable<Event> GetEvents() => _events;

        public Event? GetEvent(Guid id) => _events.FirstOrDefault(e => e.Id == id);

        public void Register(Guid eventId, Attendee attendee)
        {
            if (!_registrations.ContainsKey(eventId))
                _registrations[eventId] = new List<Attendee>();

            _registrations[eventId].Add(attendee);
        }

        public IReadOnlyList<Attendee> GetAttendees(Guid eventId)
        {
            return _registrations.TryGetValue(eventId, out var list) ? list : new List<Attendee>();
        }
    }
}
