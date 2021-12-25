﻿CREATE DATABASE QuanLiTraSua
GO
USE QuanLiTraSua
GO

CREATE TABLE NHANVIEN(
	MaNV varchar (20) NOT NULL,
	TenNV nvarchar (200) NOT NULL,
	Ngaysinh date NOT NULL,
	CMND varchar (12) NOT NULL,
	SDT varchar (12) NOT NULL,
	Gioitinh nvarchar (10) NOT NULL,
	Ngayvl datetime NOT NULL,
	Calam nvarchar (20) NOT NULL,
	Chucvu nvarchar (20) NOT NULL,
	HSLuong decimal not null,
CONSTRAINT PK_NhanVien PRIMARY KEY(MANV)
)
GO

CREATE TABLE SANPHAM(
	MaMon varchar (20) NOT NULL,
	TenMon nvarchar (200) NOT NULL,
	DonGia decimal (18,0) NOT NULL,
	Size varchar (5) NOT NULL,
	SL int NOT NULL,
CONSTRAINT PK_SanPham PRIMARY KEY(MaMon)
)
GO

CREATE TABLE BAN(
	MaBan int NOT NULL,
	TenBan nvarchar (200) NOT NULL,
CONSTRAINT PK_Ban PRIMARY KEY(MaBan)
)
GO

CREATE TABLE HOADON(
	MaHD varchar (20) NOT NULL,
	MaNV varchar (20) NOT NULL,
	NgayHD datetime NOT NULL,
CONSTRAINT PK_HoaDon PRIMARY KEY(MaHD)
)
GO

CREATE TABLE CTHD(
	MaHD varchar (20) NOT NULL,
	MaBan int NOT NULL,
	MaMon varchar (20) NOT NULL,
	Size varchar (5) NOT NULL,
	Soluong int NOT NULL,
	DonGia decimal (18,0) NOT NULL
CONSTRAINT PK_CTHD PRIMARY KEY(MaHD, MaBan, MaMon)
)
GO

CREATE TABLE TAIKHOAN(
	ID char(10) NOT NULL PRIMARY KEY,
	MaNV varchar (20) NOT NULL,
	MK char(10) NOT NULL,
	PhanQuyen nvarchar(30) NOT NULL
)
GO

ALTER TABLE HOADON ADD CONSTRAINT fk_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN (MaNV);
ALTER TABLE CTHD ADD CONSTRAINT fk_HOADON FOREIGN KEY (MaHD) REFERENCES HOADON (MaHD);
ALTER TABLE CTHD ADD CONSTRAINT fk_BAN FOREIGN KEY (MaBan) REFERENCES BAN (MaBan);
ALTER TABLE CTHD ADD CONSTRAINT fk_SANPHAM FOREIGN KEY (MaMon) REFERENCES SANPHAM (MaMon);
ALTER TABLE TAIKHOAN ADD CONSTRAINT fk_TKNV FOREIGN KEY (MaNV) REFERENCES NHANVIEN (MaNV);




/* Insert NHANVIEN */
INSERT INTO NHANVIEN
VALUES('NV01',N'Nguyễn Thị Ngọc', '2001-08-04', '553358878','0354925427', N'Nữ', '2021-08-04', N'Ca 1' , N'Phục vụ',100)

INSERT INTO NHANVIEN
VALUES('NV02',N'Nguyễn Thị Diễm', '2001-08-14', '553358866', '0165925427', N'Nữ', '2021-08-04', N'Ca 2', N'Pha chế',200)
INSERT INTO NHANVIEN
VALUES('NV03',N'Nguyễn Thị Thi', '2001-08-14', '553358866', '0165925427', N'Nữ', '2021-08-04', N'Ca 2', N'Pha chế',200)

INSERT INTO NHANVIEN
VALUES('NV04',N'Nguyễn Thị Thi', '2001-08-14', '553358866', '0165925427', N'Nữ', '2021-08-04', N'Ca 2', N'Pha chế',200)

