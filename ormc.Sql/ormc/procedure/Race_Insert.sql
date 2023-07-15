CREATE OR ALTER PROCEDURE [ormc].[Race_Insert]
    @RaceSeason INT,
    @RaceNumber INT,
    @TrackId INT,
    @RaceName NVARCHAR(128),
    @RaceDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [ormc].[Race] (
            [RaceSeason],
            [RaceNumber],
            [TrackId],
            [RaceName],
            [RaceDate])
        SELECT
            @RaceSeason,
            @RaceNumber,
            @TrackId,
            @RaceName,
            @RaceDate;
END;
GO
