CREATE TABLE [dbo].[Admin]
(
	admin_id INT PRIMARY KEY IDENTITY(1,1),
    admin_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    created_at DATETIME DEFAULT GETDATE()
   

)



