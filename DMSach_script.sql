CREATE DATABASE QLSach
GO

USE QLSach
GO

CREATE TABLE Sach (
    MaSach VARCHAR(50) PRIMARY KEY,
    TenSach NVARCHAR(200) NOT NULL,
    TacGia NVARCHAR(100),
    NhaXB NVARCHAR(100),
    NamXB INT
);
GO

CREATE TABLE dbo.HocPhan (
    MaHP VARCHAR(50) PRIMARY KEY,
    TenHP NVARCHAR(200) NOT NULL,
    SoTC INT
);
GO

CREATE TABLE TaiLieu (
    Id INT PRIMARY KEY,
    MaHP VARCHAR(50) NOT NULL,
    MaSach VARCHAR(50) NOT NULL,
    NamTLK INT,
    CONSTRAINT FK_TaiLieu_HocPhan FOREIGN KEY (MaHP) REFERENCES HocPhan(MaHP),
    CONSTRAINT FK_TaiLieu_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);
GO

-- Insert into Sach
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S001', N'Tensach 1', N'Tacgia 1', N'NXB 1', 2001);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S002', N'Tensach 2', N'Tacgia 2', N'NXB 2', 2002);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S003', N'Tensach 3', N'Tacgia 3', N'NXB 3', 2003);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S004', N'Tensach 4', N'Tacgia 4', N'NXB 4', 2004);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S005', N'Tensach 5', N'Tacgia 5', N'NXB 5', 2005);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S006', N'Tensach 6', N'Tacgia 6', N'NXB 6', 2006);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S007', N'Tensach 7', N'Tacgia 7', N'NXB 7', 2007);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S008', N'Tensach 8', N'Tacgia 8', N'NXB 8', 2008);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S009', N'Tensach 9', N'Tacgia 9', N'NXB 9', 2009);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S010', N'Tensach 10', N'Tacgia 10', N'NXB 10', 2010);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S011', N'Tensach 11', N'Tacgia 11', N'NXB 11', 2011);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S012', N'Tensach 12', N'Tacgia 12', N'NXB 12', 2012);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S013', N'Tensach 13', N'Tacgia 13', N'NXB 13', 2013);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S014', N'Tensach 14', N'Tacgia 14', N'NXB 14', 2014);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S015', N'Tensach 15', N'Tacgia 15', N'NXB 15', 2015);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S016', N'Tensach 16', N'Tacgia 16', N'NXB 16', 2016);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S017', N'Tensach 17', N'Tacgia 17', N'NXB 17', 2017);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S018', N'Tensach 18', N'Tacgia 18', N'NXB 18', 2018);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S019', N'Tensach 19', N'Tacgia 19', N'NXB 19', 2019);
INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES ('S020', N'Tensach 20', N'Tacgia 20', N'NXB 20', 2020);
GO

-- Insert into HocPhan
INSERT INTO HocPhan (MaHP, TenHP, SoTC) VALUES ('HP001', N'HocPhan 1', 4);
INSERT INTO HocPhan (MaHP, TenHP, SoTC) VALUES ('HP002', N'HocPhan 2', 5);
INSERT INTO HocPhan (MaHP, TenHP, SoTC) VALUES ('HP003', N'HocPhan 3', 6);
GO

-- Insert into TaiLieu
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (1, 'HP001', 'S002', 2016);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (2, 'HP002', 'S004', 2017);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (3, 'HP003', 'S006', 2018);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (4, 'HP001', 'S008', 2019);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (5, 'HP002', 'S010', 2020);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (6, 'HP003', 'S012', 2021);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (7, 'HP001', 'S014', 2022);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (8, 'HP002', 'S016', 2023);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (9, 'HP003', 'S018', 2024);
INSERT INTO TaiLieu (Id, MaHP, MaSach, NamTLK) VALUES (10, 'HP001', 'S020', 2025);
GO
