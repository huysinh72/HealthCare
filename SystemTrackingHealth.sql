--ASPI-Team 04 // He thong theo doi suc khoe
create database SystemTrackingHealthDB 
go
use SystemTrackingHealthDB
go
create table NguoiDung
(
	TenDangNhap char(30),
	MatKhau char(30),
	TenNguoiDung varchar(50),
	NgaySinh datetime,
	GioiTinh varchar(3),
	Email char(30),
	DienThoai char(11),
	NhanBaiDang int,
	LoaiNguoiDung int,
	primary key(TenDangNhap)
)

create table BaiDang
(
	MaBaiDang int,
	TieuDe varchar,
	NoiDung varchar,
	primary key(MaBaiDang)
)

create table BacSi
(	
	TenDangNhap char(30),
	ChuyenNganh varchar(50),
	primary key(TenDangNhap)
)


create table BenhNhan
(
	TenDangNhap char(30),
	MaHoSoBenhAn int,
	primary key(TenDangNhap)
)

create table HoSoBenhAn
(
	MaHoSoBenhAn int,
	MaDuLieuBenhAn int,
	MaChanDoan int, 
	primary key(MaHoSoBenhAn)
)

create table DuLieuBenhAn
(
	MaDuLieuBenhAn int,
	NhipTim int,
	CamXuc int,
	ChieuCao int,
	CanNang int,
	MaDuLieuKham int,
	NgayKham datetime, 
	primary key(MaDuLieuBenhAn)
)

create table DuLieuKham
(
	MaDuLieuKham int,
	DanhSachTrieuChung varchar,
	primary key(MaDuLieuKham)
)

create table ChanDoan
(
	MaChanDoan int,
	BenhChanDoan varchar,
	NgayChanDoan datetime,
	primary key(MaChanDoan)
)

go
ALTER TABLE BenhNhan
ADD CONSTRAINT FK_BenhNhan_NguoiDung
FOREIGN KEY (TenDangNhap)
REFERENCES NguoiDung(TenDangNhap)

go
ALTER TABLE BacSi
ADD CONSTRAINT FK_BacSi_NguoiDung
FOREIGN KEY (TenDangNhap)
REFERENCES NguoiDung(TenDangNhap)

go
ALTER TABLE BenhNhan
ADD CONSTRAINT FK_BenhNhan_HoSoBenhAn
FOREIGN KEY (MaHoSoBenhAn)
REFERENCES HoSoBenhAn(MaHoSoBenhAn)

go
ALTER TABLE HoSoBenhAn
ADD CONSTRAINT FK_HoSoBenhAn_DuLieuBenhAn
FOREIGN KEY (MaDuLieuBenhAn)
REFERENCES DuLieuBenhAn(MaDuLieuBenhAn)

go
ALTER TABLE HoSoBenhAn
ADD CONSTRAINT FK_HoSoBenhAn_ChanDoan
FOREIGN KEY (MaChanDoan)
REFERENCES ChanDoan(MaChanDoan)

go
ALTER TABLE DuLieuBenhAn
ADD CONSTRAINT FK_DuLieuBenhAn_DuLieuKham
FOREIGN KEY (MaDuLieuKham)
REFERENCES DuLieuKham(MaDuLieuKham)







