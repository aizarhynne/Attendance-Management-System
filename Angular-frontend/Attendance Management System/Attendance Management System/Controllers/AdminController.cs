using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Admin>> GetAdmins()
        {
            return new List<Admin>
            {
                new Admin { AdminId = 1, AdminName = "SuperAdmin", Email = "admin@example.com" }
            };
        }

        [HttpPost]
        public ActionResult<Admin> PostAdmin(Admin admin)
        {
            return CreatedAtAction(nameof(GetAdmins), new { id = admin.AdminId }, admin);
        }
    }
}
