USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaNV]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_xoaNV]
	@MaNV nvarchar(9)
AS
BEGIN
	
			DECLARE @LGNAME VARCHAR(50),@REP INT

			SELECT @LGNAME = name FROM sys.sql_logins WHERE SID =
																	 (SELECT sid  from sys.sysusers WHERE name = @MaNV )

			EXEC @REP=SP_DROPUSER @MaNV
			IF @REP = 1 OR @REP = 2
			BEGIN
				RETURN 1
			END	
			ELSE
			BEGIN
				EXEC SP_DROPLOGIN @LGNAME
				update NhanVien SET TrangThaiXoa = 1 WHERE MANV = @MaNV
			END	

END
--EXEC [dbo].[sp_xoaNV] '06'

GO
