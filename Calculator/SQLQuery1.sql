CREATE DATABASE Test
GO
USE Test
GO
CREATE TABLE TestData(
    Number1 INT,
    Number2 INT,
    Fraction INT
);
GO
INSERT INTO TestData(Number1, Number2, Fraction)
VALUES (5, 10, 0.5),
(5, 5, 1),
(13, 1, 13),
(0, 5, 0),
(-5, 1, -5),
(128, 2, 64)