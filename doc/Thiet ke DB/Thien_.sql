USE [DentalLabo]
GO
/****** Object:  Table [dbo].[ChamCong_History]    Script Date: 01/24/2010 22:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChamCong_History](
	[MaNV] [varchar](50) NOT NULL,
	[MaNVCC] [varchar](50) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[CongChinh] [float] NULL,
	[CongNghi] [float] NULL,
	[LamThemGio] [float] NULL,
	[TrucChuNhat] [float] NULL,
 CONSTRAINT [PK_ChamCong_History_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoanTru]    Script Date: 01/24/2010 22:14:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoanTru](
	[MaKhoan] [nvarchar](20) NOT NULL,
	[TenKhoan] [nvarchar](200) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
