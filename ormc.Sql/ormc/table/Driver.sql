IF (OBJECT_ID(N'ormc.Driver') IS NULL)
BEGIN
    CREATE TABLE [ormc].[Driver] (
        [DriverId] INT IDENTITY(1,1),
        [DriverFirstName] NVARCHAR(128) NOT NULL,
        [DriverLastName] NVARCHAR(128) NOT NULL,
        [Nation] NVARCHAR(128) NOT NULL,
        CONSTRAINT [pk_ormc_Driver] PRIMARY KEY ([DriverId]),
        CONSTRAINT [uc_ormc_Driver] UNIQUE ([DriverFirstName],[DriverLastName]));
END;
GO
