CREATE TABLE [dbo].[Logs]
(
	log_id INT PRIMARY KEY IDENTITY(1,1),
    admin_id INT NOT NULL,
    action VARCHAR(255) NOT NULL, -- Action performed (e.g., added user, updated attendance)
    user_id INT, -- Optional, in case action involves a user
    timestamp DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (admin_id) REFERENCES Admin(admin_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
)
