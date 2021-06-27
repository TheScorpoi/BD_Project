USE p5g8
GO

CREATE FUNCTION WineDB.checkIfNIFExists (@NIF INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM WineDB.Pessoa WHERE NIF=@NIF
		RETURN @counter
	END
GO

CREATE FUNCTION WineDB.checkIfNum_FuncExists (@Num_Func INT) RETURNS INT
AS
	BEGIN
		DECLARE @NIFPessoa INT
		DECLARE @counter INT
		DECLARE @counterPessoa INT
		DECLARE @counterGerente INT
		DECLARE @counterOpAdega INT
		DECLARE @counterOpAgricola INT

		--Check if Pessoa exists
		SELECT @NIFPessoa = WineDB.getNIFFuncfromNum_Func(@Num_Func)

		IF @NIFPessoa IS NOT NULL
			SET @counterPessoa=(SELECT WineDB.checkIfNIFExists(@NIFPessoa))
		
		IF(@counterPessoa IS NOT NULL)
			--Check if gerente exists
			SELECT @counterGerente = COUNT(1) FROM WineDB.Gerente WHERE Num_Func = @Num_Func
			--Check if Operador Adega exists
			SELECT @counterOpAdega = COUNT(1) FROM WineDB.OperadorAdega WHERE Num_Func = @Num_Func
			--Check if Operador Agricola exists
			SELECT @counterOpAgricola = COUNT(1) FROM WineDB.OperadorAgricola WHERE Num_Func = @Num_Func

		IF(@counterGerente = 1 OR @counterOpAdega = 1 OR @counterOpAgricola = 1)
			SET @counter = 1
		ELSE
			SET @counter = 0

		RETURN @counter
	END
GO

DROP FUNCTION WineDB.checkIfNum_FuncExists

CREATE FUNCTION WineDB.checkIfWineExists (@ID VARCHAR(5)) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(*) FROM WineDB.Vinho WHERE ID = @ID
		RETURN @counter
	END
GO

CREATE FUNCTION WineDB.checkIfAdegaExists (@ID VARCHAR(5)) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(*) FROM WineDB.Adega WHERE ID = @ID
		RETURN @counter
	END
GO

CREATE FUNCTION WineDB.checkIfCubaExists (@ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter = COUNT(*) FROM WineDB.Cuba WHERE ID = @ID
		RETURN @counter
	END
GO

CREATE FUNCTION WineDB.checkIfTerrenoExists (@ID VARCHAR(5)) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter = COUNT(*) FROM WineDB.Terreno WHERE ID = @ID
		RETURN @counter
	END
GO

CREATE FUNCTION WineDB.checkIfArmazemExists (@ID VARCHAR(5)) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter = COUNT(*) FROM WineDB.Armazem WHERE ID = @ID
		RETURN @counter
	END
GO

CREATE FUNCTION WineDB.getNIFFuncfromNum_Func(@Num_Func INT) RETURNS INT
AS
	BEGIN	
		DECLARE @NIFFunc INT
		DECLARE @counter INT
		DECLARE @counterGerente INT
		DECLARE @counterOpAdega INT
		DECLARE @counterOpAgricola INT

		SELECT @counterGerente = COUNT(1) FROM WineDB.Gerente WHERE Num_Func = @Num_Func
			--Check if Operador Adega exists
		SELECT @counterOpAdega = COUNT(1) FROM WineDB.OperadorAdega WHERE Num_Func = @Num_Func
			--Check if Operador Agricola exists
		SELECT @counterOpAgricola = COUNT(1) FROM WineDB.OperadorAgricola WHERE Num_Func = @Num_Func

		IF @counterGerente = 1
			SET @NIFFUNC = (SELECT NIF FROM WineDB.Gerente WHERE Num_Func = @Num_Func)
		IF @counterOpAdega = 1
			SET @NIFFUNC = (SELECT NIF FROM WineDB.OperadorAdega WHERE Num_Func = @Num_Func)
		IF @counterOpAgricola = 1
			SET @NIFFUNC = (SELECT NIF FROM WineDB.OperadorAgricola WHERE Num_Func = @Num_Func)

		RETURN @NIFFunc --means that there is no one with this employee number if zero
	END
GO

DROP FUNCTION WineDB.getNIFFuncfromNum_Func

CREATE FUNCTION WineDB.getNIFfromNome (@Nome VARCHAR(256)) RETURNS INT
AS
	BEGIN
		DECLARE @nif INT
		SELECT @nif = NIF FROM WineDB.Pessoa WHERE Nome = @nome
		RETURN @nif
	END
GO

CREATE FUNCTION WineDB.getIDAdegaFROMNome(@Nome VARCHAR(256)) RETURNS VARCHAR(5)
AS
	BEGIN
		DECLARE @id VARCHAR(5)
		SELECT @id = ID FROM WineDB.Adega WHERE Nome = @Nome
		RETURN @id
	END
GO

CREATE FUNCTION WineDB.getIDCastaFROMNome(@Nome VARCHAR(256)) RETURNS INT
AS
	BEGIN
		DECLARE @id INT
		SELECT @id = ID FROM WineDB.Casta WHERE Nome = @Nome
		RETURN @id
	END
GO

CREATE FUNCTION WineDB.getNomeTerrenoFROMiD (@ID VARCHAR(5)) RETURNS VARCHAR(256) 
AS
	BEGIN
		DECLARE @nome VARCHAR(256)
		SELECT @nome = Nome FROM WineDB.Terreno Where ID = @ID
		RETURN @nome
	END
GO
