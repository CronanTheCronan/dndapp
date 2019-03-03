CREATE TABLE [dbo].[CreatureGroupXref] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [CreatureId] INT NOT NULL,
    [GroupId]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CreatureId]) REFERENCES [dbo].[Creatures] ([Id]),
    FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id])
);

