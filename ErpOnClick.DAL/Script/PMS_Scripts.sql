
CREATE TABLE [PMS].[PMS_Company](
	[Company_Id] [int] IDENTITY(1,1) NOT NULL,
	[Company_Name] [varchar](max) NULL,
	[Contact_Number] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Contact_Person] [varchar](max) NULL,
	[Company_Image_URL] [nvarchar](max) NULL,
	[Company_Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Company_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [PMS].[Messages]    Script Date: 9/19/2021 11:40:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PMS].[PMS_Messages](
	[Message_Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Send_By] [int] NOT NULL,
	[Send_To] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Task_Id] [int] NOT NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[Message_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [PMS].[Project_Tasks]    Script Date: 9/19/2021 11:40:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PMS].[PMS_Project_Tasks](
	[Task_Id] [int] IDENTITY(1,1) NOT NULL,
	[Project_Id] [int] NOT NULL,
	[Task_Name] [nvarchar](max) NULL,
	[Task_Desc] [nvarchar](max) NULL,
	[Task_Created_Date] [datetime] NULL,
	[Task_Created_By] [int] NULL,
	[Assigned_To_Id] [int] NOT NULL,
	[Task_End_Date] [datetime] NULL,
	[Task_Status] [varchar](50) NULL,
	[Task_Completed_Percentage] [int] NULL,
	[Task_Published_URL] [nvarchar](max) NULL,
	[Task_Start_Date] [datetime] NULL,
 CONSTRAINT [PK_Project_Tasks] PRIMARY KEY CLUSTERED 
(
	[Task_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [PMS].[Project_Team]    Script Date: 9/19/2021 11:40:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PMS].[PMS_Project_Team](
	[Team_Id] [int] IDENTITY(1,1) NOT NULL,
	[Project_Id] [int] NOT NULL,
	[Project_User_Id] [int] NOT NULL,
 CONSTRAINT [PK_Project_Team] PRIMARY KEY CLUSTERED 
(
	[Team_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [PMS].[Projects]    Script Date: 9/19/2021 11:40:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PMS].[PMS_Projects](
	[Project_Id] [int] IDENTITY(1,1) NOT NULL,
	[Project_Name] [varchar](max) NULL,
	[Project_Desc] [nvarchar](max) NULL,
	[Company_Id] [int] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Project_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [PMS].[Task_Attachments]    Script Date: 9/19/2021 11:40:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PMS].[PMS_Task_Attachments](
	[Task_Attachment_Id] [int] IDENTITY(1,1) NOT NULL,
	[Task_Attachment_Name] [nvarchar](max) NULL,
	[Task_Attachment_URL] [nvarchar](max) NULL,
	[Task_Id] [int] NOT NULL,
 CONSTRAINT [PK_Task_Attachments] PRIMARY KEY CLUSTERED 
(
	[Task_Attachment_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 9/19/2021 11:40:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PMS].[PMS_User](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [varchar](max) NOT NULL,
	[User_Password] [nvarchar](max) NOT NULL,
	[User_Email] [nvarchar](100) NULL,
	[User_Contact] [nvarchar](20) NULL,
	[User_Role] [varchar](max) NULL,
	[Company_Id] [int] NULL,
	[User_Manager_Id] [int] NULL,
	[User_Image_URL] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [PMS].[PMS_Company] ON 

INSERT [PMS].[PMS_Company] ([Company_Id], [Company_Name], [Contact_Number], [Email], [Contact_Person], [Company_Image_URL], [Company_Address]) VALUES (1, N'Nayel', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [PMS].[PMS_Company] OFF
SET IDENTITY_INSERT [PMS].[PMS_User] ON 

INSERT [PMS].[PMS_User] ([User_Id], [User_Name], [User_Password], [User_Email], [User_Contact], [User_Role], [Company_Id], [User_Manager_Id], [User_Image_URL]) VALUES (6, N'hamid', N'1234', N'hamid.anjum@hotmail.com', NULL, N'Super Admin', 1, NULL, NULL)
INSERT [PMS].[PMS_User] ([User_Id], [User_Name], [User_Password], [User_Email], [User_Contact], [User_Role], [Company_Id], [User_Manager_Id], [User_Image_URL]) VALUES (10, N'yasir', N'1234', N'yasir@nayelsolutions.com', NULL, N'1', 1, 6, NULL)
SET IDENTITY_INSERT [PMS].[PMS_User] OFF
ALTER TABLE [PMS].[PMS_Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Project_Tasks] FOREIGN KEY([Task_Id])
REFERENCES [PMS].[PMS_Project_Tasks] ([Task_Id])
GO
ALTER TABLE [PMS].[PMS_Messages] CHECK CONSTRAINT [FK_Messages_Project_Tasks]
GO
ALTER TABLE [PMS].[PMS_Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_User] FOREIGN KEY([Send_By])
REFERENCES [PMS].[PMS_User] ([User_Id])
GO
ALTER TABLE [PMS].[PMS_Messages] CHECK CONSTRAINT [FK_Messages_User]
GO
ALTER TABLE [PMS].[PMS_Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_User1] FOREIGN KEY([Send_To])
REFERENCES [PMS].[PMS_User] ([User_Id])
GO
ALTER TABLE [PMS].[PMS_Messages] CHECK CONSTRAINT [FK_Messages_User1]
GO
ALTER TABLE [PMS].[PMS_Project_Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Project_Tasks_Projects] FOREIGN KEY([Project_Id])
REFERENCES [PMS].[PMS_Projects] ([Project_Id])
GO
ALTER TABLE [PMS].[PMS_Project_Tasks] CHECK CONSTRAINT [FK_Project_Tasks_Projects]
GO
ALTER TABLE [PMS].[PMS_Project_Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Project_Tasks_User] FOREIGN KEY([Assigned_To_Id])
REFERENCES [PMS].[PMS_User] ([User_Id])
GO
ALTER TABLE [PMS].[PMS_Project_Tasks] CHECK CONSTRAINT [FK_Project_Tasks_User]
GO
ALTER TABLE [PMS].[PMS_Project_Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Project_Tasks_User1] FOREIGN KEY([Task_Created_By])
REFERENCES [PMS].[PMS_User] ([User_Id])
GO
ALTER TABLE [PMS].[PMS_Project_Tasks] CHECK CONSTRAINT [FK_Project_Tasks_User1]
GO
ALTER TABLE [PMS].[PMS_Project_Team]  WITH CHECK ADD  CONSTRAINT [FK_Project_Team_Projects] FOREIGN KEY([Project_Id])
REFERENCES [PMS].[PMS_Projects] ([Project_Id])
GO
ALTER TABLE [PMS].[PMS_Project_Team] CHECK CONSTRAINT [FK_Project_Team_Projects]
GO
ALTER TABLE [PMS].[PMS_Project_Team]  WITH CHECK ADD  CONSTRAINT [FK_Project_Team_User] FOREIGN KEY([Project_User_Id])
REFERENCES [PMS].[PMS_User] ([User_Id])
GO
ALTER TABLE [PMS].[PMS_Project_Team] CHECK CONSTRAINT [FK_Project_Team_User]
GO
ALTER TABLE [PMS].[PMS_Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Company] FOREIGN KEY([Company_Id])
REFERENCES [PMS].[PMS_Company] ([Company_Id])
GO
ALTER TABLE [PMS].[PMS_Projects] CHECK CONSTRAINT [FK_Projects_Company]
GO
ALTER TABLE [PMS].[PMS_Task_Attachments]  WITH CHECK ADD  CONSTRAINT [FK_Task_Attachments_Project_Tasks] FOREIGN KEY([Task_Id])
REFERENCES [PMS].[PMS_Project_Tasks] ([Task_Id])
GO
ALTER TABLE [PMS].[PMS_Task_Attachments] CHECK CONSTRAINT [FK_Task_Attachments_Project_Tasks]
GO
ALTER TABLE [PMS].[PMS_User]  WITH CHECK ADD  CONSTRAINT [FK_User_Company] FOREIGN KEY([Company_Id])
REFERENCES [PMS].[PMS_Company] ([Company_Id])
GO
ALTER TABLE [PMS].[PMS_User] CHECK CONSTRAINT [FK_User_Company]
GO
ALTER TABLE [PMS].[PMS_User]  WITH CHECK ADD  CONSTRAINT [FK_User_User] FOREIGN KEY([User_Manager_Id])
REFERENCES [PMS].[PMS_User] ([User_Id])
GO
ALTER TABLE [PMS].[PMS_User] CHECK CONSTRAINT [FK_User_User]
GO
