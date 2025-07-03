create database QuanLyNhaSach
use QuanLyNhaSach
go

SET DATEFORMAT dmy;

create table TAIKHOAN(
	MaTK int identity(1,1) primary key,
	TenDangNhap nvarchar(255) not null unique,
	MatKhau nvarchar(255) not null,
	LoaiTaiKhoan nvarchar(50) default N'Quản lý' not null,
	TenNguoiDung nvarchar(255) not null,
	GioiTinh nvarchar(3) default N'Nam' not null,
	NgaySinh Date not null,
	DiaChi nvarchar(255) not null,
	SoDT nvarchar(20) not null
)


create table KHACHHANG(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(255) not null,
	GioiTinh nvarchar(3) default N'Nam' not null,
	DiaChi nvarchar(255) not null,
	SoDT nvarchar(255) not null,
	TongTienChi int default 0 not null
)

create table SACH(
	MaSach int identity(1,1) primary key, 
	TenSach nvarchar(255) not null,
	TheLoai nvarchar(50) not null,
	TacGia nvarchar(255) not null,
	NXB nvarchar(255) not null,
	NgayXB date  not null,
	GiaGoc int default 0 not null,
	GiaBan int default 0 not null,
	TaiQuay int default 0 not null,
	TonKho int default 0 not null,
	DaBan int default 0 not null,
	constraint ck_GiaBan check (GiaGoc < GiaBan)
)


create table HOADON(
	MaHD int identity(1,1) primary key,
	MaKH int not null,
	MaNV int not null, 
	NgayLap smalldatetime not null,
	TongTien int default 0 not null,
	constraint fk_MaKH  foreign key (MaKH) references KHACHHANG(MaKH),
	constraint fk_MaNV  foreign key(MaNV) references TAIKHOAN(MaTK)
)

create table CTHD(
	MaHD int not null,
	MaSach int not null,
	SoLuong int default 0 not null,
	primary key(MaHD, MaSach),
	constraint fk_MaHD_CTHD foreign key(MaHD) references HOADON(MaHD),
	constraint fk_MaSach_CTHD foreign key(MaSach) references SACH(MaSach)
)


create table NHAPKHO(
	MaNK int identity(1,1) primary key, 
	MaThuKho int not null,
	NhaCC nvarchar(255) not null,
	NgayNhap smalldatetime not null,
	TongTien int default 0 not null,
	TTDuyet nvarchar(20) default N'Chờ duyệt' not null,
	constraint fk_MaThuKho foreign key(MaThuKho) references TAIKHOAN(MaTK) 
)

create table CTNHAPKHO(
	MaNK int not null,
	MaSach int not null,
	SoLuong int default 0 not null,
	primary key(MaNK, MaSach),
	constraint fk_MaNK_CTNK foreign key(MaNK) references NHAPKHO(MaNK),
	constraint fk_MaSach_CTNK foreign key(MaSach) references SACH(MaSach)
)

create table XUATKHO(
	MaXK int identity(1,1) primary key,
	MaNV int not null,
	NgayXuat smalldatetime not null,
	TTDuyet nvarchar(20) default N'Chờ duyệt' not null,
	constraint fk_MaNV_XUATKHO foreign key(MaNV) references TAIKHOAN(MaTK)
)


create table CTXUATKHO(
	MaXK int not null,
	MaSach int not null,
	SoLuong int default 0 not null,
	primary key(MaXK, MaSach),
	constraint fk_MaXK_CTXK foreign key(MaXK) references XUATKHO(MaXK),
	constraint fk_MaSach_CTXK foreign key(MaSach) references SACH(MaSach)
)


