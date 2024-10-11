CREATE TRIGGER trg_log_attendance_update
ON Attendance
AFTER UPDATE
AS
BEGIN
    DECLARE @admin_id INT;
    DECLARE @user_id INT;
    DECLARE @action VARCHAR(255);

    -- Assuming Admin ID is available
    SET @admin_id = 1;
    SET @user_id = (SELECT user_id FROM inserted);

    -- Log the action
    SET @action = 'Updated attendance for user ' + CAST(@user_id AS VARCHAR);

    -- Insert the log entry into the Logs table
    INSERT INTO Logs (admin_id, action, user_id, timestamp)
    VALUES (@admin_id, @action, @user_id, GETDATE());
END;
