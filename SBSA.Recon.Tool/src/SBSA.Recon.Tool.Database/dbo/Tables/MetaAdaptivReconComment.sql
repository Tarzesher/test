CREATE TABLE [dbo].[MetaAdaptivReconComment](
	[Comment_Key] [int] IDENTITY(1,1) NOT NULL,
	[AdaptivReconID] [varchar](30) NOT NULL,
	[Reference] [varchar](255) NOT NULL,
	[ReconStatus] [varchar](255) NULL,
	[Comments] [varchar](max) NULL,
	[Username] [varchar](max) NULL,
	[BusinessDate] [varchar](max) NULL,
	[Comment_Date] [datetime] NULL DEFAULT (getdate())
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]