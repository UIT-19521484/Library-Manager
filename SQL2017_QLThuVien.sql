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
	NhaXuatBan NVARCHAR(200) NOT NULL,		--- TÊN NHÀ XUẤT BẢN
	TonTai INT DEFAULT 0,								--- SỐ LƯỢNG CÒN TRONG KHO
	DaMuon INT DEFAULT 0,								--- SỐ LƯỢNG CHO MƯỢN HIỆN TẠI
	MaTL INT,								--- SÁCH SẼ CÓ THỂ LOẠI RIÊNG (KHÓA NGOẠI)
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

