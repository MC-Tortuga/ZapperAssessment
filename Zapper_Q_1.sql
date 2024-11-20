CREATE TABLE Customers (
    Id INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    PRIMARY KEY (Id)
);

CREATE TABLE Merchants (
    Id INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    PRIMARY KEY (Id)
);

CREATE TABLE Transactions (
    Id INT NOT NULL,
    CustomerId INT NOT NULL,
    MerchantId INT NOT NULL,
    DateOfPurchase DATETIME NOT NULL,
    PRIMARY KEY (Id),
    CONSTRAINT Transactions_CustomerId_FK FOREIGN KEY (CustomerId) REFERENCES Customers (Id),
    CONSTRAINT Transactions_MerchantId_FK FOREIGN KEY (MerchantId) REFERENCES Merchants (Id)
);
