using DevOps.Models;
using DevOps.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IRepository _repository;
        public EventController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getAllEvents")]
        public IActionResult GetAllEvents()
        {
            var list = _repository.GetAllEvents();
            return Ok(list);
        }

        [HttpGet("getEvent/{id}")]
        public IActionResult GetEventById([FromRoute] int id)
        {
            var evnt = _repository.GetEventById(id);
            return Ok(evnt);
        }

        public Event GetEvent(int id)
        {
            return _repository.GetEventById(id);
        }

        public List<Event> GetEvents()
        {
            return _repository.GetAllEvents();
        }
    }
}
