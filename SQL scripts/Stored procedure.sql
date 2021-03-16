CREATE OR ALTER PROCEDURE AddStudio
  @Name VARCHAR(MAX),
  @Country VARCHAR(MAX)
AS BEGIN
    SET NOCOUNT ON;
    DECLARE @NextId INT;
    SET @NextId = (SELECT MAX(Id) + 1 FROM Studios);
    INSERT INTO Studios (Id, Name, Country)
    VALUES (@NextId, @Name, @Country);
END;
GO

EXEC AddStudio 'New studio', 'Denmark';


-- DROP PROCEDURE AddStudio;
-- DELETE FROM Studios WHERE Name = 'New studio';
