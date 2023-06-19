/*Broken tables User*/
CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) NOT NULL,
Email NVARCHAR(100) NOT NULL,
Address NVARCHAR(100) NOT NULL,
Phone NVARCHAR(20) NOT NULL,
InitialPropertyValue DECIMAL(18,2) NOT NULL,
CurrentPropertyValue DECIMAL(18,2) NOT NULL
);
/*Broken tables Properties*/
CREATE TABLE Properties(
Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    OwnerId INT NOT NULL,
    Type NVARCHAR(100) NOT NULL,
    PurchaseDateTime DATETIME NOT NULL,
    InitialValue DECIMAL(18, 2) NOT NULL,
     PriceDepreciationPeriod INT NOT NULL,
    DepreciationPerPeriod DECIMAL(18, 2) NOT NULL,
    CurrentValue AS InitialValue - (DepreciationPerPeriod * DATEDIFF(DAY, PurchaseDateTime, GETDATE())),
    FOREIGN KEY (OwnerId) REFERENCES Users (Id)
);