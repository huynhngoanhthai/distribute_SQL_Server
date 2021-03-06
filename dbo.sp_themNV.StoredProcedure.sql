USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_themNV]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themNV] @MANV nchar(10),
	@HO nvarchar(40),
	@TEN nvarchar(10),
	@DIACHI nvarchar(100),
	@PHAI nvarchar(3),
	@SODT nvarchar(15),
	@MACN nchar(10),

	@loginName  VARCHAR(50),
	@pass  VARCHAR(50)
	--userName = MANV

	
AS
BEGIN
 DECLARE @RET INT
	IF exists(select MANV from LINK.NGANHANG.dbo.NHANVIEN where MANV=@MANV)
	BEGIN
		raiserror ( 'Mã nhân viên đã tồt tại', 16, 1)
	RETURN 1;
	END
		
		EXEC @RET=[dbo].[sp_TaoTaiKhoan] @loginName,@pass,@MANV,'CHINHANH'
		IF @RET = 1 OR @RET= 2
		BEGIN 
			raiserror ( 'tên login bị trùng', 16, 1)
			RETURN 2;
		END
		ELSE 
			INSERT INTO [NHANVIEN] (MANV, HO, TEN, DIACHI, PHAI, SODT, MACN,TrangThaiXoa) VALUES(@MANV,@HO,@TEN,@DIACHI,@PHAI,@SODT,@MACN,0);
END	

-- EXEC [dbo].[sp_themNV] '111','huynh','thai','lapvo','NAM','0923204647','CN1','thai','123456'
GO
