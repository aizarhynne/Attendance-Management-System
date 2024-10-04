﻿using System;

namespace Attendance_Management_System.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

