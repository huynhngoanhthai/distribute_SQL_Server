USE [NGANHANG]
GO
/****** Object:  Table [dbo].[GD_GOIRUT]    Script Date: 5/22/2022 10:58:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_GOIRUT](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK] [nchar](9) NOT NULL,
	[LOAIGD] [nchar](2) NOT NULL,
	[NGAYGD] [datetime] NOT NULL CONSTRAINT [DF_GD_GOIRUT_NGAYGD]  DEFAULT (getdate()),
	[SOTIEN] [money] NOT NULL CONSTRAINT [DF_GD_GOIRUT_SOTIEN]  DEFAULT ((100000)),
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_5BC778AE9F704F9A87E8CF7FE71A96D1]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GD_GOIRUT] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [MSmerge_index_421576540]    Script Date: 5/22/2022 10:58:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_421576540] ON [dbo].[GD_GOIRUT]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_NhanVien]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_TaiKhoan] FOREIGN KEY([SOTK])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_TaiKhoan]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_LOAIGD] CHECK  (([LOAIGD]='RT' OR [LOAIGD]='GT'))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_LOAIGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_SOTIEN] CHECK  (([SOTIEN]>=(100000)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_B04C40F7_3E69_468C_9EE4_B03B793510D3] CHECK NOT FOR REPLICATION (([MAGD]>=(1) AND [MAGD]<=(1001) OR [MAGD]>(1001) AND [MAGD]<=(2001)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [repl_identity_range_B04C40F7_3E69_468C_9EE4_B03B793510D3]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'‘GT’ : gởi tiền vào TK , ‘RT’ : rút tiền khỏi TK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GD_GOIRUT', @level2type=N'COLUMN',@level2name=N'LOAIGD'
GO
