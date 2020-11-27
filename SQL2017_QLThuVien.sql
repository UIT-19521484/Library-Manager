CREATE DATABASE QLThuVien
GO

USE QLThuVien
GO

SET DATEFORMAT DMY
GO

------ TẠO BẢNG QUẢN LÝ TÀI KHOẢN
CREATE TABLE TAIKHOAN
(
	TenTaiKhoan VARCHAR(100) NOT NULL,		--- TÊN TÀI KHOẢN (KHÓA CHÍNH)   
	MatKhau		VARCHAR(50) NOT NULL,		--- MẬT KHẨU 
	PhanQuyen	NVARCHAR(20) NOT NULL DEFAULT 'Member',		--- ADMIN hoặc MEMBER
)
GO

ALTER TABLE TAIKHOAN ADD constraint PK_TAIKHOAN PRIMARY KEY (TenTaiKhoan)
GO

------ TẠO BẢNG NHÂN VIÊN (CÓ THỂ CÓ HOẶC KHÔNG CÓ TÀI KHOẢN)
CREATE TABLE NHANVIEN
(
	MaNV		INT IDENTITY(1,1) NOT NULL,	--- MÃ NHÂN VIÊN (KHÓA CHÍNH)
	HoTen		NVARCHAR(100) NOT NULL,		--- HỌ TÊN
	CMND		NVARCHAR(100) NOT NULL,		--- CHỨNG MINH NHÂN DÂN - CĂN CƯỚC CÔNG DÂN
	GioiTinh	NVARCHAR(5) NOT NULL,		--- GIỚI TÍNH
	NgaySinh	DATE,						--- NGÀY SINH
	DiaChi		NVARCHAR(200),				--- ĐỊA CHỈ
	SDT			VARCHAR(20),				--- SỐ ĐIỆN THOẠI
	TenTaiKhoan	VARCHAR(100)				--- TÊN TÀI KHOẢN MÀ NHÂN VIÊN ĐƯỢC CẤP (KHÓA NGOẠI)
)
GO

ALTER TABLE NHANVIEN ADD constraint PK_NHANVIEN PRIMARY KEY (MaNV)
GO

------ TẠO BẢNG THỂ LOẠI
CREATE TABLE THELOAI
(
	MaTL INT IDENTITY(1,1) NOT NULL,		--- MÃ THỂ LOẠI (KHÓA CHÍNH)
	TenTL NVARCHAR(100)						--- TÊN THỂ LOẠI 
)
GO

ALTER TABLE THELOAI ADD constraint PK_THELOAI PRIMARY KEY (MaTL)

------ TẠO BẢNG SÁCH
CREATE TABLE SACH
(
	MaSach INT IDENTITY(1,1) NOT NULL,		--- MÃ SÁCH (KHÓA CHÍNH)
	TenSach NVARCHAR(100) NOT NULL,			--- TÊN SÁCH
	TacGia NVARCHAR(100) NOT NULL,			--- TÊN TÁC GIẢ
	MaTL INT,								--- SÁCH SẼ CÓ THỂ LOẠI RIÊNG (KHÓA NGOẠI)
	NhaXuatBan NVARCHAR(200) NOT NULL,		--- TÊN NHÀ XUẤT BẢN
	TonTai INT DEFAULT 0,					--- SỐ LƯỢNG CÒN TRONG KHO
	DaMuon INT DEFAULT 0,					--- SỐ LƯỢNG CHO MƯỢN HIỆN TẠI
)
GO

ALTER TABLE SACH ADD constraint PK_SACH PRIMARY KEY (MaSach)
GO

------ TẠO BẢNG ĐỘC GIẢ
CREATE TABLE DOCGIA
(
	MaDG INT IDENTITY(1,1) NOT NULL,
	HoTen NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	NgaySinh DATE,
	DiaChi NVARCHAR(200),
	SDT VARCHAR(20),
	Email VARCHAR(100)
)
GO

ALTER TABLE DOCGIA ADD constraint PK_DOCGIA PRIMARY KEY (MaDG)
GO

------ TẠO BẢNG HÓA ĐƠN MƯỢN SÁCH
CREATE TABLE HOADON
(
	MaHD INT IDENTITY(1,1) NOT NULL,						--- MÃ HÓA ĐƠN (TẠO MÃ HÓA ĐƠN NHƯ SAU 'HD + MaHD + MaDG') (KHÓA CHÍNH)
	MaDG INT NOT NULL,										--- Bắt buộc phải tạo độc giả trước (KHÓA NGOẠI)
	NgayMuon DATE DEFAULT GETDATE(),						--- Ngày mượn sách
	NgayTra DATE DEFAULT GETDATE(),							--- Ngày trả sách phải lớn hơn ngày mượn
 	TinhTrang NVARCHAR(50) NOT NULL DEFAULT 'Cho Mượn',		--- 'Cho Mượn' hoặc 'Thu hồi'
	TongSL INT DEFAULT 0,									--- Tổng số lượng sách mượn
	ChiPhi INT DEFAULT 0 									--- Chi phí sau khi 'Thu hồi' nếu getdate() > ngày trả thì tính phí
)
GO

ALTER TABLE HOADON ADD constraint PK_HOADON PRIMARY KEY (MaHD)
GO

------ TẠO BẢNG CHI TIẾT HÓA ĐƠN
CREATE TABLE CTHD
(
	MaHD INT NOT NULL,				--- MÃ HÓA ĐƠN (KHÓA CHÍNH) (KHÓA NGOẠI)
	MaSach INT NOT NULL,			--- MÃ SÁCH	(KHÓA CHÍNH) (KHÓA NGOẠI)
	SL INT DEFAULT 0				--- SỐ LƯỢNG MỖI LOẠI SÁCH
)
GO

