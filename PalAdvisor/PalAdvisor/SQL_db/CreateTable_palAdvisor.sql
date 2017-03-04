DROP TABLE Gate
DROP TABLE Destination
DROP Table Crane

CREATE TABLE[dbo].[Crane]
(

   [Id] INT NOT NULL PRIMARY KEY,
   [Name] NCHAR(50) NOT NULL,
   [L] INT NOT NULL,
   [B] INT NOT NULL,
   [H] INT NOT NULL,
   [OpL] INT NOT NULL,
   [OpB] INT NOT NULL,
   [OpH] INT NOT NULL
)

CREATE TABLE[dbo].[Destination]
(

   [Id] INT NOT NULL PRIMARY KEY,
   [L] INT NOT NULL,
   [B] INT NOT NULL,
   [H] INT NOT NULL
)

CREATE TABLE[dbo].[Gate]
(

  [Id] INT NOT NULL,
   [B] INT NOT NULL,
   [H] INT NOT NULL,
   [DesId] INT NOT NULL,
   PRIMARY KEY CLUSTERED([Id] ASC),
   CONSTRAINT[FK_Gate_To_Destination] FOREIGN KEY([DesId]) REFERENCES[dbo].[Destination] ([Id])
);