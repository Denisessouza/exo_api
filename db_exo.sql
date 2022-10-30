

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


CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR (255) UNIQUE NOT NULL,
	Senha VARCHAR (120) NOT NULL,
	Tipo CHAR (10) NOT NULL


);


INSERT INTO Usuarios VALUES ('teste@email.com.br', '1234', '0');
INSERT INTO Usuarios VALUES ('segundo@email.com.br', '4321', '1');

SELECT * FROM Usuarios;

SELECT * FROM Usuarios WHERE Email= 'teste@email.com.br' AND Senha= '1234';
