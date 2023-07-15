SET NOCOUNT ON;

SET IDENTITY_INSERT [ormc].[Track] ON;
INSERT INTO [ormc].[Track] ([TrackId], [TrackName], [TrackType])
    SELECT 1, N'Indianapolis Motor Speedway', 4 UNION ALL
    SELECT 2, N'Barber Motorsports Park', 1 UNION ALL
    SELECT 3, N'Exhibition Place', 2 UNION ALL
    SELECT 4, N'Indianapolis Motor Speedway Road Course', 1 UNION ALL
    SELECT 5, N'Iowa Speedway', 3 UNION ALL
    SELECT 6, N'Mid-Ohio Sports Car Course', 1 UNION ALL
    SELECT 7, N'Nashville Street Circuit', 2 UNION ALL
    SELECT 8, N'Portland International Raceway', 1 UNION ALL
    SELECT 9, N'Road America', 1 UNION ALL
    SELECT 10, N'Streets of Detroit', 2 UNION ALL
    SELECT 11, N'Streets of Long Beach', 2 UNION ALL
    SELECT 12, N'Streets of St. Petersburg', 2 UNION ALL
    SELECT 13, N'Texas Motor Speedway', 4 UNION ALL
    SELECT 14, N'WeatherTech Raceway Laguna Seca', 1 UNION ALL
    SELECT 15, N'World Wide Technology Raceway', 3;
SET IDENTITY_INSERT [ormc].[Track] OFF;
DBCC CHECKIDENT ('ormc.Track', RESEED);

SET IDENTITY_INSERT [ormc].[Driver] ON;
INSERT INTO [ormc].[Driver] ([DriverId], [DriverFirstName], [DriverLastName], [Nation])
    SELECT 1, N'Marcus', N'Ericsson', N'Sweden' UNION ALL
    SELECT 2, N'Josef', N'Newgarden', N'USA' UNION ALL
    SELECT 3, N'Kyle', N'Kirkwood', N'USA' UNION ALL
    SELECT 4, N'Scott', N'McLaughlin', N'New Zealand' UNION ALL
    SELECT 5, N'Álex', N'Palou', N'Spain';
SET IDENTITY_INSERT [ormc].[Driver] OFF;
DBCC CHECKIDENT ('ormc.Driver', RESEED);

INSERT INTO [ormc].[Race] ([RaceSeason], [RaceNumber], [TrackId], [RaceName], [RaceDate])
    SELECT 2023, 1, 12, N'Firestone Grand Prix of St. Petersburg', '2023-03-05' UNION ALL
    SELECT 2023, 2, 13, N'PPG 375', '2023-04-02' UNION ALL
    SELECT 2023, 3, 11, N'Acura Grand Prix of Long Beach', '2023-04-16' UNION ALL
    SELECT 2023, 4, 2, N'Children''s of Alabama Indy Grand Prix', '2023-04-30' UNION ALL
    SELECT 2023, 5, 4, N'GMR Grand Prix', '2023-05-13' UNION ALL
    SELECT 2023, 6, 1, N'107th Running of the Indianapolis 500', '2023-05-28' UNION ALL
    SELECT 2023, 7, 10, N'Chevrolet Detroit Grand Prix', '2023-06-04' UNION ALL
    SELECT 2023, 8, 9, N'Sonsio Grand Prix at Road America', '2023-06-18' UNION ALL
    SELECT 2023, 9, 6, N'Honda Indy 200 at Mid-Ohio', '2023-07-02' UNION ALL
    SELECT 2023, 10, 3, N'Honda Indy Toronto', '2023-07-16' UNION ALL
    SELECT 2023, 11, 5, N'Hy-Vee Homefront 250', '2023-07-22' UNION ALL
    SELECT 2023, 12, 5, N'Hy-Vee One Step 250', '2023-07-23' UNION ALL
    SELECT 2023, 13, 7, N'Big Machine Music City Grand Prix', '2023-08-06' UNION ALL
    SELECT 2023, 14, 4, N'Gallagher Grand Prix', '2023-08-12' UNION ALL
    SELECT 2023, 15, 15, N'Bommarito Automotive Group 500', '2023-08-27' UNION ALL
    SELECT 2023, 16, 8, N'Grand Prix of Portland', '2023-09-03' UNION ALL
    SELECT 2023, 17, 14, N'Firestone Grand Prix of Monterey', '2023-09-10';

INSERT INTO [ormc].[RaceResult] ([RaceSeason], [RaceNumber], [WinnerId])
    SELECT 2023, 1, 1 UNION ALL
    SELECT 2023, 2, 2 UNION ALL
    SELECT 2023, 3, 3 UNION ALL
    SELECT 2023, 4, 4 UNION ALL
    SELECT 2023, 5, 5 UNION ALL
    SELECT 2023, 6, 2 UNION ALL
    SELECT 2023, 7, 5 UNION ALL
    SELECT 2023, 8, 5 UNION ALL
    SELECT 2023, 9, 5;
