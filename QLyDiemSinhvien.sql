-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyDiemSinhVien;
GO

-- Sử dụng cơ sở dữ liệu
USE QuanLyDiemSinhVien;
GO

-- Bảng Monhoc
CREATE TABLE Monhoc (
    idMon INT IDENTITY(1,1) PRIMARY KEY,
    tenMon NVARCHAR(100) NOT NULL,
    TC INT NOT NULL -- Số tín chỉ
);
GO

-- Bảng Sinhvien
CREATE TABLE Sinhvien (
    MaSV INT IDENTITY(1,1) PRIMARY KEY,
    TenSV NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    QueQuan NVARCHAR(100),
    LopHoc NVARCHAR(50) -- Thay vì liên kết với bảng lớp học
);
GO

-- Bảng Giangvien
CREATE TABLE Giangvien (
    idGiangVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    Khoa NVARCHAR(100)
);
GO

-- Bảng Diem
CREATE TABLE Diem (
    idDiem INT IDENTITY(1,1) PRIMARY KEY,
    idSinhVien INT NOT NULL,
    idMonHoc INT NOT NULL,
    DiemSo FLOAT CHECK (DiemSo BETWEEN 0 AND 10),
    DiemChu AS (CASE
        WHEN DiemSo >= 8.5 THEN 'A'
        WHEN DiemSo >= 7.0 THEN 'B'
        WHEN DiemSo >= 5.5 THEN 'C'
        WHEN DiemSo >= 4.0 THEN 'D'
        ELSE 'F'
    END),
    CONSTRAINT FK_Diem_Sinhvien FOREIGN KEY (idSinhVien) REFERENCES Sinhvien(MaSV),
    CONSTRAINT FK_Diem_Monhoc FOREIGN KEY (idMonHoc) REFERENCES Monhoc(idMon)
);
GO
