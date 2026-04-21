

use AccountantDB;

CREATE TABLE [dbo].[Persons]
(
    PersonID INT IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR(100) NOT NULL,
    SecondName NVARCHAR(100) NULL,
    LastName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(25) NULL,
    CreateDate DATETIME2(0) NOT NULL CONSTRAINT DF_Person_CreateDate DEFAULT (SYSDATETIME()),
    ModifyDate DATETIME2(0) NULL,
    Address NVARCHAR(500) NULL,

    CONSTRAINT PK_Person
        PRIMARY KEY (PersonID),

    CONSTRAINT CK_Person_FirstName_NotEmpty
        CHECK (LEN(LTRIM(RTRIM(FirstName))) > 0),

    CONSTRAINT CK_Person_LastName_NotEmpty
        CHECK (LEN(LTRIM(RTRIM(LastName))) > 0),

    CONSTRAINT CK_Person_ThirdName_NotEmpty
        CHECK (SecondName IS NULL OR LEN(LTRIM(RTRIM(SecondName))) > 0),

    CONSTRAINT CK_Person_Phone_Format
        CHECK (
            Phone IS NULL
            OR Phone NOT LIKE '%[^0-9+() -]%'
        ),

    CONSTRAINT CK_Person_Address_NotEmpty
        CHECK (
            Address IS NULL
            OR LEN(LTRIM(RTRIM(Address))) > 0
        ),

    CONSTRAINT CK_Person_ModifiedDate_AfterCreateDate
        CHECK (
            ModifyDate IS NULL
            OR ModifyDate >= CreateDate
        )
);

CREATE INDEX IX_Person_LastName_FirstName
    ON [dbo].[Persons](LastName, FirstName);
	 













CREATE TABLE Users
(
    UserID INT IDENTITY(1,1) NOT NULL,
    PersonID INT NOT NULL,
    UserName NVARCHAR(100) NOT NULL,
    HashPassword NVARCHAR(255) NOT NULL,
    Notes NVARCHAR(1000) NULL,
    PermissionInBinary VARBINARY(64) NULL,
    CreatedDate DATETIME2(0) NOT NULL  CONSTRAINT DF_User_CreatedDate DEFAULT (SYSDATETIME()),
    IsActive BIT NOT NULL CONSTRAINT DF_User_IsActive DEFAULT (1),

    CONSTRAINT PK_User
        PRIMARY KEY (UserID),

    CONSTRAINT FK_User_Person
        FOREIGN KEY (PersonID)
        REFERENCES Persons(PersonID),

    CONSTRAINT UQ_User_UserName
        UNIQUE (UserName),

    CONSTRAINT CK_User_UserName_NotEmpty
        CHECK (LEN(LTRIM(RTRIM(UserName))) > 0),

    CONSTRAINT CK_User_HashPassword_NotEmpty
        CHECK (LEN(LTRIM(RTRIM(HashPassword))) > 0)
);

CREATE INDEX IX_User_PersonID
    ON [dbo].[Users](PersonID);

CREATE INDEX IX_User_IsActive
    ON [dbo].[Users](IsActive);






	select * from Persons
	select * from Users	