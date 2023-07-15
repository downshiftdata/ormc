CREATE OR ALTER PROCEDURE [ormc].[SelectSeasonResults]
    @RaceSeason INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
            r.[RaceSeason],
            r.[RaceNumber],
            r.[RaceDate],
            r.[RaceName],
            t.[TrackName],
            tt.[TrackTypeName],
            d.[DriverFirstName],
            d.[DriverLastName]
        FROM [ormc].[Race] AS r
            LEFT JOIN [ormc].[Track] AS t
                ON r.[TrackId] = t.[TrackId]
            LEFT JOIN [ormc].[TrackType] AS tt
                ON t.[TrackType] = tt.[TrackTypeId]
            LEFT JOIN [ormc].[RaceResult] AS rr
                ON r.[RaceSeason] = rr.[RaceSeason]
                AND r.[RaceNumber] = rr.[RaceNumber]
            LEFT JOIN [ormc].[Driver] AS d
                ON rr.[WinnerId] = d.[DriverId]
        WHERE r.[RaceSeason] = @RaceSeason
        ORDER BY r.[RaceNumber];
END;
GO
