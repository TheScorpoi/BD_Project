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
			RAISERROR ('O NIF introduzido já existe, não é possivel adicionar a Pessoa', 16,1);
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
					SET @erro = 'A Pessoa não foi inserida, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

----------------- acho que isto é melhor numa UDF mas ver melhor isto
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
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Cliente', 16,1);
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
					SET @erro =  'O Cliente não foi inserido, algum valor inserido incorretamento'
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
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Funcionario', 16,1);
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
					SET @erro =  'O Funcionario não foi inserido, algum valor inserido incorretamento'
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
		DECLARE @Num_Funcionario INT;

		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Gerente', 16,1);
		ELSE
		--fazer tambem a verificacao pelo numero de funcionario
			SET @Num_Funcionario = (SELECT WineDB.checkIfNum_FuncExists(@Num_Func))
			IF(@Num_Funcionario IS NOT NULL)
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
						SET @erro = 'O Gerente não foi inserido'
						RAISERROR (@erro, 16,1);
					END CATCH
				END
			ELSE
				RAISERROR ('O número de funcionário inserido já existe!', 16,1);
	End
GO

--EXEC WineDB.AdicionarGerente 'ola', 'test', 12135116, '2020-01-01', 'f', 987987987, 'asd123', 111, '2020', 90

CREATE PROCEDURE WineDB.AdicionarOperadorAgricola (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT, @ID_Terreno VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @Num_Funcionario INT;

		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Operador Agricola', 16,1);
		ELSE
		--fazer tambem a verificacao pelo numero de funcionario
			SET @Num_Funcionario = (SELECT WineDB.checkIfNum_FuncExists(@Num_Func))
			IF(@Num_Funcionario IS NOT NULL)
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
						SET @erro = 'O Operador Agricola não foi inserido, algum valor inserido incorretamento'
						RAISERROR (@erro, 16,1);
					END CATCH
				END
			ELSE
				RAISERROR ('O número de funcionário inserido já existe!', 16,1);
	End
GO

CREATE PROCEDURE WineDB.AdicionarOperadorAdega (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT, @ID_Adega VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @Num_Funcionario INT;

		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Operador Adega', 16,1);
		ELSE
		--fazer tambem a verificacao pelo numero de funcionario
			SET @Num_Funcionario = (SELECT WineDB.checkIfNum_FuncExists(@Num_Func))
			IF(@Num_Funcionario IS NOT NULL)
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
						SET @erro = 'O Operador Adega não foi inserido, algum valor inserido incorretamento'
						RAISERROR (@erro, 16,1);
					END CATCH
				END
			ELSE
				RAISERROR ('O número de funcionário inserido já existe!', 16,1);
	
	END
GO

EXEC WineDB.AdicionarOperadorAdega 'Maria Albertina', 'Lisboa', 123444344, '2001-12-12', 'M', '765839457', PT12345678909876543212345, 234567, '2002-12-12', 17, 'CCCCC'

SELECT * FROM WineDB.Funcionario

CREATE PROCEDURE WineDB.AdicionarVinho (@ID VARCHAR(5), @ID_Cuba INT, @Nome VARCHAR(256), @DOC VARCHAR(32), @ID_Casta INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfWineExists(@ID))
		IF(@count>=1)
			RAISERROR ('O vinho introduzido já existe, não é possível adicioná-lo', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO WineDB.Vinho(ID, ID_Cuba, Nome, DOC, ID_Casta) VALUES (@ID, @ID_Cuba, @Nome, @DOC, @ID_Casta)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Vinho não foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

--EXEC WineDB.AdicionarVinho 'CCCCC', 12452, 'Vinho da Nossa Senhora', 'Douro' , 12452

CREATE PROCEDURE WineDB.AdicionarAdega (@ID VARCHAR(5), @Nome VARCHAR(256), @Endereco VARCHAR(256), @Cap_Max INT, @Num_Cubas INT, @NIF_Gerente INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfAdegaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A adega introduzida já existe, não é possível adicioná-la', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Adega(ID, Nome, Endereco, Cap_Max, Num_Cubas, NIF_Gerente) VALUES (@ID, @Nome, @Endereco, @Cap_Max, @Num_Cubas, @NIF_Gerente)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Adega não foi inserida, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

--EXEC WineDB.AdicionarAdega 'CCCCC', 'Adeguinha', 'Rua do Sacramento, Setúbal', 300.0 , 30, 237489547

--CREATE PROCEDURE WineDB.Testinho(@Num_Func INT)
--AS
--	BEGIN

--	DECLARE @NUMERO INT

--	SET @NUMERO = (SELECT WineDB.Teste(@Num_Func))

--	IF @NUMERO = 227578689
--		SELECT * FROM WineDB.Adega

--	END
--GO

--EXEC WineDB.Testinho 13
