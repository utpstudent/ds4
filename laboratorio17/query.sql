CREATE DATABASE laboratoriomvc;
GO

USE laboratoriomvc;
GO

CREATE TABLE [User] (
    id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(100) NOT NULL UNIQUE,
    [password] VARCHAR(255) NOT NULL
);
GO
