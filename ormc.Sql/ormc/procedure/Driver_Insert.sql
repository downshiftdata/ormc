CREATE OR ALTER PROCEDURE [ormc].[Driver_Insert]
    @DriverId INT OUTPUT,
    @DriverFirstName NVARCHAR(128),
    @DriverLastName NVARCHAR(128),
    @Nation NVARCHAR(128)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [ormc].[Driver] (
            [DriverFirstName],
            [DriverLastName],
            [Nation])
        SELECT
            @DriverFirstName,
            @DriverLastName,
            @Nation;
    SELECT @DriverId = SCOPE_IDENTITY();
END;
GO
