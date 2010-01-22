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
	MaSP nvarchar(20) primary key,
	TenSP nvarchar(200),
	PhamChat nvarchar(50),
	DVT nvarchar(50),
	NhomHangHoa nvarchar(50),
	GhiChu nvarchar(1000),
)
go
create table VatLieuPhu(
	MaVL nvarchar(20) primary key, 
	TenVL nvarchar(200),
	DVT nvarchar(50), 
	DonGia nvarchar(20)
)
go
create table VatLieuChinh(
	MaVL nvarchar(20) primary key, 
	TenVL nvarchar(200)
)
go
create table BangGia(
	MaSP nvarchar(20) references SanPham, 
	MaVL nvarchar(20) references VatLieuChinh, 
	DonGia nvarchar(20), 
	GiaTinhThem nvarchar(20),
	primary key(MaSP, MaVL)
)
go
-- Cac bang phuc vu viec dat hang
create table NhomKH(
	MaNhom nvarchar(20) primary key,
	TenNhom nvarchar(200)
)
go
create table KhachHang(
	MaKH nvarchar(20) primary key,
	TenKh nvarchar(200),
	GioiTinh nvarchar(100),
	SDT nvarchar(20),
	MaSoThue nvarchar(20),
	NguoiDaiDien nvarchar(200),
	MaNhomKH nvarchar(20) references NhomKH,
	DiaChi nvarchar(200)
)
go
create table MauHang(
	MaMau nvarchar(20) primary key,	
	MaKH nvarchar(20) references KhachHang,
	LoaiPhucHinh nvarchar(50),
	NgayNhan datetime,
	NgayTra datetime,
	GioTra nvarchar(100),	
	UserId nvarchar(20),
	TrangThai nvarchar(100),	
)
go
create table SanPhamDatHang(
	MaSPDatHang nvarchar(20) primary key,
	MaSP nvarchar(20) references SanPham,
	MaVLC nvarchar(20) references VatLieuChinh,
	MaVLP nvarchar(20) references VatLieuPhu, 
	SoLuongVLC nvarchar(100),
	SoLuongVLP nvarchar(100), 
	MauSP nvarchar(50),
	LuuY nvarchar(1000),
	YeuCauChiTiet nvarchar(1000)
)
go 
create table MauHang_SanPhamDatHang(
	MaMau nvarchar(20) references MauHang,
	MaSPDatHang nvarchar(20) references SanPhamDatHang,
	primary key(MaMau, MaSPDatHang)
)
go

------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Nhan Vien va Tinh Luong
------------------------------------------------------------------------
create table BoPhan(
	MaBP nvarchar(20) primary key, 
	TenBP nvarchar(200)
)
go
create table NhanVien(
	MaNV nvarchar(20) primary key,
	MaBP nvarchar(20) references BoPhan,
	TenNV nvarchar(200),
	GioiTinh nvarchar(100),
	NamSinh nvarchar(100),	
	SoCMT nvarchar(20),
	DiaChi nvarchar(100),
	DienThoai nvarchar(50)
) 
go
create table CongDoanSX(
	MaCD nvarchar(20) primary key,
	TenCD nvarchar(200),
	DonViTinh nvarchar(50),
	SoLuongQuyChieu nvarchar(20)
)
go
create table ChamCongDoan(
	MaCD nvarchar(20) references CongDoanSX,
	MaNV nvarchar(20) references NhanVien,
	MaMau nvarchar(20) references MauHang,
	SoLan nvarchar(100),
	primary key(MaCD, MaNV, MaMau)
)
go
-- Khoan Luong bao gom: Khoan Luong Chinh, Luong Phu, va cac loai khoan Luong Tinh them
create table KhoanLuong(
	MaKhoan nvarchar(20) primary key,
	TenKhoan nvarchar(200),
	DonViTinh nvarchar(50),	
)
go
create table GiaTriKhoanLuong(
	MaKhoan nvarchar(20) references KhoanLuong,
	MaBP nvarchar(20) references BoPhan,
	DonGia nvarchar(20),
	primary key(MaKhoan, MaBP)	
)
go
create table KhoanTru(
	MaKhoan nvarchar(20) primary key,
	TenKhoan nvarchar(200),
	DonViTinh nvarchar(50),
	DonGia	nvarchar(20)
)
go
create table ChamCong(
	MaNV nvarchar(20) references NhanVien,	
	KhoanLuong nvarchar(20) references KhoanLuong,
	Thang nvarchar(100),
	Nam nvarchar(100),
	SoLan nvarchar(100),
	primary key(MaNV, Thang, Nam)
)
go
create table ChamPhat(
	MaNV nvarchar(20) references NhanVien,	
	KhoanTru nvarchar(20) references KhoanTru,
	Thang nvarchar(100),
	Nam nvarchar(100),
	SoLan nvarchar(100),
	primary key(MaNV, Thang, Nam)
)
go
create table TamUng(
	MaNV nvarchar(20) references NhanVien,
	DVT nvarchar(20),
	MucTamUng nvarchar(20),
	ThanhTien nvarchar(20),
	GhiChu nvarchar(200),
	NgayTamUng datetime,
	primary key(MaNV, NgayTamUng)
)
go