-- procedure
--Them tai khoan
create procedure USP_ThemTaiKhoan
@TenDangNhap nvarchar(255),
@MatKhau nvarchar(255),
@LoaiTaiKhoan nvarchar(50), 
@TenNguoiDung nvarchar(255), 
@GioiTinh nvarchar(3), 
@NgaySinh date, 
@DiaChi nvarchar(255), 
@SoDT nvarchar(20) 
as
begin
	insert into TAIKHOAN(TenDangNhap, MatKhau, LoaiTaiKhoan, TenNguoiDung ,GioiTinh ,NgaySinh, DiaChi, SoDT)
	values(@TenDangNhap, @MatKhau, @LoaiTaiKhoan, @TenNguoiDung, @GioiTinh , @NgaySinh, @DiaChi, @SoDT)
end


-- Xoa tai khoan
create procedure USP_XoaTaiKhoan
@MaTK int 
as
begin
	delete from TAIKHOAN 
	where MaTK = @MaTK
end

--Sua tai khoan
create procedure USP_SuaTaiKhoan
@MaTK int,
@TenDangNhap nvarchar(255),
@MatKhau nvarchar(255),
@LoaiTaiKhoan nvarchar(50), 
@TenNguoiDung nvarchar(255), 
@GioiTinh nvarchar(3), 
@NgaySinh date, 
@DiaChi nvarchar(255), 
@SoDT nvarchar(20) 
as
begin
	update TAIKHOAN
	set TenDangNhap = @TenDangNhap,
	MatKhau = @MatKhau,
	LoaiTaiKhoan = @LoaiTaiKhoan,
	TenNguoiDung = @TenNguoiDung,
	GioiTinh = @GioiTinh,
	NgaySinh = @NgaySinh,
	DiaChi = @DiaChi,
	SoDT = @SoDt
	where MaTK = @MaTK
end


--Danh sach tai khoan
create procedure USP_DanhSachTaiKhoan
as
begin
	select * from TAIKHOAN;
end

--Tai ten nhan vien 
create procedure USP_TaiTenNhanVienLen
as 
begin
	select MaTK, TenNguoiDung
	from TAIKHOAN
	where LoaiTaiKhoan = N'Nhân viên'
end

--TaiTenThuKhoLen
create procedure USP_TaiTenThuKhoLen
as
begin
	select MaTK, TenNguoiDung
	from TAIKHOAN
	where LoaiTaiKhoan = N'Thủ kho'
end

--Danh sach khach hang
create procedure USP_DanhSachKhachHang
as 
begin
	select * from KHACHHANG;
end

--Them khach hang
create procedure USP_ThemKhachHang
@TenKH nvarchar(255),
@GioiTinh nvarchar(3),
@DiaChi nvarchar(255),
@SoDT nvarchar(255)
as
begin
	insert into KHACHHANG(TenKH, GioiTinh, DiaChi, SoDT)
	values(@TenKH, @GioiTinh, @DiaChi, @SoDT);
end

--Xoa khach hang
create procedure USP_XoaKhachHang
@MaKH int 
as 
begin
	delete from KHACHHANG
	where MaKH = @MaKH;
end

--Sua khach hang
create procedure USP_SuaKhachHang
@MaKH int,
@TenKH nvarchar(255),
@GioiTinh nvarchar(3),
@DiaChi nvarchar(255),
@SoDT nvarchar(255)
as
begin
	update KHACHHANG
	set TenKH = @TenKH,
	GioiTinh = @GioiTinh,
	DiaChi = @DiaChi,
	SoDT = @SoDT
	where MaKH = @MaKH;
end

--Tai ten khach hang len
create procedure USP_TaiTenKhachHangLen
as
begin
	select MaKH, TenKH
	from KHACHHANG
end


--- Danh sach sach
create procedure USP_DanhSachSach
as
begin
	select * from SACH;
end

--Them sach
create procedure USP_ThemSach
@TenSach nvarchar(255),
@TheLoai nvarchar(50),
@TacGia nvarchar(255),
@NXB nvarchar(255),
@NgayXB date,
@GiaGoc int,
@GiaBan int
as
begin
	insert into SACH(TenSach, TheLoai, TacGia, NXB, NgayXB, GiaGoc, GiaBan)
	values(@TenSach, @TheLoai, @TacGia, @NXB, @NgayXB, @GiaGoc, @GiaBan);
