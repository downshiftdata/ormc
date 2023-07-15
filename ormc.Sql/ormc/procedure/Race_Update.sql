CREATE OR ALTER PROCEDURE [ormc].[Race_Update]
    @RaceSeason INT,
    @RaceNumber INT,
    @TrackId INT,
    @RaceName NVARCHAR(128),
    @RaceDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE [ormc].[Race]
        SET
            [TrackId] = @TrackId,
            [RaceName] = @RaceName,
            [RaceDate] = @RaceDate
        WHERE [RaceSeason] = @RaceSeason
            AND [RaceNumber] = @RaceNumber;
END;
GO
