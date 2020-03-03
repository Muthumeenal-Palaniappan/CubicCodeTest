Create Database CalculatorSystem

Create Table DiagnosticInformation
(
ID int IDENTITY(1,1) Primary key ,
FirstParameter int not null,
SecondParameter int not null,
Operation nvarchar(50) not null,
Result int null,
MessageInfo nvarchar(max) null,
CreatedTimeStamp DateTime not null
)

