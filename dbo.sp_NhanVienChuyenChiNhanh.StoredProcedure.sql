USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVienChuyenChiNhanh]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVienChuyenChiNhanh] @MANV nchar(10),
@MACN nchar(10),
@MANVMOI nchar(10),
@pass  VARCHAR(50)

AS
BEGIN
		DECLARE @REP INT,
		@HO nvarchar(40),
		@TEN nvarchar(10),
		@DIACHI nvarchar(100),
		@PHAI nvarchar(3),
		@SODT nvarchar(15)

		SELECT @HO=HO,@TEN=TEN,@DIACHI=DIACHI,@PHAI=PHAI,@SODT=SODT FROM NhanVien WHERE MANV = @MANV
		if exists(SELECT  1 FROM NhanVien WHERE MACN = @MACN)
		BEGIN 
			raiserror('nhan vien danh o chi nhanh hien tai ',16,1)
			return 3;
		END
		else
		BEGIN
			EXEC @REP= LINK.NGANHANG.[dbo].sp_themnv @MANVMOI,@HO,@TEN,@DIACHI,@PHAI,@SODT,@MACN,@TEN,@pass
			 IF @REP = 1 OR @REP = 2
			begin
				raiserror('mã nv,login đã tồn tại ',16,1)
				return 2;
			end
			ELSE
			BEGIN
				EXEC @REP=sp_xoaNV @MANV
				IF @REP = 1
				BEGIN
					RAISERROR('MA NV KHONG TON TAI',16,1) 
					RETURN 1
				END
			END
		END
END
--EXEC sp_NhanVienChuyenChiNhanh '111','CN2','444','123456'

GO
