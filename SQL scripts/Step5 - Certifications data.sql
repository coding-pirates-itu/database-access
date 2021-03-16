INSERT INTO Certifications(Id, Name, Description, MinimumAge, SupervisedAge)
VALUES (1, 'U', 'Universal', 4, 0),
       (2, 'PG', 'Parental guidance', 8, 4),
	   (3, '12A', '12 or accompanied', 12, 8),
	   (4, 'AA', 'Adult Accompaniment', 14, 14),
	   (5, '15', '15 or over', 15, 15)
;


-- DELETE FROM Certifications WHERE Id IN (1, 2, 3, 4, 5)
