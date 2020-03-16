use [debtbook]
GO

INSERT INTO Debtors VALUES
(
	1,
	'Henrik',
	300
)

INSERT INTO Debts VALUES
(
	1,
	GETDATE(),
	300
)


INSERT INTO Debtors VALUES
(
	2,
	'Michael',
	-600
)

INSERT INTO Debts VALUES
(
	2,
	GETDATE(),
	-600
)