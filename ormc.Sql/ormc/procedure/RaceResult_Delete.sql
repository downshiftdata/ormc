CREATE OR ALTER PROCEDURE [ormc].[RaceResult_Delete]
    @RaceSeason INT,
    @RaceNumber INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE
        FROM [ormc].[RaceResult]
        WHERE [RaceSeason] = @RaceSeason
            AND [RaceNumber] = @RaceNumber;
END;
GO
