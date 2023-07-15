CREATE OR ALTER PROCEDURE [ormc].[Driver_Update]
    @DriverId INT,
    @DriverFirstName NVARCHAR(128),
    @DriverLastName NVARCHAR(128),
    @Nation NVARCHAR(128)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE [ormc].[Driver]
        SET
            [DriverFirstName] = @DriverFirstName,
            [DriverLastName] = @DriverLastName,
            [Nation] = @Nation
        WHERE [DriverId] = @DriverId;
END;
GO
