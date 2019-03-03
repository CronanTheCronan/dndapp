-- =============================================
-- Author:		Cronan
-- Create date: 2019-02-08
-- Description:	Gets a list of all creatures
-- =============================================
CREATE PROCEDURE spGroupsRetrieve 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id
	FROM Groups
END
