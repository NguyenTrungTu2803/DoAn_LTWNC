	CREATE DATABASE QL_BanVe																	 
	GO
	USE QL_BanVe
	GO

	Create Table DoanhThuNam
	(
		MaDTN nchar(10) not null,
		TongTien float,
		TiLe float
	)
	Create Table DoanhThuThang
	(
		MaDTT nchar(10) not null,
		MaDTN nchar(10) not null,
		TongTien float
	)
	Create Table Xe
	(	
		SoXe nchar(10) not null,
		TenXe nvarchar(30),
		HieuXe nvarchar(15),
		SoChoNgoi int
	)
	Create Table TuyenXe
	(
		MaTuyen nchar(10) not null,
		TenTuyen nvarchar(30),
		DiaDiemDi nvarchar(30),
		DiaDiemDen nvarchar(30)
	)
	Create Table ChuyenXe
	(
		MaChuyen nchar(10) not null,
		NgayDi date,
		giodi char(10),
		MaTuyen nchar(10) not null,
		GiaTien money
	)
	Create Table CTTuyenXe_ChuyenXe
	(
		MaChuyen nchar(10) not null,
		MaTuyen nchar(10) not null
	)
	Create Table CTChuyenXe_Xe
	(
		SoXe nchar(10) not null,
		MaChuyen nchar(10)not null
	)
	Create Table TaiXe
	(
		CMND nchar(10)not null,
		TenTX nvarchar(30),
		SDT char(11),
		DiaChi nvarchar(50)
	)
	Create Table CTTaiXe_Xe
	(
		CMND nchar(10)not null,
		SoXe nchar(10)not null
	)
	Create Table Xe7Cho
	(
		IdSoGhe Nchar(10)not null,
		SoXe nchar(10),
		TenGhe nchar(10)
	)
	GO
	Create Table Xe16Cho
	(
		IdSoGhe Nchar(10)not null,
		TenGhe 	nchar(10),
		SoXe nchar(10)
	)
	Create Table BanVe
	(
		MaVe nchar(10)not null,
		MaChuyen nchar(10),
		SoXe nchar(10)
	)
	Create Table LyDo
	(
		MaLD nchar(10)not null,
		TenLyDo nvarchar(30),
		UocTinh money
	)
	Create Table HoanVe
	(
		MaVe nchar(30)not null,
		MaLD nchar(30)not null
	)

	Create Table CTKH_BanVe
	(
		MaVe nchar(10)not null,
		MaKH nchar(10)not null,
		SoLuongVe int
	)
	Create Table KhachHang
	(
		MaKH nchar(10)not null,
		TenKH nvarchar(20),
		SDT nchar(11),
		DiaChi nvarchar(50),
		DiaDiemDon nvarchar(30),
		DiaDiemTra nvarchar(30)
	)
---------------------------------------- Tạo khóa chính ---------------------------------------------

	Alter table DoanhThuNam 
	Add Constraint pk_DTN Primary Key(MaDTN)

	Alter table DoanhThuThang 
	Add Constraint pk_DTT Primary Key(MaDTT)
	Alter table Xe 
	Add Constraint pk_Xe Primary Key(SoXe)

	Alter Table ChuyenXe
	Add Constraint pk_ChuyenXe Primary Key(MaChuyen)

	Alter table CTTuyenXe_ChuyenXe
	Add constraint pk_ChiTietTuyen primary key(MaChuyen, MaTuyen)

	Alter table TuyenXe 
	Add constraint pk_TuyenXe primary key(MaTuyen)

	Alter table BanVe 
	Add constraint pk_BanVe primary key(MaVe)

	Alter table Xe7Cho 
	Add constraint pk_7cho primary key(IdSoGhe)

	Alter table Xe16Cho 
	Add constraint pk_16cho primary key(IdSoGhe)

	Alter table LyDo
	Add constraint pk_LD primary key(MaLD)

	Alter Table TaiXe
	Add constraint pk_TX primary key(MaTX)

	Alter Table KhachHang
	Add constraint pk_kh primary key(MaKH)

	Alter Table HoanVe
	Add constraint pk_hv primary key(MaVe, MaLD)

	Alter Table CTKH_BanVe
	Add constraint pk_ct primary key(MaVe, MaKH)

	Alter Table CTChuyenXe_Xe
	Add constraint pk_ctcx primary key(MaChuyen,SoXe)

	Alter Table CTTaiXe_Xe
	Add constraint pk_cttx primary key(CMND, SoXe)

-------------------------------------------Tạo khóa ngoại --------------------------------------------