CREATE TABLE MovieGenres (
    MovieId INT NOT NULL,
    GenreId INT NOT NULL,
    CONSTRAINT FK_MovieId FOREIGN KEY (MovieId) REFERENCES Movies(Id),
    CONSTRAINT FK_GenreId FOREIGN KEY (GenreId) REFERENCES Genres(Id)
);


INSERT INTO MovieGenres (MovieId, GenreId)
VALUES (1, 1), (1, 7), (1, 8),
       (2, 1), (2, 2), (2, 7),
       (3, 3), (3, 2), (3, 6),
       (4, 3), (4, 2), (4, 5),
       (5, 1), (5, 2), (5, 4),
       (6, 2), (6, 4), (6, 7),
       (7, 4),
       (8, 4), (8, 5), (8, 6)
;


-- DROP TABLE MovieGenres
