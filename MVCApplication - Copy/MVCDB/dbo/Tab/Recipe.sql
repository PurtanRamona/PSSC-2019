CREATE TABLE [dbo].[Recipe]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(MAX) NOT NULL, 
    [LastName] NVARCHAR(MAX) NOT NULL, 
    [Age] INT NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL, 
    [MedicalRecords] INT NOT NULL, 
    [Diagnostic] NVARCHAR(MAX) NOT NULL, 
    [Prescriptions] NVARCHAR(MAX) NOT NULL
)
