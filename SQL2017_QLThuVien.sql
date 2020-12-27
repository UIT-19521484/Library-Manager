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
	PhanQuyen	NVARCHAR(20) NOT NULL DEFAULT 'Member',		--- Admin hoặc Member
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
	TenTL NVARCHAR(100)	UNIQUE NOT NULL					--- TÊN THỂ LOẠI 
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
 	TinhTrang NVARCHAR(50) DEFAULT 'Cho Mượn',		--- 'Cho Mượn' hoặc 'Thu hồi'
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

INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Hướng dẫn nấu các món ăn Đông Á', N'Trần Hoàng Lân', N'KiMoChi', 481, 19, 10)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Hướng dẫn nấu các món ăn Tây', N'Trần Hoàng Lân', N'KiMoChi', 392, 10, 10)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Kỹ năng sinh tồn - Phần 1', N'Zoro', N'One Piece', 293, 5, 1)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Kỹ năng sinh tồn - Phần 3', N'Robin', N'One Piece', 192, 6, 1)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Kỹ năng sinh tồn - Phần 2', N'Robin', N'One Piece', 94, 5, 1)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Nhà Giả Kim ', N'Paulo Coelho', N'', 200, 30, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Chuyện Con Mèo Dạy Hải Âu Bay (Tái Bản 2014)', N'Luis Sepulveda', N'', 200, 21, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Cho Tôi Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', N'', 200, 18, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Bàn Có Năm Chỗ Ngồi', N'Nguyễn Nhật Ánh', N'', 200, 18, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Bồ Câu Không Đưa Thư', N'Nguyễn Nhật Ánh', N'', 200, 2, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Đời Cơ Bản Là Buồn Cười', N'Lê Bích', N'', 200, 3, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Bong Bóng Lên Trời', N'Nguyễn Nhật Ánh', N'', 200, 4, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Khi Lỗi Thuộc Về Những Vì Sao', N'John Green', N'', 200, 0, 3)
INSERT INTO [dbo].[SACH] ([TenSach],[TacGia],[NhaXuatBan],[TonTai],[DaMuon], [MaTL]) VALUES (N'Bức Xúc Không Làm Ta Vô Can', N'Đặng Hoàng Giang', N'', 200, 0, 3)

Select SACH.TenSach, SACH.TacGia, SACH.NhaXuatBan, THELOAI.TenTL 
from SACH left join THELOAI on SACH.MaTL = THELOAI.MaTL 
where SACH.TenSach = N'Bức Xúc Không Làm Ta Vô Can' and SACH.TacGia = N'Đặng Hoàng Giang' and SACH.NhaXuatBan = N'' and THELOAI.TenTL = N'Văn học'

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

INSERT [dbo].[DOCGIA] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email]) VALUES (N'Châu Tinh Trì', N'Nam', CAST(0x0000A61200000000 AS DateTime), N'Quảng Châu - Trung Quốc', N'0123548521  ', N'chautinhtinh@gmail.com')
INSERT [dbo].[DOCGIA] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email]) VALUES (N'Nguyễn Thị Bé', N'Nữ', CAST(0x000088E300000000 AS DateTime), N'Đà Nẵng', N'0166555555  ', N'bexinhxinh@yahoo.com')
INSERT [dbo].[DOCGIA] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email]) VALUES (N'Trần Hạo Nam', N'Nam', CAST(0x0000806800000000 AS DateTime), N'Hải Phòng', N'0120000000  ', N'nguoitronggiangho@gmail.com')

INSERT INTO [dbo].[TAIKHOAN] ([TenTaiKhoan], [MatKhau]) VALUES ('a', '1')
INSERT INTO [dbo].[TAIKHOAN] ([TenTaiKhoan], [MatKhau]) VALUES ('b', '1')

go

select *
from SACH
where MaSach = 1

CREATE QUEUE SQLDependencyQueue;
CREATE SERVICE SQLDependencyService ON QUEUE SQLDependencyQueue

--DROP SERVICE SQLDependencyService;
--DROP QUEUE SQLDependencyQueue;

/*CREATE QUEUE ContactChangeMessages;   
  
CREATE SERVICE ContactChangeNotifications  
  ON QUEUE ContactChangeMessages  
([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]); */

