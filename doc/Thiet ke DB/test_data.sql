use DentalLabo
------------------------------------------------------------------------
-- Tao du lieu de Test
------------------------------------------------------------------------
go
select * from BoPhan
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
select * from NhanVien
insert NhanVien values('NV1', 'BP1', 'Nhan vien 1', '0', '1984', '1234425', 'dia chi 1', 'dien thoai 1')
insert NhanVien values('NV2', 'BP1', 'Nhan vien 2', '0', '1984', '1234425', 'dia chi 2', 'dien thoai 2')
insert NhanVien values('NV3', 'BP2', 'Nhan vien 3', '0', '1984', '1234425', 'dia chi 3', 'dien thoai 3')
insert NhanVien values('NV4', 'BP2', 'Nhan vien 4', '0', '1984', '1234425', 'dia chi 4', 'dien thoai 4')
insert NhanVien values('NV5', 'BP1', 'Nhan vien 5', '0', '1984', '1234425', 'dia chi 5', 'dien thoai 5')

go
select * from KhoHang
insert KhoHang values('KH1', 'Kho hang 1', 'NV1', 'dia chi 1', 'dt 1', 'thu kho 1')
insert KhoHang values('KH2', 'Kho hang 2', 'NV2', 'dia chi 2', 'dt 2', 'thu kho 2')
insert KhoHang values('KH3', 'Kho hang 3', 'NV3', 'dia chi 3', 'dt 3', 'thu kho 3')



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
insert VatLieuPhu values('VLP1', 'Vat lieu phu 1', 'chiec', 1243)
insert VatLieuPhu values('VLP2', 'Vat lieu phu 2', 'ham', 1243)
insert VatLieuPhu values('VLP3', 'Vat lieu phu 3', 'dvt3', 1243)
insert VatLieuPhu values('VLP4', 'Vat lieu phu 4', 'dvt4', 100)

go
insert SanPham values('SP1', 'San pham 1', 'Tot', 'cai', 'nhom 1', 'ghi chu 1')
insert SanPham values('SP2', 'San pham 2', 'Tot', 'chiec', 'nhom 1', 'ghi chu 1')
insert SanPham values('SP3', 'San pham 3', 'Tot', 'rang', 'nhom 1', 'ghi chu 1')
insert SanPham values('SP4', 'San pham 4', 'Tot', 'ham', 'nhom 1', 'ghi chu 1')

go
insert SanPhamDatHang values('SPDH1', 'SP1', 'VLC1', 'VLP1', 20, 1,'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH2', 'SP1', 'VLC4', 'VLP1', 12, 2, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH3', 'SP2', 'VLC1', 'VLP2', 33, 5, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH4', 'SP3', 'VLC2', 'VLP2', 5, 1, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH5', 'SP4', 'VLC3', 'VLP2', 4, 5, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH6', 'SP2', 'VLC1', 'VLP2', 33, 5, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH7', 'SP3', 'VLC2', 'VLP2', 5, 1, 'Xanh', 'luu y 1', 'chi tiet 1')
insert SanPhamDatHang values('SPDH8', 'SP4', 'VLC3', 'VLP2', 4, 5, 'Xanh', 'luu y 1', 'chi tiet 1')



go
insert NhomKH values('NKH1', 'Nhom Khach Hang 1')
insert NhomKH values('NKH2', 'Nhom Khach Hang 2')
insert NhomKH values('NKH3', 'Nhom Khach Hang 3')

go
select * from KhachHang
insert KhachHang values('KH1', 'Khach hang 1', 0, '123124', 'ma so thue 1', 'nguoi dai dien 1', 'NKH1', 'dia chi 1')
insert KhachHang values('KH2', 'Khach hang 2', 0, '123124', 'ma so thue 2', 'nguoi dai dien 1', 'NKH1', 'dia chi 2')
insert KhachHang values('KH3', 'Khach hang 3', 0, '123124', 'ma so thue 3', 'nguoi dai dien 1', 'NKH2', 'dia chi 3')
insert KhachHang values('KH4', 'Khach hang 4', 0, '123124', 'ma so thue 4', 'nguoi dai dien 1', 'NKH2', 'dia chi 4')
insert KhachHang values('KH5', 'Khach hang 5', 0, '123124', 'ma so thue 5', 'nguoi dai dien 1', 'NKH1', 'dia chi 5')

go
insert MauHang values('MH1', 'KH1', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH2', 'KH1', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH3', 'KH1', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH4', 'KH2', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH5', 'KH2', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)
insert MauHang values('MH6', 'KH3', 'Co dinh', '2010-1-1', '2010-1-23', '14', '', 0)

go
insert MauHang_SanPhamDatHang values('MH1', 'SPDH1')
insert MauHang_SanPhamDatHang values('MH1', 'SPDH2')
insert MauHang_SanPhamDatHang values('MH1', 'SPDH3')
insert MauHang_SanPhamDatHang values('MH2', 'SPDH4')
insert MauHang_SanPhamDatHang values('MH3', 'SPDH5')
insert MauHang_SanPhamDatHang values('MH4', 'SPDH6')
insert MauHang_SanPhamDatHang values('MH4', 'SPDH5')
insert MauHang_SanPhamDatHang values('MH5', 'SPDH7')
insert MauHang_SanPhamDatHang values('MH6', 'SPDH8')

go
insert NoiDungGiamTru values('0', 'Giảm trừ theo % thanh toán', '%')
 
go
insert DuNoKhachHang values('KH1', '12', '2009', 0)
insert DuNoKhachHang values('KH2', '12', '2009', 0)
insert DuNoKhachHang values('KH3', '12', '2009', 0)
insert DuNoKhachHang values('KH4', '12', '2009', 0)
insert DuNoKhachHang values('KH5', '12', '2009', 0)