ALTER TABLE CTHD ADD constraint PK_CTHD PRIMARY KEY (MaHD, MaSach)
GO

--Nhập dữ liệu mẫu: Sách
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (10, N'Hướng dẫn nấu các món ăn Đông Á', N'Trần Hoàng Lân', N'NXB Nấu Ăn Không Ngon', 481, 19)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (10, N'Hướng dẫn nấu các món ăn Tây', N'Trần Hoàng Lân', N'NXB Nấu Ăn Không Ngon', 392, 8)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (1, N'Kỹ năng sinh tồn - Phần 1', N'Zoro', N'One Piece', 293, 5)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (1, N'Kỹ năng sinh tồn - Phần 3', N'Robin', N'One Piece', 192, 6)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (1, N'Kỹ năng sinh tồn - Phần 2', N'Robin', N'One Piece', 94, 5)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Nhà Giả Kim ', N'Paulo Coelho', N'', 200, 30)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Chuyện Con Mèo Dạy Hải Âu Bay (Tái Bản 2014)', N'Luis Sepulveda', N'', 200, 21)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Cho Tôi Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', N'', 200, 18)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Bàn Có Năm Chỗ Ngồi', N'Nguyễn Nhật Ánh', N'', 200, 18)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Bồ Câu Không Đưa Thư', N'Nguyễn Nhật Ánh', N'', 200, 2)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Đời Cơ Bản Là Buồn Cười', N'Lê Bích', N'', 200, 3)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Bong Bóng Lên Trời', N'Nguyễn Nhật Ánh', N'', 200, 4)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Khi Lỗi Thuộc Về Những Vì Sao', N'John Green', N'', 200, 0)
insert Sach (MaTL, TenSach, TacGia, NhaXuatBan, TonTai, DaMuon) values (3, N'Bức Xúc Không Làm Ta Vô Can', N'Đặng Hoàng Giang', N'', 200, 0)

select * from SACH

--Thêm dữ liệu mẫu: Thể loại
insert THELOAI (TenTL) values (N'Sách kỹ năng sống')
insert THELOAI (TenTL) values (N'Sách truyện ngắn - Bút ký')
insert THELOAI (TenTL) values (N'Văn học')
insert THELOAI (TenTL) values (N'Sách văn hóa - xã hội')
insert THELOAI (TenTL) values (N'Sách thiếu nhi')
insert THELOAI (TenTL) values (N'Sách truyện tranh')
insert THELOAI (TenTL) values (N'Sách lịch sử Việt Nam')
insert THELOAI (TenTL) values (N'Sách trinh thám')
insert THELOAI (TenTL) values (N'Sách du lịch')
insert THELOAI (TenTL) values (N'Sách nấu ăn')
insert THELOAI (TenTL) values (N'Sách kỹ thuật công nghệ')
insert THELOAI (TenTL) values (N'Sách tin học')

select * from THELOAI

--Thêm dữ liệu mẫu: Đọc giả
insert DocGia (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email) values (N'Hoàng Lê Trung Hậu', N'Nam', CAST('01-01-2001' AS date), N'Bình Phước', N'0123548521', N'haucanloi@gmail.com')
insert DocGia (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email) values (N'Văn Quốc Huy', N'Nam', CAST('09-05-2001' AS date), N'Gia Lai', N'0166555555', N'behuy@yahoo.com')
insert DocGia (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email) values (N'Nguyễn Trọng Phúc', N'Nam', CAST('01-02-2001' AS date), N'TP Hồ Chí Minh', N'0120000000', N'thietkedao@gmail.com')

select * from DOCGIA

--Thêm dữ liệu mẫu: Nhân viên
insert NHANVIEN (HoTen, CMND, GioiTinh, NgaySinh, DiaChi, SDT, TenTaiKhoan) values (N'Nguyễn Văn Dũng', N'248455546', N'Nam', CAST('06-03-1999' AS date), N'Hà Nội', N'012106172360', N'dungnv')
insert NHANVIEN (HoTen, CMND, GioiTinh, NgaySinh, DiaChi, SDT, TenTaiKhoan) values (N'Nguyễn Hồng Phương', N'248455246', N'Nữ', CAST('21-10-1995' AS date), N'Quảng Ngãi', N'01206172360', N'phuongnh')
insert NHANVIEN (HoTen, CMND, GioiTinh, NgaySinh, DiaChi, SDT, TenTaiKhoan) values (N'Nguyễn Vân', N'248458746', N'Nữ', CAST('31-01-1995' AS date), N'Hà Nội', N'01206172360', N'vann')
insert NHANVIEN (HoTen, CMND, GioiTinh, NgaySinh, DiaChi, SDT, TenTaiKhoan) values (N'Trần Phúc Thuận', N'248455446', N'Nam', CAST('14-06-1997' AS date), N'Đồng Nai', N'0123456789', N'thuantp')
insert NHANVIEN (HoTen, CMND, GioiTinh, NgaySinh, DiaChi, SDT, TenTaiKhoan) values (N'Thới Lục', N'248451346', N'Nữ', CAST('20-03-2000' AS date), N'TP HCM', N'01206172323', N'luct')

select * from NHANVIEN

--Thêm dữ liệu mẫu: 
INSERT TAIKHOAN (TenTaiKhoan, MatKhau, PhanQuyen) VALUES (N'admin', N'1', 0)

select * from TAIKHOAN