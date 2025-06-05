create database ENVIROMENT
go
use [ENVIROMENT]
-- Tạo bảng TOCHUC
CREATE TABLE TOCHUC (
    MaTC INT PRIMARY KEY,
    TenCD NVARCHAR(100),
    contact_email VARCHAR(100),
    phone VARCHAR(20),
    Diachi NVARCHAR(200)
);

-- Thêm dữ liệu vào TOCHUC
INSERT INTO TOCHUC (MaTC, TenCD, contact_email, phone, Diachi) VALUES
(1, 'Green Earth Group', 'info@greenearth.org', '0123456789', N'123 Green St, Hà Nội'),
(2, 'Eco Warriors', 'contact@ecowarriors.vn', '0987654321', N'45 Nguyễn Huệ, HCMC'),
(3, 'Clean Future', 'hello@cleanfuture.org', '0901122334', N'56 Trần Phú, Đà Nẵng'),
(4, 'Blue Planet', 'support@blueplanet.net', '0833445566', N'78 Lê Lợi, Huế'),
(5, 'Nature Guardians', 'guardians@nature.org', '0709988776', N'9 Bạch Đằng, Cần Thơ');

-- Tạo bảng DIADIEM
CREATE TABLE DIADIEM (
    MaDD INT PRIMARY KEY,
    TenDD NVARCHAR(100) not null,
    tinh NVARCHAR(100)not null,
    nuoc NVARCHAR(50)
);

-- Thêm dữ liệu vào DIADIEM
INSERT INTO DIADIEM (MaDD, TenDD, tinh, nuoc) VALUES
(1, N'Hoan Kiem Lake', N'Hà Nội', 'Việt Nam'),
(2, N'Thu Duc District', N'Ho Chi Minh City', 'Việt Nam'),
(3, N'My Khe Beach', N'Đà Nẵng', N'Việt Nam'),
(4, N'Huong River', N'Huế', N'Việt Nam'),
(5, N'Ninh Kieu Wharf', N'Cần Thơ', N'Việt Nam'),
(6, N'Cat Ba Island', N'Hải Phòng', N'Việt Nam'),
(7, N'Phu Quoc Beach', N'Kiên Giang', N'Việt Nam'),
(8, N'Cuc Phuong National Park', N'NInh Bình', N'Việt Nam');

-- Tạo bảng CHIENDICH
CREATE TABLE CHIENDICH (
    MaCD INT identity(1,1) PRIMARY KEY,
    TenCD NVARCHAR(150) not null,
    Mota NVARCHAR(150)not null,
    Ngaybd DATE not null,
    Ngaykt DATE not null ,
    MaTC INT not null,
    FOREIGN KEY (MaTC) REFERENCES TOCHUC(MaTC)
);

-- Thêm dữ liệu vào CHIENDICH
INSERT INTO CHIENDICH ( TenCD, Mota, Ngaybd, Ngaykt, MaTC) VALUES
(N'Clean Up Việt Nam', N'National campaign to clean public areas.', '2024-04-01', '2024-04-30', 1),
( N'Beach Protection Drive', N'Preserve and clean Việt Nam’s beaches.', '2024-05-10', '2024-05-20', 2),
(N'Tree Planting Month', N'Plant 10,000 trees nationwide.', '2024-06-01', '2024-06-30', 3),
(N'Say No to Plastic', N'Promote reusable products.', '2024-07-15', '2024-08-15', 4),
( N'River Revival', N'Restore polluted rivers.', '2024-09-01', '2024-09-30', 5);

-- Tạo bảng TRIENKHAICHIENDICH
CREATE TABLE TRIENKHAICHIENDICH (
    id INT identity (1,1) PRIMARY KEY,
    MaCD INT,
    MaDD INT,
    Hoatdongchinh VARCHAR(100),
    Trangthai VARCHAR(50),
    FOREIGN KEY (MaCD) REFERENCES CHIENDICH(MaCD),
    FOREIGN KEY (MaDD) REFERENCES DIADIEM(MaDD)
);

-- Thêm dữ liệu vào TRIENKHAICHIENDICH
INSERT INTO TRIENKHAICHIENDICH (MaCD, MaDD, Hoatdongchinh, Trangthai) VALUES
( 1, 1, 'Trash Collection', 'Completed'),
( 1, 2, 'Trash Collection', 'Completed'),
( 2, 3, 'Beach Cleanup', 'Ongoing'),
( 2, 7, 'Beach Cleanup', 'Planned'),
( 3, 8, 'Tree Planting', 'Completed'),
(3, 4, 'Tree Planting', 'Ongoing'),
( 4, 2, 'Plastic Awareness Workshop', 'Completed'),
( 4, 5, 'Reusable Bag Distribution', 'Ongoing'),
(5, 4, 'Water Sampling', 'Planned'),
( 5, 6, 'Riverbank Cleaning', 'Planned');

