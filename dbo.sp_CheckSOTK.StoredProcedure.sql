USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckSOTK]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[sp_CheckSOTK] 
	@SOTK NCHAR(9)
AS
BEGIN
	IF EXISTS (SELECT * FROM DBO.TAIKHOAN WHERE SOTK = @SOTK)
		RETURN 1
	ELSE
		BEGIN
			raiserror ( 'SOTK khong ton tai', 16, 1)
			RETURN 0
		END
END

GO
