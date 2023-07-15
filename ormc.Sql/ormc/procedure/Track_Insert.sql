CREATE OR ALTER PROCEDURE [ormc].[Track_Insert]
    @TrackId INT OUTPUT,
    @TrackName NVARCHAR(128),
    @TrackType INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [ormc].[Track] (
            [TrackName],
            [TrackType])
        SELECT
            @TrackName,
            @TrackType;
    SELECT @TrackId = SCOPE_IDENTITY();
END;
GO
