USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_themKH]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_themKH]
	@CMND nvarchar(9), @HO nvarchar(30), @TEN nvarchar(9), @DIACHI nvarchar(200), @PHAI nvarchar(3), @SODT nvarchar(9), @MACN nvarchar(9)
AS
BEGIN
	if exists(SELECT 1 FROM LINK.NGANHANG.dbo.[KHACHHANG] WHERE CMND= @CMND)
	BEGIN
		raiserror('CMND đã tồn tại',16,1)
		return 1;
	END
	ELSE
		INSERT INTO [KHACHHANG] (CMND, HO, TEN, DIACHI, PHAI, NGAYCAP, SODT, MACN) VALUES(@CMND,@HO,@TEN,@DIACHI,@PHAI,GETDATE(),@SODT,@MACN) 
END

GO