------ FORM MAIN
------------- SP_COUNT ----------

--- 1. ---Count tất cả Sách (tồn kho)
CREATE PROC sp_count_all_available_books
AS
BEGIN
	SELECT SUM(TonTai) FROM SACH
END
GO

--- 2. ---Count tất cả Sách (đã mượn)
CREATE PROC sp_count_all_borrowed_books
AS
BEGIN
	SELECT SUM(DaMuon) FROM SACH
END
GO


--- 3. ---Count tất cả Sách (đã mượn)
CREATE PROC sp_count_all_books
AS
BEGIN
	SELECT SUM(DaMuon) + SUM(TonTai) FROM SACH
END
GO


--- 4. ---Count tất cả Độc giả
CREATE PROC sp_count_all_readers
AS
BEGIN
	SELECT COUNT(*) FROM DOCGIA
END
GO

--- 5. ---Count độc giả đang mượn sách
CREATE PROC sp_count_borrowing_readers
AS
BEGIN
	SELECT COUNT(DISTINCT DG.MaDG) FROM DOCGIA DG, HOADON HD
	WHERE DG.MaDG = HD.MaDG AND HD.TinhTrang = 'Cho mượn'
END
GO


--- 6. ---Count độc giả đã mượn sách quá hạn
CREATE PROC sp_count_overdue_readers
AS
BEGIN
	SELECT COUNT(DISTINCT DG.MaDG) FROM DOCGIA DG, HOADON HD
	WHERE DG.MaDG = HD.MaDG AND GETDATE() > HD.NgayTra
END
GO


--- 7. ---Count tất cả Thể loại
CREATE PROC sp_count_all_genres
AS
BEGIN
	SELECT COUNT(*) FROM THELOAI
END
GO




----------- SP_SELECT --------------

--- 8. ---Select tất cả Sách
CREATE PROC sp_select_all_books
AS
BEGIN
	SELECT SACH.MaSach, SACH.TenSach AS [TÊN SÁCH], SACH.TacGia AS [TÁC GIẢ], THELOAI.TenTL AS [THỂ LOẠI], SACH.NhaXuatBan AS [NHÀ XUẤT BẢN], SACH.TonTai AS [CÓ SẴN], SACH.DaMuon AS [ĐÃ MƯỢN] 
	FROM SACH LEFT JOIN THELOAI ON SACH.MaTL = THELOAI.MaTL 
END
GO

--drop proc sp_select_all_books

--EXEC sp_select_all_books

--- 9. ---Select tất cả Thể loại
CREATE PROC sp_select_all_genres
AS
BEGIN
	SELECT MaTL, TenTL AS [TÊN THỂ LOẠI] FROM THELOAI
END
GO

drop proc sp_select_all_genres

--EXEC sp_select_all_genres

--- 10. ---Select tất cả Độc giả
CREATE PROC sp_select_all_readers
AS
BEGIN
	SELECT MaDG, HoTen AS [HỌ TÊN], GioiTinh AS [GIỚI TÍNH], NgaySinh AS [NGÀY SINH], DiaChi AS [ĐỊA CHỈ], SDT AS [SĐT], Email AS [EMAIL] 
	FROM DOCGIA
END
GO

--drop proc sp_select_all_readers

--- 11.---Select tất cả Nhân viên
CREATE PROC sp_select_all_staff
AS
BEGIN
	SELECT MaNV, HoTen AS [HỌ TÊN], GioiTinh AS [GIỚI TÍNH], NgaySinh AS [NGÀY SINH], DiaChi AS [ĐỊA CHỈ], SDT AS [SĐT], NHANVIEN.TenTaiKhoan AS [TÀI KHOẢN], TAIKHOAN.PhanQuyen AS [PHÂN QUYỀN] 
	FROM NHANVIEN left join TAIKHOAN on NHANVIEN.TenTaiKhoan = TAIKHOAN.TenTaiKhoan
END
GO

--drop proc sp_select_all_staff

