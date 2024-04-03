using DevOps.Models;

namespace DevOps.Services
{
    public interface IRepository
    {
        List<Event> GetAllEvents();
        Event GetEventById(int id);
    }
}
