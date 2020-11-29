USE QLThuVien

GO

--Tạo Store Procedure

--Đếm số lượng sách
CREATE PROCEDURE sp_book_count
AS
	SELECT COUNT(MaSach) 
	FROM SACH
GO

--Đếm số lượng bản sao có thể mượn
CREATE PROCEDURE sp_available_copies_count
AS
	SELECT SUM(TonTai)
	FROM SACH
GO

--Đếm tổng số bản sao của thư viện
CREATE PROCEDURE sp_copies_count
AS
	SELECT SUM(TonTai + DaMuon)
	FROM SACH
GO

--Đếm số lượng nhân viên
CREATE PROCEDURE sp_employee_count
AS
	SELECT COUNT(MaNv) 
	FROM NHANVIEN
GO

--Đếm số lượng người đọc
CREATE PROCEDURE sp_reader_count
AS
	SELECT COUNT(MaDG) 
	FROM DOCGIA
GO

--Đếm tổng lượt mượn sách
CREATE PROCEDURE sp_borrowed_count
AS
	SELECT COUNT(MaHD) 
	FROM HOADON
GO

--Đếm số lượng sách đang mượn
CREATE PROCEDURE sp_borrowing_count
AS
	SELECT COUNT(*)
	FROM HOADON
	WHERE GETDATE() <= NgayTra
GO

--Đếm số lượng đơn quá hạn
CREATE PROCEDURE sp_overdue_count
AS
	SELECT COUNT(*)
	FROM HOADON
	WHERE GETDATE() > NgayTra
go

--SÁCH

--Lấy thông tin sách
CREATE PROCEDURE sp_get_book
AS
	SELECT MaSach, TenSach, TacGia, TenTL, NhaXuatBan, TonTai ,DaMuon
	FROM SACH inner join THELOAI on SACH.MaTL = THELOAI.MaTL
GO

--Thêm sách
create procedure sp_add_book
	@TenSach NVARCHAR(100),
	@TacGia NVARCHAR(100),
	@MaTL INT,
	@NhaXuatBan NVARCHAR(200),
	@TonTai INT
as
	insert Sach (TenSach, TacGia, MaTL, NhaXuatBan, TonTai) 
	values (@TenSach, @TacGia, @MaTL, @NhaXuatBan, @TonTai)
go

--Xóa sách
create procedure sp_delete_book
	@MaSach INT
as
	delete from SACH 
	where MaSach = @MaSach
go

--Chỉnh sửa sách
create procedure sp_edit_book
	@MaSach INT, 
	@TenSach NVARCHAR(100), 
	@TacGia NVARCHAR(100), 
	@MaTL INT, 
	@NhaXuatBan NVARCHAR(200), 
	@TonTai INT
as
	update SACH 
	set TenSach = @TenSach, 
		TacGia = @TacGia, 
		MaTL = @MaTL, 
		NhaXuatBan = @NhaXuatBan, 
		TonTai = @TonTai 
	where MaSach = @MaSach
go

--Kiểm tra sách đã tồn tại
create procedure sp_check_book_is_exists
	@TenSach NVARCHAR(100), 
	@TacGia NVARCHAR(100), 
	@MaTL INT, 
	@NhaXuatBan NVARCHAR(200)
as
	select count(*)
	from SACH
	where TenSach = @TenSach and TacGia = @TacGia and MaTL = @MaTL and NhaXuatBan = @NhaXuatBan
go

--ĐỌC GIẢ--

--Lấy thông tin người đọc
create procedure sp_get_reader
as
select *
from DOCGIA
go

--Thêm người đọc
create procedure sp_add_reader
	@HoTen NVARCHAR(100), 
	@GioiTinh NVARCHAR(10), 
	@NgaySinh DATE, 
	@DiaChi NVARCHAR(200), 
	@SDT VARCHAR(20), 
	@Email VARCHAR(100)
as
	insert DocGia (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, Email) 
	values (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email)
go

--Xóa người đọc
create procedure sp_delete_reader
	@MaDG INT
as
	delete 
	from DOCGIA 
	where MaDG = @MaDG
go

--Chỉnh sửa thông tin người đọc
create procedure sp_edit_reader
	@MaDG INT, 
	@HoTen NVARCHAR(100), 
	@GioiTinh NVARCHAR(10), 
	@NgaySinh DATE, 
	@DiaChi NVARCHAR(200), 
	@SDT VARCHAR(20), 
	@Email VARCHAR(100)
as
	update DOCGIA 
	set HoTen = @HoTen, 
		GioiTinh = @GioiTinh, 
		NgaySinh = @NgaySinh,
		DiaChi = @DiaChi, 
		SDT = @SDT, 
		Email = @Email 
	where MaDG = @MaDG
go

--Kiểm tra người đọc đã tồn tại
create procedure sp_check_reader_exists
	@HoTen NVARCHAR(100), 
	@GioiTinh NVARCHAR(10), 
	@SDT VARCHAR(20), 
	@Email VARCHAR(100)
as
	select count(*)
	from DOCGIA
	where HoTen = @HoTen and GioiTinh = @GioiTinh and SDT = @SDT and Email = @Email
go

--Kiểm tra thông tin liên lạc email đã tồn tại
create procedure sp_check_reader_email_exists 
	@Email VARCHAR(100)
as
	select count(*)
	from DOCGIA
	where Email = @Email	
go

--Kiểm tra SĐT đã tồn tại
create procedure sp_check_reader_phone_exist
	@SDT VARCHAR(20)
as
	select count(*)
	from DOCGIA
	where SDT = @SDT
go

--HÓA ĐƠN--

