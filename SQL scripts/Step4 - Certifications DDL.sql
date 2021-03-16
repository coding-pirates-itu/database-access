CREATE TABLE Certifications (
	Id INT PRIMARY KEY,
	Name VARCHAR(MAX) NOT NULL,
	Description VARCHAR(MAX),
	MinimumAge INT NOT NULL,
	SupervisedAge INT NOT NULL
)
;

ALTER TABLE Movies
	ADD CertificationId INT NOT NULL
;

ALTER TABLE Movies
	ADD CONSTRAINT FK_CertificationId FOREIGN KEY (CertificationId) REFERENCES Certifications(Id)
;

-- ALTER TABLE MOVIES DROP CONSTRAINT FK_CertificationId; ALTER TABLE Movies DROP COLUMN CertificationId; DROP TABLE Certifications
