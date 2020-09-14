ALTER TABLE [Student] ADD [Gender] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200827231245_AddColumnGender', N'3.1.7');

GO

