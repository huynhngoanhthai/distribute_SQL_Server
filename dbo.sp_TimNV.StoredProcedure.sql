USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_TimNV]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TimNV]
  @MANV NCHAR(10)
AS
 DECLARE @MACN NCHAR(10), @HO nvarchar(40), @TEN nvarchar(10)
 IF  exists(select MANV from  dbo.NHANVIEN  where MANV=@MANV)
 BEGIN
   	SELECT TENCN=(SELECT TENCN FROM dbo.CHINHANH), HO, TEN 
   	FROM NHANVIEN WHERE MANV=@MANV
 END
 ELSE IF  exists(select MANV from LINK.NGANHANG.dbo.NHANVIEN where MANV=@MANV)
 BEGIN
    SELECT  @MACN=MACN,  @HO=HO, @TEN=TEN 
   	    FROM LINK.NGANHANG.dbo.NHANVIEN WHERE MANV=@MANV
   	SELECT  TENCN, HO=@HO, TEN=@TEN
   		FROM LINK.NGANHANG.dbo.CHINHANH WHERE MACN=@MACN              
 END
 ELSE  -- không có nv
     raiserror ( 'Ma nhan vien ban tim khong co', 16, 1)

GO
