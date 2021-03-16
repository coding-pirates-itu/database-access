CREATE TABLE Genres (
    Id INT PRIMARY KEY,
    Name VARCHAR(MAX) NOT NULL
);

INSERT INTO Genres (Id, Name)
VALUES (1, 'Action'),
       (2, 'Adventure'),
       (3, 'Animation'),
       (4, 'Comedy'),
       (5, 'Drama'),
       (6, 'Family'),
       (7, 'Sci-Fi'),
       (8, 'Thriller')
;


-- DROP TABLE Genres
