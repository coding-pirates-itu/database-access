WITH Stat AS
(
    -- C, G, movie count
    SELECT M.CertificationId, T.GenreId, COUNT(*) AS NofMovies
    FROM MovieGenres AS T
    INNER JOIN Movies M ON M.Id = T.MovieId
    GROUP BY T.GenreId, M.CertificationId
),
Maxs AS
(
    -- MAX count(film) per certification
    SELECT S.CertificationId, S.GenreId FROM Stat S
    WHERE NofMovies = (
        SELECT MAX(NofMovies)
        FROM Stat E
        WHERE E.CertificationId = S.CertificationId
    )
)
SELECT C.Name AS CertName, G.Name AS GenreName FROM Maxs X
    INNER JOIN Certifications C ON C.Id = X.CertificationId
    INNER JOIN Genres G ON G.Id = X.GenreId


-- Execution plan
