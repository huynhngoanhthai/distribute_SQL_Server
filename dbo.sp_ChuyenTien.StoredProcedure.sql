USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_ChuyenTien]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ChuyenTien] @SOTK_CHUYEN NCHAR(9), @SOTIEN MONEY,  @SOTK_NHAN NCHAR(9), @MANV NCHAR(10)
AS

SET XACT_ABORT ON
BEGIN TRANSACTION
	BEGIN TRY
	    if exists(SELECT 1 FROM TaiKhoan WHERE SOTK=@SOTK_NHAN)
		BEGIN	
			INSERT INTO GD_CHUYENTIEN (SOTK_CHUYEN, SOTIEN, SOTK_NHAN, MANV)
			VALUES ( @SOTK_CHUYEN, @SOTIEN, @SOTK_NHAN, @MANV)
			EXEC sp_CalSODU @SOTK_CHUYEN, @SOTIEN, 'GIAM'
			EXEC sp_CalSODU @SOTK_NHAN, @SOTIEN, 'TANG'
			COMMIT
		END
		ELSE
		BEGIN
		  RAISERROR('SOTK KHONG TON TAI', 16, 1);
		END
	END TRY

	BEGIN CATCH
	   ROLLBACK
	   RAISERROR('SODU không đủ hoặc SOTK không tồn tại', 16, 1);
	END CATCH


-- EXEC [dbo].[sp_ChuyenTien] '9999900', 60000, '32288800 ', '222'
GO
