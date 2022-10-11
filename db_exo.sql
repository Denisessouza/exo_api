

USE db_exo;

CREATE TABLE Projetos
(
	Id Int PRIMARY KEY IDENTITY,
	Titulo VARCHAR (150) NOT NULL,
	Status VARCHAR (30) NOT NULL,
	Data_Inicio VARCHAR (10) NOT NULL,
	Area VARCHAR (150) NOT NULL

	
);

INSERT INTO Projetos (Titulo, Status, Data_Inicio, Area) 
VALUES ('Projeto A', 'Planejamento', '10/04/2022', 'TI');

INSERT INTO Projetos (Titulo, Status, Data_Inicio, Area) 
VALUES ('Projeto B', 'Concluído', '17/05/2022', 'RH');


SELECT * FROM Projetos;
