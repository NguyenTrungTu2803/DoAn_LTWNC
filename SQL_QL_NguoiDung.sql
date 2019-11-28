Create DataBase QL_NguoiDung
go
Use QL_NguoiDung
go

------------------------Tạo bảng--------------------------
Create Table NguoiDung
(
	SDT nchar(11),
	MatKhau nchar(20),
	Email nchar(50),
	Ho nvarchar(20),
	Ten nvarchar(20),
	ViTriCV nvarchar(20),
	GhiChu nvarchar(30),
	DiaChi nvarchar(30),
	CMND nvarchar(11),
	Constraint pk_ND primary key(SDT)
	--Constraint pk_ND primary key(SDT, MatKhau, Email)
)
go
insert Into NguoiDung values('sadasd','asdasd','asd','asd','asd','asd','asda','asd','asd')
/*Create Table LoaiNguoiDung
(
	SDT NCHAR(11) not null,
	TenLoaiND NVARCHAR(30) not null
)
Go	 */

Create Table PhanQuyen
(
	SDT NCHAR(11) not null primary key,
	BanVe int,
	TKDonTraKhach int,
	QuanLyXe int,
	QuanLyHeThong int,
	ThongKe int
)
Go
/*Alter table LoaiNguoiDung 
Add Constraint pk_LoaiNguoiDung Primary Key(IDLoaiND)	*/

--Alter table PhanQuyen
--Add Constraint pk_PhanQuyen Primary Key(SDT)
--Go
																																			   
Alter table PhanQuyen
Add constraint fk_PQ_ND foreign key(SDT) references NguoiDung(SDT)


