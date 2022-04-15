using GenericApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericApp.Api.Controllers
{
    [ApiController]
    [Route("api/person")]
    public class PersonController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            return new Person() { Id = id, Name = Person.GetGeneratedName() };
        }
    }
}
