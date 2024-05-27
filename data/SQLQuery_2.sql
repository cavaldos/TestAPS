-- Bước 1: Tạo Database
CREATE DATABASE QuanLyNhaSach;
GO

-- Sử dụng database vừa tạo
USE QuanLyNhaSach;
GO

-- Bước 2: Tạo Các Bảng

-- Tạo bảng Tác giả 
CREATE TABLE TacGia (
    MaTacGia INT PRIMARY KEY IDENTITY(1,1),
    TenTacGia NVARCHAR(100) NOT NULL
);

-- Tạo bảng Nhà xuất bản
CREATE TABLE NhaXuatBan (
    MaNhaXuatBan INT PRIMARY KEY IDENTITY(1,1),
    TenNhaXuatBan NVARCHAR(100) NOT NULL
);

-- Tạo bảng Sách
CREATE TABLE Sach (
    MaSach INT PRIMARY KEY IDENTITY(1,1),
    TenSach NVARCHAR(100) NOT NULL,
    MaTacGia INT,
    MaNhaXuatBan INT,
    NamXuatBan INT,
    Gia DECIMAL(18, 2) NOT NULL,
    SoLuong INT NOT NULL,
    FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia),
    FOREIGN KEY (MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan)
);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY(1,1),
    TenKhachHang NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100)
);

-- Tạo bảng Đơn hàng
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang INT,
    NgayDatHang DATE NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- Tạo bảng Chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    MaChiTietDonHang INT PRIMARY KEY IDENTITY(1,1),
    MaDonHang INT,
    MaSach INT,
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

-- Tạo bảng Nhân viên
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY IDENTITY(1,1),
    TenNhanVien NVARCHAR(100) NOT NULL,
    ChucVu NVARCHAR(50),
    Luong DECIMAL(18, 2),
    DiaChi NVARCHAR(200),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100)
);

SELECT * FROM sys.tables;

USE QuanLyNhaSach;
GO

-- Chèn dữ liệu mẫu vào bảng TacGia
INSERT INTO TacGia (TenTacGia) VALUES
('Nguyễn Nhật Ánh'),
('Paulo Coelho'),
('J.K. Rowling');

-- Chèn dữ liệu mẫu vào bảng NhaXuatBan
INSERT INTO NhaXuatBan (TenNhaXuatBan) VALUES
('Nhà xuất bản Kim Đồng'),
('Nhà xuất bản Trẻ'),
('Penguin Random House');

-- Chèn dữ liệu mẫu vào bảng Sach
INSERT INTO Sach (TenSach, MaTacGia, MaNhaXuatBan, NamXuatBan, Gia, SoLuong) VALUES
('Mắt Biếc', 1, 2, 1990, 50000, 100),
('Nhà Giả Kim', 2, 3, 1988, 150000, 50),
('Harry Potter và Hòn Đá Phù Thủy', 3, 3, 1997, 200000, 30);

-- Chèn dữ liệu mẫu vào bảng KhachHang
INSERT INTO KhachHang (TenKhachHang, DiaChi, SoDienThoai, Email) VALUES
('Nguyễn Văn A', '123 Đường ABC, Quận 1, TP.HCM', '0901234567', 'vana@example.com'),
('Trần Thị B', '456 Đường XYZ, Quận 2, TP.HCM', '0902345678', 'thib@example.com'),
('Phạm Văn C', '789 Đường DEF, Quận 3, TP.HCM', '0903456789', 'test1@gmail.com'),
('Nguyễn Thị D', '012 Đường GHI, Quận 4, TP.HCM', '0904567890', 'test2@gmail.com');


-- Chèn dữ liệu mẫu vào bảng DonHang
INSERT INTO DonHang (MaKhachHang, NgayDatHang, TongTien) VALUES
(1, '2024-05-20', 250000),
(2, '2024-05-21', 200000);

-- Chèn dữ liệu mẫu vào bảng ChiTietDonHang
INSERT INTO ChiTietDonHang (MaDonHang, MaSach, SoLuong, Gia) VALUES
(1, 1, 1, 50000),
(1, 3, 1, 200000),
(2, 2, 1, 150000),
(2, 3, 1, 200000);

-- Chèn dữ liệu mẫu vào bảng NhanVien
INSERT INTO NhanVien (TenNhanVien, ChucVu, Luong, DiaChi, SoDienThoai, Email) VALUES
('Lê Thị C', 'Quản lý', 15000000, '789 Đường DEF, Quận 3, TP.HCM', '0903456789', 'lec@example.com'),
('Phạm Văn D', 'Nhân viên bán hàng', 8000000, '012 Đường GHI, Quận 4, TP.HCM', '0904567890', 'vand@example.com');


select * from TacGia;