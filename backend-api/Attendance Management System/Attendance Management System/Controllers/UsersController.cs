using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return new List<User>
            {
                new User { UserId = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return new User { UserId = id, FirstName = "John", LastName = "Doe", Email = "john@example.com" };
        }

        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }
    }
}
