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
			SELECT @counterPessoa=(SELECT WineDB.checkIfNIFExists(@NIFPessoa))
		
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

CREATE FUNCTION WineDB.getNIFFuncfromNum_Func(@Num_Func INT) RETURNS INT
AS
	BEGIN	
		DECLARE @condition INT
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
			-- nao sei, se nao encontrar, se da erro ou nao
			-- SUPONDO Q O NUM_FUNC JA TA COMO UNIQUE
			SET @condition = @counterGerente
			IF @condition = 1
				SET @NIFFUNC = (SELECT NIF FROM WineDB.Gerente WHERE Num_Func = @Num_Func)
		IF @counterOpAdega = 1
			-- nao sei, se nao encontrar, se da erro ou nao
			-- SUPONDO Q O NUM_FUNC JA TA COMO UNIQUE
			SET @condition = @counterOpAdega
			IF @condition = 1
				SET @NIFFUNC = (SELECT NIF FROM WineDB.OperadorAdega WHERE Num_Func = @Num_Func)
		IF @counterOpAgricola = 1
			-- nao sei, se nao encontrar, se da erro ou nao
			-- SUPONDO Q O NUM_FUNC JA TA COMO UNIQUE
			SET @condition = @counterOpAgricola
			IF @condition = 1
				SET @NIFFUNC = (SELECT NIF FROM WineDB.OperadorAgricola WHERE Num_Func = @Num_Func)

		RETURN @NIFFunc --means that there is no one with this employee number
	END
GO

--CREATE FUNCTION WineDB.Teste(@Numero INT) RETURNS INT
--AS
	--BEGIN
		--DECLARE @numerozinho INT

			--SET @numerozinho = (SELECT NIF FROM WineDB.OperadorAgricola WHERE Num_Func = @Numero)

		--RETURN @numerozinho
	--END
--GO

SELECT NIF FROM WineDB.OperadorAgricola WHERE Num_Func = 13