end


--Xoa sach
create procedure USP_XoaSach
@MaSach int
as 
begin
	delete from SACH 
	where MaSach = @MaSach;
end

--Sua sach
create procedure USP_SuaSach
@MaSach int,
@TenSach nvarchar(255),
@TheLoai nvarchar(50),
@TacGia nvarchar(255),
@NXB nvarchar(255),
@NgayXB date,
@GiaGoc int,
@GiaBan int
as
begin
	update SACH
	set 
	TenSach = @TenSach,
	TheLoai = @TheLoai,
	TacGia = @TacGia,
	NXB = @NXB,
	NgayXB = @NgayXB,
	GiaGoc = @GiaGoc,
	GiaBan = GiaBan
	where MaSach = @MaSach
end

--Tim kiem sach 
create procedure USP_TimSachTheoTen
@TenSach nvarchar(255)
as
begin
	select * 
	from SACH
	where lower(TenSach) like '%' + lower(@TenSach) + '%';
end

--Tim kiem sach con tai quay
create procedure USP_TaiTenSachLen
as
begin
	select MaSach,TenSach
	from SACH
	where TaiQuay > 0;
end


--Lay gia goc sach
create procedure USP_LayGiaGocSach
@MaSach int 
as
begin
	select GiaGoc
	from SACH 
	where MaSach = @MaSach
end
--Lay don gia cua sach
create procedure USP_LayDonGiaSach
@MaSach int
as
begin
	select GiaBan 
	from SACH
	where MaSach = @MaSach;
end


--Lay danh sach sach 
create procedure USP_LayDanhSachSachTheoCTHD
@MaHD int 
as
begin
	select s.MaSach, TenSach, SoLuong, (GiaBan) as DonGia, (SoLuong*GiaBan) as ThanhTien
	from SACH s
	join CTHD ct on s.MaSach = ct.MaSach 
	where MaHD = @MaHD
end

--Lay so sach ton kho
create procedure USP_LayTonKhoSach
@MaSach int
as
begin
	select TonKho
	from SACH 
	where MaSach = @MaSach
end
--Lay so sach tai quay
create procedure USP_LayTaiQuaySach
@MaSach int
as
begin
	select TaiQuay
	from SACH 
	where MaSach = @MaSach
end

--Them hoa don
create procedure USP_ThemHoaDon
@MaKH int, 
@MaNV int,
@NgayLap smalldatetime,
@TongTien int
as
begin
	insert into HOADON(MaKH, MaNV, NgayLap, TongTien)
	values(@MaKH, @MaNV, @NgayLap, @TongTien)
end


--Xoa hoa don
create procedure USP_XoaHoaDon
@MaHD int
as
begin
	delete from HOADON
	where MaHD = @MaHD
end

--Sua hoa don
create procedure USP_SuaHoaDon
@MaHD int, 
@MaKH int, 
@MaNV int
as
begin
	update HOADON
	set
	MaKH = @MaKH,
	MaNV = @MaNV
	where MaHD = @MaHD
end


--Them CTHD 
create procedure USP_ThemCTHD
@MaHD int,
@MaSach int,
@SoLuong int
as
begin
	insert into CTHD(MaHD, MaSach, SoLuong)
	values(@MaHD, @MaSach, @SoLuong)
end

--Xoa CTHD 
create procedure USP_XoaCTHD
@MaHD int
as
begin
	delete from CTHD 
	where MaHD = @MaHD;
end


-- Lay danh sach hoa don
create procedure USP_LayDanhSachHoaDon
as
begin
	select MaHD, hd.MaKH, TenKH, hd.MaNV, TenNguoiDung as TenNhanVien, NgayLap, TongTien
	from HOADON hd
	join TAIKHOAN tk on hd.MaNV = tk.MaTK
	join KHACHHANG kh on hd.MaKH = kh.MaKH;