--- 12.---Select tất cả Tên tài khoản + Phân quyền
CREATE PROC sp_select_all_accounts
AS
BEGIN
	SELECT HoTen as [HỌ TÊN], TAIKHOAN.TenTaiKhoan AS [TÊN TÀI KHOẢN], PhanQuyen AS [PHÂN QUYỀN] FROM TAIKHOAN left join NHANVIEN on TAIKHOAN.TenTaiKhoan = NHANVIEN.TenTaiKhoan
END
GO

--drop proc sp_select_all_accounts

--- 13.---Select Tên tài khoản
CREATE PROC sp_select_all_account_name
AS
BEGIN
	SELECT TenTaiKhoan AS [TÊN TÀI KHOẢN] FROM TAIKHOAN
END
GO


--- 14. --- Select Tài khoản, mật khẩu, phân quyền để LOGIN
CREATE PROC sp_select_login_account
@TenTaiKhoan VARCHAR(100), @MatKhau VARCHAR(50)
AS
BEGIN
	SELECT TenTaiKhoan AS [TÊN TÀI KHOẢN], MatKhau AS [MẬT KHẨU], PhanQuyen AS [PHÂN QUYỀN] FROM TAIKHOAN
	WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau
END
GO

--- 15. --- Select Tài khoản để Cấp lại mật khẩu
CREATE PROC sp_select_forgot_password_account
@TenTaiKhoan VARCHAR(100)
AS
BEGIN
	SELECT TenTaiKhoan AS [TÊN TÀI KHOẢN] FROM TAIKHOAN
	WHERE TenTaiKhoan = @TenTaiKhoan
END
GO

--- 16. --- Update Mật khẩu cho Tài khoản
CREATE PROC sp_update_password
@TenTaiKhoan VARCHAR(100), @MatKhau VARCHAR(50)
AS
BEGIN
	UPDATE TAIKHOAN SET MatKhau = @MatKhau WHERE TenTaiKhoan = @TenTaiKhoan
END
GO

--- 17. --- Select from SACH, THELOAI để tìm kiếm
CREATE PROC sp_search_books
@TuKhoa NVARCHAR(200)
AS
BEGIN
	DECLARE @temp NVARCHAR(200) = N'"*'+ @TuKhoa + '*"'
	SELECT MaSach, SACH.TenSach AS [TÊN SÁCH], SACH.TacGia AS [TÁC GIẢ], THELOAI.TenTL AS [THỂ LOẠI], SACH.NhaXuatBan AS [NHÀ XUẤT BẢN], SACH.TonTai AS [CÓ SẴN], SACH.DaMuon AS [ĐÃ MƯỢN] 
	FROM SACH, THELOAI
	WHERE SACH.MaTL = THELOAI.MaTL 
	AND ( CONTAINS(SACH.TenSach, @temp ) OR FREETEXT(SACH.TenSach, @TuKhoa) OR SACH.TenSach LIKE '%'+ @TuKhoa +'%' OR
		  CONTAINS(SACH.TacGia, @temp ) OR FREETEXT(SACH.TacGia, @TuKhoa) OR SACH.TacGia LIKE '%'+ @TuKhoa +'%' OR
		  CONTAINS(SACH.NhaXuatBan, @temp ) OR FREETEXT(SACH.NhaXuatBan, @TuKhoa) OR SACH.NhaXuatBan LIKE '%'+ @TuKhoa +'%' OR
		  CONTAINS(THELOAI.TenTL, @temp ) OR FREETEXT(THELOAI.TenTL, @TuKhoa) OR THELOAI.TenTL LIKE '%'+ @TuKhoa +'%' OR
		  SACH.TonTai LIKE '%'+ @TuKhoa +'%' OR SACH.DaMuon LIKE '%'+ @TuKhoa +'%' )
END
GO

--drop proc sp_search_books

--- 19. --- Select 1 loại sách dựa tên Tên sách, Tác giả, Tên Thể loại, Nhà xuất bản
CREATE PROC sp_select_book
@TenSach NVARCHAR(100), @TacGia NVARCHAR(100), @NhaXuatBan NVARCHAR(200)
AS
BEGIN
	SELECT MaSach FROM SACH
	WHERE TenSach = @TenSach AND TacGia = @TacGia AND NhaXuatBan = @NhaXuatBan
END
GO

--exec sp_select_book @TenSach = 'A', @TacGia = 'B', @NhaXuatBan = 'C'

