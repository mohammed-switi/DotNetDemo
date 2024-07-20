using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TrainingAPI.Model;

namespace TrainingAPI.Controllers
{

    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {

        static Dictionary<int, User> users = new Dictionary<int, User>();
        static int UserId = 1;



        [HttpGet]

        public IActionResult getAllUsers()
        {

            return Ok(users.ToArray());
        }


        [HttpGet("{id}")]

        public IActionResult GetUserById(int id)
        {
            return (!users.ContainsKey(id)) ? NotFound() : Ok(users[id]);

        }


        [HttpPost]
        public IActionResult AddUser( User user) {




            user.Id = UserId;
            users.Add(UserId++, user);

            return Ok(user);
        }



        [HttpPut("{id}")]
        public IActionResult EditUser(int id,User user) {


            if (!users.ContainsKey(id)) {

                return BadRequest("User Not Found");
            }
            users[id]=user;


            return Ok(user);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id) {

            if (!users.ContainsKey(id)) { 
            
                return NotFound("User Not Found");
            }
            users.Remove(id);

            return NoContent();
        }


    }
}
