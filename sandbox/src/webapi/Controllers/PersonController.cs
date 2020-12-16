using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sandbox.Data.Models;
using Sandbox.Data.Services;

namespace Sandbox.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes(MediaTypeNames.Application.Json)]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> logger;
        private readonly IPersonService personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            this.logger = logger;
            this.personService = personService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Person>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Person>> GetAll()
        {
            var persons = personService.GetAllPersons();
            if (persons == null)
            {
                return NotFound();
            }
            return Ok(persons);
        }
        [HttpGet]
        [Route("{guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Person))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Person> Get(Guid guid)
        {
            var person = personService.GetPerson(guid);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

    }
}
