using Attendance_Management_System.Models;
using System;

namespace Attendance_Management_System.Models
{
    public class Log
    {
        public int LogId { get; set; }
        public int AdminId { get; set; } = 0;
        public string Action { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public Admin? Admin { get; set; }
        public User? User { get; set; }
    }
}

