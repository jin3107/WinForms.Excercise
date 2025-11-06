CREATE DATABASE CongTy;
GO
USE CongTy;
GO

-- Bảng Phòng Ban
CREATE TABLE PhongBan (
    MaPhong INT PRIMARY KEY,
    TenPhong NVARCHAR(50),
    DiaChi NVARCHAR(100)
);

-- Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(50),
    TenCongViec NVARCHAR(50),
    MaQL INT NULL,
    NgayTuyen DATE,
    GioiTinh BIT,
    Bac INT,
    Ngach VARCHAR(20),
    MaPhong INT,
    FOREIGN KEY (MaPhong) REFERENCES PhongBan(MaPhong)
);

-- Bảng Bậc Ngạch
CREATE TABLE BacNgach (
    Bac INT,
    Ngach VARCHAR(20),
    HeSoLuong DECIMAL(4,2),
    PRIMARY KEY (Bac, Ngach)
);

-- Bảng Tăng Lương
CREATE TABLE TangLuong (
    MaNV INT,
    ThuTu INT,
    Bac INT,
    Ngach VARCHAR(20),
    NgayBD DATE,
    PRIMARY KEY (MaNV, ThuTu),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Dữ liệu Phòng Ban
INSERT INTO PhongBan (MaPhong, TenPhong, DiaChi) VALUES
(10, N'Kinh doanh', N'Hà Nội'),
(20, N'Nhân sự', N'TP HCM'),
(30, N'Tài chính', N'Đà Nẵng'),
(40, N'Công nghệ', N'Cần Thơ');

-- Dữ liệu Bậc Ngạch
INSERT INTO BacNgach (Bac, Ngach, HeSoLuong) VALUES
(1, 'V.07.01.02', 4.40),
(1, 'V.07.01.03', 2.34),
(2, 'V.07.01.02', 4.74),
(2, 'V.07.01.03', 2.67),
(3, 'V.07.01.02', 5.08),
(3, 'V.07.01.03', 3.00),
(4, 'V.07.01.02', 5.42),
(4, 'V.07.01.03', 3.33),
(5, 'V.07.01.02', 5.76),
(5, 'V.07.01.03', 3.66),
(6, 'V.07.01.02', 6.10),
(6, 'V.07.01.03', 3.99),
(7, 'V.07.01.02', 6.44),
(7, 'V.07.01.03', 4.32),
(8, 'V.07.01.02', 6.78),
(8, 'V.07.01.03', 4.65),
(9, 'V.07.01.03', 4.98);

-- Dữ liệu Nhân Viên
INSERT INTO NhanVien (MaNV, TenNV, TenCongViec, MaQL, NgayTuyen, GioiTinh, Bac, Ngach, MaPhong) VALUES
(101, N'Nguyễn Văn An', N'Giảng viên', NULL, '2018-09-01', 1, 5, 'V.07.01.03', 10),
(102, N'Lê Thị Bình', N'Giảng viên', 101, '2019-08-15', 0, 3, 'V.07.01.03', 10),
(103, N'Trần Văn Cường', N'Giảng viên chính', 101, '2015-03-20', 1, 4, 'V.07.01.02', 10),
(104, N'Phạm Thị Dung', N'Nhân viên hành chính', 108, '2020-01-10', 0, 2, 'V.07.01.03', 20),
(105, N'Đỗ Minh Đức', N'Giảng viên', 101, '2021-09-05', 1, 2, 'V.07.01.03', 10),
(106, N'Võ Thanh Hà', N'Kế toán viên', NULL, '2017-07-01', 0, 4, 'V.07.01.03', 30),
(107, N'Nguyễn Thị Hòa', N'Giảng viên chính', 101, '2016-04-25', 0, 6, 'V.07.01.02', 10),
(108, N'Lưu Văn Khánh', N'Trưởng phòng', NULL, '2014-02-12', 1, 6, 'V.07.01.02', 20),
(109, N'Trương Thị Lan', N'Thư ký khoa', 108, '2022-05-01', 0, 1, 'V.07.01.03', 20),
(110, N'Bùi Quốc Nam', N'Giảng viên', 101, '2023-09-10', 1, 1, 'V.07.01.03', 10);

-- Dữ liệu Tăng Lương
INSERT INTO TangLuong (MaNV, ThuTu, Bac, Ngach, NgayBD) VALUES
(103, 2, 4, 'V.07.01.02', '2019-05-01'),
(103, 3, 5, 'V.07.01.02', '2022-05-01'),
(104, 1, 1, 'V.07.01.03', '2019-03-15'),
(104, 2, 2, 'V.07.01.03', '2022-03-15'),
(105, 1, 4, 'V.07.01.02', '2015-09-01'),
(105, 2, 5, 'V.07.01.02', '2018-09-01'),
(105, 3, 6, 'V.07.01.02', '2021-09-01'),
(106, 1, 1, 'V.07.01.03', '2020-01-01'),
(106, 2, 2, 'V.07.01.03', '2023-01-01'),
(107, 1, 2, 'V.07.01.03', '2018-06-01'),
(107, 2, 3, 'V.07.01.03', '2021-06-01'),
(108, 1, 5, 'V.07.01.02', '2016-10-01'),
(108, 2, 6, 'V.07.01.02', '2019-10-01'),
(108, 3, 7, 'V.07.01.02', '2022-10-01'),
(109, 1, 1, 'V.07.01.03', '2021-05-01'),
(110, 1, 3, 'V.07.01.02', '2019-09-01'),
(110, 2, 4, 'V.07.01.02', '2022-09-01');