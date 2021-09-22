using Microsoft.AspNetCore.Mvc;
using SoftCaribbeanSystem.Model.Entities;
using SoftCaribbeanSystem.Model.Interfaces.Services;

namespace SoftCaribbeanSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("create")]
        public IActionResult CreatePerson([FromBody] Person request)
        {
            _personService.CreatePerson(request);
            return Ok("Person created");
        }

        [HttpPut("update")]
        public IActionResult UpdatePerson([FromBody] Person request)
        {
            _personService.UpdatePerson(request);
            return Ok("Person updated");
        }
    }
}
