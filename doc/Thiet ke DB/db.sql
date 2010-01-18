use master
go
drop database DentalLabo
go
create database DentalLabo
go
use DentalLabo
go
------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Mau Dat Hang
------------------------------------------------------------------------

-- Cac danh muc
create table SanPham(
	MaSP varchar(20) primary key,
	TenSP varchar(200),
	PhamChat varchar(50),
	DVT varchar(50),
	NhomHangHoa varchar(50),
	GhiChu varchar(1000),
)
go
create table VatLieuPhu(
	MaVL varchar(20) primary key, 
	TenVL varchar(200), 
	DonGia numeric(20)
)
go
create table VatLieuChinh(
	MaVL varchar(20) primary key, 
	TenVL varchar(200)
)
go
create table BangGia(
	MaSP varchar(20) references SanPham, 
	MaVL varchar(20) references VatLieuChinh, 
	DonGia numeric(20), 
	GiaTinhThem numeric(20),
	primary key(MaSP, MaVL)
)
go
-- Cac bang phuc vu viec dat hang
create table NhomKH(
	MaNhom varchar(20) primary key,
	TenNhom varchar(200)
)
go
create table KhachHang(
	MaKH varchar(20) primary key,
	TenKh varchar(200),
	GioiTinh int,
	SDT varchar(20),
	MaSoThue varchar(20),
	NguoiDaiDien varchar(200),
	MaNhomKH varchar(20) references NhomKH	
)
go
create table MauHang(
	MaMau varchar(20) primary key,	
	MaKH varchar(20) references KhachHang,
	LoaiPhucHinh varchar(50),
	NgayNhan datetime,
	NgayTra datetime,
	GioTra int,	
	UserId varchar(20),
	TrangThai int,	
)
go
create table SanPhamDatHang(
	MaSPDatHang varchar(20) primary key,
	MaSP varchar(20) references SanPham,
	MaVLC varchar(20) references VatLieuChinh,
	MaVLP varchar(20) references VatLieuPhu, 
	SoLuong int,
	MauSP varchar(50),
	LuuY varchar(1000),
	YeuCauChiTiet varchar(1000)
)
go 
create table MauHang_SanPhamDatHang(
	MaMau varchar(20) references MauHang,
	MaSPDatHang varchar(20) references SanPhamDatHang,
	primary key(MaMau, MaSPDatHang)
)
go

------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Nhan Vien va Tinh Luong
------------------------------------------------------------------------
create table BoPhan(
	MaBP varchar(20) primary key, 
	TenBP varchar(200)
)
go
create table NhanVien(
	MaNV varchar(20) primary key,
	MaBP varchar(20) references BoPhan,
	TenNV varchar(200),	
	GioiTinh varchar(10),
	NamSinh int,	
	SoCMT varchar(20)
) 
go
create table CongDoanSX(
	MaCD varchar(20) primary key,
	TenCD varchar(200),
	DonViTinh varchar(50),
	SoLuongQuyChieu numeric(20)
)
go
create table ChamCongDoan(
	MaCD varchar(20) references CongDoanSX,
	MaNV varchar(20) references NhanVien,
	MaMau varchar(20) references MauHang,
	SoLan int,
	primary key(MaCD, MaNV, MaMau)
)
go
-- Khoan Luong bao gom: Khoan Luong Chinh, Luong Phu, va cac loai khoan Luong Tinh them
create table KhoanLuong(
	MaKhoan varchar(20) primary key,
	TenKhoan varchar(200),
	DonViTinh varchar(50),	
)
go
create table GiaTriKhoanLuong(
	MaKhoan varchar(20) references KhoanLuong,
	MaBP varchar(20) references BoPhan,
	DonGia numeric(20),
	primary key(MaKhoan, MaBP)	
)
go
create table KhoanTru(
	MaKhoan varchar(20) primary key,
	TenKhoan varchar(200),
	DonViTinh varchar(50),
	DonGia	numeric(20)
)
go
create table ChamCong(
	MaNV varchar(20) references NhanVien,	
	KhoanLuong varchar(20) references KhoanLuong,
	Thang int,
	Nam int,
	SoLan int,
	primary key(MaNV, Thang, Nam)
)
go
create table ChamPhat(
	MaNV varchar(20) references NhanVien,	
	KhoanTru varchar(20) references KhoanTru,
	Thang int,
	Nam int,
	SoLan int,
	primary key(MaNV, Thang, Nam)
)
go
create table TamUng(
	MaNV varchar(20) references NhanVien,
	DVT varchar(20),
	MucTamUng numeric(20),
	ThanhTien numeric(20),
	GhiChu varchar(200),
	NgayTamUng datetime,
	primary key(MaNV, NgayTamUng)
)
go


------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Ban Hang va Cong No Khach Hang
------------------------------------------------------------------------
create table KhoHang (
	MaKho varchar(20) primary key,
	TenKho varchar(200),
	MaThuKho varchar(20) references NhanVien,	
)
go
create table PhieuNhapKhoSP(
	MaPhieu varchar(20) primary key,	
	NgayNhap datetime,	
	GioNhap varchar(50),
	MaKho varchar(20) references KhoHang,
	MaNV varchar(20) references NhanVien,
	DienGiai varchar(200)
)

