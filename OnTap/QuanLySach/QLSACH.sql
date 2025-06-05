CREATE Database QLNSN;
go
use QLNSN;
go
CREATE TABLE SACH (MaSach varchar(10), TenSach nVarchar(50),  NamXB int, NhaXB nvarchar(50), TriGia int, MaTheLoai nvarchar(5),
constraint PK_Sach primary key (MaSach)
);
go
CREATE TABLE TACGIA(MaTG varchar(10), TenTG nVarchar(50),  NgaySinh date, GioiTinh bit, DiaChi nvarchar(50), SDT varchar(10), MaSach varchar(10),
constraint PK_TG primary key (MaTG)
);

go
CREATE TABLE THELOAI (MaTheLoai nvarchar(5), TenTheLoai nvarchar(50),
constraint PK_TheLoai primary key (MaTheLoai)
);
-------------------Tao Khoa ngoai---------------------
ALTER TABLE Sach ADD CONSTRAINT FK_theloai_ FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)
ALTER TABLE TACGIA ADD CONSTRAINT FK_TG FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
go
INSERT INTO TheLoai ([MaTheLoai], [TenTheLoai] )VALUES('01',N'Truyện ngắn')
INSERT INTO TheLoai ([MaTheLoai], [TenTheLoai] )VALUES('02',N'Tiểu thuyết')
INSERT INTO TheLoai ([MaTheLoai], [TenTheLoai] )VALUES('03',N'Tin học')
go
INSERT INTO Sach ([MaSach], [TenSach], NamXB, NhaXB, TriGia, MaTheLoai   )VALUES('1',N'Hoa Cẩm Chướng', '2000','Đồng Nai', '15000', '01')
INSERT INTO Sach ([MaSach], [TenSach], NamXB, NhaXB, TriGia, MaTheLoai   )VALUES('2',N'Hoa Hồng', '2000','ĐH Quốc Gia', '25000', '02')
INSERT INTO Sach ([MaSach], [TenSach], NamXB, NhaXB, TriGia, MaTheLoai   )VALUES('3',N'Hoa Cúc', '2000','TpHCM', '35000', '01')
INSERT INTO Sach ([MaSach], [TenSach], NamXB, NhaXB, TriGia, MaTheLoai   )VALUES('4',N'Trinh Thám', '2000','TpHCM', '45000', '03')
go
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S01',N'Minh Anh', '1/1/1998', '1', 'TpHCM', '01234567', '1')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S02',N'Nguyệt Ánh', '2/1/1998','0','TpHCM', '01234567', '1')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S03',N'Hà My', '3/1/1998','0','TpHCM', '01234567', '2')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S04',N'Thành Luân', '1/4/1998','1', 'TpHCM', '01234567', '2')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S05',N'Bá Trình', '1/5/1998','1', 'TpHCM', '01234567', '3')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S06',N'Phú Lâm', '1/6/1998','1','TpHCM', '01234567', '3')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S07',N'Hữu Lộc', '1/7/1998','1','TpHCM', '01234567', '1')
INSERT INTO TacGia(MaTg, TenTG, NgaySinh, GioiTinh, DiaChi, SDT, MaSach) VALUES('S08',N'Minh Khánh', '1/8/1998','1','TpHCM', '01234567', '2')

select TenTheLoai from THELOAI