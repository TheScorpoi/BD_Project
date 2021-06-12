USE p5g8
GO

-- VER AS CENAS DOS CASCADE E UPDATE E CONFIRMAR OS TIPOS DOS ATRIBUTOS SE PODEM SER NULL, DEFAULT, ETC....
CREATE TABLE WineDB.Pessoa (
	Nome		VARCHAR(256)	NOT NULL,
	Morada		VARCHAR(256)	NOT NULL,
	NIF			VARCHAR(9)		DEFAULT 999999999, --VARCHAR TB D� PARA SO 9 NUMEROS? OU � 9*4(BYTES)?
	Data_Nasc	DATE,			
	Genero		VARCHAR(1),
	Telemovel	VARCHAR(9),

	PRIMARY KEY (NIF)
);
GO
--DROP TABLE WineDB.Pessoa

--ver tambem aquilo do cascade e dos alter e o crlh
CREATE TABLE WineDB.Adega (
--DEVIA SER ID_Adega meu menino
	ID			VARCHAR(5)		NOT NULL,
	Nome		VARCHAR(256)	NOT NULL,
	Endereco	VARCHAR(256)	NOT NULL,
	Cap_Max		FLOAT			DEFAULT 0,
	Num_Cubas	INT				DEFAULT 0,
	NIF_Func	VARCHAR(9),		

	PRIMARY KEY (ID),
	FOREIGN KEY (NIF_Func) REFERENCES WineDB.Gerente(NIF)
);
GO
--DROP TABLE WineDB.Adega

CREATE TABLE WineDB.Cuba (
	ID			INT				NOT NULL	UNIQUE,
	ID_Adega	VARCHAR(5)	NOT NULL,
	Cap_Max		FLOAT			NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY(ID_Adega) REFERENCES WineDB.Adega(ID)
);
GO
--DROP TABLE WineDB.Cuba

CREATE TABLE WineDB.TipoCuba (
	ID			INT				NOT NULL	UNIQUE,
	TipoCuba	VARCHAR(64)		NOT NULL,

	PRIMARY KEY (ID, TipoCuba),
	FOREIGN KEY (ID) REFERENCES WineDB.Cuba(ID)
);
GO
--DROP TABLE WineDB.TipoCuba

CREATE TABLE WineDB.Casta (
	Nome			VARCHAR(128)	NOT NULL,
	ID				INT				NOT NULL,
	Percentagem		FLOAT			NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY (ID) REFERENCES WineDB.Cuba(ID)
);
GO
--DROP TABLE WineDB.Casta

CREATE TABLE WineDB.Vinho (
	ID			VARCHAR(5)		NOT NULL	UNIQUE,
	ID_Cuba		INT				NOT NULL	UNIQUE,
	Nome		VARCHAR(256)	NOT NULL,
	DOC			VARCHAR(32),
	ID_Casta	INT				NOT NULL,

	PRIMARY KEY (ID, ID_cuba, ID_Casta),
	FOREIGN KEY (ID_Cuba) REFERENCES WineDB.Cuba(ID),
	FOREIGN KEY (ID_Casta) REFERENCES WineDB.Casta(ID),

);
GO
--DROP TABLE WineDB.Vinho

CREATE TABLE WineDB.Terreno (
	ID				VARCHAR(5)		NOT NULL,
	Nome			VARCHAR(256)	NOT NULL,
	Localizacao		VARCHAR(256)	NOT NULL,
	Ano_plantacao	DATE, 
	ID_Casta		INT,
	Hectares		FLOAT			NOT NULL,
	ID_Adega		VARCHAR(5)		NOT NULL,
	
	PRIMARY KEY (ID),
	FOREIGN KEY (ID_Adega) REFERENCES WineDB.Adega(ID),
	FOREIGN KEY (ID_Casta) REFERENCES WineDB.Casta(ID),
);
GO
--DROP TABLE WineDB.Terreno

CREATE TABLE WineDB.Armazem (
	ID					VARCHAR(5)		NOT NULL,
	Localizacao			VARCHAR(256)	NOT NULL,
	Nome				VARCHAR(256)	NOT NULL,
	ID_Adega			VARCHAR(5)		NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY (ID_Adega) REFERENCES WineDB.Adega(ID) 
);
GO
--DROP TABLE WineDB.Armazem


CREATE TABLE WineDB.Venda (
	ID_Venda		INT				NOT NULL	IDENTITY,
	ID_Produto		VARCHAR(5)		NOT NULL,
	Preco			FLOAT			NOT NULL,
	IVA				INT				DEFAULT 23,
	Quantidade		INT,
	NIF_Cliente		VARCHAR(9)		NOT NULL,

	PRIMARY KEY(ID_Venda),
	FOREIGN KEY (ID_Produto) REFERENCES WineDB.Vinho(ID),
	FOREIGN KEY (NIF_Cliente) REFERENCES WineDB.Cliente(NIF),
);
GO
--DROP TABLE WineDB.Venda

CREATE TABLE WineDB.Cliente (
	NIF				VARCHAR(9),

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF)
);
GO
--DROP TABLE WineDB.Cliente

CREATE TABLE WineDB.Funcionario(
	NIF						VARCHAR(9),
	IBAN					VARCHAR(25)		NOT NULL,
	Num_SS					VARCHAR(11)		NOT NULL,
	Data_Inicio_Atividade	DATE			NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF)
);
GO
--DROP TABLE WineDB.Funcionario

CREATE TABLE WineDB.Gerente(
	NIF			VARCHAR(9),
	Num_Func	VARCHAR(4)		NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF),
);
GO
--DROP TABLE WineDB.Gerente

CREATE TABLE WineDB.OperadorAdega (
	NIF			VARCHAR(9),
	Num_Func	VARCHAR(4)		NOT NULL,
	ID_Adega	VARCHAR(5)		NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF),
	FOREIGN KEY (ID_Adega) REFERENCES WineDB.Adega(ID),

);
GO
--DROP TABLE WineDB.OperadorAdega

CREATE TABLE WineDB.OperadorAgricola(
	NIF				VARCHAR(9),
	ID_Terreno		VARCHAR(5), 

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF),
	FOREIGN KEY (ID_Terreno) REFERENCES WineDB.Terreno(ID),
);
GO
--DROP TABLE WineDB.OperadorAgricola

Create TABLE WineDB.TipoTrabalho(
	NIF				VARCHAR(9),
	Tipo_Trabalho	VARCHAR(64),

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.OperadorAgricola(NIF),
);
GO
--DROP TABLE WineDB.TipoTrabalho

CREATE TABLE WineDB.Armazenado(
	ID_Vinho				VARCHAR(5)		NOT NULL,
	ID_Armazem				VARCHAR(5)		NOT NULL,

	PRIMARY KEY (ID_Vinho, ID_Armazem),
	FOREIGN KEY (ID_Vinho) REFERENCES WineDB.Vinho(ID),
	FOREIGN KEY (ID_Armazem) REFERENCES WineDB.Armazem(ID),
);
GO
--DROP TABLE WineDB.Armazenado