/* Insert SANPHAM */
INSERT INTO SANPHAM VALUES('M01',N'Trà sữa trân châu', 20000 , N'S', 200)
INSERT INTO SANPHAM VALUES('M02',N'Trà đào', 18000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M03',N'Trà chanh', 22000 , N'S', 200)
INSERT INTO SANPHAM VALUES('M04',N'Trà đào cam sả', 18000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M05',N'Trà sữa cam sả', 20000 , N'M', 200)
INSERT INTO SANPHAM VALUES('M06',N'Trà đào', 20000 , N'M', 100)
INSERT INTO SANPHAM VALUES('M07',N'Sữa tươi TC đường đen', 25000 , N'S', 200)
INSERT INTO SANPHAM VALUES('M08',N'Sữa tươi TC đường đen', 18000 , N'M', 100)
INSERT INTO SANPHAM VALUES('M09',N'Trà sữa trân châu', 25000 , N'M', 200)
INSERT INTO SANPHAM VALUES('M10',N'Capuchino', 25000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M11',N'Capuchino', 30000 , N'M', 200)
INSERT INTO SANPHAM VALUES('M12',N'Americano', 30000 , N'L', 100)
INSERT INTO SANPHAM VALUES('M13',N'Sinh tố dâu', 30000 , N'S', 200)
INSERT INTO SANPHAM VALUES('M14',N'Sinh tố bơ', 30000 , N'S', 200)
INSERT INTO SANPHAM VALUES('M15',N'Trà sữa thái xanh', 20000 , N'S', 200)
INSERT INTO SANPHAM VALUES('M16',N'Trà sữa thái xanh', 25000 , N'M', 100)
INSERT INTO SANPHAM VALUES('M17',N'Olong', 20000 , N'Chai', 200)
INSERT INTO SANPHAM VALUES('M18',N'Sting', 18000 , N'Chai', 100)
INSERT INTO SANPHAM VALUES('M19',N'Sting', 18000 , N'Lon', 100)
INSERT INTO SANPHAM VALUES('M20',N'Trà sữa hoa lài', 20000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M21',N'Trà sữa hoa lài', 22000 , N'M', 100)
INSERT INTO SANPHAM VALUES('M22',N'Trà sữa thái xanh', 28000 , N'L', 100)
INSERT INTO SANPHAM VALUES('M23',N'Trà sữa hoa lài', 28000 , N'L', 100)
INSERT INTO SANPHAM VALUES('M24',N'Socola kem Cheese', 30000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M25',N'Socola kem Cheese', 35000 , N'M', 100)
INSERT INTO SANPHAM VALUES('M26',N'Socola kem Cheese', 45000 , N'L', 100)
INSERT INTO SANPHAM VALUES('M27',N'Trà hoa nhiệt đới', 25000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M28',N'Trà hoa nhiệt đới', 35000 , N'L', 100)
INSERT INTO SANPHAM VALUES('M29',N'Trà sữa Morri đặc biệt', 30000 , N'S', 100)
INSERT INTO SANPHAM VALUES('M30',N'Trà sữa Morri đặc biệt', 38000 , N'M', 100)
INSERT INTO SANPHAM VALUES('M31',N'Trà sữa Morri đặc biệt', 45000 , N'L', 100)

/* Insert SANPHAM */
INSERT INTO BAN VALUES(1, N'Bàn 1' )
INSERT INTO BAN VALUES(2, N'Bàn 2' )
INSERT INTO BAN VALUES(3, N'Bàn 3' )
INSERT INTO BAN VALUES(4, N'Bàn 4' )
INSERT INTO BAN VALUES(5, N'Bàn 5' )
INSERT INTO BAN VALUES(6, N'Bàn 6' )
INSERT INTO BAN VALUES(7, N'Bàn 7' )
INSERT INTO BAN VALUES(8, N'Bàn 8' )
INSERT INTO BAN VALUES(9, N'Bàn 9' )
INSERT INTO BAN VALUES(10, N'Bàn 10' )
INSERT INTO BAN VALUES(11, N'Bàn 11' )
INSERT INTO BAN VALUES(12, N'Bàn 12' )

/* Insert HOADON */
INSERT INTO HOADON VALUES(N'HD01', 'NV01', '2021-10-22' )
INSERT INTO HOADON VALUES(N'HD02', 'NV02', '2021-10-22' )
INSERT INTO HOADON VALUES(N'HD03', 'NV01', '2021-11-05' )
INSERT INTO HOADON VALUES(N'HD04', 'NV01', '2021-11-30' )
INSERT INTO HOADON VALUES(N'HD05', 'NV01', '2021-12-11' )
INSERT INTO HOADON VALUES(N'HD06', 'NV01', '2021-12-19' )
INSERT INTO HOADON VALUES(N'HD07', 'NV01', '2021-12-25' )
INSERT INTO HOADON VALUES(N'HD08', 'NV01', '2021-09-04' )
INSERT INTO HOADON VALUES(N'HD09', 'NV02', '2021-08-15' )
INSERT INTO HOADON VALUES(N'HD10', 'NV02', '2021-07-30' )
INSERT INTO HOADON VALUES(N'HD11', 'NV02', '2021-07-14' )
INSERT INTO HOADON VALUES(N'HD12', 'NV02', '2021-06-04' )
INSERT INTO HOADON VALUES(N'HD13', 'NV02', '2021-05-20' )
INSERT INTO HOADON VALUES(N'HD14', 'NV02', '2021-05-04' )
INSERT INTO HOADON VALUES(N'HD15', 'NV02', '2021-04-20' )
INSERT INTO HOADON VALUES(N'HD16', 'NV02', '2021-03-05' )
INSERT INTO HOADON VALUES(N'HD17', 'NV01', '2021-02-02' )
INSERT INTO HOADON VALUES(N'HD18', 'NV01', '2021-02-14' )
INSERT INTO HOADON VALUES(N'HD19', 'NV01', '2021-02-24' )
INSERT INTO HOADON VALUES(N'HD20', 'NV01', '2021-01-02' )
INSERT INTO HOADON VALUES(N'HD21', 'NV01', '2021-01-10' )
INSERT INTO HOADON VALUES(N'HD22', 'NV02', '2021-01-18' )
INSERT INTO HOADON VALUES(N'HD23', 'NV01', '2021-01-29' )

/* Insert CTHD */
INSERT INTO CTHD VALUES(N'HD01',1, 'M01', N'S', 1, 20000 )
INSERT INTO CTHD VALUES(N'HD01',1, 'M02', N'S', 1, 20000 )
INSERT INTO CTHD VALUES(N'HD02',1, 'M02', N'S', 2, 18000 )
INSERT INTO CTHD VALUES(N'HD02',1, 'M03', N'S', 5, 22000 )
INSERT INTO CTHD VALUES(N'HD02',1, 'M11', N'M', 3, 30000 )
INSERT INTO CTHD VALUES(N'HD03',2, 'M05', N'M', 4, 20000 )
INSERT INTO CTHD VALUES(N'HD03',2, 'M16', N'M', 2, 25000 )
INSERT INTO CTHD VALUES(N'HD04',6, 'M14', N'S', 2, 30000 )
INSERT INTO CTHD VALUES(N'HD04',6, 'M04', N'S', 10, 18000 )
INSERT INTO CTHD VALUES(N'HD05',7, 'M01', N'S', 2, 20000 )
INSERT INTO CTHD VALUES(N'HD05',7, 'M10', N'S', 7, 25000 )
INSERT INTO CTHD VALUES(N'HD06',4, 'M20', N'S', 6, 20000 )
INSERT INTO CTHD VALUES(N'HD07',5, 'M18', N'Chai', 5, 18000 )
INSERT INTO CTHD VALUES(N'HD08',10, 'M26', N'L', 4, 45000 )
INSERT INTO CTHD VALUES(N'HD08',10, 'M08', N'M', 2, 18000 )
INSERT INTO CTHD VALUES(N'HD09',9, 'M07', N'S', 20, 25000 )
INSERT INTO CTHD VALUES(N'HD10',5, 'M22', N'L', 2, 28000 )
INSERT INTO CTHD VALUES(N'HD10',5, 'M11', N'M', 2, 30000 )
INSERT INTO CTHD VALUES(N'HD10',5, 'M02', N'S', 2, 18000 )
INSERT INTO CTHD VALUES(N'HD11',1, 'M17', N'Chai', 2, 20000 )
INSERT INTO CTHD VALUES(N'HD12',1, 'M09', N'M', 2, 25000 )
INSERT INTO CTHD VALUES(N'HD12',1, 'M25', N'M', 2, 35000 )
INSERT INTO CTHD VALUES(N'HD13',3, 'M30', N'M', 1, 38000 )
INSERT INTO CTHD VALUES(N'HD14',8, 'M29', N'S', 1, 30000 )
INSERT INTO CTHD VALUES(N'HD15',6, 'M12', N'L', 5, 30000 )
INSERT INTO CTHD VALUES(N'HD16',7, 'M08', N'M', 2, 30000 )
INSERT INTO CTHD VALUES(N'HD17',9, 'M04', N'S', 2, 18000 )
INSERT INTO CTHD VALUES(N'HD18',11, 'M13', N'S', 2, 30000 )
INSERT INTO CTHD VALUES(N'HD18',11, 'M02', N'S', 5, 18000 )
INSERT INTO CTHD VALUES(N'HD19',12, 'M10', N'S', 4, 25000 )
INSERT INTO CTHD VALUES(N'HD20',6, 'M05', N'M', 3, 20000 )
INSERT INTO CTHD VALUES(N'HD20',6, 'M20', N'S', 4, 20000 )
INSERT INTO CTHD VALUES(N'HD21',1, 'M26', N'L', 2, 45000 )
INSERT INTO CTHD VALUES(N'HD21',1, 'M31', N'L', 2, 45000 )
INSERT INTO CTHD VALUES(N'HD22',7, 'M22', N'L', 6, 28000 )
INSERT INTO CTHD VALUES(N'HD23',5, 'M09', N'M', 2, 25000 )

/* Insert TAIKHOAN */
INSERT INTO TAIKHOAN VALUES('N1','NV01','1', N'Quản lý')
INSERT INTO TAIKHOAN VALUES('N2','NV02','1', N'Thu ngân')
INSERT INTO TAIKHOAN VALUES('N3','NV04','1', N'Quản lý kho')