--- 20. --- Delete 1 loại sách
CREATE PROC sp_delete_book
@MaSach INT
AS
BEGIN
	DELETE FROM SACH
	WHERE MaSach = @MaSach
END
GO

--drop proc sp_delete_book

--- 21. --- Insert 1 loại sách
CREATE PROC sp_insert_book
@TenSach NVARCHAR(100), @TacGia NVARCHAR(100), @NhaXuatBan NVARCHAR(200), @TenTL NVARCHAR(100), @TonTai INT
AS
BEGIN
	DECLARE @MaTL INT
	SELECT @MaTL = MaTL FROM THELOAI
	WHERE TenTL = @TenTL
	INSERT INTO SACH(TenSach, TacGia, NhaXuatBan, TonTai, MaTL) VALUES (@TenSach, @TacGia, @NhaXuatBan, @TonTai, @MaTL)
END
GO

--drop proc sp_insert_book

--EXEC sp_insert_book @TenSach = 'A', @TacGia = 'B', @NhaXuatBan = 'C', @TenTL = 'D', @TonTai = 0, @DaMuon  = 0

ALTER DATABASE QLThuVien SET  READ_WRITE 
GO

--- 22. --- Update 1 loại sách dựa theo mã sách
CREATE PROC sp_update_book
@MaSach INT, @TenSach NVARCHAR(100), @TacGia NVARCHAR(100), @NhaXuatBan NVARCHAR(200), @TenTL NVARCHAR(100), @TonTai INT
AS
BEGIN
	DECLARE @MaTL INT
	SELECT @MaTL = MaTL FROM THELOAI WHERE TenTL = @TenTL

	UPDATE SACH
	SET TenSach = @TenSach, TacGia = @TacGia, NhaXuatBan = @NhaXuatBan, TonTai = @TonTai, MaTL = @MaTL
	WHERE MaSach = @MaSach 
END
GO

--drop proc sp_update_book

--- 23. --- Select from THELOAI để tìm kiếm
CREATE PROC sp_search_genres
@TuKhoa NVARCHAR(200)
AS
BEGIN
	DECLARE @temp NVARCHAR(200) = N'"*'+ @TuKhoa + '*"'
	SELECT MaTL, TenTL AS [TÊN THỂ LOẠI] FROM THELOAI 
	WHERE 
		( CONTAINS(TenTL, @temp ) OR FREETEXT(TenTL, @TuKhoa) OR TenTL LIKE '%'+ @TuKhoa +'%' )
END
GO

--drop proc sp_search_genre

--- 24. --- Select 1 thể loại từ tên thể loại (kiểm tra có sách thuộc thể loại này hay không)
CREATE PROC sp_select_genre
@TenTL NVARCHAR(100)
AS
BEGIN
	SELECT TenTL FROM THELOAI, SACH
	WHERE TenTL = @TenTL AND THELOAI.MaTL = SACH.MaTL
END
go

--- 25. --- Delete 1 thể loại 
CREATE PROC sp_delete_genre
@TenTL NVARCHAR(100)
AS
BEGIN
	DELETE FROM THELOAI
	WHERE TenTL = @TenTL
END
go

--- 26. --- Insert Update 1 thể loại -- ko tạo

--- 27. --- Select from Độc giả để tìm kiếm
create PROC sp_search_readers
@TuKhoa NVARCHAR(200)
AS
BEGIN
	DECLARE @temp NVARCHAR(200) = N'"*'+ @TuKhoa + '*"'
	SELECT MaDG, HoTen AS [HỌ TÊN], GioiTinh AS [GIỚI TÍNH], NgaySinh AS [NGÀY SINH], DiaChi AS [ĐỊA CHỈ], SDT AS [SĐT], Email AS [EMAIL] 
	FROM DOCGIA
	WHERE ( CONTAINS(HoTen, @temp ) OR FREETEXT(HoTen, @TuKhoa) OR HoTen LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(GioiTinh, @temp ) OR FREETEXT(GioiTinh, @TuKhoa) OR GioiTinh LIKE '%'+ @TuKhoa +'%' OR
		    NgaySinh LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(DiaChi, @temp ) OR FREETEXT(DiaChi, @TuKhoa) OR DiaChi LIKE '%'+ @TuKhoa +'%' OR
		    SDT LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(Email, @temp ) OR FREETEXT(Email, @TuKhoa) OR Email LIKE '%'+ @TuKhoa +'%' )
