IF (OBJECT_ID(N'ormc.RaceResult') IS NULL)
BEGIN
    CREATE TABLE [ormc].[RaceResult] (
        [RaceSeason] INT NOT NULL,
        [RaceNumber] INT NOT NULL,
        [WinnerId] INT NOT NULL,
        CONSTRAINT [pk_ormc_RaceResult] PRIMARY KEY ([RaceSeason], [RaceNumber]));
END;
GO
