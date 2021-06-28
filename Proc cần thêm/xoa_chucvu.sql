use QuanLyNhanSu1
go

create or alter proc XoaCV
@maCV nvarchar(20)
as
begin
update NHANVIEN_CHUCVU set MaCV = null where MaCV = @maCV;
delete CHUCVU where MaCV = @maCV
end