--Lấy thông tin hóa đơn
create procedure sp_get_employee
as
select HOADON.MaHD, HoTen, NgayMuon, NgayTra, TenSach, TongSL, ChiPhi, TinhTrang
from HOADON inner join DOCGIA on DOCGIA.MaDG = HOADON.MaDG
			inner join (CTHD inner join SACH on SACH.MaSach = CTHD.MaSach) on CTHD.MaHD = HOADON.MaHD
go

--Tạo hóa đơn
create procedure sp_create_bill
	@MaDG INT,
	@NgayMuon DATE,
	@NgayTra DATE,
	@TinhTrang NVARCHAR(50)
as
	insert HOADON (MaDG, NgayMuon, NgayTra, TinhTrang)
	values (@MaDG, @NgayMuon, @NgayTra, @TinhTrang)
go

--Tạo CTHD
create procedure sp_create_billinfo
	@MaHD INT,
	@MaSach INT,
	@SL INT
as
	insert CTHD (MaHD, MaSach, SL)
	values (@MaHD, @MaSach, @SL)

	update SACH 
	set TonTai = TonTai - @SL,
		DaMuon = DaMuon + @SL
	where MaSach = @MaSach

	update HOADON
	set TongSL = TongSL + @SL
	where MaHD = @MaHD
go

--Cập nhật chi phí
create procedure sp_update_cost
	@TienPhat INT
as
	update HOADON
	set ChiPhi = (
		case
			when GETDATE() <= NgayTra and TinhTrang = 'Cho Mượn'
			then 0
			when GETDATE() > NgayTra and TinhTrang = 'Cho Mượn'
			then DATEDIFF(DAY, NgayMuon, GETDATE()) * TongSL * @TienPhat
		end)
go

--Xóa hóa đơn
create procedure sp_delete_bill
	@MaHD INT
as
	delete from HOADON where MaHD = @MaHD
	delete from CTHD where MaHD = @MaHD
go

--Chỉnh sửa hóa đơn
create procedure sp_edit_bill
	@MaHD INT, 
	@MaDG INT,
	@NgayMuon DATE,
	@NgayTra DATE
as
	update HOADON 
	set MaDG = @MaDG,
		NgayMuon = @NgayMuon,
		NgayTra = @NgayTra
	where MaHD = @MaHD
go

--Chỉnh sửa tình trạng hóa đơn
create procedure sp_edit_bill_status
	@MaHD INT, 
	@TinhTrang NVARCHAR(50)
as
	update HOADON 
	set TinhTrang = @TinhTrang
	where MaHD = @MaHD

	if (select TinhTrang from HOADON where MaHD = @MaHD) = 'Thu hồi'
	begin
		update SACH
		set TonTai = TonTai + (select SL from CTHD where CTHD.MaSach = MaSach and CTHD.MaHD = @MaHD)
		where MaSach = ANY (select MaSach from CTHD where CTHD.MaHD = @MaHD)
	end
go

--TÀI KHOẢN

--Tạo tài khoản
create procedure sp_create_account
	@Username VARCHAR(100),
	@Password VARCHAR(50)
as
	insert TAIKHOAN (TenTaiKhoan, MatKhau)
	values (@Username, @Password)
go

--Đổi mật khẩu
create procedure sp_change_password
	@Username VARCHAR(100),
	@NewPassword VARCHAR(50)
as
	update TAIKHOAN
	set MatKhau = @NewPassword
	where TenTaiKhoan = @Username
go

--Chỉnh phân quyền
create procedure sp_set_permission
	@Username VARCHAR(100),
	@Permisson NVARCHAR(20)
as
	update TAIKHOAN
	set PhanQuyen = @Permisson
	where TenTaiKhoan = @Username
go

--Xóa tài khoản
create procedure sp_delete_password
	@Username VARCHAR(100)
as
	delete from TAIKHOAN
	where TenTaiKhoan = @Username
go

--Đăng nhập
create procedure sp_login
	@Username VARCHAR(100),
	@Password VARCHAR(50)
as
	select count(*)
	from TAIKHOAN
	where TenTaiKhoan = @Username and MatKhau = @Password
go

--NHÂN VIÊN

--Lấy thông tin nhân viên
create procedure sp_get_employees
as
	select *
	from NHANVIEN
go

--Thêm nhân viên
create procedure sp_add_employee
	@HoTen NVARCHAR(100),
	@GioiTinh NVARCHAR(5),
	@NgaySinh DATE,
	@DiaChi NVARCHAR(200),
	@SDT VARCHAR(20),
	@TenTaiKhoan VARCHAR(100)
as
	insert NHANVIEN (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, TenTaiKhoan)
	values (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @TenTaiKhoan)
go

--Sửa thông tin nhân viên
create procedure sp_edit_employee
	@MaNV INT,
	@HoTen NVARCHAR(100),
	@GioiTinh NVARCHAR(5),
	@NgaySinh DATE,
	@DiaChi NVARCHAR(200),
	@SDT VARCHAR(20)
as
	update NHANVIEN
	set	HoTen = @HoTen,
		GioiTinh = @GioiTinh,
		NgaySinh = @NgaySinh,
		DiaChi = @DiaChi,
		SDT = @SDT
	where MaNV = @MaNV
go

--Xóa nhân viên
create procedure sp_delete_employee
	@MaNV INT
as
	delete from NHANVIEN
	where MaNV = @MaNV
go

--THỂ LOẠI

--Thêm thể loại
create procedure sp_add_genre
	@TenTL NVARCHAR(100)
as
	insert THELOAI (TenTL)
	value (@TenTL)
go

--Chỉnh sửa tên thể loại
create procedure sp_edit_genre
	@MaTL INT,
	@TenTLMoi NVARCHAR(100)
as
	update THELOAI
	set TenTL = @TenTLMoi
	where MaTL = @MaTL
go

