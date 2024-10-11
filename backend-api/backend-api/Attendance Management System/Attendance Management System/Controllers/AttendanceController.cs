using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Attendance>> GetAttendance()
        {
            return new List<Attendance>
            {
                new Attendance { AttendanceId = 1, UserId = 1, Date = System.DateTime.Now }
            };
        }

        [HttpPost]
        public ActionResult<Attendance> PostAttendance(Attendance attendance)
        {
            return CreatedAtAction(nameof(GetAttendance), new { id = attendance.AttendanceId }, attendance);
        }
    }
}
