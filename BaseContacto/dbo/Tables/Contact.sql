CREATE TABLE [dbo].[Contact] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (150) NULL,
    [age]  INT           NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([id] ASC)
);

