USE p5g8
GO
------------------
CREATE PROCEDURE WineDB.AdicionarPessoa (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9))
AS
	BEGIN
		INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
	END
GO

EXEC WineDB.AdicionarPessoa 'ola garota', 'avenida das boas', 94263789, '2020-12-12', 'M', '965143566'
DROP PROC WineDB.AdicionarPessoa 

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
								INSERT INTO WineDB.Pessoa (Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
								INSERT INTO WineDB.Cliente (NIF) VALUES (@NIF)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'O Cliente n�o foi inserido, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO


DROP PROCEDURE WineDB.AdicionarCliente

EXEC WineDB.AdicionarCliente 'ola', 'test', 123561333, '2020-01-01', 'f', 987987987

-----------------
CREATE PROCEDURE WineDB.AdicionarFuncionario (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE)
AS
	BEGIN
		BEGIN TRAN
			INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
			INSERT INTO WineDB.Funcionario(NIF , IBAN, NUM_SS, Data_Inicio_Atividade) VALUES (@NIF, @IBAN, @Num_SS, @Data_Inicio_Atividade)
		COMMIT TRAN
	End
GO
DROP PROCEDURE WineDB.AdicionarFuncionario


SELECT * FROM WineDB.Pessoa;
EXEC WineDB.AdicionarFuncionario 'ola', 'test', 121516111, '2020-01-01', 'f', 910987087, 'PT1425164758695847364758695', 11112111, '2020'

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
										INSERT INTO WineDB.Pessoa (Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
										INSERT INTO WineDB.Funcionario(NIF, IBAN, Num_SS, Data_Inicio_Atividade )  VALUES (@NIF, @IBAN, @Num_SS, @Data_Inicio_Atividade);
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
DROP PROCEDURE WineDB.AdicionarGerente

EXEC WineDB.AdicionarGerente 'ola', 'test', 121951465, '2020-01-01', 'f', 927117987, 'PT12345671765400043213251', 15022003, '2020-12-12', 88
EXEC WineDB.AdicionarGerente 'ola', 'test', 124426165, '2020-01-01', 'f', 917955587, 'PT11145557865476543218851', 15229993, '2020-12-12', 88

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
					BEGIN TRY
						BEGIN TRAN
									INSERT INTO WineDB.Pessoa (Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
									INSERT INTO WineDB.Funcionario (NIF, IBAN, Num_SS, Data_Inicio_Atividade) VALUES (@NIF, @IBAN, @Num_SS, @Data_Inicio_Atividade);
									INSERT INTO WineDB.OperadorAgricola(NIF, Num_Func, ID_Terreno) VALUES (@NIF, @Num_Func, @ID_Terreno)
						COMMIT TRAN
					END TRY
					BEGIN CATCH
						Rollback TRAN
						SELECT @erro = ERROR_MESSAGE(); 
						SET @erro = 'O Operador Agricola n�o foi inserido, algum valor inserido incorretamento'
						RAISERROR (@erro, 16,1);
					END CATCH
	End
GO

DROP PROC WineDB.AdicionarOperadorAgricola
EXEC WineDB.AdicionarOperadorAgricola 'ola', 'test', 121300165, '2020-01-01', 'f', 927957111, 'PT12345671761116543213251', 15000033, '2020-12-12', 161, 'GTFD3'

EXEC WineDB.AdicionarOperadorAdega 'Maria Albertina', 'Lisboa', 000444344, '2001-12-12', 'M', '765839457', 'PT23456789098765432112345', 09815346, '2002-12-12', 25, '54W3T'
SELECT * FROM WineDB.OperadorAdega
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
			BEGIN TRY
				BEGIN TRAN
						INSERT INTO WineDB.Pessoa (Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
						INSERT INTO WineDB.Funcionario (NIF, IBAN, Num_SS, Data_Inicio_Atividade) VALUES (@NIF, @IBAN, @Num_SS, @Data_Inicio_Atividade);
						INSERT INTO WineDB.OperadorAdega(NIF, Num_Func, ID_Adega) VALUES (@NIF, @Num_Func, @ID_Adega)
				COMMIT TRAN
			END TRY
			BEGIN CATCH
				Rollback TRAN
				SELECT @erro = ERROR_MESSAGE(); 
				SET @erro = 'O Operador Adega n�o foi inserido, algum valor inserido incorretamento'
				RAISERROR (@erro, 16,1);
			END CATCH
		
	END
GO

DROP Proc WineDB.AdicionarOperadorAdega

SELECT * FROM WineDB.Adega

CREATE PROCEDURE WineDB.AdicionarVinho (@ID VARCHAR(5), @ID_Cuba INT, @Nome VARCHAR(256), @DOC VARCHAR(32), @ID_Casta INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfWineExists(@ID))
		IF(@count>=1)
			RAISERROR ('O vinho introduzido j� existe, n�o � poss�vel adicion�-lo', 16,1);
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
					SET @erro = 'Vinho n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

EXEC WineDB.AdicionarVinho 'CCCAC', 12452, 'Vinho da Nossa Senhora', 'Douro' , 12452

SELECT * FROM WineDB.Vinho

CREATE PROCEDURE WineDB.AdicionarAdega (@ID VARCHAR(5), @Nome VARCHAR(256), @Endereco VARCHAR(256), @Cap_Max INT, @Num_Cubas INT, @NIF_Gerente INT)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfAdegaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A adega introduzida j� existe, n�o � poss�vel adicion�-la', 16,1);
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
					SET @erro = 'Adega n�o foi inserida, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

EXEC WineDB.AdicionarAdega 'CCCCC', 'Adeguinha', 'Rua do Sacramento, Set�bal', 300.0 , 30, 237489547

CREATE PROCEDURE WineDB.AdicionarCuba (@ID INT, @ID_Adega VARCHAR(5), @Cap_Max FLOAT, @TipoCuba VARCHAR(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfCubaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A Cuba introduzida j� existe, n�o � possivel adicionar-la', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Cuba(ID, ID_Adega, Cap_Max) VALUES (@ID, @ID_Adega, @Cap_Max);
						INSERT INTO WineDB.TipoCuba(ID, TipoCuba) VALUES (@ID, @TipoCuba);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'N�o foi possivel adicionar a Cuba, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

DROP PROC WineDB.AdicionarCuba ;

EXEC WineDB.AdicionarCuba 77777, '03ED5', 25000

Select * from WineDB.Cuba

CREATE PROCEDURE WineDB.AdicionarTipoCuba (@ID INT, @TipoCuba VARCHAR(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfCubaExists(@ID))
		IF(@count = 0)
			RAISERROR ('A Cuba em que pretende inserir o tipo n�o existe', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.TipoCuba(ID, TipoCuba) VALUES (@ID, @TipoCuba);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'N�o foi possivel introduzir, ou porque j� existe, ou algum dado estava incorreto'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

EXEC WineDB.AdicionarTipoCuba 77777, 'Teste'

Select * from WineDB.TipoCuba

CREATE PROCEDURE WineDB.AdicionarTerreno (@ID VARCHAR(5), @Nome VARCHAR(256), @Localizacao VARCHAR(256), @Ano_Plantacao DATE, @ID_Casta INT, @Hectares FLOAT , @ID_Adega VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfTerrenoExists(@ID))
		IF(@count >= 1)
			RAISERROR ('O Terreno que pretende inserir j� existe', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Terreno(ID, Nome, Localizacao, Ano_Plantacao, ID_Casta, Hectares, ID_Adega) VALUES (@ID, @Nome, @Localizacao, @Ano_Plantacao, @ID_Casta, @Hectares, @ID_Adega);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'N�o foi possivel inserir o Terreno, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

EXEC WineDB.AdicionarTerreno 'AAAAA', 'AAAA', 'AAAAA', '2012', 12452, 2.34, '03ED5'

Select * from WineDB.Terreno

CREATE PROCEDURE WineDB.AdicionarArmazem (@ID VARCHAR(5), @Localizacao VARCHAR(256), @Nome VARCHAR(256), @ID_Adega VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfTerrenoExists(@ID))
		IF(@count >= 1)
			RAISERROR ('O Armaz�m que pretende inserir j� existe', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Armazem(ID, Localizacao, Nome, ID_Adega) VALUES (@ID, @Localizacao, @Nome, @ID_Adega);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'N�o foi possivel inserir o Armaz�m, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

EXEC WineDB.AdicionarArmazem 'ABAAA', 'AAAA', 'AAAAA', '03ED5'

SELECT * FROM WineDB.Armazem

CREATE PROCEDURE WineDB.AdicionarVenda (@ID_Produto VARCHAR(5), @Preco FLOAT , @IVA INT = 23, @Quantidade INT, @NIF_Cliente INT)
AS
	BEGIN
	
		DECLARE @countVinho INT;
		DECLARE @countNIF INT;
		DECLARE @erro VARCHAR(100);
		SET @countNIF = (SELECT WineDB.checkIfNIFExists(@NIF_Cliente))
		SET @countVinho = (SELECT WineDB.checkIfWineExists(@ID_Produto))
		IF (@countVinho < 1)
			RAISERROR ('N�o existe esse vinho em armaz�m.', 16,1);
		ELSE IF (@countNIF < 1)
			RAISERROR ('N�o existe esse cliente na base de dados.', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Venda(ID_Produto, Preco, IVA, Quantidade, NIF_Cliente) VALUES (@ID_Produto, @Preco, @IVA, @Quantidade, @NIF_Cliente);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'N�o foi possivel inserir a venda, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO
DROP PROC WineDB.AdicionarVenda

EXEC WineDB.AdicionarVenda 'H6G34', 88.5,DEFAULT ,3, 276875341

SELECT * FROM WineDB.Venda