------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Ban Hang va Cong No Khach Hang
------------------------------------------------------------------------
create table KhoHang (	
	MaKho nvarchar(20) primary key,
	TenKho nvarchar(200),
	MaThuKho nvarchar(20),
	DiaChi nvarchar(100),
	DienThoai nvarchar(14),
	ThuKho nvarchar(30),
)
go
create table PhieuNhapKhoSP(
	MaPhieu nvarchar(20) primary key,	
	NgayNhap datetime,	
	GioNhap nvarchar(50),
	MaKho nvarchar(20) references KhoHang,
	MaNV nvarchar(20) references NhanVien,
	DienGiai nvarchar(200)
)

go
create table PhieuNhapKhoSP_MauHang (
	MaPhieu nvarchar(20) references PhieuNhapKhoSP,
	MaMau nvarchar(20) references MauHang,
	NgayNhap datetime,
	GioNhap nvarchar(50),
	primary key (MaPhieu, MaMau)
)
go
create table HoaDonBanHang(
	MaHD nvarchar(20) primary key,
	MaKH nvarchar(20) references KhachHang,
	MaNV nvarchar(20) references NhanVien,
	NgayXuat datetime,	
)
go
create table HoaDonBanHang_MauHang(
	MaHD nvarchar(20) references HoaDonBanHang,
	MaMau nvarchar(20) references MauHang,
	primary key(MaHD, MaMau)
)
go
create table NoiDungGiamTru(
	MaGiamTru nvarchar(20) primary key,
	NoiDung nvarchar(200),
	DVT nvarchar(20),	
)
go
create table HoaDonBanHang_NoiDungGiamTru(
	MaHD nvarchar(20) references HoaDonBanHang,
	MaGiamTru nvarchar(20) references NoiDungGiamTru,
	DonGia nvarchar(20),
	SoLuong nvarchar(100),
	ThanhTien nvarchar(20),
	GhiChu nvarchar(200),
	primary key(MaHD, MaGiamTru)
)
go
create table KhoanThanhToan (	
	MaKH nvarchar(20) references KhachHang,
	NgayTT datetime,
	SoTien nvarchar
)
go
create table DuNoKhachHang (	
	MaKH nvarchar(20) references KhachHang,
	Thang nvarchar(100),
	Nam nvarchar(100),
	SoTienNo nvarchar(100),	
	primary key (MaKH, Thang, Nam)
)
go


------------------------------------------------------------------------
-- Tao du lieu cho Module Quan Ly Kho Hang va No Nha Cung Cap
------------------------------------------------------------------------
create table NhaCungCap(
	MaNCC nvarchar(20) primary key,
	TenNCC nvarchar(200),
	MaSoThue nvarchar(20),
	NguoiDaiDien nvarchar(100),
	DiaChi nvarchar(200),
	DienThoai nvarchar(20)
)
go
create table VatTu(
	MaVatTu nvarchar(20) primary key,
	MaNCC nvarchar(20) references NhaCungCap,
	TenVatTu nvarchar(200),
	DVT nvarchar(20),
	NhomHangHoa nvarchar(20),
	QuyCach nvarchar(100),
	DonGia nvarchar(20),
)
go
create table ThietBi(
	MaThietBi nvarchar(20) primary key,
	MaNCC nvarchar(20) references NhaCungCap,
	TenThietBi nvarchar(200),
	DVT nvarchar(20),
	NhomHangHoa nvarchar(20),
	QuyCach nvarchar(100),
	ThoiGianKhauHao nvarchar(100),
	MucTrichKhauHao nvarchar(20),
	DonGia nvarchar(20)
)
go
create table PhieuNhapKhoVTTB(
	MaPhieu nvarchar(20) primary key,
	MaNCC nvarchar(20) references NhaCungCap,
	NguoiGiaoHang nvarchar(200),
	NgayNhap datetime,
	ThoiHanThanhToan datetime,		
	MaTienTe nvarchar(20),
	TyGia nvarchar(20),
	ChungTuGoc nvarchar(20)
)
go
create table PhieuNhapKhoVTTB_VatTu(
	MaPhieu nvarchar(20) references PhieuNhapKhoVTTB,
	MaVatTu nvarchar(20) references VatTu,	
)
go
create table PhieuNhapKhoVTTB_ThietBi(
	MaPhieu nvarchar(20) references PhieuNhapKhoVTTB,
	MaThietBi nvarchar(20) references ThietBi,	
)
go
create table PhieuThanhToanNCC(
	MaPhieu nvarchar(20) primary key,
	MaNCC nvarchar(20) references NhaCungCap,
	NgayThanhToan datetime,
	SoTien nvarchar(20)		
)
go
create table PhieuXuatVTTB(
	MaPhieu nvarchar(20) primary key,
	MaNV nvarchar(20) references NhanVien,
	MaCD nvarchar(20) references CongDoanSX,
	NgayXuat datetime,
	DienGiai nvarchar(200)
)
go
create table PhieuXuatVTTB_NVL(
	MaPhieu nvarchar(20) references PhieuXuatVTTB,
	MaVatTu nvarchar(20) references VatTu,
	SoLuong nvarchar
)
go
create table PhieuXuatVTTB_TB(
	MaPhieu nvarchar(20) references PhieuXuatVTTB,
	MaThietBi nvarchar(20) references ThietBi,
	SoLuong nvarchar
)

