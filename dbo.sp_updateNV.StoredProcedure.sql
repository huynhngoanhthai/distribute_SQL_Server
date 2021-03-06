USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateNV]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateNV]
	@MANV nchar(10),
	@HO nvarchar(40),
	@TEN nvarchar(10),
	@DIACHI nvarchar(100),
	@PHAI nvarchar(3),
	@SODT nvarchar(15),
	@loginName VARCHAR(50),
	@pass  NVARCHAR(50)	
AS
BEGIN
	IF (@pass = '')
	BEGIN
		UPDATE NhanVien SET HO = @HO, TEN = @TEN , DIACHI=@DIACHI,PHAI=@PHAI,SODT=@SODT WHERE MANV = @MANV
	END
	ELSE 
	BEGIN 
	    UPDATE NhanVien SET HO = @HO, TEN = @TEN , DIACHI=@DIACHI,PHAI=@PHAI,SODT=@SODT WHERE MANV = @MANV
		EXEC sp_password NULL,@pass ,@loginName
	END
END
-- EXEC sp_updateNV '222','Huynh Anh','thai', 'Dong thap','NAM','0822946299','thai','123456'

GO
