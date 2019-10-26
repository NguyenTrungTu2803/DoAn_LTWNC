	CREATE DATABASE QL_NhanVien
	GO
	USE QL_NhanVien
	GO
	/*CREATE TABLE ACCOUNT
	(
		Username NVARCHAR(30) NOT NULL DEFAULT N'Ten',
		password  NVARCHAR(30) NOT NULL DEFAULT 0 ,
		typ INT NOT NULL DEFAULT 0
	)
	INSERT INTO dbo.ACCOUNT
	VALUES (N'Trung Tu', N'123', 1 )
	SELECT * FROM dbo.ACCOUNT
	GO
	CREATE PROC USP_LOGIN  --load csdl lên để kiểm tra login
	@Username NVARCHAR(30), @password NVARCHAR(30)
	AS
	BEGIN
		SELECT * FROM dbo.ACCOUNT WHERE Username = @Username AND password = @password
	END
	GO*/

	-----------------------------------------------------------------------
	CREATE TABLE ACCOUNTDAILY
	(
		Id NCHAR(30) NOT NULL,
		Ho nvarchar(30),
		Email nchar(60),
		Name NVARCHAR(30) NOT NULL,
		password NVARCHAR(30) NOT NULL,
		GioiTinh NVARCHAR(5),
		SDT NVARCHAR(12),
		IDLoaiND NCHAR(30) NOT NULL
	)
	GO

	Create Table LoaiNguoiDung
	(
		IDLoaiND NCHAR(30) not null,
		TenLoaiND NVARCHAR(30) not null
	)
	Go

	Create Table PhanQuyen
	(
		IdNhanVien NCHAR(30) not null,
		NguoiDung int not null,
		Xe int not null,
		TuyenXe int not null,
		ThoiDiem int not null,
		ChuyenXe int not null,
		BanVe int not null
	)
	Go
	---------------------------------Khóa chính-----------------------------------------------
	Alter Table ACCOUNTDAILY
		Add constraint pk_ACCOUNTDAILY Primary Key (Id)

	Alter table PhanQuyen
		Add Constraint pk_PhanQuyen Primary Key(IdNhanVien, Xe, TuyenXe, ThoiDiem, ChuyenXe, BanVe)

	Alter table LoaiNguoiDung 
		Add Constraint pk_LoaiNguoiDung Primary Key(IDLoaiND)
	---------------------------------Khóa ngoại------------------------------------------------
	Alter table ACCOUNTDAILY 
	Add constraint fk_ACCOUNTDAILY_LoaiNguoiDung foreign key(IDLoaiND) references LoaiNguoiDung(IDLoaiND)
	Go
																																			   
	Alter table PhanQuyen
	Add constraint fk_PhanQuyen_ACCOUNTDAILY foreign key(IdNhanVien) references ACCOUNTDAILY(Id)
	Go
	-----------------------------------Hàm Fuction---------------------------------------------
	CREATE FUNCTION AddmaIdAcounut(@makt char(2))
	RETURNS char(6)
	AS
	BEGIN 
		DECLARE @iMaso int 
  		DECLARE @vMaso varchar(9) 
  		IF @makt='ID' SET @iMaso= (SELECT MAX(RIGHT(Id, 4)) FROM ACCOUNTDAILY)  	
		IF (@iMaso IS NULL) SET @vMaso= @makt+ CONVERT(varchar(6),'0001')
		ELSE
		BEGIN
			SET @iMaso= @iMaso+1
	    		SET @vMaso= '000'+ CONVERT(varchar,@iMaso) 
	    		SET @vMaso= @makt+ RIGHT(@vMaso,4)
		END
	RETURN @vMaso 
	END
	go
	-----------------------------------Thêm dữ liệu--------------------------------------------
	Insert Into LoaiNguoiDung values('Admin',N'Administrator')
	Insert Into LoaiNguoiDung values('Quan_Ly',N'Quản Lý')
	Insert Into LoaiNguoiDung values('Nhan_Vien',N'Nhân Viên')

	ALTER TABLE ACCOUNTDAILY ADD CONSTRAINT def_Id DEFAULT dbo.AddmaIdAcounut('ID') FOR Id
	GO
	INSERT INTO ACCOUNTDAILY(Ho, Email, Name, password, GioiTinh, SDT, IDLoaiND) VALUES(N'Nguyen', 'Nguyentrungtu0808', N'Tú', '123', N'Nam', '098576', 'Admin')


