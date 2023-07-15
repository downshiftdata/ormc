CREATE OR ALTER PROCEDURE [ormc].[Track_Delete]
    @TrackId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE
        FROM [ormc].[Track]
        WHERE [TrackId] = @TrackId;
END;
GO
