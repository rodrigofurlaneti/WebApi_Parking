USE [DB_Parking]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_Parking_Brand_Delete](@Id INT)

AS
BEGIN
	DELETE FROM [dbo].[Parking_Brand]
		WHERE Id = @Id
	SET NOCOUNT ON;
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_Parking_Brand_Get]

AS
BEGIN
	SELECT * 
		FROM Parking_Brand
	SET NOCOUNT ON;
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_Parking_Brand_GetById] (@Id INT)

AS
BEGIN
	SELECT TOP 1 * 
		FROM Parking_Brand
			WHERE Id = @Id;
	SET NOCOUNT ON;
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[USP_Parking_Brand_Post] (@Name VARCHAR(50), 
												@Status BIT, 
												@IdUser INT, 
												@DateInsert DATETIME, 
												@DateUpdate DATETIME)

AS
BEGIN
	INSERT INTO Parking_Brand (Name, Status, IdUser, DateInsert, DateUpdate)
            VALUES	(@Name, @Status, @IdUser, @DateInsert, @DateUpdate)
	SET NOCOUNT ON;
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_Parking_Brand_Put](@Id INT,
												  @Name VARCHAR(50),
												  @Status BIT,
												  @IdUser INT,
												  @DateInsert DATETIME,
												  @DateUpdate DATETIME)

AS
BEGIN
	UPDATE [dbo].[Parking_Brand]
    SET Name = @Name,
		IdUser = @IdUser,
		Status = @Status,
		DateInsert = @DateInsert,
		DateUpdate = @DateUpdate
        WHERE Id = @Id
	SET NOCOUNT ON;
END
GO