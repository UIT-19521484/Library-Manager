CREATE DATABASE QLThuVien
GO

USE QLThuVien
GO

SET DATEFORMAT DMY
GO

------ TẠO BẢNG QUẢN LÝ TÀI KHOẢN
CREATE TABLE TAIKHOAN
(
	TenTaiKhoan VARCHAR(100) NOT NULL,						--- TÊN TÀI KHOẢN (KHÓA CHÍNH)   
	MatKhau		VARCHAR(50) NOT NULL,						--- MẬT KHẨU 
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
	NhaXuatBan NVARCHAR(200),				--- TÊN NHÀ XUẤT BẢN
	TonTai INT DEFAULT 0,					--- SỐ LƯỢNG CÒN TRONG KHO
	DaMuon INT DEFAULT 0,					--- SỐ LƯỢNG CHO MƯỢN HIỆN TẠI
	MaTL INT,								--- SÁCH SẼ CÓ THỂ LOẠI RIÊNG (KHÓA NGOẠI)
)
GO

ALTER TABLE SACH ADD constraint PK_SACH PRIMARY KEY (MaSach)
GO

------ TẠO BẢNG ĐỘC GIẢ
CREATE TABLE DOCGIA
(
	MaDG INT IDENTITY(1,1) NOT NULL,		--- MÃ ĐỘC GIẢ
	HoTen NVARCHAR(100) NOT NULL,			--- HỌ TÊN
	GioiTinh NVARCHAR(10) NOT NULL,			--- GIỚI TÍNH
	NgaySinh DATE,							--- NGÀY SINH
	DiaChi NVARCHAR(200),					--- ĐỊA CHỈ
	SDT VARCHAR(20),						--- SĐT (phải có số 0)
	Email VARCHAR(100)						--- Email (phải có @ ở vị trí thứ 2 và dấu chấm)
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

------ THỰC HIỆN CÁC RÀNG BUỘC
ALTER TABLE NHANVIEN WITH CHECK
ADD constraint FK_NHANVIEN_TAIKHOAN FOREIGN KEY (TenTaiKhoan) REFERENCES TAIKHOAN(TenTaiKhoan)
GO

ALTER TABLE SACH WITH CHECK
ADD constraint FK_SACH_THELOAI FOREIGN KEY (MaTL) REFERENCES THELOAI(MaTL)
GO

ALTER TABLE HOADON WITH CHECK
ADD constraint FK_HOADON_DOCGIA FOREIGN KEY (MaDG) REFERENCES DOCGIA(MaDG)
GO

ALTER TABLE CTHD WITH CHECK
ADD constraint FK_CTHD_HOADON FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD)
GO

ALTER TABLE CTHD WITH CHECK
ADD constraint FK_CTHD_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
GO


INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Hướng dẫn nấu các món ăn Đông Á', N'Trần Hoàng Lân', N'KiMoChi', 481, 19)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Hướng dẫn nấu các món ăn Đông Á', N'Trần Hoàng Lân', N'KiMoChi', 481, 19)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Hướng dẫn nấu các món ăn Tây', N'Trần Hoàng Lân', N'KiMoChi', 392, 8)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Kỹ năng sinh tồn - Phần 1', N'Zoro', N'One Piece', 293, 5)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Kỹ năng sinh tồn - Phần 3', N'Robin', N'One Piece', 192, 6)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Kỹ năng sinh tồn - Phần 2', N'Robin', N'One Piece', 94, 5)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Nhà Giả Kim ', N'Paulo Coelho', N'', 200, 30)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Chuyện Con Mèo Dạy Hải Âu Bay (Tái Bản 2014)', N'Luis Sepulveda', N'', 200, 21)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Cho Tôi Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', N'', 200, 18)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Bàn Có Năm Chỗ Ngồi', N'Nguyễn Nhật Ánh', N'', 200, 18)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Bồ Câu Không Đưa Thư', N'Nguyễn Nhật Ánh', N'', 200, 2)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Đời Cơ Bản Là Buồn Cười', N'Lê Bích', N'', 200, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Bong Bóng Lên Trời', N'Nguyễn Nhật Ánh', N'', 200, 4)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Khi Lỗi Thuộc Về Những Vì Sao', N'John Green', N'', 200, 0)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon]) VALUES (N'Bức Xúc Không Làm Ta Vô Can', N'Đặng Hoàng Giang', N'', 200, 0)

INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách kỹ năng sống')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách truyện ngắn - Bút ký')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Văn học')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách văn hóa - xã hội')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách thiếu nhi')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách truyện tranh')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách lịch sử Việt Nam')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách Hentai')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách du lịch')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách nấu ăn')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách kỹ thuật công nghệ')
INSERT [dbo].[THELOAI] ([TenTL]) VALUES (N'Sách tin học')

INSERT [dbo].[NHANVIEN] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Nguyễn Văn Dũng', N'Nam', CAST(0x0000881000000000 AS DateTime), N'Hà Nội', N'012106172360')
INSERT [dbo].[NHANVIEN] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Nguyễn Hồng Phương', N'Nữ', CAST(0x0000884600000000 AS DateTime), N'Quảng Ngãi', N'01206172360 ')
INSERT [dbo].[NHANVIEN] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Nguyễn Vân', N'Nữ', CAST(0x00008C6300000000 AS DateTime), N'Hà Nội', N'01206172360 ')
INSERT [dbo].[NHANVIEN] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Trần Phúc Thuận', N'Nam', CAST(0x000088CD00000000 AS DateTime), N'Đồng Nai', N'0123456789  ')
INSERT [dbo].[NHANVIEN] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Thới Lục', N'Nam', CAST(0x0000874100000000 AS DateTime), N'TP HCM', N'01206172323 ')





CREATE PROC SelectBook
AS
BEGIN
	SELECT SACH.TenSach AS [TÊN SÁCH], SACH.TacGia AS [TÁC GIẢ], THELOAI.TenTL AS [THỂ LOẠI], SACH.NhaXuatBan AS [NHÀ XUẤT BẢN], SACH.TonTai AS [CÓ SẴN], SACH.DaMuon AS [ĐÃ MƯỢN] 
	FROM SACH, THELOAI
	WHERE SACH.MaTL = THELOAI.MaTL 
END

EXEC SelectBook 



ALTER DATABASE QLThuVien SET  READ_WRITE 
GO