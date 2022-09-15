CREATE TABLE Student (
Id int not null primary key identity(1,1), --primary key; identity-starts from 1 value & increases by 1
Name  nvarchar(50), --varchar: sql's datatype
Address nvarchar(200), --n for language friendly
Email varchar(50),
DOB datetime2,
Gender char(1),
);