end


-- Lay danh sach hoa don theo ma
create procedure USP_LayDanhSachHoaDonTheoMa
@MaHD int
as
begin
	select hd.MaHD, hd.MaKH, TenKH, hd.MaNV, TenNguoiDung as TenNhanVien, NgayLap, TongTien
	from HOADON hd
	join TAIKHOAN tk on hd.MaNV = tk.MaTK
	join KHACHHANG kh on hd.MaKH = kh.MaKH
	where MaHD = @MaHD;
end

-- Thong ke doanh thu
create procedure USP_ThongKeDoanhThu
@NgayBatDau smalldatetime,
@NgayKetThuc smalldatetime
as
begin
	select convert(date, NgayLap) as NgayLap, sum(TongTien) as TongTien
	from HOADON
	where NgayLap between @NgayBatDau and @NgayKetThuc
	group by convert(date, NgayLap)
end

select * from HOADON

exec USP_ThongKeDoanhThu '2025-06-14 16:42:00', '2025-06-18 16:42:00'
--them phieu nhap kho
create procedure USP_ThemPhieuNhapKho
@MaThuKho int,
@NhaCC nvarchar(255), 
@NgayNhap smalldatetime,
@TongTien int
as	
begin
	insert into NHAPKHO(MaThuKho, NhaCC, NgayNhap, TongTien)
	values(@MaThuKho, @NhaCC, @NgayNhap, @TongTien)
end


--xoa phieu nhap kho
create procedure USP_XoaPhieuNhapKho
@MaNK int
as	
begin
	delete from NHAPKHO 
	where MaNK = @MaNK
end

-- cap nhat trang thai cho nhap kho
create procedure USP_CapNhatTrangThaiNhapKho
@MaNK int 
as
begin
	update NHAPKHO
	set TTDuyet = N'Đã duyệt'
	where MaNK = @MaNK
end

-- lay danh sach nhap kho
create procedure USP_LayDanhSachNhapKho
as
begin
	select MaNK, TenNguoiDung as TenThuKho, NhaCC, TongTien, TTDuyet
	from NHAPKHO nk
	join TAIKHOAN tk on nk.MaThuKho = tk.MaTK;
end


--them chi tiet nhap kho
create procedure USP_ThemCTNhapKho
@MaNK int,
@MaSach int,
@SoLuong int
as 
begin
	insert into CTNHAPKHO(MaNK, MaSach, SoLuong)
	values(@MaNK, @MaSach, @SoLuong)
end 

-- danh sach chi tiet nhap kho
create procedure USP_LayDanhSachCTNhapKho
@MaNK int
as
begin
	select ct.MaSach, TenSach, SoLuong, GiaGoc, SoLuong*GiaGoc as ThanhTien
	from CTNHAPKHO ct 
	join SACH s on ct.MaSach = s.MaSach
	where MaNK = @MaNK
end


--xoa chi tiet nhap kho
create procedure USP_XoaCTNhapKho
@MaNK int
as 
begin
	delete from CTNHAPKHO
	where MaNK = @MaNK
end 



--them phieu xuat kho
create procedure USP_ThemPhieuXuatKho
@MaNV int,
@NgayXuat smalldatetime
as	
begin
	insert into XUATKHO(MaNV, NgayXuat)
	values(@MaNV, @NgayXuat)
end


-- lay danh sach xuat kho 
create procedure USP_LayDanhSachXuatKho
as
begin
	select MaXK, TenNguoiDung as TenNhanVien, TTDuyet
	from XUATKHO xk
	join TAIKHOAN tk on xk.MaNV = tk.MaTK;
end

