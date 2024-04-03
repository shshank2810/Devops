using DevOps.Controllers;
using DevOps.Models;
using DevOps.Services;
using Moq;

namespace TestProject
{
    public class UnitTest1
    {
        public Mock<IRepository> mock = new Mock<IRepository>();
        [Fact]
        public void GetEventByIdTester()
        {
            Event evt = new Event() { Id = 1, Title = "Test1", Description = "Test1" };
            mock.Setup(p => p.GetEventById(1)).Returns(evt);
            EventController controller=new EventController(mock.Object);
            var result= controller.GetEvent(1);
            Assert.NotNull(result);
            Assert.Equal(evt, result);
        }

        [Fact]
        public void GetAllEventsTester()
        {
            List<Event> events = events = new List<Event>
            {
                new Event(){Id=1,Title="Test1",Description="Test1"},
                new Event(){Id=2,Title="Test1",Description="Test1"},
                new Event(){Id=3,Title="Test1",Description="Test1"}
            };
            mock.Setup(p => p.GetAllEvents()).Returns(events);
            EventController controller = new EventController(mock.Object);
            var result= controller.GetEvents();
            Assert.NotNull(result);
            Assert.Equal(events, result);

        }
    }
}