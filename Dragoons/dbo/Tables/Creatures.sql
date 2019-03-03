CREATE TABLE [dbo].[Creatures] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [Affiliation]  INT            NOT NULL,
    [CurrentHp]    INT            NOT NULL,
    [MaxHp]        INT            NOT NULL,
    [ArmorClass]   INT            NOT NULL,
    [Strength]     INT            NULL,
    [Dexterity]    INT            NULL,
    [Constitution] INT            NULL,
    [Intelligence] INT            NULL,
    [Wisdom]       INT            NULL,
    [Charisma]     INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