-- them Chi tiet xuat kho
create procedure USP_ThemCTXuatKho
@MaXK int,
@MaSach int,
@SoLuong int
as 
begin
	insert into CTXUATKHO(MaXK, MaSach, SoLuong)
	values(@MaXK, @MaSach, @SoLuong)
end 

-- lay danh sach chi tiet xuat kho
create procedure USP_LayDanhSachCTXuatKho
@MaXK int
as
begin
	select ct.MaSach, TenSach, SoLuong
	from CTXUATKHO ct 
	join SACH s on ct.MaSach = s.MaSach
	where MaXK = @MaXK
end

--xoa xuat kho
create procedure USP_XoaPhieuXuatKho
@MaXK int
as
begin
	delete from XUATKHO
	where MaXK = @MaXK
end

--cap nhat trang thai cho xuat kho
create procedure USP_CapNhatTrangThaiXuatKho
@MaXK int
as 
begin	
	update XUATKHO
	set TTDuyet = N'Đã duyệt'
	where MaXK = @MaXK
end

--xoa chi tiet xuat kho
create procedure USP_XoaCTXuatKho
@MaXK int
as 
begin
	delete from CTXUATKHO
	where MaXK = @MaXK
end 


---Trigger
--tao trigger cap nhat TongTien cho bang HOADON
create trigger TRG_CapNhatTongTienChi_i
on HOADON
after insert
as
begin
	update KHACHHANG
	set TongTienChi =  TongTienChi + TongTien
	from inserted i 
	join KHACHHANG kh on kh.MaKH = i.MaKH
end

create trigger TRG_CapNhatTongTienChi_d
on HOADON
after delete
as
begin
	update KHACHHANG
	set TongTienChi = TongTienChi - TongTien
	from deleted d 
	join KHACHHANG kh on kh.MaKH = d.MaKH
end

create trigger TRG_CapNhatTongTienChi_u
on HOADON
after update 
as
begin
	update KHACHHANG 
	set TongTienChi = TongTienChi + i.TongTien
	from inserted i
	join deleted d on i.MaHD = d.MaHD
	join KHACHHANG kh on i.MaKH = kh.MaKH

	update KHACHHANG 
	set TongTienChi = TongTienChi - d.TongTien
	from inserted i
	join deleted d on i.MaHD = d.MaHD
	join KHACHHANG kh on kh.MaKH = d.MaKH
end

--Tao trigger XoaCTHD cho bang HOADON
create trigger TRG_XoaCTHD
on HOADON
instead of delete
as
begin
	declare @MaHD int
	select @MaHD = MaHD 
	from deleted
	delete from CTHD 
	where @MaHD in (
		select MaHD 
		from CTHD
	)
	delete from HOADON
	where MaHD = @MaHD;
end


--tao trigger xoa tai quay cho bang ChiTietHoaDon
create trigger TRG_XoaTaiQuay_i
on CTHD
after insert
as 
begin
	update SACH
	set TaiQuay = TaiQuay - SoLuong,
	DaBan = DaBan + SoLuong
	from SACH s 
	join inserted i on s.MaSach = i.MaSach
end

create trigger TRG_XoaTaiQuay_d
on CTHD
after delete 
as
begin
	update SACH
	set TaiQuay = TaiQuay + SoLuong,
	DaBan = DaBan - SoLuong
	from SACH s 
	join deleted d on s.MaSach = d.MaSach
end

-- tao trigger XoaCTNK cho bang NhapKho
create trigger TRG_XoaCTNK
on NHAPKHO
instead of delete
as
begin
	delete from CTNHAPKHO 
	where MaNK in (
		select MaNK from deleted
	)

	delete from NHAPKHO
	where MaNK in (
		select MaNK from deleted
	)
end

--tao trigger khong cho xoa khi da duyet
create trigger TRG_XoaNhapKho
on NHAPKHO
after delete
as 
begin	
	if exists(
		select *
		from deleted d 
		where TTDuyet = N'Đã duyệt'
	)
		rollback transaction
