
# Employee Attendance

## Database Query

```sql
CREATE TABLE Absence
(
    [Tangal Absence] DATE NOT NULL,
    [NIK] VARCHAR(50) NOT NULL,
    PRIMARY KEY ([Tangal Absence], [NIK]),
    FOREIGN KEY ([NIK]) REFERENCES Employee(NIK)
);

-------------------------------------------------------------
INSERT INTO Absence ([Tangal Absence], [NIK]) VALUES 
('2014-08-30', 'A001'),
('2014-09-02', 'A001'),
('2014-08-30', 'A002'),
('2014-08-31', 'A002'),
('2014-09-01', 'A002'),
('2014-08-29', 'A003'),
('2014-09-02', 'A003'),
('2014-08-29', 'A004'),
('2014-08-31', 'A004');

```

```sql
CREATE TABLE Employee
(
	[NIK] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Nama] VARCHAR(MAX) NULL 
)

-------------------------------------------------------------
INSERT INTO Employee (NIK, Nama) VALUES 
('A001', 'Andi'),
('A002', 'Susi'),
('A003', 'Toni'),
('A004', 'Hendra');

```


## API Reference

#### Show Employees Table

```http
  https://localhost:7200/employees
```

#### Create Employees

```http
    https://localhost:7200/Employees/Create
```

#### Detail Employees
```http
    https://localhost:7200/Employees/Details?id=?
```

##### Edit Employees
```http
    https://localhost:7200/Employees/Edit?id=?
```

##### Delete Employees
```http
    https://localhost:7200/Employees/Delete?id=?
```



## Authors

- [@FebricoJonata](https://github.com/FebricoJonata)


## Screenshots of Application

#### Table
![Alt text](</Assets-readme/Screenshot 2023-11-21 002624.png>)
![Alt text](</Assets-readme/Screenshot 2023-11-21 002711.png>)
![Alt text](</Assets-readme/Screenshot 2023-11-21 003049.png>)

#### Create
![Alt text](</Assets-readme/Screenshot 2023-11-21 003100.png>)

#### Edits
![Alt text](</Assets-readme/Screenshot 2023-11-21 003123.png>)

#### Details
![Alt text](</Assets-readme/Screenshot 2023-11-21 003110.png>)

## Tech Stack

**Client:** ASP.NET, NET 8.0 (LTS)

**IDE :** Visual Studio 2022