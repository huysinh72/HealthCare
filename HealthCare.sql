--ASPI-Team 04 // He thong theo doi suc khoe
create database HealthCareDB 
go
use HealthCareDB
go
create table BenhNhan
(
	TenDangNhap char(30),
	MatKhau char(30),
	TenNguoiDung nchar(50),
	NgaySinh datetime,
	GioiTinh nchar(3),
	Email char(30),
	DienThoai char(11),
	DiaChi nchar(50),
	NhanBaiDang int,
	primary key(TenDangNhap)
)

create table BaiDang
(
	MaBaiDang int,
	TieuDe nchar,
	NoiDung nchar,
	primary key(MaBaiDang)
)

create table BacSi
(	
	MaBacSi int,
	TenBacSi nchar(50),
	NgaySinh datetime,
	GioiTinh nchar(3),
	Email char(30),
	DienThoai char(11),
	DiaChi nchar(50),
	ChuyenNganh nchar(50),
	BangCap nchar(30),
	primary key(MaBacSi)
)

create table DuLieuKham
(
	MaDuLieuKham int,
	NhipTim int,
	CamXuc int,
	ChieuCao int,
	CanNang int,
	NgayKham datetime,
	ChanDoan int,  
	primary key(MaDuLieuKham)
)

create table ChiTietKham
(
	BenhNhan char(30),
	DuLieuKham int,
	primary key(BenhNhan, DuLieuKham)
)

create table TrieuChungKham
(
	DuLieuKham int,
	TrieuChung int,
	primary key(DuLieuKham, TrieuChung)
)

create table ChanDoan
(
	MaChanDoan int,
	Benh int,
	primary key(MaChanDoan)
)

create table ViTriBenh
(
	MaViTri int,
	TenViTri nvarchar(50),
	primary key(MaViTri)
)

create table TrieuChung
(
	MaTrieuChung int,
	TenTrieuChung nvarchar(50),
	primary key(MaTrieuChung)
)

create table TrieuChung_ViTri
(
	MaViTri int,
	MaTrieuChung int,
	primary key(MaViTri, MaTrieuChung)
)

create table Benh
(
	MaBenh int,
	TenBenh nvarchar(50),
	NoiDung nvarchar(50),
	LoiKhuyen nchar(100),
	primary key(MaBenh)
)

go
ALTER TABLE TrieuChung_ViTri
ADD CONSTRAINT FK_TCVT_ViTri
FOREIGN KEY (MaViTri)
REFERENCES ViTriBenh(MaViTri) 

go
ALTER TABLE TrieuChung_ViTri
ADD CONSTRAINT FK_TCVT_TrieuChung
FOREIGN KEY (MaTrieuChung)
REFERENCES TrieuChung(MaTrieuChung) 

go
ALTER TABLE ChiTietKham
ADD CONSTRAINT FK_ChiTietKham_DuLieuKham
FOREIGN KEY (DuLieuKham)
REFERENCES DuLieuKham(MaDuLieuKham) 

go
ALTER TABLE ChiTietKham
ADD CONSTRAINT FK_ChiTietKham_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(TenDangNhap) 
 
go
ALTER TABLE DuLieuKham
ADD CONSTRAINT FK_DuLieuKham_ChanDoan
FOREIGN KEY (ChanDoan)
REFERENCES ChanDoan(MaChanDoan) 

go
ALTER TABLE TrieuChungKham
ADD CONSTRAINT FK_TrieuChungKham_DuLieuKham
FOREIGN KEY (DuLieuKham)
REFERENCES DuLieuKham(MaDuLieuKham) 

go
ALTER TABLE TrieuChungKham
ADD CONSTRAINT FK_TrieuChungKham_TrieuChung
FOREIGN KEY (TrieuChung)
REFERENCES TrieuChung(MaTrieuChung)

go
ALTER TABLE ChanDoan
ADD CONSTRAINT FK_ChanDoan_Benh
FOREIGN KEY (Benh)
REFERENCES Benh(MaBenh)

go
insert into Benh values (1,N'Cảm', N'Bị cảm do thời tiết', N'Nên giữ ấm cơ thể'),
						(2, N'Sốt', N'Nhiệt độ cơ thể cao', N'Nên mua thuoc uống và nghỉ ngơi'),
						(3, N'Muỗi Chích', N'Bị muỗi chích thôi mà', N'Không nên gãi bôi thuốc')
go

insert into TrieuChung values			(1,	N'Ngứa'),
										(2,	N'Gãy Xương'),
										(3,	N'Chảy Máu'),
										(4,	N'Đau'),
										(5,	N'Nhức'),
										(6,	N'Nóng'),
										(7,	N'Lạnh')
go
insert into ViTriBenh values (1,N'Đầu'),
(2, N'Lưng'),
(3, N'Vai'),
(4, N'Cánh Tay'),
(5, N'Bàn Tay'),
(6,N'Đùi'),
(7,N'Cẳng Chân'),
(8,N'Bàn Chân'),
(9,N'Mông'),
(10,N'Bụng'),
(11,N'Ngực'),
(12,N'Cổ'),
(13,N'Bộ Phận Sinh Dục'),
(14,N'Miệng')

go
insert into TrieuChung_ViTri values (1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(2,1),
(2,4),
(2,5),
(3,5),
(4,1),
(4,2),
(4,5),
(5,1),
(5,4),	
(6,4),
(6,5),
(7,2),
(8,1),
(8,3),
(9,1),
(10,3),
(10,4),
(11,5),
(12,5),
(13,3)
go
create procedure sp_form_ThemBenhNhan @tenDN char(30), @mk char(30), @ten nchar(50), @ns datetime, @gt nchar(3), @email char(30), @dt char(11), @diaChi nchar(50) 
as
	insert into BenhNhan
	values (@tenDN, @mk, @ten, @ns, @gt, @email, @dt, @diaChi, null)
			
	




