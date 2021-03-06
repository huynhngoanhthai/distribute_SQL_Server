USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_CheckMANV]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,thái>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CheckMANV]
	@MANV nvarchar(10)
AS
BEGIN
	if exists (select 1 from dbo.NhanVien where dbo.NhanVien.MANV = @MANV)
	begin
		return 1;
	end
	
	if exists (select 1 from LINK.NGANHANG.dbo.NhanVien VN where VN.MANV = @MANV)
	begin
		return 1;
	end
	
	return 0;

END

GO
