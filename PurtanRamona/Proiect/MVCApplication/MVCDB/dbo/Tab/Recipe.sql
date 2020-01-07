CREATE TABLE [dbo].[Recipe]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(MAX) NULL, 
    [LastName] NVARCHAR(MAX) NULL, 
    [Age] INT NULL, 
    [Address] NVARCHAR(MAX) NULL, 
    [MedicalRecords] INT NULL, 
    [Diagnostic] NVARCHAR(MAX) NULL, 
    [Prescriptions] NVARCHAR(MAX) NULL
)
