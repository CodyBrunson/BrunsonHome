IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Horses] (
    [Id] int NOT NULL IDENTITY,
    [BarnName] nvarchar(max) NOT NULL,
    [RegisteredName] nvarchar(max) NULL,
    [AddDate] datetime2 NOT NULL,
    [UpdateDate] datetime2 NULL,
    CONSTRAINT [PK_Horses] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230412172742_InitialCreate', N'7.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Horses] ADD [PurchaseDate] datetime2 NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230412174234_HorseEntityUpdate', N'7.0.3');
GO

COMMIT;
GO

