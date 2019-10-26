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
	Constraint pk_ND primary key(SDT, MatKhau, Email)
)
go
select count(*) From NguoiDung where SDT = 'txtuser.Text' and MatKhau= 'txtPass.Text' and Email = 'txtemail.Text'
