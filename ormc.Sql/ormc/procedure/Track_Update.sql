CREATE OR ALTER PROCEDURE [ormc].[Track_Update]
    @TrackId INT,
    @TrackName NVARCHAR(128),
    @TrackType INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE [ormc].[Track]
        SET
            [TrackName] = @TrackName,
            [TrackType] = @TrackType
        WHERE [TrackId] = @TrackId;
END;
GO
