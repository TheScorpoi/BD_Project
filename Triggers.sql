--INSERT PERSON IN PESSOATABLE -----------------------------------
CREATE TRIGGER WineDB.addPersona ON WineDB.Pessoa
AFTER INSERT, UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @total AS int;
	DECLARE @totalTelemovel AS int;
	DECLARE @NIFPerson AS int;
	DECLARE @numTele AS int;
	SELECT @NIFPerson = NIF FROM INSERTED;
	SELECT @numTele = Telemovel FROM INSERTED;
	
	IF LEN(@NIFPerson) <> 9
	BEGIN
		RAISERROR('NIF tem de ter 9 números!' , 16, 1);
		ROLLBACK TRAN;
	END

	IF LEN(@numTele) <> 9
	BEGIN
		RAISERROR('Número de Telemovel tem de ter 9 números!' , 16, 1);
		ROLLBACK TRAN;
	END

	SELECT @totalTelemovel = count(*) FROM WineDB.Pessoa WHERE Telemovel = @numTele
	IF @totalTelemovel > 1
	BEGIN 
		RAISERROR('Número de telemovel repetido na base de dados!' , 16, 1);
		ROLLBACK TRAN;
	END

	SELECT @total = count(*) FROM WineDB.Pessoa where NIF = @NIFPerson;
	IF @total > 1
	BEGIN 
		RAISERROR('NIF repetido na base de dados!' , 16, 1);
		ROLLBACK TRAN;
	END
GO

INSERT INTO WineDB.Pessoa VALUES ('ola garota', 'Rua da jenovevia', 29748365, '2020', 'M', '999111222')

--INSERT FUNCIONARIO ------------------------------------------------
CREATE TRIGGER WineDB.addFunc ON WineDB.Funcionario
AFTER INSERT, UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @IBANFunc AS VARCHAR(25);
	DECLARE @SSFunc AS int;
	DECLARE @IBANTotal AS int;
	DECLARE @SSTotal AS int;
	SELECT @IBANFunc = IBAN FROM INSERTED;
	SELECT @SSFunc = Num_SS	FROM INSERTED; 
	
	IF NOT @IBANFunc LIKE 'PT%'
	BEGIN 
		RAISERROR('IBAN mal inserido!' , 16, 1);
		ROLLBACK TRAN;
	END

	IF LEN(@IBANFunc) <> 25
	BEGIN 
		RAISERROR('IBAN mal inserido!' , 16, 1);
		ROLLBACK TRAN;
	END
	
	SELECT @IBANTotal = count(*) FROM WineDB.Funcionario WHERE IBAN = @IBANFunc
	IF @IBANTotal > 1
	BEGIN 
		RAISERROR('IBAN repetido na base de dados!' , 16, 1);
		ROLLBACK TRAN;
	END

	SELECT @SSTotal = count(*) FROM WineDB.Funcionario WHERE Num_SS = @SSFunc
	IF @SSTotal > 1
	BEGIN 
		RAISERROR('Número de SS repetido na base de dados!' , 16, 1);
		ROLLBACK TRAN;
	END

	IF LEN(@SSFunc) <> 8
	BEGIN 
		RAISERROR('Número de SS mal inserido!' , 16, 1);
		ROLLBACK TRAN;
	END

GO