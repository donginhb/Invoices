USE [invoices_raman]
GO
-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-12
-- Description:	Procedure that adds a company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'add_company')
	DROP PROCEDURE add_company
GO

CREATE PROCEDURE add_company 
	@name varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- if runtime error occurs, transaction is terminated and rolled back completely
	SET XACT_ABORT ON

	

    -- Insert statements for procedure here
	-- Make sure a unique company name is entered
	-- Make sure company name != NULL
	IF EXISTS (SELECT * FROM companies WHERE name = @name) BEGIN
		RAISERROR('This company name already exists. Please enter a different name', 16, 1)
		RETURN
	END

	IF @name IS NULL BEGIN
		RAISERROR('Company name cannot be blank. Please enter company name.', 16, 1)
		RETURN
	END

	-- Else, create company id for the new company name
	BEGIN TRANSACTION

		DECLARE @company_id INT 

		IF NOT EXISTS (SELECT * FROM companies WHERE @name = name) BEGIN
			SELECT @company_id = ISNULL(MAX(company_id),0) + 1 FROM companies
			INSERT INTO companies (company_id, name) VALUES (@company_id, @name) 
		END

	COMMIT TRANSACTION

	GRANT EXECUTE ON add_company TO PUBLIC

END
GO
