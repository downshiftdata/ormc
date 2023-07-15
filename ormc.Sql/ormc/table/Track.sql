IF (OBJECT_ID(N'ormc.Track') IS NULL)
BEGIN
    CREATE TABLE [ormc].[Track] (
        [TrackId] INT IDENTITY(1,1) NOT NULL,
        [TrackName] NVARCHAR(128) NOT NULL,
        [TrackType] INT NOT NULL,
        CONSTRAINT [pk_ormc_Track] PRIMARY KEY ([TrackId]));
END;
GO
