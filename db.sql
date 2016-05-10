USE [BiYeSheng]
GO
/****** Object:  Table [dbo].[ziyuan]    Script Date: 05/10/2016 20:05:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ziyuan](
	[yxdm] [nvarchar](255) NULL,
	[yxmc] [nvarchar](255) NULL,
	[xm] [nvarchar](255) NULL,
	[ksh] [nvarchar](255) NULL,
	[yksh] [nvarchar](255) NULL,
	[sfzh] [nvarchar](255) NULL,
	[xbdm] [nvarchar](255) NULL,
	[xb] [nvarchar](255) NULL,
	[mzdm] [nvarchar](255) NULL,
	[mz] [nvarchar](255) NULL,
	[zzmmdm] [nvarchar](255) NULL,
	[zzmm] [nvarchar](255) NULL,
	[xldm] [nvarchar](255) NULL,
	[xl] [nvarchar](255) NULL,
	[zydm] [nvarchar](255) NULL,
	[zy] [nvarchar](255) NULL,
	[zyfx] [nvarchar](255) NULL,
	[pyfsdm] [nvarchar](255) NULL,
	[pyfs] [nvarchar](255) NULL,
	[syszddm] [nvarchar](255) NULL,
	[syszd] [nvarchar](255) NULL,
	[cxsy] [nvarchar](255) NULL,
	[xz] [nvarchar](255) NULL,
	[xjbddm] [nvarchar](255) NULL,
	[xjbd] [nvarchar](255) NULL,
	[zhcpdc] [nvarchar](255) NULL,
	[zxrzdm] [nvarchar](255) NULL,
	[dsznbz] [nvarchar](255) NULL,
	[rxsj] [nvarchar](255) NULL,
	[sfslbdm] [nvarchar](255) NULL,
	[knslbdm] [nvarchar](255) NULL,
	[dxhwpdw] [nvarchar](255) NULL,
	[szyx] [nvarchar](255) NULL,
	[szbj] [nvarchar](255) NULL,
	[xh] [nvarchar](255) NULL,
	[csrq] [nvarchar](255) NULL,
	[rxqdaszdw] [nvarchar](255) NULL,
	[dasfzrxx] [nvarchar](255) NULL,
	[rxqhkszdpc] [nvarchar](255) NULL,
	[hksfzrxx] [nvarchar](255) NULL,
	[mobilephon] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[qq] [nvarchar](255) NULL,
	[jtdz] [nvarchar](255) NULL,
	[jtdh] [nvarchar](255) NULL,
	[jtyb] [nvarchar](255) NULL,
	[bz2] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dm]    Script Date: 05/10/2016 20:05:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dm](
	[type] [nvarchar](255) NULL,
	[code] [nvarchar](255) NULL,
	[value] [nvarchar](255) NULL
) ON [PRIMARY]
GO
