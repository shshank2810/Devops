using DevOps.Models;

namespace DevOps.Services
{
    public class Repository:IRepository
    {
        public List<Event> events;
        public Repository()
        {
            events = new List<Event>
            {
                new Event(){Id=1,Title="Test1",Description="Test1"},
                new Event(){Id=2,Title="Test1",Description="Test1"},
                new Event(){Id=3,Title="Test1",Description="Test1"}
            };
        }

        public List<Event> GetAllEvents()
        {
            return events;
        }

        public Event GetEventById(int id)
        {
            var evnt = events.Find(evt => evt.Id == id);
            if (evnt != null)
            {
                return evnt;
            }
            return null;
        }
    }
}
