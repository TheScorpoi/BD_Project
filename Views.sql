USE p5g8
GO

CREATE VIEW WineDB.ViewOperadorAgricola AS
SELECT P.Nome, P.Morada, P.NIF, P.Data_Nasc, P.Genero, P.Telemovel, F.IBAN, F.Num_SS, F.Data_Inicio_Atividade, OA.Num_Func, Terreno.Nome AS TerrenoNome, TT.Tipo_Trabalho
FROM WineDB.Pessoa AS P JOIN WineDB.Funcionario AS F ON P.NIF = F.NIF 
JOIN WineDB.OperadorAgricola AS OA ON F.NIF = OA.NIF
JOIN WineDB.TipoTrabalho AS TT ON TT.NIF = OA.NIF
JOIN WineDB.Terreno AS Terreno ON Terreno.ID = OA.ID_Terreno

CREATE VIEW WineDB.ViewOperadorAdega AS
SELECT P.Nome, P.Morada, P.NIF, P.Data_Nasc, P.Genero, P.Telemovel, F.IBAN, F.Num_SS, F.Data_Inicio_Atividade, OA.Num_Func, A.Nome AS Nome_Adega
FROM WineDB.Pessoa AS P JOIN WineDB.Funcionario AS F ON P.NIF = F.NIF 
JOIN WineDB.OperadorAdega AS OA ON F.NIF = OA.NIF
JOIN WineDB.Adega AS A ON A.ID = OA.ID_Adega

CREATE VIEW WineDB.ViewGerente AS
SELECT P.Nome, P.Morada, P.NIF, P.Data_Nasc, P.Genero, P.Telemovel, F.IBAN, F.Num_SS, F.Data_Inicio_Atividade, G.Num_Func, A.Nome AS Nome_Adega
FROM WineDB.Pessoa AS P JOIN WineDB.Funcionario AS F ON P.NIF = F.NIF 
JOIN WineDB.Gerente AS G ON F.NIF = G.NIF
JOIN WineDB.Adega AS A ON A.NIF_Gerente = G.NIF

CREATE VIEW WineDB.ViewCliente AS
SELECT P.Nome, P.Morada, P.NIF, P.Data_Nasc, P.Genero, P.Telemovel
FROM WineDB.Pessoa AS P JOIN WineDB.Cliente AS C ON P.NIF = C.NIF 

CREATE VIEW WineDB.ViewPessoa AS
SELECT * FROM WineDB.Pessoa

CREATE VIEW WineDB.ViewFuncionarios AS
SELECT P.Nome, P.Morada, P.NIF, P.Data_Nasc, P.Genero, P.Telemovel, F.IBAN, F.Num_SS, F.Data_Inicio_Atividade
FROM WineDB.Funcionario AS F
JOIN WineDB.Pessoa AS P ON F.NIF = P.NIF
