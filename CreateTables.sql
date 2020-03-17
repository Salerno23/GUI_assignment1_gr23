CREATE DATABASE [debtbook]
GO

--DROP TABLE [dbo].[Debtors]
--GO
--DROP TABLE [dbo].[Debts]
--GO

use [debtbook]
GO

CREATE TABLE [dbo].[Debtors](
	[DebtorId] [int] NOT NULL PRIMARY KEY,
	[Name] [nvarchar] (50),
	[TotalDebt] [int] NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Debts](
	[DebtorId] [int] NOT NULL FOREIGN KEY REFERENCES Debtors(DebtorId),
	[Date] [datetime2],
	[DebtValue] [int] NOT NULL,
) ON [PRIMARY]
GO

