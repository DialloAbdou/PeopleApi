using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleApi.Services;

namespace PeopleApi.Controllers
{
    public class PersonController : Controller
    {

        private readonly PersonService _personService;
        public PersonController( PersonService personService)
        {
                _personService = personService;
        }

        // GET: PersonController/Edit/5
        [HttpGet]
        public async Task<IActionResult>GetAsync()
        {
            return Ok( await _personService.GetAll());
        }

    }
}
