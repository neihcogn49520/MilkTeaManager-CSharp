CREATE DATABASE QLTraSua
GO
USE QLTraSua
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
INSERT INTO SANPHAM
VALUES('M01',N'Trà sữa trân châu', 20000 , N'S', 200)

INSERT INTO SANPHAM
VALUES('M02',N'Trà đào', 18000 , N'S', 100)

/* Insert SANPHAM */
INSERT INTO BAN VALUES(1, N'Bàn 1' )
INSERT INTO BAN VALUES(2, N'Bàn 2' )

/* Insert HOADON */
INSERT INTO HOADON VALUES(N'HD01', 'NV01', '2021-10-22' )
INSERT INTO HOADON VALUES(N'HD02', 'NV02', '2021-10-22' )

/* Insert CTHD */
INSERT INTO CTHD VALUES(N'HD01',1, 'M01', N'S', 1, 20000 )
INSERT INTO CTHD VALUES(N'HD01',1, 'M02', N'S', 1, 20000 )
INSERT INTO CTHD VALUES(N'HD02',1, 'M02', N'S', 2, 18000 )

/* Insert TAIKHOAN */
INSERT INTO TAIKHOAN VALUES('N1','NV01','1', N'Quản lý')
INSERT INTO TAIKHOAN VALUES('N2','NV02','1', N'Thu ngân')
INSERT INTO TAIKHOAN VALUES('N3','NV04','1', N'Quản lý kho')


