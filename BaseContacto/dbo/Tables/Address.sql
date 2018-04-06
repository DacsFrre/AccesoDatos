CREATE TABLE [dbo].[Address] (
    [id]        INT           NOT NULL,
    [street]    VARCHAR (150) NOT NULL,
    [number]    INT           NULL,
    [contactId] INT           NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Address_Address] FOREIGN KEY ([contactId]) REFERENCES [dbo].[Contact] ([id])
);

