﻿Use QuanLyNhanSu1
Go
 create proc TK_Vitri_Ma
 @MaVT nvarchar(50)

AS
BEGIN
	SELECT MaVT AS N'Mã vị trí', TenVT AS N'Tên vị trí'
	FROM VITRICONGVIEC
	WHERE MaVT like '%'+@MaVT+'%' 
END
GO
create proc TK_Vitri_Ten
@TenVT nvarchar(50)

AS
BEGIN
	SELECT MaVT AS N'Mã vị trí', TenVT AS N'Tên vị trí'
	FROM VITRICONGVIEC
	WHERE TenVT LIKE N'%' + @TenVT + N'%'
END

