CREATE OR ALTER PROCEDURE [ormc].[RaceResult_Insert]
    @RaceSeason INT,
    @RaceNumber INT,
    @WinnerId INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [ormc].[RaceResult] (
            [RaceSeason],
            [RaceNumber],
            [WinnerId])
        SELECT
            @RaceSeason,
            @RaceNumber,
            @WinnerId;
END;
GO
