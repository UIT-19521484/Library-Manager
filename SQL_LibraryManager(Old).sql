create database QuanLyThuVien
go

use QuanLyThuVien
go

set dateformat DMY
go

---table User
create table Users
(
	Username varchar(50) not null,
	Password varchar(50) not null,
	PhanQuyen int not null,
	constraint PK_ID primary key (Username)
)
go

---table NhanVien
create table NhanVien
(
	MANV char(10) not null,
	HoTen nvarchar(50) not null,
	GioiTinh nvarchar(3) null,
	NgaySinh date null,
	DiaChi nvarchar(150) null,
	DienThoai char(12) null,
	constraint PK_MANV primary key (MANV)
)
go

---table TheLoaiSach
create table TheLoaiSach
(
	MaTL char(10) not null,
	TenTheLoai nvarchar(50) not null,
	constraint PK_MaTL primary key (MaTL)
)
go

----table Sach
create table Sach
(
	MaSach char(12) not null,
	MaTL char(10) not null,
	TenSach nvarchar(50) not null,
	TacGia nvarchar(30) null,
	NhaXuatBan nvarchar(50) null,
	TonTai int null,
	SoLanMuon int null,
	constraint PK_MaSach primary key (MaSach)
)
go

----table DocGia
create table DocGia
(
	MaDG char(12) not null,
	HoTen nvarchar(30) not null,
	GioiTinh nvarchar(3) null,
	NgaySinh date null,
	DiaChi nvarchar(150) not null,
	DienThoai char(12) null,
	Email varchar(50) null,
	constraint PK_MaDG primary key (MaDG)
)
go


insert DocGia (MaDG, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email) values (N'DG001', N'Hoàng Lê Trung Hậu', N'Nam', CAST('01-01-2001' AS date), N'Bình Phước', N'0123548521  ', N'haucanloi@gmail.com')
insert DocGia (MaDG, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email) values (N'DG002', N'Văn Quốc Huy', N'Nam', CAST('09-05-2001' AS date), N'Gia Lai', N'0166555555  ', N'behuy@yahoo.com')
insert DocGia (MaDG, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email) values (N'DG003', N'Nguyễn Trọng Phúc', N'Nam', CAST('01-02-2001' AS date), N'TP Hồ Chí Minh', N'0120000000  ', N'thietkedao@gmail.com')

insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS001', N'L010', N'Hướng dẫn nấu các món ăn Đông Á', N'Trần Hoàng Lân', N'NXB Nấu Ăn Không Ngon', 481, 19)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS002', N'L010', N'Hướng dẫn nấu các món ăn Tây', N'Trần Hoàng Lân', N'NXB Nấu Ăn Không Ngon', 392, 8)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS004', N'L001', N'Kỹ năng sinh tồn - Phần 1', N'Zoro', N'One Piece', 293, 5)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS005', N'L001', N'Kỹ năng sinh tồn - Phần 3', N'Robin', N'One Piece', 192, 6)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS006', N'L001', N'Kỹ năng sinh tồn - Phần 2', N'Robin', N'One Piece', 94, 5)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS007', N'L003', N'Nhà Giả Kim ', N'Paulo Coelho', N'', 200, 30)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS008', N'L003', N'Chuyện Con Mèo Dạy Hải Âu Bay (Tái Bản 2014)', N'Luis Sepulveda', N'', 200, 21)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS009', N'L003', N'Cho Tôi Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', N'', 200, 18)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS010', N'L003', N'Bàn Có Năm Chỗ Ngồi', N'Nguyễn Nhật Ánh', N'', 200, 18)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS011', N'L003', N'Bồ Câu Không Đưa Thư', N'Nguyễn Nhật Ánh', N'', 200, 2)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS012', N'L003', N'Đời Cơ Bản Là Buồn Cười', N'Lê Bích', N'', 200, 3)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS013', N'L003', N'Bong Bóng Lên Trời', N'Nguyễn Nhật Ánh', N'', 200, 4)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS014', N'L003', N'Khi Lỗi Thuộc Về Những Vì Sao', N'John Green', N'', 200, 0)
insert Sach (MaSach, MaTL, TenSach, TacGia, NhaXuatBan, TonTai, SoLanMuon) values (N'MS015', N'L003', N'Bức Xúc Không Làm Ta Vô Can', N'Đặng Hoàng Giang', N'', 200, 0)

insert TheLoaiSach (MaTL, TenTheLoai) values (N'L001', N'Sách kỹ năng sống')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L002', N'Sách truyện ngắn - Bút ký')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L003', N'Văn học')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L004', N'Sách văn hóa - xã hội')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L005', N'Sách thiếu nhi')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L006', N'Sách truyện tranh')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L007', N'Sách lịch sử Việt Nam')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L008', N'Sách trinh thám')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L009', N'Sách du lịch')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L010', N'Sách nấu ăn')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L011', N'Sách kỹ thuật công nghệ')
insert TheLoaiSach (MaTL, TenTheLoai) values (N'L012', N'Sách tin học')

insert NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai) values (N'NV001', N'Nguyễn Văn Dũng', N'Nam', CAST('06-03-1999' AS date), N'Hà Nội', N'012106172360')
insert NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai) values (N'NV002', N'Nguyễn Hồng Phương', N'Nữ', CAST('21-10-1995' AS date), N'Quảng Ngãi', N'01206172360 ')
insert NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai) values (N'NV004', N'Nguyễn Vân', N'Nữ', CAST('31-01-1995' AS date), N'Hà Nội', N'01206172360 ')
insert NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai) values (N'NV006', N'Trần Phúc Thuận', N'Nam', CAST('14-06-1997' AS date), N'Đồng Nai', N'0123456789  ')
insert NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai) values (N'NV007', N'Thới Lục', N'Nữ', CAST('20-03-2000' AS date), N'TP HCM', N'01206172323 ')

INSERT Users (Username, Password, PhanQuyen) VALUES (N'admin', N'1', 0)
INSERT Users (Username, Password, PhanQuyen) VALUES (N'dung', N'dung', 3)

alter database QuanLyThuVien set read_write
go

