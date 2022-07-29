--Tạo CSDL Quản lý kho
use master

CREATE DATABASE QuanLyKho
GO
--Tạo các bảng trong Database
use QuanLyKho

CREATE TABLE NhanVien
(
 MaNV varchar(30) PRIMARY KEY NOT NULL,
 HoTen nvarchar(80) NOT NULL,
 GioiTinh nvarchar(10) NOT NULL,
 NgaySinh DATE NOT NULL,
 Luong INT NOT NULL,
 DiaChi VARCHAR (100) NOT NULL,
 SDT CHAR (15) NOT NULL,
 MatKhau VARCHAR (20) NOT NULL,
 ChucVu NVARCHAR (50) NOT NULL,
 TrangThai BIT NOT NULL
)

GO
CREATE TABLE LoaiSanPham
(
MaLoaiSP varchar(30) PRIMARY KEY NOT NULL,
TenLoaiSP nvarchar(50) NOT NULL,
TrangThai BIT NOT NULL
)


GO

CREATE TABLE NhaCungCap
(
 MaNCC varchar(30) PRIMARY KEY NOT NULL,
 TenNCC nvarchar(200) NOT NULL,
 DiaChiNCC nvarchar(1000) NOT NULL,
 SDTNCC CHAR (15) NOT NULL,
 TrangThai BIT NOT NULL
)


GO

CREATE TABLE SanPham
(
 MaSP varchar(30) PRIMARY KEY NOT NULL,
 TenSP nvarchar(50) NOT NULL,
 MaLoaiSP varchar(30)FOREIGN KEY REFERENCES LoaiSanPham (MaLoaiSP) NOT NULL,
 SoLuong INT NOT NULL,
 DonVi nvarchar(30) NOT NULL,
 DonGia INT NOT NULL,
 MaNCC varchar(30)FOREIGN KEY REFERENCES NhaCungCap (MaNCC) NOT NULL,
 TrangThai BIT NOT NULL
)


GO
CREATE TABLE PhieuNhap
(
 MaPN varchar(30) PRIMARY KEY NOT NULL,
 MaNV varchar(30) FOREIGN KEY REFERENCES NhanVien (MaNV) NOT NULL,
 NgayTao DATE NOT NULL,
 TongTien INT NOT NULL,
 MaNCC varchar(30) FOREIGN KEY REFERENCES NhaCungCap (MaNCC) NOT NULL
)

GO

CREATE TABLE ChiTietPhieuNhap
(

 MaPN varchar(30) FOREIGN KEY REFERENCES PhieuNhap (MaPN) NOT NULL,
 MaSP varchar(30) FOREIGN KEY REFERENCES SanPham (MaSP) NOT NULL,
 SoLuong INT NOT NULL,
 DonVi nvarchar(30) NOT NULL,
 ThanhTien INT NOT NULL,
   PRIMARY KEY ( MaPN, MaSP )
 
 )

 GO
 CREATE TABLE PhieuXuat
(
 MaPX varchar(30) PRIMARY KEY NOT NULL,
 MaNV varchar(30) FOREIGN KEY REFERENCES NhanVien (MaNV) NOT NULL,
 NgayTao DATE NOT NULL,
 TongTien INT NOT NULL,
 NguoiNhan NVARCHAR(50) NOT NULL,
 LyDo NVARCHAR(500) NOT NULL
)
GO
CREATE TABLE ChiTietPhieuXuat
(

 MaPX varchar(30) FOREIGN KEY REFERENCES PhieuXuat (MaPX) NOT NULL,
 MaSP varchar(30) FOREIGN KEY REFERENCES SanPham (MaSP) NOT NULL,
 SoLuong INT NOT NULL,
 DonVi nvarchar(30) NOT NULL,
 ThanhTien INT NOT NULL,
   PRIMARY KEY ( MaPX, MaSP )
 )

 GO

CREATE TABLE PhieuTraHang
(
 MaPT varchar(30) PRIMARY KEY NOT NULL,
 MaNV varchar(30) FOREIGN KEY REFERENCES NhanVien (MaNV) NOT NULL,
 NgayTao DATE NOT NULL,
 TongTien INT NOT NULL,
 LyDo NVARCHAR (1000) NOT NULL,
 MaNCC varchar(30) FOREIGN KEY REFERENCES NhaCungCap (MaNCC) NOT NULL
)