go
create table PhieuNhapKhoSP_MauHang (
	MaPhieu varchar(20) references PhieuNhapKhoSP,
	MaMau varchar(20) references MauHang,
	NgayNhap datetime,
	GioNhap varchar(50),
	primary key (MaPhieu, MaMau)
)
go
create table HoaDonBanHang(
	MaHD varchar(20) primary key,
	MaKH varchar(20) references KhachHang,
	MaNV varchar(20) references NhanVien,
	NgayXuat datetime,	
)
go
create table HoaDonBanHang_MauHang(
	MaHD varchar(20) references HoaDonBanHang,
	MaMau varchar(20) references MauHang,
	primary key(MaHD, MaMau)
)
go
create table NoiDungGiamTru(
	MaGiamTru varchar(20) primary key,
	NoiDung varchar(200),
	DVT varchar(20),
	DonGia numeric(20),
)
go
create table HoaDonBanHang_NoiDungGiamTru(
	MaHD varchar(20) references HoaDonBanHang,
	MaGiamTru varchar(20) references NoiDungGiamTru,
	SoLuong float,
	GhiChu varchar(200),
	primary key(MaHD, MaGiamTru)
)
go

------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Kho Hang va No Nha Cung Cap
------------------------------------------------------------------------
create table NhaCungCap(
	MaNCC varchar(20) primary key,
	TenNCC varchar(200),
	MaSoThue varchar(20),
	NguoiDaiDien varchar(100),
	DiaChi varchar(200),
	DienThoai varchar(20)
)
go
create table VatTu(
	MaVatTu varchar(20) primary key,
	MaNCC varchar(20) references NhaCungCap,
	TenVatTu varchar(200),
	DVT varchar(20),
	NhomHangHoa varchar(20),
	QuyCach varchar(100),
	DonGia numeric(20),
)
go
create table ThietBi(
	MaThietBi varchar(20) primary key,
	MaNCC varchar(20) references NhaCungCap,
	TenThietBi varchar(200),
	DVT varchar(20),
	NhomHangHoa varchar(20),
	QuyCach varchar(100),
	ThoiGianKhauHao int,
	MucTrichKhauHao numeric(20),
	DonGia numeric(20)
)
go
create table PhieuNhapKhoVTTB(
	MaPhieu varchar(20) primary key,
	MaNCC varchar(20) references NhaCungCap,
	NguoiGiaoHang varchar(200),
	NgayNhap datetime,
	ThoiHanThanhToan datetime,		
	MaTienTe varchar(20),
	TyGia numeric(20),
	ChungTuGoc varchar(20)
)
go
create table PhieuNhapKhoVTTB_VatTu(
	MaPhieu varchar(20) references PhieuNhapKhoVTTB,
	MaVatTu varchar(20) references VatTu,	
)
go
create table PhieuNhapKhoVTTB_ThietBi(
	MaPhieu varchar(20) references PhieuNhapKhoVTTB,
	MaThietBi varchar(20) references ThietBi,	
)
go
create table PhieuThanhToanNCC(
	MaPhieu varchar(20) primary key,
	MaNCC varchar(20) references NhaCungCap,
	NgayThanhToan datetime,
	SoTien numeric(20)		
)
go
create table PhieuXuatVTTB(
	MaPhieu varchar(20) primary key,
	MaNV varchar(20) references NhanVien,
	MaCD varchar(20) references CongDoanSX,
	NgayXuat datetime,
	DienGiai varchar(200)
)
go
create table PhieuXuatVTTB_NVL(
	MaPhieu varchar(20) references PhieuXuatVTTB,
	MaVatTu varchar(20) references VatTu,
	SoLuong int
)
go
create table PhieuXuatVTTB_TB(
	MaPhieu varchar(20) references PhieuXuatVTTB,
	MaThietBi varchar(20) references ThietBi,
	SoLuong int
)

------------------------------------------------------------------------
-- Tao du lieu de Test
------------------------------------------------------------------------
go
insert BoPhan values('BP1', 'Bo Phan 1')
insert BoPhan values('BP2', 'Bo Phan 2')
insert BoPhan values('BP3', 'Bo Phan 3')
insert BoPhan values('BP4', 'Bo Phan 4')

--insert BoPhan values('42456', 'Bo Phan 4')
--insert BoPhan values('12456', 'Bo Phan 4')
--insert BoPhan values('1', 'Bo Phan 4')
--insert BoPhan values('2', 'Bo Phan 4')
--insert BoPhan values('8', 'Bo Phan 4')
--insert BoPhan values('9972', 'Bo Phan 4')

go
insert NhanVien values('NV1', 'BP1', 'Nhan vien 1', 'Nam', 1984, 1234425)
insert NhanVien values('NV2', 'BP1', 'Nhan vien 2', 'Nu', 1984, 1234425)
insert NhanVien values('NV3', 'BP1', 'Nhan vien 3', 'Nam', 1984, 1234425)
insert NhanVien values('NV4', 'BP1', 'Nhan vien 4', 'Nam', 1984, 1234425)
insert NhanVien values('NV5', 'BP2', 'Nhan vien 5', 'Nu', 1984, 1234425)
insert NhanVien values('NV6', 'BP2', 'Nhan vien 6', 'Nam', 1984, 1234425)
go
insert KhoHang values('KH1', 'Kho hang 1', 'NV1')
insert KhoHang values('KH2', 'Kho hang 2', 'NV2')
insert KhoHang values('KH3', 'Kho hang 3', 'NV3')


delete from PhieuNhapKhoSP
select * from PhieuNhapKhoSP
SELECT TOP 1 MaPhieu FROM PhieuNhapKhoSP ORDER BY len(MaPhieu) desc, MaPhieu desc
delete from BoPhan where MaBP not like 'B%'

--insert PhieuNhapKhoSP values('121414', null, null, null, null, null, null)
--insert PhieuNhapKhoSP values('12', null, null, null, null, null, null)
--insert PhieuNhapKhoSP values('99', null, null, null, null, null, null)
--insert PhieuNhapKhoSP values('121423', null, null, null, null, null, null)
--insert PhieuNhapKhoSP values('23525', null, null, null, null, null, null)
--truncate table PhieuNhapKhoSP

