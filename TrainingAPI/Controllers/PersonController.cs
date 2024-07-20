using Microsoft.AspNetCore.Mvc;
using TrainingAPI.Model;
using TrainingAPI.Service;

namespace TrainingAPI.Controllers
{
    public class PersonController : Controller
    {

        static Dictionary<int, Person> objects = new Dictionary<int, Person>();



        private readonly IEmailService _emailService;


        public PersonController (IEmailService emailService)
        {
            _emailService = emailService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("person/{id}")]
        public IActionResult GetPersonById(int id)
        {
            Console.WriteLine(objects);

            return (!objects.ContainsKey(id)) ? NotFound() : Ok(objects[id]);


        }

        [HttpPost("person")]
        public IActionResult PostPerson(Person person)
        {

            objects.Add(person.Id, person);

            Console.WriteLine(objects);


            return Ok(person);
        }


        [HttpDelete("person/{id}")]
        public IActionResult DeletePerson(int id)
        {


            objects.Remove(id);

            return NoContent();

        }

        [HttpPost("email/{email}")]
        public IActionResult SendEmail(string email)
        {
             var result  = _emailService.SendEmail(email);
            return Ok(result);


        }
    }
}
