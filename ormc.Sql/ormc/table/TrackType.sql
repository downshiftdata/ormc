IF (OBJECT_ID(N'ormc.TrackType') IS NULL)
BEGIN
    CREATE TABLE [ormc].[TrackType] (
        [TrackTypeId] INT NOT NULL,
        [TrackTypeName] NVARCHAR(128) NOT NULL,
        CONSTRAINT [pk_ormc_TrackType] PRIMARY KEY ([TrackTypeId]));
END;
GO
