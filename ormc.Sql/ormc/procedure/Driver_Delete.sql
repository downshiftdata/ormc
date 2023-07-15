CREATE OR ALTER PROCEDURE [ormc].[Driver_Delete]
    @DriverId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE
        FROM [ormc].[Driver]
        WHERE [DriverId] = @DriverId;
END;
GO
