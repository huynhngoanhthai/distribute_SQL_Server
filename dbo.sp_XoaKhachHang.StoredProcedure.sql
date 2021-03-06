USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaKhachHang]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	xoá khách hành thì phải xoá luôn tài khoản của khách hành đó
-- =============================================
CREATE PROCEDURE [dbo].[sp_XoaKhachHang] 
	@CMND nchar(10)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM TaiKhoan WHERE CMND = @CMND)
		RAISERROR('TAI KHOAN DA TAO KHONG DC XOA', 16, 1)
	ELSE
		DELETE FROM KhachHang WHERE CMND=@CMND 
END

GO
