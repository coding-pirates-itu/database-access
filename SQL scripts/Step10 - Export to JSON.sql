SELECT M.Title, M.ReleaseDate, M.Slogan, M.Link,
    Certification.Name, Certification.Description, Certification.MinimumAge, Certification.SupervisedAge,
    Studio.Name, Studio.Country
FROM Movies M
INNER JOIN Certifications AS Certification ON Certification.Id = M.CertificationId
INNER JOIN Studios Studio ON Studio.Id = M.StudioId
FOR JSON AUTO
;


SELECT M.Title, G.Name FROM Movies M
INNER JOIN MovieGenres T ON T.MovieId = M.Id
INNER JOIN Genres G ON G.Id = T.GenreId
;
