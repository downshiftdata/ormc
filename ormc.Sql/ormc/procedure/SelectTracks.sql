CREATE OR ALTER PROCEDURE [ormc].[SelectTracks]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
            [TrackId],
            [TrackName],
            [TrackType]
        FROM [ormc].[Track]
        ORDER BY [TrackName];
END;
GO
