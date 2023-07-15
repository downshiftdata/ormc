SET NOCOUNT ON;
GO

IF EXISTS (SELECT 1 FROM [ormc].[TrackType] WHERE [TrackTypeId] = 0)
    UPDATE [ormc].[TrackType] SET [TrackTypeName] = N'Unknown' WHERE [TrackTypeId] = 0;
ELSE
    INSERT INTO [ormc].[TrackType] ([TrackTypeId], [TrackTypeName])
        SELECT 0, N'Unknown';
GO

IF EXISTS (SELECT 1 FROM [ormc].[TrackType] WHERE [TrackTypeId] = 1)
    UPDATE [ormc].[TrackType] SET [TrackTypeName] = N'RoadCourse' WHERE [TrackTypeId] = 1;
ELSE
    INSERT INTO [ormc].[TrackType] ([TrackTypeId], [TrackTypeName])
        SELECT 1, N'RoadCourse';
GO

IF EXISTS (SELECT 1 FROM [ormc].[TrackType] WHERE [TrackTypeId] = 2)
    UPDATE [ormc].[TrackType] SET [TrackTypeName] = N'StreetCourse' WHERE [TrackTypeId] = 2;
ELSE
    INSERT INTO [ormc].[TrackType] ([TrackTypeId], [TrackTypeName])
        SELECT 2, N'StreetCourse';
GO

IF EXISTS (SELECT 1 FROM [ormc].[TrackType] WHERE [TrackTypeId] = 3)
    UPDATE [ormc].[TrackType] SET [TrackTypeName] = N'ShortOval' WHERE [TrackTypeId] = 3;
ELSE
    INSERT INTO [ormc].[TrackType] ([TrackTypeId], [TrackTypeName])
        SELECT 3, N'ShortOval';
GO

IF EXISTS (SELECT 1 FROM [ormc].[TrackType] WHERE [TrackTypeId] = 4)
    UPDATE [ormc].[TrackType] SET [TrackTypeName] = N'LongOval' WHERE [TrackTypeId] = 4;
ELSE
    INSERT INTO [ormc].[TrackType] ([TrackTypeId], [TrackTypeName])
        SELECT 4, N'LongOval';
GO
