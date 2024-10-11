CREATE TABLE [dbo].[Attendance]
(
	attendance_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    date DATE NOT NULL,
    time_in TIME NOT NULL,
    time_out TIME,
    status VARCHAR(50), -- e.g., Present, Absent, Late
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
)
