IF (OBJECT_ID(N'ormc.Race') IS NULL)
BEGIN
    CREATE TABLE [ormc].[Race] (
        [RaceSeason] INT NOT NULL,
        [RaceNumber] INT NOT NULL,
        [TrackId] INT NOT NULL,
        [RaceName] NVARCHAR(128) NOT NULL,
        [RaceDate] DATE NOT NULL,
        CONSTRAINT [pk_ormc_Race] PRIMARY KEY ([RaceSeason], [RaceNumber]));
END;
GO
