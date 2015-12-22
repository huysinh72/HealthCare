--ASPI-Team 04 // He thong theo doi suc khoe
create database HealthCareDB 
go
use HealthCareDB
go
create table BenhNhan
(
	TenDangNhap char(30),
	MatKhau char(30),
	TenBenhNhan nchar(50),
	NgaySinh date,
	GioiTinh nchar(3),
	Email char(30),
	DienThoai char(11),
	DiaChi nchar(50),
	NhanBaiDang int,
	primary key(TenDangNhap)
)

create table NguoiThan
(
	BenhNhan char(30),
	NguoiThan char(30),
	MucDo char(20),
	primary key(BenhNhan, NguoiThan)
)

create table BaiDang
(
	MaBaiDang int IDENTITY PRIMARY KEY,
	TieuDe nchar(100),
	NoiDung nchar(1000)
)

create table BacSi
(	
	MaBacSi int IDENTITY PRIMARY KEY,
	TenBacSi nchar(50),
	NgaySinh date,
	GioiTinh nchar(3),
	Email char(30),
	DienThoai char(11),
	DiaChi nchar(50),
	ChuyenNganh nchar(50),
	BangCap nchar(30)
)

create table DuLieuKham
(
	MaDuLieuKham int IDENTITY PRIMARY KEY,
	NhipTim int,
	CamXuc int,
	ChieuCao int,
	CanNang int,
	NgayKham datetime,
	ChanDoan int,
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
ALTER TABLE NguoiThan
ADD CONSTRAINT FK_NguoiThan_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(TenDangNhap)

go 
ALTER TABLE NguoiThan
ADD CONSTRAINT FK_NguoiThan_NguoiThan
FOREIGN KEY (NguoiThan)
REFERENCES BenhNhan(TenDangNhap)

go
insert into BenhNhan 
values('bn1', 'bn1', N'Bùi Trung Hải', '1995-01-01', N'Nam', 'btHai@gmail.com', '0123456789',N'123', 0), 
		('bn2', 'bn2', N'Nguyễn Nhật Tài', '1995-03-01', N'Nam', 'nnTai@gmail.com', '0123456789',N'123', 0),  
		('bn3', 'bn3', N'Nguyễn Phan Mạnh Hùng', '1995-05-01', N'Nam', 'npmHung@gmail.com', '0123456789',N'123', 0), 
		('bn4', 'bn4', N'Lê Huy Sinh', '1995-07-01', N'Nam', 'lhSinh@gmail.com', '0123456789',N'123', 0)

go 
insert into NguoiThan
values('bn1', 'bn2', 'Than'),
		('bn1', 'bn3', 'Than'),
		('bn1', 'bn4', 'Than'),
		('bn2', 'bn1', 'Than'),
		('bn3', 'bn4', 'Than'),
		('bn4', 'bn1', 'Than')

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
insert into BacSi 
values(N'Bùi Trung Hải', '1995-01-01', N'Nam', 'btHai@gmail.com', '0123456789',N'123', N'Rang Ham Mat', N'Tien sĩ'), 
		(N'Nguyễn Nhật Tài', '1995-03-01', N'Nam', 'nnTai@gmail.com', '0123456789',N'123', N'Da liễu', N'Thạc Sĩ'),  
		(N'Nguyễn Phan Mạnh Hùng', '1995-05-01', N'Nam', 'npmHung@gmail.com', '0123456789',N'123', N'Nội khoa', N'Thạc sĩ'), 
		(N'Lê Huy Sinh', '1995-07-01', N'Nam', 'lhSinh@gmail.com', '0123456789',N'123', N'Tim mạch', N'Tiến sĩ')

go 
insert into DuLieuKham
values(80, 2, 170, 60, '2015-12-20', null),
		(90, 2, 170, 60, '2015-12-20', null),
		(75, 2, 170, 60, '2015-12-20', null),
		(79, 2, 170, 60, '2015-12-20', null),
		(85, 2, 170, 60, '2015-12-20', null),
		(100, 2, 170, 60, '2015-12-20', null),
		(70, 2, 170, 60, '2015-12-20', null),
		(80, 2, 170, 60, '2015-12-20', null),
		(85, 2, 170, 60, '2015-12-20', null),
		(89, 2, 170, 60, '2015-12-20', null),
		(95, 2, 170, 60, '2015-12-20', null),
		(87, 2, 170, 60, '2015-12-20', null),
		(88, 2, 170, 60, '2015-12-20', null),
		(67, 2, 170, 60, '2015-12-20', null),
		(76, 2, 170, 60, '2015-12-20', null),
		(89, 2, 170, 60, '2015-12-20', null),
		(98, 2, 170, 60, '2015-12-20', null)

go
insert into ChiTietKham
values ('bn1', 1),
		('bn1', 2),
		('bn1', 3),
		('bn1', 4),
		('bn1', 5),
		('bn1', 6),
		('bn1', 7),
		('bn1', 8),
		('bn1', 9),
		('bn1', 10),
		('bn1', 11),
		('bn1', 12),
		('bn1', 13),
		('bn1', 14),
		('bn1', 15),
		('bn1', 16),
		('bn1', 17)

go
insert into BaiDang
values (N'CÁC BỆNH THƯỜNG GẶP TRONG MÙA MƯA VÀ CÁCH PHÒNG TRÁNH HIỆU QUẢ', N'Mùa mưa có thể mang lại niềm vui và hứng thú cho nhiều bạn bởi tiết trời mát mẻ và thoáng đãng. Nhưng cũng mang đến nhiều nguy cơ rối loạn sức khỏe. Hạn chế rủi ro mắc phải những căn bệnh thông thường trong mùa mưa hoàn toàn không khó. Bệnh thường thấy nhất là liên quan đến hệ hô hấp và tiêu hóa. Nên cẩn trọng với triệu chứng của những căn bệnh này để có thể phòng tránh và chữa trị kịp thời.
Cảm và cúm là hai bệnh mà rất nhiều người mắc phải khi mùa mưa đến. Nguyên nhân là do sự thay đổi nhiệt độ và độ ẩm. Bạn không nên dầm mưa và không được để cơ thể bị ướt quá lâu trong nước mưa. 
Một số bệnh khác cũng cần phải lưu ý: sốt phát ban, nhiễm trùng máu, nhiễm trùng nước, bệnh tả, bệnh trùng xoắn móc câu (khuẩn xoắn móc câu kí sinh có thể gây nguy hại cho thận, gan, gây viêm màng não và hô hấp cấp)…'),
		(N'Bệnh về tim mạch', N' Trong số các bệnh về tim mạch ở NCT thì bệnh xơ vữa động mạch, thiểu năng mạch vành, tăng huyết áp chiếm một vị trí đáng kể. Trong một số trường hợp, các loại bệnh này thường thấy ở những người nghiện bia, rượu chiếm tỷ lệ cao hơn những người không nghiện bia, rượu'),
		(N'Bệnh về hệ hô hấp', N'Bệnh viêm họng, viêm phế quản mạn tính, giãn phế quản, âm phế mạn tính, hen phế quản, bệnh phổi tắc nghẽn mạn tính là những bệnh gặp khá nhiều ở NCT, nhất là ở những người có tiền sử hoặc đang hút thuốc lá, thuốc lào. Đặc điểm bệnh về đường hô hấp lại thường hay xảy ra vào mùa lạnh, thay đổi thời tiết, lúc giữa đêm gần sáng do đó rất dễ làm cho NCT mất ngủ kéo dài'),
		(N'Bệnh về đường tiêu hóa', N'người cao tuổi rất dễ mắc bệnh rối loạn tiêu hóa như viêm loét miệng, ăn không tiêu, đầy hơi, trướng bụng, táo bón hoặc đi lỏng. NCT cũng có thể mắc bệnh viêm loét dạ dày - tá tràng, trào ngược thực quản hoặc viêm đại tràng mạn tính. Các loại bệnh dạng này thường làm cho người cao tuổi rất khó chịu, gây lo lắng, ăn không ngon, ngủ không ngon giấc hoặc kém ngủ, mất ngủ kéo dài. Mất ngủ lại làm cho nhiều bệnh tật phát sinh.'),
		(N'Bệnh về hệ tiết niệu - sinh dục', N'NCT cũng rất dễ mắc các bệnh về hệ tiết niệu - sinh dục, đặc biệt là u xơ tiền liệt tuyến hoặc ung thư tiền liệt tuyến. Những bệnh về sinh dục - tiết niệu thường có hiện tượng đi tiểu nhiều lần, đái dắt, đái són nhất là vào ban đêm, gây nhiều phiền toái cho NCT.')
go
create procedure sp_form_ThemBenhNhan @tenDN char(30), @mk char(30), @ten nchar(50), @ns datetime, @gt nchar(3), @email char(30), @dt char(11), @diaChi nchar(50) 
as
	insert into BenhNhan
	values (@tenDN, @mk, @ten, @ns, @gt, @email, @dt, @diaChi, null)

go
create procedure sp_form_TimNguoiThan @name nchar(50), @tenDN char(30)
as
	Select BN.TenBenhNhan
	From BenhNhan BN
	Where BN.TenBenhNhan like '%'+@name+'%' and BN.TenDangNhap != @tenDN and BN.TenDangNhap not in (Select NT.NguoiThan
																From NguoiThan NT
																Where NT.BenhNhan = BN.TenDangNhap)

go
create procedure sp_form_ThemNguoiThan @benhNhan char(30), @nguoiThan char(30)
as
	insert into NguoiThan
	values (@benhNhan, @nguoiThan, 'Than')




