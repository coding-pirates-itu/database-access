-- Remember to set SQL Server login mode in Properties->Security to mixed
-- Then restart the SQL Server service

CREATE LOGIN [admin] WITH PASSWORD = 'Admin123';
CREATE USER [admin] FOR LOGIN [admin];
ALTER ROLE [db_owner] ADD MEMBER [admin];

-- DROP USER Admin; DROP LOGIN Admin;
