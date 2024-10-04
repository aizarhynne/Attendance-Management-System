using Attendance_Management_System.Models;
using System;

namespace Attendance_Management_System.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int UserId { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Now;
        public TimeSpan TimeIn { get; set; } = TimeSpan.Zero;
        public TimeSpan? TimeOut { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public User? User { get; set; }
    }
}


