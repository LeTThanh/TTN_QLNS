Use QuanLyNhanSu1
Go
 create proc TK_Vitri_Ma
 @MaVT nvarchar(50)

AS
BEGIN
	SELECT MaVT AS N'M� V? tr�', TenVT AS N'T�n v? tr�'
	FROM VITRICONGVIEC
	WHERE MaVT like '%'+@MaVT+'%' 
END
GO
create proc TK_Vitri_Ten
@TenVT nvarchar(50)

AS
BEGIN
	SELECT MaVT AS N'M� v? tr�', TenVT AS N'T�n v? tr�'
	FROM VITRICONGVIEC
	WHERE TenVT LIKE N'%' + @TenVT + N'%'
END

