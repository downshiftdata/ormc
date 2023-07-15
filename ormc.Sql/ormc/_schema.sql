IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE [name] = N'ormc')
    CREATE USER [ormc] WITHOUT LOGIN;
GO

IF NOT EXISTS (SELECT 1 FROM sys.schemas WHERE [name] = N'ormc')
    EXEC (N'CREATE SCHEMA [ormc] AUTHORIZATION [ormc];');
GO
