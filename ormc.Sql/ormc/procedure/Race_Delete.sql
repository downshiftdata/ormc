CREATE OR ALTER PROCEDURE [ormc].[Race_Delete]
    @RaceSeason INT,
    @RaceNumber INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE
        FROM [ormc].[Race]
        WHERE [RaceSeason] = @RaceSeason
            AND [RaceNumber] = @RaceNumber;
END;
GO
