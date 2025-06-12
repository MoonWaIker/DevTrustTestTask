using DevTrustTestTask.DataBase.Entities;
using DevTrustTestTask.Infrastructure.DTO;
using DevTrustTestTask.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevTrustTestTask.Controllers
{
    [Route(ControllerRoute)]
    [ApiController]
    public class PersonController(IPeopleService service) : ControllerBase
    {
        private const string IdRoute = "{id:long}";
        private const string ControllerRoute = "api/[controller]";

        private readonly IPeopleService _service = service;

        [ValidateAntiForgeryToken]
        [HttpPut(IdRoute)]
        public IActionResult PutPerson(Person person)
        {
            _service.UpdatePerson(person);

            return NoContent();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult<Person> PostPerson(Person person)
        {
            _service.AddPerson(person);

            return Created();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetPeople([FromQuery] GetAllRequest request)
        {
            return Ok(_service.GetPeople(request));
        }
    }
}
