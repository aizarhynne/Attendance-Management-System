using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Log>> GetLogs()
        {
            return new List<Log>
            {
                new Log { LogId = 1, Action = "User added", AdminId = 1 }
            };
        }

        [HttpPost]
        public ActionResult<Log> PostLog(Log log)
        {
            return CreatedAtAction(nameof(GetLogs), new { id = log.LogId }, log);
        }
    }
}