end

---tao trigger update TTDuyet cho NhapKho
create trigger TRG_TTDuyet_u
on NHAPKHO
after update
as
begin
	if exists(
		select * 
		from inserted i
		join deleted d on i.MaNK = d.MaNK
		where i.TTDuyet = N'Đã duyệt' and d.TTDuyet = N'Chờ duyệt'
	)
	begin
		update SACH
		set TonKho = TonKho + SoLuong
		from SACH s
		join CTNHAPKHO ct on s.MaSach = ct.MaSach
		join inserted i on ct.MaNK = i.MaNK
		join deleted d on i.MaNK = d.MaNK
	end
end


--Tao trigger ThemTonKho cho bang CTNK
create trigger TRG_ThemTonKho_iu
on CTNHAPKHO
after insert
as
begin
	if exists(
		select *
		from inserted i
		join NHAPKHO nk on i.MaNK = nk.MaNK
		where TTDuyet = N'Chờ duyệt'
	)
		return;

	update SACH
	set TonKho = TonKho +  SoLuong
	from SACH s 
	join inserted i on s.MaSach = i.MaSach
	
end

create trigger TRG_ThemTonKho_d
on CTNHAPKHO
after delete
as
begin
	if exists(
		select *
		from deleted d
		join NHAPKHO nk on d.MaNK = nk.MaNK
		where TTDuyet = N'Chờ duyệt'
	)
		return;

	update SACH
	set TonKho = TonKho - SoLuong
	from SACH s
	join deleted d on s.MaSach = d.MaSach

end


--tao trigger khong cho xoa khi da duyet 
create trigger TRG_XoaXuatKho 
on XUATKHO
after delete
as
begin
	if exists(
		select * 
		from deleted d 
		where TTDuyet = N'Đã duyệt'
	)
		rollback transaction
end

---tao trigger update TTDuyet cho XUATKHO
create trigger TRG_TTDuyet_u_XuatKho
on XUATKHO
after update
as
begin
	if exists(
		select * 
		from inserted i
		join deleted d on i.MaXK = d.MaXK
		where i.TTDuyet = N'Đã duyệt' and d.TTDuyet = N'Chờ duyệt'
	)
	begin
		update SACH
		set TaiQuay = TaiQuay + SoLuong,
		TonKho = TonKho - SoLuong
		from SACH s
		join CTXUATKHO ct on s.MaSach = ct.MaSach
		join inserted i on ct.MaXK = i.MaXK
		join deleted d on i.MaXK = d.MaXK
	end
end


--tao trigger ThemTaiQuay cho bang CTXuatKho
create trigger TRG_ThemTaiQuay_iu
on CTXUATKHO
after insert
as 
begin
	if exists(
		select * 
		from inserted i
		join XUATKHO xk on i.MaXK = xk.MaXK
		where TTDuyet = N'Chờ duyệt'
	)
		return;
	
	update SACH
	set TaiQuay = TaiQuay +  SoLuong,
	TonKho = TonKho - SoLuong
	from SACH s 
	join inserted i on s.MaSach = i.MaSach
end


create trigger TRG_ThemTaiQuay_d
on CTXUATKHO
after delete
as
begin
	if exists(
		select * 
		from deleted d
		join XUATKHO xk on d.MaXK = xk.MaXK
		where TTDuyet = N'Chờ duyệt'
	)
		return;
	
	update SACH
	set TonKho = TonKho + SoLuong,
	TaiQuay = TaiQuay - SoLuong
	from SACH s
	join deleted d on s.MaSach = d.MaSach

end

-- tao trigger XoaCTXK cho bang XuatKho
create trigger TRG_XoaCTXK
on XUATKHO
instead of delete
as
begin
	delete from CTXUATKHO 
	where MaXK in (
		select MaXK from deleted
	)

	delete from XUATKHO
	where MaXK in (
		select MaXK from deleted
	)
end


