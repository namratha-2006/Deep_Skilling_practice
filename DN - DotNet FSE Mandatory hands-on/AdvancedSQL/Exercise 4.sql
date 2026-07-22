-- Create a new database
CREATE DATABASE CompanyHRDB;
GO

-- Use the database
USE CompanyHRDB;
GO

-- Create Departments table
CREATE TABLE DeptMaster (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(100)
);

-- Create Employees table
CREATE TABLE StaffMaster (
    StaffID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DeptID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DeptID) REFERENCES DeptMaster(DeptID)
);

-- Insert Department data
INSERT INTO DeptMaster (DeptID, DeptName)
VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');

-- Insert Employee data
INSERT INTO StaffMaster
(StaffID, FirstName, LastName, DeptID, Salary, JoinDate)
VALUES
(1,'John','Doe',1,5000.00,'2020-01-15'),
(2,'Jane','Smith',2,6000.00,'2019-03-22'),
(3,'Michael','Johnson',3,7000.00,'2018-07-30'),
(4,'Emily','Davis',4,5500.00,'2021-11-05');

-- Display data
SELECT * FROM DeptMaster;
SELECT * FROM StaffMaster;