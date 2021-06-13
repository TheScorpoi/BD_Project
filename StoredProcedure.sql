USE p5g8
GO
------------------
CREATE PROCEDURE WineDB.AdicionarPessoa (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9))
AS
BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido j� existe, n�o � possivel adicionar a Pessoa', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'A Pessoa n�o foi inserida'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

----------------- acho que isto � melhor numa UDF mas ver melhor isto
CREATE PROCEDURE WineDB.VerTodosAsPessoas
AS
	SELECT * FROM WineDB.Pessoa
GO

-----------------
CREATE PROCEDURE WineDB.AdicionarCliente (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Cliente', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								EXEC WineDB.AdicionarPessoa @Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel;
								INSERT INTO WineDB.Cliente (NIF) VALUES (@NIF)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Cliente n�o foi inserido'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

--EXEC WineDB.AdicionarCliente 'ola', 'test', 12356, '2020-01-01', 'f', 987987987

-----------------
CREATE PROCEDURE WineDB.AdicionarFuncionario (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Funcionario', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								EXEC WineDB.AdicionarPessoa @Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel;
								INSERT INTO WineDB.Funcionario(NIF , IBAN, NUM_SS, Data_Inicio_Atividade) VALUES (@NIF, @IBAN, @Num_SS, @Data_Inicio_Atividade)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Funcionario n�o foi inserido'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

--EXEC WineDB.AdicionarFuncionario 'ola', 'test', 123516, '2020-01-01', 'f', 987987987, 'asd123', 111, '2020'

CREATE PROCEDURE WineDB.AdicionarGerente (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Gerente', 16,1);
		ELSE
		--fazer tambem a verificacao pelo numero de funcionario
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								EXEC WineDB.AdicionarFuncionario @Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel, @IBAN, @Num_SS, @Data_Inicio_Atividade;
								INSERT INTO WineDB.Gerente(NIF, Num_Func) VALUES (@NIF, @Num_Func)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'O Gerente n�o foi inserido'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

--EXEC WineDB.AdicionarGerente 'ola', 'test', 12135116, '2020-01-01', 'f', 987987987, 'asd123', 111, '2020', 90

CREATE PROCEDURE WineDB.AdicionarOperadorAgricola (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT, @ID_Terreno VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Operador Agricola', 16,1);
		ELSE
		--fazer tambem a verificacao pelo numero de funcionario
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								EXEC WineDB.AdicionarFuncionario @Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel, @IBAN, @Num_SS, @Data_Inicio_Atividade;
								INSERT INTO WineDB.OperadorAgricola(NIF, Num_Func, ID_Terreno) VALUES (@NIF, @Num_Func, @ID_Terreno)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'O Operador Agricola n�o foi inserido'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE WineDB.AdicionarOperadorAdega (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT, @ID_Adega VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Operador Adega', 16,1);
		ELSE
		--fazer tambem a verificacao pelo numero de funcionario
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								EXEC WineDB.AdicionarFuncionario @Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel, @IBAN, @Num_SS, @Data_Inicio_Atividade;
								INSERT INTO WineDB.OperadorAdega(NIF, Num_Func, ID_Adega) VALUES (@NIF, @Num_Func, @ID_Adega)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'O Operador Adega n�o foi inserido'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


