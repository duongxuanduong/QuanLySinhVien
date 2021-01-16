create table tblPhongHoc
(
	MaPhong varchar(4) primary key,
	SoCho int not null,
)
Go
Create table tblLop
(
	MaLop varchar(4) Primary Key,
	TenLop nvarchar(50) not null,
	NienKhoa varchar(10) not null,
	MaPhong varchar(4) not null,
	FOREIGN KEY (MaPhong) REFERENCES tblPhongHoc (MaPhong)
)
Go
Create table tblGiangVien
(
	MaGV varchar(4) Primary key,
	HoTen nvarchar(50) not null,
	NgaySinh varchar(10) not null,
	GioiTinh nvarchar(10) not null,
	DiaChi nvarchar(50) not null,
	SDT varchar(10) not null
)
Go
Create table tblSinhVien
(
	MaSV varchar(4) Primary key,
	HoTen nvarchar(50) not null,
	NgaySinh varchar(10) not null,
	GioiTinh nvarchar(10) not null,
	DiaChi nvarchar(50) not null,
	SDT varchar(10) not null,
	MaLop varchar(4) not null,
	FOREIGN KEY (MaLop) REFERENCES tblLop (Malop)
)
GO
Create table tblPhong_lop
(
	MaPhong varchar(4) not null,
	MaLop varchar(4) not null,
	HocKy varchar(10) not null,
	FOREIGN KEY (MaLop) REFERENCES tblLop (MaLop),
	FOREIGN KEY (MaPhong) REFERENCES tblPhongHoc (MaPhong)
)
create table tblTaiKhoan
(
	TenTK varchar(50) primary key,
	MatKhau  varchar(50) not null,
	ThongTin nvarchar(50) null,
	SDT varchar(10) null,
	Email varchar(50) null
)
select * from tblGiangVien
select * from tblSinhVien
select * from tblLop
select * from tblPhong_lop
select * from tblPhongHoc
insert into tblTaiKhoan
values ('admin','admin','abc','020','abc')
insert into tblPhongHoc
values ('A101',20)
insert into tblLop
values ('18T3',N'Lớp 18T3','2020','A101')
insert into tblPhong_lop
values ('A101','18T3','118')
insert into tblGiangVien
values ('GV01','abc','01/01/2000',N'Nam',N'abc','22')
insert into tblSinhVien
values('SV01',N'Phúc','06/01/2000',N'Nam','ABC','22','18T3')