END
GO

--- 28. --- Select reader từ SĐT, Email để Insert, Update, Delete
CREATE PROC sp_select_reader 
@SDT VARCHAR(20), @Email VARCHAR(100)
AS
BEGIN
	SELECT MaDG FROM DOCGIA
	WHERE SDT = @SDT OR Email = @Email
END
go

exec sp_select_reader @SDT = '0934957323', @Email = 'f@m.m'

--- 29. --- Delete 1 độc giả
CREATE PROC sp_delete_reader 
@SDT VARCHAR(20), @Email VARCHAR(100)
AS
BEGIN
	DELETE FROM DOCGIA
	WHERE SDT = @SDT OR Email = @Email
END
go

--- 29. --- Insert 1 độc giả
CREATE PROC sp_insert_reader 
@HoTen NVARCHAR(100), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @DiaChi NVARCHAR(200), @SDT VARCHAR(20), @Email VARCHAR(100)
AS
BEGIN
	INSERT [dbo].[DOCGIA] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email]) VALUES (@HoTen, @GioiTinh, @NgaySinh,@DiaChi,@SDT, @Email)
END
go

--- 30. --- Update 1 độc giả
CREATE PROC sp_update_reader 
@MaDG INT, @HoTen NVARCHAR(100), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @DiaChi NVARCHAR(200), @SDT VARCHAR(20), @Email VARCHAR(100)
AS
BEGIN
	UPDATE DOCGIA
	SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, Email = @Email
	WHERE MaDG = @MaDG
END
go


--- 31. --- Select Nhân viên từ NHANVIEN để tìm kiểm
CREATE PROC sp_search_staff 
@TuKhoa NVARCHAR(200)
AS
BEGIN
	DECLARE @temp NVARCHAR(200) = N'"*'+ @TuKhoa + '*"'
	SELECT MaNV, HoTen AS [HỌ TÊN], GioiTinh AS [GIỚI TÍNH], NgaySinh AS [NGÀY SINH], DiaChi AS [ĐỊA CHỈ], SDT AS [SĐT], TenTaiKhoan AS [TÀI KHOẢN] 
	FROM NHANVIEN
	WHERE ( CONTAINS(HoTen, @temp ) OR FREETEXT(HoTen, @TuKhoa) OR HoTen LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(GioiTinh, @temp ) OR FREETEXT(GioiTinh, @TuKhoa) OR GioiTinh LIKE '%'+ @TuKhoa +'%' OR
		    NgaySinh LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(DiaChi, @temp ) OR FREETEXT(DiaChi, @TuKhoa) OR DiaChi LIKE '%'+ @TuKhoa +'%' OR
		    SDT LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(TenTaiKhoan, @temp ) OR FREETEXT(TenTaiKhoan, @TuKhoa) OR TenTaiKhoan LIKE '%'+ @TuKhoa +'%' )
END
go

--- 32. --- Select 1 nhân viên để Insert, Delete, Update
CREATE PROC sp_select_staff
@SDT VARCHAR(20)
AS
BEGIN
	SELECT MaNV FROM NHANVIEN
	WHERE SDT = @SDT
END
go

--- 33. --- Delete 1 nhân viên
CREATE PROC sp_delete_staff
@SDT VARCHAR(20)
AS
BEGIN
	DELETE FROM NHANVIEN
	WHERE SDT = @SDT 
END
go

--- 34. --- Insert 1 nhân viên
CREATE PROC sp_insert_staff 
@HoTen NVARCHAR(100), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @DiaChi NVARCHAR(200), @SDT VARCHAR(20), @TenTaiKhoan VARCHAR(100), @MatKhau VARCHAR(50)
AS
BEGIN
	INSERT [dbo].[TAIKHOAN] (TenTaiKhoan, MatKhau) VALUES (@TenTaiKhoan, @MatKhau);
	INSERT [dbo].[NHANVIEN] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TenTaiKhoan]) VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @TenTaiKhoan)
END
go

--drop proc sp_insert_staff

