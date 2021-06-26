USE p5g8
GO
------------------
CREATE PROCEDURE WineDB.AdicionarPessoa (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9))
AS
	BEGIN
		INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
	END
GO

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

CREATE PROCEDURE WineDB.AdicionarFuncionario (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE)
AS
	BEGIN
		BEGIN TRAN
			INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES (@Nome, @Morada, @NIF, @Data_Nasc, @Genero, @Telemovel);
			INSERT INTO WineDB.Funcionario(NIF , IBAN, NUM_SS, Data_Inicio_Atividade) VALUES (@NIF, @IBAN, @Num_SS, @Data_Inicio_Atividade)
		COMMIT TRAN
	End
GO

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

CREATE PROCEDURE WineDB.AdicionarOperadorAgricola (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT, @ID_Terreno VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);

		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Operador Agricola', 16,1);
		ELSE
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

CREATE PROCEDURE WineDB.AdicionarOperadorAdega (@Nome VARCHAR(256), @Morada VARCHAR(256), @NIF INT, @Data_Nasc DATE, @Genero VARCHAR(1), @Telemovel VARCHAR(9), @IBAN VARCHAR(25), @Num_SS INT, @Data_Inicio_Atividade DATE, @Num_Func INT, @ID_Adega VARCHAR(5))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);

		SET @count = (SELECT WineDB.checkIfNIFExists(@NIF))
		IF(@count>=1)
		
			RAISERROR ('O NIF introduzido j� existe, n�o � poss�vel adicionar o Operador Adega', 16,1);
		ELSE
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

CREATE PROCEDURE WineDB.AdicionarVinho (@ID VARCHAR(5), @ID_Cuba INT, @Nome VARCHAR(256), @DOC VARCHAR(32), @Nome_Casta varchar(128))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_Casta VARCHAR(5);
		SET @id_Casta = (SELECT WineDB.getIDCastaFROMNome(@Nome_Casta))
		SET @count = (SELECT WineDB.checkIfWineExists(@ID))
		IF(@count>=1)
			RAISERROR ('O vinho introduzido j� existe, n�o � poss�vel adicion�-lo', 16,1);
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
					SET @erro = 'Vinho n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE WineDB.AdicionarAdega (@ID VARCHAR(5), @Nome VARCHAR(256), @Endereco VARCHAR(256), @Cap_Max INT, @Num_Cubas INT, @NomeGerente VARCHAR(256))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @nif INT;
		SET @nif = (SELECT WineDB.getNIFfromNome(@NomeGerente))
		SET @count = (SELECT WineDB.checkIfAdegaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A adega introduzida j� existe, n�o � poss�vel adicion�-la', 16,1);
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
					SET @erro = 'Adega n�o foi inserida, algum valor inserido incorretamento'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE WineDB.AdicionarCuba (@ID INT, @Nome_Adega VARCHAR(256), @Cap_Max FLOAT, @TipoCuba VARCHAR(64))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_adega VARCHAR(5); 
		SET @id_adega = (SELECT WineDB.getIDAdegaFROMNome(@Nome_Adega))
		SET @count = (SELECT WineDB.checkIfCubaExists(@ID))
		IF(@count>=1)
			RAISERROR ('A Cuba introduzida j� existe, n�o � possivel adicionar-la', 16,1);
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
					SET @erro = 'N�o foi possivel adicionar a Cuba, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

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

CREATE PROCEDURE WineDB.AdicionarTerreno (@ID VARCHAR(5), @Nome VARCHAR(256), @Localizacao VARCHAR(256), @NomeCasta varchar(128), @Hectares FLOAT , @Nome_Adega VARCHAR(256))
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
			RAISERROR ('O Terreno que pretende inserir j� existe', 16,1);
		ELSE
			BEGIN
				BEGIN TRY
						INSERT INTO WineDB.Terreno(ID, Nome, Localizacao, Ano_plantacao ,ID_Casta, Hectares, ID_Adega) VALUES (@ID, @Nome, @Localizacao, @Ano_plantacao,@id_casta, @Hectares, @id_Adega);
				END TRY
				BEGIN CATCH
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro = 'N�o foi possivel inserir o Terreno, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

CREATE PROCEDURE WineDB.AdicionarArmazem (@ID VARCHAR(5), @Localizacao VARCHAR(256), @Nome VARCHAR(256), @Nome_Adega VARCHAR(256))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100);
		DECLARE @id_Adega VARCHAR(5);
		SET @id_adega = (SELECT  WineDB.getIDAdegaFROMNome(@Nome_Adega))
		SET @count = (SELECT WineDB.checkIfTerrenoExists(@ID))
		IF(@count >= 1)
			RAISERROR ('O Armaz�m que pretende inserir j� existe', 16,1);
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
					SET @erro = 'N�o foi possivel inserir o Armaz�m, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO

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
			RAISERROR ('N�o existe esse vinho em armaz�m.', 16,1);
		ELSE IF (@countNIF < 1)
			RAISERROR ('N�o existe esse cliente na base de dados.', 16,1);
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
					SET @erro = 'N�o foi possivel inserir a venda, algum dado foi passado de forma incorreta'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	End
GO