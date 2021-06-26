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
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Cliente', 16,1);
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
					SET @erro =  'O Cliente não foi inserido, algum valor inserido incorretamento'
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
		
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Gerente', 16,1);
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
							SET @erro = 'O Gerente não foi inserido'
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
		
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Operador Agricola', 16,1);
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
						SET @erro = 'O Operador Agricola não foi inserido, algum valor inserido incorretamento'
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
		
			RAISERROR ('O NIF introduzido já existe, não é possível adicionar o Operador Adega', 16,1);
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
				SET @erro = 'O Operador Adega não foi inserido, algum valor inserido incorretamento'
				RAISERROR (@erro, 16,1);
			END CATCH
		
	END
GO

DROP Proc WineDB.AdicionarOperadorAdega

SELECT * FROM WineDB.Adega

CREATE PROCEDURE WineDB.AdicionarVinho (@ID VARCHAR(5), @ID_Cuba INT, @Nome VARCHAR(256), @DOC VARCHAR(32), @Nome_Casta varchar(128))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_Casta VARCHAR(5);
		SET @id_Casta = (SELECT WineDB.getIDCastaFROMNome(@Nome_Casta))
		SET @count = (SELECT WineDB.checkIfWineExists(@ID))
		IF(@count>=1)
			RAISERROR ('O vinho introduzido já existe, não é possível adicioná-lo', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
								INSERT INTO WineDB.Vinho(ID, ID_Cuba, Nome, DOC, ID_Casta) VALUES (@ID, @ID_Cuba, @Nome, @DOC, @id_Casta)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Vinho não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO
DROP PROC WineDB.AdicionarVinho

EXEC WineDB.AdicionarVinho 'CCCAC', 12452, 'Vinho da Nossa Senhora', 'Douro' , 12452

SELECT * FROM WineDB.Vinho

S

CREATE PROCEDURE WineDB.AdicionarAdega (@ID VARCHAR(5), @Nome VARCHAR(256), @Endereco VARCHAR(256), @Cap_Max INT, @Num_Cubas INT, @NomeGerente VARCHAR(256))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @nif INT;
		SET @nif = (SELECT WineDB.getNIFfromNome(@NomeGerente))
		SET @count = (SELECT WineDB.checkIfAdegaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A adega introduzida já existe, não é possível adicioná-la', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Adega(ID, Nome, Endereco, Cap_Max, Num_Cubas, NIF_Gerente) VALUES (@ID, @Nome, @Endereco, @Cap_Max, @Num_Cubas, @nif)
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

DROP PROC WineDB.AdicionarAdega

SELECT * FROM WineDB.Pessoa Where NIF = 374985902

DELETE FROM WineDB.Pessoa WHERE NIF = 124426165
DELETE FROM WineDB.Funcionario WHERE NIF = 124426165
DELETE FROM WineDB.Gerente WHERE NIF = 124426165
DELETE FROM WineDB.OperadorAgricola WHERE NIF = 121300165
DELETE FROM WineDB.OperadorAdega WHERE NIF = 123444344

EXEC WineDB.AdicionarAdega 'CCCCC', 'Adeguinha', 'Rua do Sacramento, Setúbal', 300.0 , 30, 237489547

CREATE PROCEDURE WineDB.AdicionarCuba (@ID INT, @Nome_Adega VARCHAR(256), @Cap_Max FLOAT, @TipoCuba VARCHAR(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_adega VARCHAR(5); 
		SET @id_adega = (SELECT WineDB.getIDAdegaFROMNome(@Nome_Adega))
		SET @count = (SELECT WineDB.checkIfCubaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A Cuba introduzida já existe, não é possivel adicionar-la', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Cuba(ID, ID_Adega, Cap_Max) VALUES (@ID, @id_adega, @Cap_Max);
						INSERT INTO WineDB.TipoCuba(ID, TipoCuba) VALUES (@ID, @TipoCuba);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Não foi possivel adicionar a Cuba, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

DROP PROC WineDB.AdicionarCuba

EXEC WineDB.AdicionarCuba 00011, 'Boa Uva', 25000, 'Barril de Carvalho'

Select * from WineDB.Cuba

CREATE PROCEDURE WineDB.AdicionarTipoCuba (@ID INT, @TipoCuba VARCHAR(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		SET @count = (SELECT WineDB.checkIfCubaExists(@ID))
		IF(@count = 0)
			RAISERROR ('A Cuba em que pretende inserir o tipo não existe', 16,1);
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
					SET @erro = 'Não foi possivel introduzir, ou porque já existe, ou algum dado estava incorreto'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

EXEC WineDB.AdicionarTipoCuba 77777, 'Teste'

Select * from WineDB.TipoCuba

CREATE PROCEDURE WineDB.AdicionarTerreno (@ID VARCHAR(5), @Nome VARCHAR(256), @Localizacao VARCHAR(256),@Ano_plantacao VARCHAR(4), @NomeCasta varchar(128), @Hectares FLOAT , @Nome_Adega VARCHAR(256))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_CASTA INT;
		DECLARE @id_Adega VARCHAR(5);
		SET @id_Adega = (SELECT WineDB.getIDAdegaFROMNome(@Nome_Adega))
		SET @id_casta = (SELECT WineDB.getIDCastaFROMNome(@NomeCasta))
		SET @count = (SELECT WineDB.checkIfTerrenoExists(@ID))
		IF(@count >= 1)
			RAISERROR ('O Terreno que pretende inserir já existe', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
						INSERT INTO WineDB.Terreno(ID, Nome, Localizacao, Ano_plantacao ,ID_Casta, Hectares, ID_Adega) VALUES (@ID, @Nome, @Localizacao, @Ano_plantacao,@id_casta, @Hectares, @id_Adega);
				END TRY
				BEGIN CATCH
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Não foi possivel inserir o Terreno, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO
DROP PROC WineDB.AdicionarTerreno

EXEC WineDB.AdicionarTerreno 'TEST2', 'OLA', 'RUA', '01/01/2000 00:00:00', 'Gouveio Preto', 2.34, 'Boa Uva'

Select * from WineDB.Terreno

CREATE PROCEDURE WineDB.AdicionarArmazem (@ID VARCHAR(5), @Localizacao VARCHAR(256), @Nome VARCHAR(256), @Nome_Adega VARCHAR(256))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_Adega VARCHAR(5);
		SET @id_adega = (SELECT  WineDB.getIDAdegaFROMNome(@Nome_Adega))
		SET @count = (SELECT WineDB.checkIfTerrenoExists(@ID))
		IF(@count >= 1)
			RAISERROR ('O Armazém que pretende inserir já existe', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Armazem(ID, Localizacao, Nome, ID_Adega) VALUES (@ID, @Localizacao, @Nome, @id_adega);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Não foi possivel inserir o Armazém, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

DROP PROC WineDB.AdicionarArmazem

EXEC WineDB.AdicionarArmazem 'AAAAA', 'RUA DE CIMA', 'NOMINHO', 'Adega La Rose'

SELECT * FROM WineDB.Armazem

CREATE PROCEDURE WineDB.AdicionarVenda (@ID_Produto VARCHAR(5), @Preco FLOAT , @IVA INT = 23, @Quantidade INT, @Nome VARCHAR(256))
AS
	BEGIN
	
		DECLARE @countVinho INT;
		DECLARE @nif INT;
		DECLARE @countNIF INT;
		DECLARE @erro VARCHAR(100);
		SET @nif = (SELECT WineDB.getNIFfromNome(@Nome))
		SET @countNIF = (SELECT WineDB.checkIfNIFExists(@nif))
		SET @countVinho = (SELECT WineDB.checkIfWineExists(@ID_Produto))
		IF (@countVinho < 1)
			RAISERROR ('Não existe esse vinho em armazém.', 16,1);
		ELSE IF (@countNIF < 1)
			RAISERROR ('Não existe esse cliente na base de dados.', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO WineDB.Venda(ID_Produto, Preco, IVA, Quantidade, NIF_Cliente) VALUES (@ID_Produto, @Preco, @IVA, @Quantidade, @nif);
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'Não foi possivel inserir a venda, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO
DROP PROC WineDB.AdicionarVenda

EXEC WineDB.AdicionarVenda 'H6G34', 88.5,DEFAULT ,3, 276875341

SELECT * FROM WineDB.Venda
