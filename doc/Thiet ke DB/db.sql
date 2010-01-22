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
	DVT varchar(50), 
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
	MaNhomKH varchar(20) references NhomKH,
	DiaChiKH varchar(255)
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
	SoLuongVLC int,
	SoLuongVLP int, 
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

go
insert VatLieuChinh values('VLC1', 'Vat lieu chinh 1')
insert VatLieuChinh values('VLC2', 'Vat lieu chinh 2')
insert VatLieuChinh values('VLC3', 'Vat lieu chinh 3')
insert VatLieuChinh values('VLC4', 'Vat lieu chinh 4')

go
insert VatLieuPhu values('VLP1', 'Vat lieu phu 1', 1243)
insert VatLieuPhu values('VLP2', 'Vat lieu phu 2', 1243)
insert VatLieuPhu values('VLP3', 'Vat lieu phu 3', 1243)

go
insert SanPham values('SP1', 'San pham 1', 'Tot', 'cai', 'nhom 1', 'ghi chu 1')
insert SanPham values('SP2', 'San pham 2', 'Tot', 'chiec', 'nhom 1', 'ghi chu 1')
insert SanPham values('SP3', 'San pham 3', 'Tot', 'rang', 'nhom 1', 'ghi chu 1')
insert SanPham values('SP4', 'San pham 4', 'Tot', 'ham', 'nhom 1', 'ghi chu 1')

update SanPham set DVT = 'chiec' where MaSP = 'SP3'
update SanPham set DVT = 'rang' where MaSP = 'SP2'
update SanPham set DVT = 'ham' where MaSP = 'SP4'
go
insert SanPhamDatHang values('SPDH1', 'SP1', 'VLC1', 'VLP1', 20, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH2', 'SP1', 'VLC4', 'VLP1', 20, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH3', 'SP2', 'VLC1', 'VLP2', 20, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH4', 'SP3', 'VLC2', 'VLP2', 20, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH5', 'SP4', 'VLC3', 'VLP2', 20, 'Xanh', 'luu y 1', 'chi tiet 1')

go
insert NhomKH values('NKH1', 'Nhom Khach Hang 1')
insert NhomKH values('NKH2', 'Nhom Khach Hang 2')
insert NhomKH values('NKH3', 'Nhom Khach Hang 3')

go
insert KhachHang values('KH1', 'Khach hang 1', 0, '123124', 'ma so thue 1', 'nguoi dai dien 1', 'NKH1')
insert KhachHang values('KH2', 'Khach hang 2', 0, '123124', 'ma so thue 2', 'nguoi dai dien 1', 'NKH1')
insert KhachHang values('KH3', 'Khach hang 3', 0, '123124', 'ma so thue 3', 'nguoi dai dien 1', 'NKH2')
insert KhachHang values('KH4', 'Khach hang 4', 0, '123124', 'ma so thue 4', 'nguoi dai dien 1', 'NKH2')
insert KhachHang values('KH5', 'Khach hang 5', 0, '123124', 'ma so thue 5', 'nguoi dai dien 1', 'NKH1')

go
insert MauHang values('MH1', 'KH1', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH2', 'KH1', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH3', 'KH1', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)

go
insert MauHang_SanPhamDatHang values('MH1', 'SPDH1')
insert MauHang_SanPhamDatHang values('MH1', 'SPDH2')
insert MauHang_SanPhamDatHang values('MH1', 'SPDH3')
insert MauHang_SanPhamDatHang values('MH2', 'SPDH4')
insert MauHang_SanPhamDatHang values('MH3', 'SPDH5')

go
select * from PhieuNhapKhoSP
select * from PhieuNhapKhoSP_MauHang
delete from PhieuNhapKhoSP_MauHang

select * from MauHang

delete from MauHang where MaMau in ('MH5', 'MH6')

select * from VatLieuPhu
select * from MauHang
select * from MauHang_SanPhamDatHang where MaMau = 'MH1'
select * from SanPhamDatHang where MaSPDatHang = 'SPDH1'


delete SanPhamDatHang where MaSPDatHang in ('SPDH6', 'SPDH7', 'SPDH8')
select * from SanPham

select top 1 MaSP from SanPham where TenSP = 'San pham 1'

INSERT SanPhamDatHang Values('SPDH9', 'SP1', 'VLC1', '', 22, '', '', '')

select * from SanPhamDatHang where MaSPDatHang in (select MaSPDatHang from MauHang_SanPhamDatHang where MaMau = 'MH2')

update sanphamdathang set masp = 'sp3', mavlc = 'vlc2', mavlp = 'vlp2', soluong = 132 where maspdathang = 'spdh12'

select * from SanPhamDatHang
select * from MauHang_SanPhamDatHang 
select * from MauHang
select * from PhieuNhapKhoSP
select * from PhieuNhapKhoSP_MauHang

delete MauHang_SanPHamDatHang
delete PhieuNhapKhoSP_MauHang
delete PhieuNHapKHoSP
delete MauHang
delete SanPhamDatHang
