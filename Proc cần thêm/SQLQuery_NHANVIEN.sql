

CREATE OR ALTER      proc [dbo].[xoa1NV]
@ma nchar(10)
as begin
if(select COUNT(*)from NHANVIEN where MANV =@MA)=0
print(N'Không có nhân viên này mời nhập lại thông tin')
else
begin
delete NHANVIEN where MANV=@ma
print(N'Xóa nhân viên thành công')
end
end
GO



CREATE OR ALTER         proc [dbo].[Capnhatthongtin] (@MANV nchar(10),@HOTEN nvarchar(50), @bangcap nvarchar(50),@GIOITINH nchar(3) ,@Ngaysinh date,@DIACHI nvarchar(200), @mapb nchar(10), @CMTND nchar(20), @SDT nchar(11) , @dantoc nvarchar(11), @tongiao nvarchar(11), @manv_cu nchar(10))
as begin
if(select count(manv)from NHANVIEN where MANV= @manv_cu)=0
print(N'Không có nhân viên cần sửa')
else
begin
update NHANVIEN set MANV=@MANV,  HOTEN=@HOTEN, BangCap=@bangcap,
                                   NGAYSINH=@Ngaysinh,
                                   SDT=@SDT,
                                   GIOITINH=@GIOITINH,
     DIACHI=@DIACHI, DanToc=@dantoc, MaPB=@mapb, CMTND=@CMTND, TonGiao=@tongiao
where MANV=@manv_cu
print(N'Đã sửa thông tin nhân viên thành công')
end
end
GO



CREATE OR ALTER    proc [dbo].[themNV]
@MANV nchar(10),@HOTEN nvarchar(50), @bangcap nvarchar(50),@GIOITINH nchar(3) ,@Ngaysinh date,@DIACHI nvarchar(200), @mapb nchar(10), @CMTND nchar(20), @SDT nchar(11) , @dantoc nvarchar(11), @tongiao nvarchar(11)
as begin 
if(select COUNT(*)from NHANVIEN where MANV =@MANV)>0
begin
print(N'Đã có mã nhân viên này mời nhập lại')
end
else
begin
insert  into dbo.NHANVIEN(MANV,HoTen, BangCap,GIOITINH,NGAYSINH,DIACHI, MaPB, CMTND,SDT,DanToc,
TonGiao)
values(@MANV,@HOTEN,@bangcap,@GIOITINH,@NGAYSINH,@DIACHI, @mapb, @CMTND,@SDT, @dantoc,@tongiao)
print(N'Đã thêm nhân viên thành công')
end
end
GO


CREATE OR ALTER proc [dbo].[timkiemnv] @ma nvarchar(10), @ten nvarchar(50)
as begin
if(@ma <> '' and @ten = '')
begin
Select manv as N'Mã nhân viên', hoten as N'Họ và tên', bangcap as N'Bằng cấp', gioitinh as N'Giới tính', ngaysinh N'Ngày sinh', diachi as N'Địa chỉ', mapb as N'Mã phòng ban', cmtnd as N'Số CCCD', sdt as N'Số điện thoại', dantoc as N'Dân tộc', tongiao as N'Tôn giáo' from NHANVIEN where MaNV like '%'+ @ma +'%'
end
if(@ma = '' and @ten <> '')
begin
Select manv as N'Mã nhân viên', hoten as N'Họ và tên', bangcap as N'Bằng cấp', gioitinh as N'Giới tính', ngaysinh N'Ngày sinh', diachi as N'Địa chỉ', mapb as N'Mã phòng ban', cmtnd as N'Số CCCD', sdt as N'Số điện thoại', dantoc as N'Dân tộc', tongiao as N'Tôn giáo' from NHANVIEN where HoTen like '%' + @ten +'%'
end
end
GO

--select * from HDLD

create or alter trigger xoanhanvien on nhanvien instead of delete
as
begin
declare @ma nchar(10)
select @ma=manv from deleted
delete NHANVIEN_CHUCVU where MaNV =@ma
delete DANGNHAP where MaNV =@ma
delete NHANVIEN_VITRI where MaNV =@ma
delete HDLD where MaNV =@ma
end
