CREATE OR ALTER PROCEDURE [ormc].[SelectDrivers]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
            [DriverId],
            [DriverFirstName],
            [DriverLastName],
            [Nation]
        FROM [ormc].[Driver]
        ORDER BY
            [DriverLastName],
            [DriverFirstName];
END;
GO