--- 35. --- Update 1 nhân viên
CREATE PROC sp_update_staff
@MaNV INT, @HoTen NVARCHAR(100), @GioiTinh NVARCHAR(10), @NgaySinh DATE, @DiaChi NVARCHAR(200), @SDT VARCHAR(20)
AS
BEGIN
	UPDATE NHANVIEN
	SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT
	WHERE MaNV = @MaNV
END
go

--drop proc sp_update_staff

---- 36. --- Search Tài khoản
CREATE PROC sp_search_accounts
@TuKhoa NVARCHAR(200)
AS
BEGIN
	DECLARE @temp NVARCHAR(200) = N'"*'+ @TuKhoa + '*"'
	SELECT HoTen as [HỌ TÊN], TAIKHOAN.TenTaiKhoan AS [TÊN TÀI KHOẢN], PhanQuyen AS [PHÂN QUYỀN]  FROM TAIKHOAN left join NHANVIEN on NHANVIEN.TenTaiKhoan = TAIKHOAN.TenTaiKhoan
	WHERE 
		( CONTAINS(TAIKHOAN.TenTaiKhoan, @temp ) OR FREETEXT(TAIKHOAN.TenTaiKhoan, @TuKhoa) OR TAIKHOAN.TenTaiKhoan LIKE '%'+ @TuKhoa +'%' OR
		  CONTAINS(PhanQuyen, @temp ) OR FREETEXT(PhanQuyen, @TuKhoa) OR PhanQuyen LIKE '%'+ @TuKhoa +'%' )
END
GO

--drop proc sp_search_accounts

--- 37. ---- Select 1 tài khoản 
CREATE PROC sp_select_account
@TenTaiKhoan VARCHAR(100)
AS
BEGIN
	SELECT TAIKHOAN.TenTaiKhoan AS [TÀI KHOẢN] FROM TAIKHOAN, NHANVIEN
	WHERE TAIKHOAN.TenTaiKhoan = @TenTaiKhoan AND NHANVIEN.TenTaiKhoan = TAIKHOAN.TenTaiKhoan
END
go

--- 38. --- Delete 1 account
CREATE PROC sp_delete_account
@TenTaiKhoan VARCHAR(100)
AS
BEGIN
	DELETE FROM TAIKHOAN
	WHERE TenTaiKhoan = @TenTaiKhoan
END
go

--- 39. --- Thêm số lượng sách khi thêm sách trùng 
CREATE PROC sp_increase_book_quantity
@TenSach NVARCHAR(100), @TacGia NVARCHAR(100), @NhaXuatBan NVARCHAR(200), @TenTL NVARCHAR(100), @SoLuong INT
AS
BEGIN
	DECLARE @MaTL INT
	SELECT @MaTL = MaTL FROM THELOAI
	WHERE TenTL = @TenTL

	UPDATE SACH set TonTai = TonTai + @SoLuong where TenSach = @TenSach and TacGia = @TacGia and NhaXuatBan = @NhaXuatBan and MaTL = @MaTL
END
GO

--- 40. --- Select tất cả hóa đơn
CREATE PROC sp_select_all_receipts
AS
BEGIN
	SELECT MaHD, DG.MaDG, MAHD + 10000000 AS [MÃ MƯỢN/TRẢ], DG.SDT AS [SĐT], NgayMuon AS [NGÀY MƯỢN], NgayTra AS [NGÀY TRẢ],
		TongSL AS [SL SÁCH], TinhTrang AS [TÌNH TRẠNG], ChiPhi AS [CHI PHÍ]
	
	FROM HOADON HD, DOCGIA DG
	WHERE HD.MaDG = DG.MaDG
END
go

