USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaTKNGANHANG]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_xoaTKNGANHANG]
	@LGNAME NVARCHAR(50),
	@USERNAME NVARCHAR(50)
AS
BEGIN
	 EXEC SP_DROPUSER @USERNAME
	 EXEC SP_DROPLOGIN @LGNAME

	 EXEC LINK.NGANHANG.[dbo].SP_DROPUSER @USERNAME
	 EXEC LINK.NGANHANG.[dbo].SP_DROPLOGIN @LGNAME

END

GO
