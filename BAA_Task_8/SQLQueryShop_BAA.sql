use master;
CREATE DATABASE Shop_BAA;
USE Shop_BAA;

-- TABLE USERS --
CREATE TABLE Users (UserId  INT not null, UserName NVARCHAR(30), Passwords NVARCHAR(30), Roles NVARCHAR(30));

-- TABLE CATEGORY --
CREATE TABLE Category (CategoryId  INT not null, CategoryName NVARCHAR(30));

-- TABLE GOOD --
CREATE TABLE Good (GoodId  INT not null, GoodName NVARCHAR(255), Price FLOAT, Picture NVARCHAR(50), Descriptions NVARCHAR(255), CountGood INT, CategoryId INT);

-- TABLE SELL --
CREATE TABLE Sell (SellId  INT not null, GoodId INT, DateSell DATETIME, SellCount INT);
