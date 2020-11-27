USE QLThuVien

GO

--Tạo Store Procedure

--Đếm số lượng sách
CREATE PROCEDURE sp_book_count
AS
SELECT COUNT(MaSach) FROM SACH
GO

--Đếm số lượng bản sao có thể mượn
CREATE PROCEDURE sp_available_copies_count
AS
SELECT SUM(TonTai) FROM SACH
GO

--Đếm tổng số bản sao của thư viện
CREATE PROCEDURE sp_copies_count
AS
SELECT SUM(TonTai + DaMuon) FROM SACH
GO

--Đếm số lượng nhân viên
CREATE PROCEDURE sp_employee_count
AS
SELECT COUNT(MaNv) FROM NHANVIEN
GO

--Đếm số lượng người đọc
CREATE PROCEDURE sp_reader_count
AS
SELECT COUNT(MaDG) FROM DOCGIA
GO

--Đếm tổng lượt mượn sách
CREATE PROCEDURE sp_borrowed_count
AS
SELECT COUNT(MaHD) FROM HOADON
GO