CREATE PROCEDURE [dbo].[UpdateAttendance]
	@attendance_id INT,
    @time_out TIME,
    @status VARCHAR(50)
AS
BEGIN
    -- Update the attendance record with the provided ID
    UPDATE Attendance
    SET time_out = @time_out,
        status = @status,
        created_at = GETDATE()
    WHERE attendance_id = @attendance_id;

    -- Optionally log this action
END;
