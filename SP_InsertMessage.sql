USE [B77848_2021]
GO
/****** Object:  StoredProcedure [dbo].[InsertMessage]    Script Date: 1/18/2021 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 12/01/2021
-- Description:	SP Insert a Message
-- =============================================
ALTER PROCEDURE [dbo].[InsertMessage] @Name nvarchar(100), @Email varchar(30), @Description nvarchar(200) 
AS
BEGIN

	-- Insert statements for procedure
	INSERT INTO dbo.Message ([Name], Email, [Description])
	VALUES (@Name, @Email, @Description)

END