GO

CREATE TABLE ChiTietPhieuTra
(
 MaPT varchar(30) FOREIGN KEY REFERENCES PhieuTraHang (MaPT) NOT NULL,
 MaSP varchar(30) FOREIGN KEY REFERENCES SanPham (MaSP) NOT NULL,
 SoLuong INT NOT NULL,
 DonVi nvarchar(30) NOT NULL,
 ThanhTien INT NOT NULL,
   PRIMARY KEY ( MaPT, MaSP )
)
-- Nhập dữ liệu vào các bảng

INSERT INTO dbo.NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,Luong,DiaChi,SDT,MatKhau,ChucVu,TrangThai)
VALUES ('QL01',N'Phan Hồng Phát',N'Nam','2000/01/20',3000000,'Cai Rang, Can Tho','0123456789','phat2020',N'quản lý',1),
       ('TK01',N'Nguyễn Thái Nguyên',N'Nam','2000/04/15',2500000,'Lap Vo, Dong Thap','0147258369','nguyen2020',N'thủ kho',1),
	   ('TK02',N'Châu Nhật Minh',N'Nam','2000/09/03',2500000,'O Mon, Can Tho','0321654987','minh2020',N'thủ kho',1)

INSERT INTO dbo.LoaiSanPham (MaLoaiSP,TenLoaiSP,TrangThai)
VALUES ('LS01',N'Sữa bột',1),
       ('LS02',N'Sữa nước',1),
	   ('LS03',N'Sữa chua',1)

INSERT INTO dbo.NhaCungCap (MaNCC,TenNCC,DiaChiNCC,SDTNCC,TrangThai)
VALUES 
       ('NCC01',N'Công Ty Cổ Phần Sữa Việt Nam',N'Hùng Vương, Q. Ninh Kiều, Tp. Cần Thơ','0292382882',1),
	   ('NCC02',N'Công Ty TNHH TDK',N'P. An Khánh, Q. Ninh Kiều, Tp. Cần Thơ','0292389638',1),
	   ('NCC03',N'Cty Cổ Phần Sữa Việt Nam',N'Q. Bình Thủy, Tp. Cần Thơ','0292384269',1)
INSERT INTO dbo.SanPham (MaSP,TenSP,MaLoaiSP,SoLuong,DonVi,DonGia,MaNCC,TrangThai)
VALUES ('NUT01','NUTIFOOD PEDIA PLUS GOLD 900G','LS01',100,N'Lon',350000,'NCC01',1),
       ('NUT02','NUTIFOOD PEDIA PLUS 900G','LS01',100,N'Lon',275000,'NCC01',1),
	   ('NUT03','NUTIFOOD NUTI IQ MUM GOLD 900G','LS01',100,N'Lon',180000,'NCC01',1),
	   ('VNM04','VINAMILK OPTIMUM GOLD 3 900G','LS01',100,N'Lon',328000,'NCC02',1),
	   ('VNM05','VINAMILK OPTIMUM MAMA 900G','LS01',100,N'Lon',290000,'NCC02',1),
	   ('ABB06','ABBOTT GROW 180ML','LS02',100,N'Lon',180000,'NCC03',1),
	   ('ABB07','ABBOTT ENSURE GOLD 237ML','LS02',100,N'Lốc',270000,'NCC03',1),
	   ('ABB08','ABBOTT PEDIA SURE 237ML','LS02',100,N'Lốc',350000,'NCC03',1),
	   ('NUT04','NUTIFOOD NUTI NHA DAM','LS03',100,N'Thùng',264000,'NCC01',1),
	   ('NUT05','NUTIFOOD NUTI KID','LS03',100,N'Thùng',276000,'NCC01',1)

UPDATE NhanVien SET TrangThai='1' WHERE MaNV='TK02'
select MaNCC AS N'Mã nhà cung cấp',TenNCC AS N'Tên nhà cung cấp',DiaChiNCC AS N'Địa chỉ',SDTNCC AS N'Số điện thoại' from NhaCungCap where TrangThai='1'