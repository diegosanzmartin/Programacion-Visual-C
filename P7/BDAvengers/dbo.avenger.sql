CREATE TABLE [dbo].[avenger]
(
	[Id]		INT				NOT NULL,
	[alias]		VARCHAR(20)		NOT NULL,
	[nombre]	VARCHAR(20)		NOT NULL,
	[cumple]	DATETIME		NOT NULL,
	[imagen]	VARCHAR(20)		NOT NULL,
	PRIMARY KEY CLUSTERED ([ID] ASC)
);


INSERT famoso VALUES (1, 'Iron Man', 'Tony Stark', '29/05/1970', 'IronMan.jpg')
INSERT famoso VALUES (2, 'Spider-Man', 'Peter Parker', '10/08/2001', 'Spider-Man.jpg')
INSERT famoso VALUES (3, 'Capitán América', 'Steven Rogers', '04/07/1918', 'CapAmerica.jpg')
INSERT famoso VALUES (4, 'Hulk', 'Bruce Banner', '18/12/1969', 'Hulk.jpg')
INSERT famoso VALUES (5, 'Thor', 'Thor Odinson', '11/08/964', 'Thor.jpg')
INSERT famoso VALUES (6, 'Black Widow', 'Natalia Romanoff', '22/11/1984', 'BlackWidow.jpg')
INSERT famoso VALUES (7, 'Doctor Strange', 'Stephen Strange', '19/07/1930', 'DoctorStrange.jpg')
INSERT famoso VALUES (8, 'Groot', 'Groot', '13/11/1960', 'Groot.jpg')