--- 41. --- Search hóa đơn
CREATE PROC sp_search_receipts 
@TuKhoa NVARCHAR(200)
AS
BEGIN
	DECLARE @temp NVARCHAR(200) = N'"*'+ @TuKhoa + '*"'
	SELECT MaHD, DG.MaDG, MAHD + 10000000 AS [MÃ MƯỢN/TRẢ], DG.SDT AS [SĐT], NgayMuon AS [NGÀY MƯỢN], NgayTra AS [NGÀY TRẢ],
		TongSL AS [SL SÁCH], TinhTrang AS [TÌNH TRẠNG], ChiPhi AS [CHI PHÍ]
	FROM HOADON HD, DOCGIA DG
	WHERE HD.MaDG = DG.MaDG 
		AND ( MaHD LIKE '%'+ @TuKhoa +'%' OR
			 SDT LIKE '%'+ @TuKhoa +'%' OR
		    NgayMuon LIKE '%'+ @TuKhoa +'%' OR
			NgayTra LIKE '%'+ @TuKhoa +'%' OR
		    CONTAINS(TinhTrang, @temp ) OR FREETEXT(TinhTrang, @TuKhoa) OR TinhTrang LIKE '%'+ @TuKhoa +'%' OR
		    TongSL LIKE '%'+ @TuKhoa +'%' OR
		    ChiPhi LIKE '%'+ @TuKhoa +'%' )
END
go

--- 42. --- Select CTHD của HOADON theo MaHD
CREATE PROC sp_select_all_details_1_receipt 
@MaHD int
AS
BEGIN
	SELECT CT.MaHD, CT.MaSach, 
			S.TenSach AS [TÊN SÁCH], S.TacGia AS [TÁC GIẢ], TL.TenTL AS [THỂ LOẠI],
			S.NhaXuatBan AS [NHÀ XUẤT BẢN], CT.SL AS [SỐ LƯỢNG]
	FROM CTHD CT, SACH S, THELOAI TL
	WHERE CT.MaHD = @MaHD AND CT.MaSach = S.MaSach AND S.MaTL = TL.MaTL
END
go

--- 43. --- Insert HOADON kèm CTHD của nó
CREATE PROC sp_insert_receipt 
@SDT varchar(20), @NgayMuon date, @NgayTra date, @TongSL int
AS
BEGIN
	DECLARE @MaDG int
	SELECT @MaDG = MaDG FROM DOCGIA
	INSERT INTO HOADON (MaDG, NgayMuon, NgayTra, TinhTrang, TongSL, ChiPhi) 
	VALUES (@MaDG, @NgayMuon, @NgayTra, N'Cho mượn', @TongSL, 0)
END

--- 45. --- Insert CTHD sau khi insert HOADON
CREATE PROC sp_insert_detail
@MaHD int, @MaSach int, @SoLuong int
AS
BEGIN
	INSERT INTO CTHD VALUES (@MaHD, @MaSach, @SoLuong)

	UPDATE SACH
	SET TonTai = TonTai - @SoLuong, DaMuon = DaMuon + @SoLuong
	WHERE MaSach = @MaSach
END

--- 46. --- Update hóa đơn
CREATE PROC sp_update_receipt 
@MaHD int, @MaDG int, @NgayMuon date, @NgayTra date, @TongSL int, 
@TinhTrang nvarchar(20), @ChiPhi int
AS
BEGIN
	UPDATE HOADON
	SET MaDG = @MaDG, NgayMuon = @NgayMuon, NgayTra = @NgayTra, TongSL = @TongSL,
		TinhTrang = @TinhTrang, ChiPhi = @ChiPhi
	WHERE MaHD = @MaHD
END


alter database QLThuVien set enable_broker with rollback immediate;

SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON 
GO
SET ANSI_WARNINGS ON 
GO
SET CONCAT_NULL_YIELDS_NULL ON 
GO
SET QUOTED_IDENTIFIER ON
GO 
SET NUMERIC_ROUNDABORT OFF
GO 
SET ARITHABORT ON
GO
SET QUOTED_IDENTIFIER ON
GO

delete from NHANVIEN
alter table NHANVIEN alter column TenTaiKhoan VARCHAR(100) not null
alter table NHANVIEN add unique(TenTaiKhoan)

ALTER TABLE NHANVIEN drop constraint FK_NHANVIEN_TAIKHOAN

ALTER TABLE TAIKHOAN WITH CHECK
ADD constraint FK_TAIKHOAN_NHANVIEN FOREIGN KEY (TenTaiKhoan) REFERENCES NHANVIEN(TenTaiKhoan)
GO

---- Chỉnh sửa Bảng CTHD
ALTER TABLE CTHD ADD CheckMove varchar(5)