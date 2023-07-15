CREATE OR ALTER PROCEDURE [ormc].[RaceResult_Update]
    @RaceSeason INT,
    @RaceNumber INT,
    @WinnerId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE [ormc].[RaceResult]
        SET
            [WinnerId] = @WinnerId
        WHERE [RaceSeason] = @RaceSeason
            AND [RaceNumber] = @RaceNumber;
END;
GO
