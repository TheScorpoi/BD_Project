USE p5g8
GO

-- VER AS CENAS DOS CASCADE E UPDATE E CONFIRMAR OS TIPOS DOS ATRIBUTOS SE PODEM SER NULL, DEFAULT, ETC....
CREATE TABLE WineDB.Pessoa (
	Nome		VARCHAR(256)	NOT NULL,
	Morada		VARCHAR(256)	NOT NULL,
	NIF			VARCHAR(9)		DEFAULT 999999999, --VARCHAR TB DÁ PARA SO 9 NUMEROS? OU É 9*4(BYTES)?
	Data_Nasc	DATE,			
	Genero		VARCHAR(1),
	Telemovel	VARCHAR(9),

	PRIMARY KEY (NIF)
);
GO
DROP TABLE WineDB.Pessoa

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
DROP TABLE WineDB.Adega

CREATE TABLE WineDB.Cuba (
	ID			INT				NOT NULL	UNIQUE,
	ID_Adega	VARCHAR(5)		NOT NULL,
	Cap_Max		FLOAT			NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY(ID_Adega) REFERENCES WineDB.Adega(ID)
);
GO
DROP TABLE WineDB.Cuba

CREATE TABLE WineDB.TipoCuba (
	ID			INT				NOT NULL	UNIQUE,
	TipoCuba	VARCHAR(64)		NOT NULL,

	PRIMARY KEY (ID, TipoCuba),
	FOREIGN KEY (ID) REFERENCES WineDB.Cuba(ID)
);
GO
DROP TABLE WineDB.TipoCuba

CREATE TABLE WineDB.Casta (
	Nome		VARCHAR(128)	NOT NULL,
	ID			INT				NOT NULL,

	PRIMARY KEY (Nome),
);
GO
DROP TABLE WineDB.Casta

CREATE TABLE WineDB.Vinho (
	ID			VARCHAR(5)		NOT NULL	UNIQUE,
	ID_Cuba		INT				NOT NULL	UNIQUE,
	Nome		VARCHAR(256)	NOT NULL,
	DOC			VARCHAR(32),
	Nome_Casta	VARCHAR(128)	NOT NULL,

	PRIMARY KEY (ID, ID_cuba, Nome_Casta),
	FOREIGN KEY (ID_Cuba) REFERENCES WineDB.Cuba(ID),
	FOREIGN KEY (Nome_Casta) REFERENCES WineDB.Casta(Nome),

);
GO
DROP TABLE WineDB.Vinho

CREATE TABLE WineDB.Terreno (
	ID				VARCHAR(5)		NOT NULL,
	Nome			VARCHAR(256)	NOT NULL,
	Localizacao		VARCHAR(256)	NOT NULL,
	Ano_plantacao	DATE, --ACHO QUE NAO HA SO ANO, MAS CONFIRMAR
	Casta			VARCHAR(256),
	Hectares		FLOAT			NOT NULL,
	ID_Adega		VARCHAR(5)	NOT NULL,
	
	PRIMARY KEY (ID),
	FOREIGN KEY (ID_Adega) REFERENCES WineDB.Adega(ID),
);
GO
DROP TABLE WineDB.Terreno

CREATE TABLE WineDB.Armazem (
	ID					VARCHAR(5)		NOT NULL,
	Localizacao			VARCHAR(256)	NOT NULL,
	Nome				VARCHAR(256)	NOT NULL,
	ID_Adega			VARCHAR(5)		NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY (ID_Adega) REFERENCES WineDB.Adega(ID) 
);
GO
DROP TABLE WineDB.Armazem


CREATE TABLE WineDB.Venda (
	ID				VARCHAR(8)		NOT NULL,
	ID_Produto		VARCHAR(5)		NOT NULL,
	Preco			FLOAT			NOT NULL,
	IVA				INT				DEFAULT 23,
	NIF				VARCHAR(9),
	Quantidade		INT,

	PRIMARY KEY(ID),
);
GO
DROP TABLE WineDB.Venda

CREATE TABLE WineDB.Cliente (
	NIF				VARCHAR(9),
	ID				INT				NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF)
);
GO
DROP TABLE WineDB.Cliente

CREATE TABLE WineDB.Funcionario(
	NIF						VARCHAR(9),
	IBAN					VARCHAR(25)		NOT NULL,
	Num_SS					VARCHAR(11)		NOT NULL,
	Data_Inicio_Atividade	DATE			NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF)
);
GO
DROP TABLE WineDB.Funcionario

CREATE TABLE WineDB.Gerente(
	NIF			VARCHAR(9),
	Num_Func	VARCHAR(4)		NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF),
);
GO
DROP TABLE WineDB.Gerente

CREATE TABLE WineDB.OperadorAdega (
	NIF			VARCHAR(9),
	Num_Func	VARCHAR(4)		NOT NULL,
	ID_Adega	VARCHAR(5)		NOT NULL,

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF),
	FOREIGN KEY (ID_Adega) REFERENCES WineDB.Adega(ID),

);
GO
DROP TABLE WineDB.OperadorAdega

--mudar o nome para OperadorAgricola
CREATE TABLE WineDB.OperadorAgricola(
	NIF		VARCHAR(9), 

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.Pessoa(NIF),
);
GO
DROP TABLE WineDB.OperadorAgricola

Create TABLE WineDB.TipoTrabalho(
	NIF				VARCHAR(9),
	Tipo_Trabalho	VARCHAR(64),

	PRIMARY KEY (NIF),
	FOREIGN KEY (NIF) REFERENCES WineDB.OperadorAgricola(NIF),
);
GO
DROP TABLE WineDB.TipoTrabalho

CREATE TABLE WineDB.Armazenado(
	ID_Vinho				VARCHAR(5)		NOT NULL,
	ID_Armazem				VARCHAR(5)		NOT NULL,

	PRIMARY KEY (ID_Vinho, ID_Armazem),
	FOREIGN KEY (ID_Vinho) REFERENCES WineDB.Vinho(ID),
	FOREIGN KEY (ID_Armazem) REFERENCES WineDB.Armazem(ID),
);
GO
DROP TABLE WineDB.Armazenado

CREATE TABLE WineDB.TemProdutos(
	ID_Armazem		VARCHAR(5)		NOT NULL,
	ID_Venda		VARCHAR(8)		NOT NULL,

	PRIMARY KEY (ID_Armazem, ID_Venda),
	FOREIGN KEY (ID_Armazem) REFERENCES WineDB.Armazem(ID),
	FOREIGN KEY (ID_Venda) REFERENCES WineDB.Venda(ID)

);
GO
DROP TABLE WineDB.TemProdutos

CREATE TABLE WineDB.Compra (
	ID_Venda		VARCHAR(8)		NOT NULL,
	NIF				VARCHAR(9)		NULL,

	FOREIGN KEY (ID_Venda) REFERENCES WineDB.Venda(ID),
	FOREIGN KEY (NIF) REFERENCES WineDB.Cliente(NIF),
);
GO
DROP TABLE WineDB.Compra

CREATE TABLE WineDB.Trabalha(
	ID			VARCHAR(5)			NOT NULL,
	NIF			VARCHAR(9)			NOT NULL,

	PRIMARY KEY(ID),
	FOREIGN KEY (ID) REFERENCES WineDB.Terreno(ID),
	FOREIGN KEY (NIF) REFERENCES WineDB.OperadorAgricola(NIF),
);
GO
DROP TABLE WineDB.Trabalha


--INSERT DATA IN THE TABLES
INSERT INTO WineDB.Adega(ID,Nome,Endereco,Cap_Max,Num_Cubas, NIF_Func) VALUES
('6A3E4','Solar Dona Maria','Rua de Cima, 234, Ervedosa do Douro',350000,38, '237489547'),
('54W3T','Casa dos Vinhos','Estrada Municipal 501, 12, Soutelo do Douro',1250000,80, '233765487'),
('03ED5','Boa Uva','Travessa da Laranja, 12, Anadia',250000,32, '257483675'),
('6S4U3','Adega La Rose','Estrada Nacional 10, 123, Azeitão',900000,75, '374985902');

DELETE FROM WineDB.Adega 

Select * FROM WineDB.Adega

INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES
('Alfredo Costa', 'Urbanização Chave, 23, Averio', '345612398', '1987-05-16', 'M', '92345876'),
('Alexandra Silva', 'Rua das Largadas, 45, Águeda', '334712345', '1998-06-29', 'F', '931256786'),
('Pedro Figueiredo', 'Rua Fundo de Vila, 13, Trancoso', '276875341', '1997-06-19', 'M', '963426457'),
('Eva Freixo', 'Avenida Batista Lemos, 66, Peso da Régua', '287649264', '1994-06-12', 'F', '913472345'),
('Filipe Sobral', 'Travessa de Baixo, 48, Ermesinde', '295748365', '1991-07-14', 'M', '934512876'),
('Andre Figueiredo', 'Avenida Dr. Lopes, 98, Évora', '312876490', '1989-06-18', 'M', '961298645'),
('Daniel Sousa', 'Rua Vasco da Gama, 73, Lisboa', '376598467', '1993-05-11', 'M', '912876345'),
('Tiago Costa', 'Rua da Avenida, 34, Leiria', '245678345', '1999-05-22', 'M', '962846581'),
('Beatriz Augusto', 'Avenidade Principal, 38, Lamego', '239817654', '1998-03-12', 'F', '934562398'),
('Anita Pinto', 'Rua Principal, 12, Mangualde', '237489547', '1976-01-11', 'F', '919873451'),
('Miguel Silva', 'Estrada Municipal 23, 1, Guarda', '233765487', '1994-07-18', 'M', '967893541'),
('Maria Trindade', 'Estrada Nacional 222, 56, Viseu', '257483675', '1989-03-01', 'F', '923456712'),
('Inês Sequeira', 'Bairro das Laranjas, 87, Vila Real', '374985902', '1976-04-15', 'F', '961234512'),
('Sofia Sousa', 'Bairro de Santiago, 51, Porto', '237598309', '1999-05-23', 'F', '934567123'),
('Laurindo Vilas', 'Avenida Dessarges, 100, S.J.Pesqueira', '235400888', '2000-04-23', 'M', '961051386'),
('Carla Setúbal', 'Rua Lisabon, 30, Porto', '236978309', '1960-10-13', 'F', '919898982'),
('Luis Lopes', 'Urbanização Chavinha, 52, Aveiro', '236696379', '1975-06-27', 'M', '924468103'),
('Mariana Rodriguez', 'Rua do Corvo, 33 , Setúbal', '237588123', '1995-07-28', 'F', '925562223'),
('Marta Fradique', 'Rua de Biana, 50, Esposende', '255246336', '1988-08-04', 'F', '934427533'),
('Joana Rafaela', 'Bairro de Nova Deli, 150, Porto', '237256978', '2001-01-03', 'F', '933458903'),
('João Cruz', 'Rua da Laranjeira, 56, Faro', '234555999', '2002-02-15', 'M', '964554668'),
('Luisa Setúbal', 'Rua Abon, 35, Funchal', '227578689', '1980-10-13', 'F', '915598982'),
('Vitor Sanches', 'Rua dos Gatos, 13, Arouca', '266699979', '1985-04-27', 'M', '923468103'),
('Raquel Silveira', 'Rua do Pássaro, 55 , Guimarães', '227579113', '1985-02-28', 'F', '921164443'),
('Ana Frades', 'Avenida Da Boa Vontade, 50, Lisboa', '215256356', '1999-09-09', 'F', '934447733'),
('Sofia Pereira', 'Rua Dali, 10, Vila Real', '207206079', '2001-01-01', 'F', '933278903'),
('André Matosinhos', 'Rua Além, 36, Matosinhos', '204009990', '2000-01-01', 'M', '962552660');

Select * FROM WineDB.Pessoa

DELETE FROM WineDB.Pessoa 


INSERT INTO WineDB.Cuba(ID, ID_Adega, Cap_Max) VALUES
(12452, '6A3E4', 30093),
(23411, '6A3E4', 234231),
(52143, '6A3E4', 234231),
(47581, '6A3E4', 234231),
(17543, '6A3E4', 234231),
(54432, '6A3E4', 30234),
(34234, '6A3E4', 30234),
(43633, '6A3E4', 30234),
(46423, '6A3E4', 30234),
(16546, '6A3E4', 30234),
(16453, '6A3E4', 30234),
(16556, '6A3E4', 30234),
(12342, '6A3E4', 30234),
(15646, '6A3E4', 45632),
(14564, '54W3T', 45632),
(16565, '54W3T', 45632),
(12131, '54W3T', 45632),
(87665, '54W3T', 45632),
(78665, '54W3T', 45632),
(18666, '54W3T', 45632),
(18768, '54W3T', 45632),
(14243, '54W3T', 45632),
(16464, '54W3T', 123432),
(65435, '54W3T', 123432),
(17544, '54W3T', 123432),
(65543, '54W3T', 123432),
(75467, '54W3T', 123432),
(45645, '54W3T', 123432),
(18767, '54W3T', 123432),
(18735, '54W3T', 123432),
(78567, '54W3T', 123432),
(19876, '03ED5', 123432),
(96755, '03ED5', 54564),
(86565, '03ED5', 54564),
(14574, '03ED5', 54564),
(17576, '03ED5', 54564),
(86785, '03ED5', 54564),
(86865, '03ED5', 54564),
(18755, '03ED5', 54564),
(18626, '03ED5', 54564),
(18656, '03ED5', 54564),
(18655, '03ED5', 54564),
(84565, '03ED5', 35352),
(15474, '6S4U3', 35352),
(16586, '6S4U3', 35352),
(32423, '6S4U3', 35352),
(53455, '6S4U3', 35352),
(15657, '6S4U3', 35352),
(17657, '6S4U3', 35352),
(19788, '6S4U3', 35352),
(19877, '6S4U3', 35352),
(67865, '6S4U3', 423423),
(18687, '6S4U3', 423423);

DELETE FROM WineDB.Cuba

select * from WineDB.Cuba


INSERT INTO WineDB.TipoCuba(ID, TipoCuba) VALUES
(12452, 'Depósito Inox'),
(23411, 'Depósito Inox'),
(52143, 'Depósito Inox'),
(47581, 'Depósito Duplo'),
(17543, 'Depósito Duplo'),
(54432, 'Depósito Duplo'),
(34234, 'Depósito Duplo'),
(43633, 'Depósito Duplo'),
(46423, 'Depósito Fundo Plano'),
(16546, 'Depósito Fundo Plano'),
(16453, 'Depósito Fundo Plano'),
(16556, 'Depóstio Fundo Cónico'),
(12342, 'Depóstio Fundo Cónico'),
(15646, 'Depóstio Fundo Cónico'),
(14564, 'Depóstio Fundo Cónico'),
(16565, 'Barril de Carvalho'),
(12131, 'Barril de Carvalho'),
(87665, 'Barril de Carvalho'),
(78665, 'Barril de Carvalho'),
(18666, 'Barril de Carvalho'),
(18768, 'Barril de Carvalho'),
(14243, 'Barril de Madeira Francesa'),
(16464, 'Barril de Madeira Francesa'),
(65435, 'Barril de Madeira Francesa'),
(17544, 'Barril de Madeira Francesa'),
(65543, 'Barril de Madeira Francesa'),
(75467, 'Barril de Madeira Francesa'),
(45645, 'Barril de Madeira Francesa'),
(18767, 'Barril Estilo Barrica Americana'),
(18735, 'Barril Estilo Barrica Americana'),
(78567, 'Barril Estilo Barrica Americana'),
(19876, 'Barril Estilo Barrica Americana'),
(96755, 'Barril Estilo Barrica Americana'),
(86565, 'Barril Estilo Barrica Americana'),
(14574, 'Barril Estilo Barrica Americana'),
(17576, 'Barril Estilo Barrica Americana'),
(86785, 'Deposito em Balão'),
(86865, 'Deposito em Balão'),
(18755, 'Deposito em Balão'),
(18626, 'Deposito em Balão'),
(18656, 'Deposito em Balão'),
(18655, 'Deposito em Balão'),
(84565, 'Deposito em Balão'),
(15474, 'Deposito em Balão'),
(16586, 'Deposito em Balão'),
(32423, 'Depóstio Fundo Cónico'),
(53455, 'Depóstio Fundo Cónico'),
(15657, 'Depóstio Fundo Cónico'),
(17657, 'Depóstio Fundo Cónico'),
(19788, 'Depóstio Fundo Cónico'),
(19877, 'Depóstio Fundo Cónico'),
(67865, 'Depóstio Fundo Cónico'),
(18687, 'Depóstio Fundo Cónico');

DELETE FROM WineDB.TipoCuba

select * from WineDB.TipoCuba

--NAOD DEU PARA INSERIR, acho que o nome n pode ser primary pq repete tem de ser o ID depois mudar isso
INSERT INTO WineDB.Casta(Nome, ID) VALUES
('Touriga Franca', 12452),
('Touriga Franca', 23411),
('Touriga Franca', 52143),
('Touriga Franca', 47581),
('Touriga Franca', 17543),
('Touriga Franca', 54432),
('Touriga Franca', 34234),
('Touriga Franca', 43633),
('Touriga Franca', 46423),
('Touriga Franca', 16546),
('Touriga Franca', 16453),
('Touriga Nacional', 16556),
('Touriga Nacional', 12342),
('Touriga Nacional', 15646),
('Touriga Nacional', 14564),
('Touriga Nacional', 16565),
('Touriga Nacional', 12131),
('Touriga Nacional', 87665),
('Touriga Nacional', 78665),
('Touriga Nacional', 18666),
('Touriga Nacional', 18768),
('Touriga Nacional', 14243),
('Rabigato Moreno', 16464),
('Rabigato Moreno', 65435),
('Rabigato Moreno', 17544),
('Rabigato Moreno', 65543),
('Rabigato Moreno', 75467),
('Rabigato Moreno', 45645),
('Rabigato Moreno', 18767),
('Rabigato Moreno', 18735),
('Rabigato Moreno', 78567),
('Gouveio Preto', 19876),
('Gouveio Preto', 96755),
('Gouveio Preto', 86565),
('Gouveio Preto', 14574),
('Gouveio Preto', 17576),
('Gouveio Preto', 86785),
('Gouveio Preto', 86865),
('Gouveio Preto', 18755),
('Gouveio Preto', 18626),
('Gouveio Preto', 18655),
('Gouveio Preto', 84565),
('Gouveio Preto', 15474),
('Gouveio Preto', 16586),
('Mourisco de Trevões', 32423),
('Mourisco de Trevões', 53455),
('Mourisco de Trevões', 15657),
('Mourisco de Trevões', 17657),
('Mourisco de Trevões', 19788),
('Mourisco de Trevões', 19877),
('Mourisco de Trevões', 67865),
('Mourisco de Trevões', 18687);

Select * FROM WineDB.Casta

DELETE FROM WineDB.Casta


--tb n deu fds
INSERT INTO WineDB.Vinho(ID, ID_Cuba, Nome, DOC, Nome_Casta) VALUES
('AS3FR', 12452,'Vinho Velho', 'Douro', 'Touriga Franca'),
('SF231', 23411,'Vinho Dão', 'DÃO', 'Touriga Nacional'),
('FGDF3', 52143,'Vinho Alegre', 'Alenquer', 'Touriga Franca'),
('GDDF3', 47581,'Vale Dona Maria', 'Douro', 'Touriga Franca'),
('AG434', 17543,'Vinho Velho - 2017', 'Tejo', 'Touriga Franca'),
('GFH54', 54432,'VZ', 'Douro', 'Gouveio Preto'),
('H6G34', 34234,'VZ', 'Douro', 'Gouveio Preto'),
('G5325', 43633,'Bajancas', 'Douro', 'Gouveio Preto'),
('A34R2', 46423,'Bajancas', 'Tejo', 'Touriga Franca'),
('23F54', 16546,'Bajancas', 'Alentejo', 'Gouveio Preto'),
('GTG45', 16453,'Bajancas', 'Alenquer', 'Gouveio Preto'),
('GTDT5', 16556,'Vallado`s', 'Douro', 'Touriga Franca'),
('HYD54', 12342,'Vallado`s', 'Tejo', 'Touriga Franca'),
('343SF', 15646,'Vallado`s', 'Dão', 'Touriga Franca'),
('ADE23', 14564,'Vallado`s', 'Douro', 'Touriga Nacional'),
('AHYT3', 16565,'Vallado`s', 'Douro', 'Touriga Nacional'),
('ADF34', 12131,'Vinho Velho - 2017', 'Douro', 'Touriga Nacional'),
('B534F', 87665,'Dona Doroteia', 'Douro', 'Touriga Nacional'),
('343F4', 78665,'Dona Doroteia', 'Douro', 'Touriga Nacional'),
('FDS42', 18666,'Dona Doroteia', 'Douro', 'Touriga Nacional'),
('GDF43', 18768,'Dona Doroteia', 'Tejo', 'Touriga Franca'),
('AGTG2', 14243,'Dona Doroteia', 'Douro', 'Mourisco de Trevões'),
('32DS2', 16464,'Dona Doroteia', 'Douro', 'Mourisco de Trevões'),
('ACVT4', 65435,'Dona Doroteia', 'Dão', 'Touriga Franca'),
('AFS32', 17544,'Dona Doroteia', 'Douro', 'Touriga Franca'),
('A323R', 65543,'Romaneira', 'Douro', 'Touriga Franca'),
('AS323', 75467,'Romaneira', 'Douro', 'Touriga Franca'),
('232SR', 45645,'Romaneira', 'Douro', 'Touriga Franca'),
('FSD23', 18767,'Romaneira', 'Dão', 'Touriga Franca'),
('434FD', 18735,'Romaneira', 'Douro', 'Rabigato Moreno'),
('AGFD3', 78567,'Romaneira', 'Douro', 'Rabigato Moreno'),
('A234F', 19876,'Romaneira', 'Douro', 'Rabigato Moreno'),
('A5433', 96755,'Romaneira', 'Alentejo', 'Touriga Franca'),
('FGD43', 86565,'Vinho Velho - 2017', 'Alentejo', 'Touriga Franca'),
('AFSD3', 14574,'Vinho Velho - 2017', 'Tejo', 'Touriga Franca'),
('BN33F', 17576,'Cidrô', 'Alenquer', 'Touriga Franca'),
('AR265', 86785,'Cidrô', 'DOU', 'Touriga Franca'),
('AFSF2', 86865,'Cidrô', 'Dão', 'Rabigato Moreno'),
('FSD42', 18755,'Cidrô', 'Dão', 'Rabigato Moreno'),
('GDH56', 18626,'Cidrô', 'Dão', 'Rabigato Moreno'),
('76U6J', 18656,'Cidrô', 'Dão', 'Rabigato Moreno'),
('JH5GT', 18655,'Aneto, Grande Reservax', 'Dão', 'Touriga Franca'),
('GFH54', 84565,'Aneto, Grande Reservax', 'Dão', 'Touriga Franca'),
('AHJ56', 15474,'Aneto, Grande Reservax', 'Douro', 'Touriga Nacional'),
('AJG56', 16586,'Aneto, Grande Reservax', 'Douro', 'Touriga Nacional'),
('GHJ55', 32423, 'Aciprestes', 'Alentejo', 'Mourisco de Trevões'),
('JGHJ5', 53455, 'Aciprestes', 'Alentejo', 'Mourisco de Trevões'),
('HF345', 15657, 'Aciprestes', 'Alentejo', 'Mourisco de Trevões'),
('FDE3D', 17657, 'Aciprestes', 'Alentejo', 'Mourisco de Trevões'),
('AT34D', 19788, 'Vesúvio', 'Dão', 'Touriga Nacional'),
('AS345', 19877, 'Vesúvio', 'Dão', 'Touriga Nacional'),
('AS34T', 67865, 'Vesúvio', 'Douro', 'Touriga Franca'),
('A43RG', 18687, 'Vesúvio', 'Douro', 'Touriga Franca');

Select * FROM WineDB.Vinho

INSERT INTO WineDB.Terreno(ID, Nome, Localizacao, Ano_Plantacao, Casta, Hectares, ID_Adega) VALUES
('FDG32', 'Curtinho', 'Vale de Vila', '2012', 'Touriga Franca', 2.34, '6A3E4'),
('3DG43', 'Ervedeiro', 'Soutelo do Douro', '2015', 'Touriga Nacional', 5.40, '03ED5'),
('FDG34', 'Sobreiro', 'Soutelo do Douro', '2011', 'Touriga Nacional', 80.64, '6A3E4'),
('SDF34', 'Serra - Sul', 'Soutelo do Douro', '2007', 'Touriga Nacional', 56.78, '6A3E4'),
('GTFD3', 'Poças de Cima', 'Soutelo do Douro', '2008', 'Touriga Nacional', 245.98, '6A3E4'),
('FGDF4', 'Fuseiro', 'Évora', '2018', 'Rabigato Moreno', 34.12, '54W3T'),
('F5G54', 'Vale de Parada', 'Évora', '2019', 'Rabigato Moreno', 56.42, '54W3T'),
('GDGH7', 'Montijinho', 'Évora', '2016', 'Touriga Franca', 78.23, '6A3E4'),
('54Y32', 'Fundeira', 'Santa Comba Dão', '2015', 'Mourisco de Trevões', 30.34, '6S4U3'),
('FY632', 'Sobreira', 'Santa Comba Dão', '2017', 'Mourisco de Trevões', 23.64, '54W3T'),
('FDY56', 'Eucaliptal', 'Santa Comba Dão', '2018', 'Mourisco de Trevões', 32.74, '54W3T'),
('JHY32', 'Pinheira', 'Santa Comba Dão', '2018', 'Mourisco de Trevões', 12.88, '03ED5'),
('5Y665', 'Ribeiro do Centro', 'Santa Comba Dão', '2019', 'Mourisco de Trevões', 2.15, '03ED5'),
('F456G', 'Alijo de Cima', 'Ervedosa do Douro', '2020', 'Rabigato Moreno', 245.64, '03ED5'),
('6YRG5', 'Ranhados', 'Ervedosa do Douro', '2012', 'Rabigato Moreno', 12.77, '03ED5'),
('YYHF5', 'Mouristo', 'Ervedosa do Douro', '2013', 'Rabigato Moreno', 67.79, '54W3T'),
('MHFG5', 'Silveiro', 'Ervedosa do Douro', '2011', 'Rabigato Moreno', 123.45, '6S4U3'),
('NFGH5', 'Selvagem', 'Peso da Régua', '2010', 'Touriga Nacional', 23.56, '6A3E4'),
('D5445', 'Torneira', 'Peso da Régua', '2009', 'Touriga Nacional', 13.65, '6S4U3'),
('FH5D3', 'Hortinhas', 'Peso da Régua', '2007', 'Touriga Nacional', 54.44, '6S4U3'),
('EEFD4', 'Serra - Norte', 'Peso da Régua', '2014', 'Touriga Nacional', 56.44, '6S4U3');

DELETE FROM WineDB.Terreno

SELECT * FROM WineDB.Terreno


INSERT INTO WineDB.Armazem(ID, Localizacao, Nome, ID_Adega) VALUES
('ASA12', 'Avenida Principal, 12, S.J. Pesqueira', 'Vinhos Douro', '6A3E4'),
('2SA21', 'Rua de Cima, 45, Évora', 'Alentejo Armazem', '54W3T'),
('DA221', 'Estrada Municipal 222, 23, Peso da Réguma', 'Peso dos Vinhos', '03ED5'),
('FFD33', 'Estrada Nacional 23, 45, Santa Comba Dão', 'Santa Vinhos Dão', '6S4U3'),
('GRT43', 'Rua do Lago, 23, Vila Nova de Gaia', 'Caves Gaia', '6A3E4');

DELETE FROM WineDB.Armazem

SELECT * FROM WineDB.Armazem

--NAO WORKA PQ A PRIMARY É O ID_PRODUTO AINDA, MAS VAMOS TER O MESMO PROBLEMA QUANDO MUDARMOS A PRIMARY PARA ID
INSERT INTO WineDB.Venda(ID, ID_Produto, Preco, IVA, NIF, Quantidade) VALUES
('AAAAAA', 'AS3FR', 25.0, DEFAULT , '345612398', 2),
('AAAAAA', 'SF231',20.0, DEFAULT , '345612398', 1),
('AAAAAA', 'FGDF3', 35.50 , DEFAULT , '345612398', 1),
('A1B2C3', 'G5325', 17.50, DEFAULT , '334712345', 1),
('A1B2C3', '23F54', 15.25, DEFAULT , '334712345', 3),
('BBB123', 'AR265', 5.0, DEFAULT , '276875341', 5),
('BBB123', 'AFSF2', 10.50, DEFAULT , '276875341', 2),
('BBB123', '76U6J', 50.0, DEFAULT , '276875341', 1),
('BBB123', 'G5325', 17.50, DEFAULT , '276875341', 1),
('BBB123', 'JGHJ5', 13.50, DEFAULT , '276875341', 1),
('A1B555', 'G5325', 17.50, DEFAULT , '345612398', 1),
('A1B555', 'FGDF3', 35.50, DEFAULT , '345612398', 1),
('A5B222', 'B534F', 5.55, DEFAULT , '287649264', 10),
('BABA25', 'AGTG2', 20.0, DEFAULT , '295748365', 2),
('BABA25', 'A5433', 15.99, DEFAULT , '295748365', 2),
('F0DA53', 'BN33F', 35.99, DEFAULT , '312876490', 3),
('CA4UE1', 'BN33F', 35.99, DEFAULT , '376598467', 1),
('F00053', 'JH5GT', 30.50, DEFAULT , '376598467', 1),
('D4SSE1', 'ADE23', 15.99, DEFAULT , '245678345', 2),
('ALEL14', 'AT34D', 9.99, DEFAULT , '239817654', 3);

DELETE FROM WineDB.Venda

SELECT * FROM WineDB.Venda


-- NAO DEVIA TER ID, MAS SO NIF, Q JA É UM IDENTIFICADOR
INSERT INTO WineDB.Cliente(NIF , ID) VALUES
('345612398', 1),
('334712345', 2),
('276875341', 3),
('287649264', 4),
('295748365', 5),
('312876490', 6),
('376598467', 7),
('245678345', 8),
('239817654', 9);

DELETE FROM WineDB.Cliente

SELECT * FROM WineDB.Cliente

--IBAN NAO TEM SO 16 NUMEROS MORCAO TEM 25 NUMEROS
INSERT INTO WineDB.Funcionario(NIF , IBAN, NUM_SS, Data_Inicio_Atividade) VALUES
('237489547' , 'PT50003506514866776619784', '52997233452', '2001-12-25'),
('233765487' , 'PT50003506519431633932716', '30342326822', '2010-05-13'),
('257483675' , 'PT50003506514424823965114', '41232386822', '2015-05-13'),
('374985902' , 'PT50003506512227616567972', '12345678900', '2013-11-22'),
('237598309' , 'PT50003506511968949842841', '35362376822', '2020-01-03'),
('235400888' , 'PT50003506512332944435963', '24750178211', '2021-06-01'),
('236978309' , 'PT50003506513388963216308', '52907436612', '2005-06-11'),
('236696379' , 'PT50003506515288816766635', '53087191043', '2017-01-31'),
('237588123' , 'PT50003506512872757694420', '51015954322', '2016-02-28'),
('255246336' , 'PT50003506514334729721152', '41643902866', '2015-12-03'),
('237256978' , 'PT50003506511853321374904', '36232808562', '2011-10-13'),
('234555999' , 'PT50003506512556514255258', '25366797712', '2019-05-12');

DELETE FROM WineDB.Funcionario

SELECT * FROM WineDB.Funcionario

--NAO DEVIAM TER NUMFUNC, ESTE E O OPERADOR GAY
--E DEVIAM TER COMO FOREIGN A ADEGA A Q ESTAO LIGADOS
INSERT INTO WineDB.Gerente(NIF , Num_Func) VALUES
('237489547' , '1'),
('233765487' , '2'),
('257483675' , '3'),
('374985902' , '4');

DELETE FROM WineDB.Gerente

SELECT * FROM WineDB.Gerente

INSERT INTO WineDB.OperadorAdega(NIF, Num_Func, ID_Adega) VALUES
('237598309', '5' ,'6A3E4'),
('235400888', '6' ,'6A3E4'),
('236978309', '7' ,'54W3T'),
('236696379', '8' ,'54W3T'),
('237588123', '9' ,'03ED5'),
('255246336', '10','03ED5'),
('237256978', '11','6S4U3'),
('234555999', '12','6S4U3');

DELETE FROM WineDB.OperadorAdega

SELECT * FROM WineDB.OperadorAdega

INSERT INTO WineDB.OperadorAgricola(NIF) VALUES
('227578689'),
('266699979'),
('227579113'),
('215256356'),
('207206079'),
('204009990');

DELETE FROM WineDB.OperadorAgricola

SELECT * FROM WineDB.OperadorAgricola


INSERT INTO WineDB.TipoTrabalho(NIF, Tipo_Trabalho) VALUES
('227578689','Tratorista'),
('266699979','Despejador de Baldes'),
('227579113','Cortador de uvas'),
('215256356','Cortador de uvas'),
('207206079','Cortador de uvas'),
('204009990','Cortador de uvas');

DELETE FROM WineDB.TipoTrabalho

SELECT * FROM WineDB.TipoTrabalho


INSERT INTO WineDB.Armazenado(ID_Vinho, ID_Armazem) VALUES
('AS3FR','ASA12'),
('SF231','2SA21'),
('FGDF3','DA221'),
('GDDF3','FFD33'),
('AG434','GRT43'),
('GFH54','ASA12'),
('H6G34','2SA21'),
('G5325','DA221'),
('A34R2','FFD33'),
('23F54','GRT43'),
('GTG45','ASA12'),
('GTDT5','2SA21'),
('HYD54','DA221'),
('343SF','FFD33'),
('ADE23','GRT43'),
('AHYT3','ASA12'),
('ADF34','2SA21'),
('B534F','DA221'),
('343F4','FFD33'),
('FDS42','GRT43'),
('GDF43','ASA12'),
('AGTG2','2SA21'),
('32DS2','DA221'),
('ACVT4','FFD33'),
('AFS32','GRT43'),
('A323R','ASA12'),
('AS323','2SA21'),
('232SR','DA221'),
('FSD23','FFD33'),
('434FD','GRT43'),
('AGFD3','ASA12'),
('A234F','2SA21'),
('A5433','DA221'),
('FGD43','FFD33'),
('AFSD3','GRT43'),
('BN33F','ASA12'),
('AR265','2SA21'),
('AFSF2','DA221'),
('FSD42','FFD33'),
('GDH56','GRT43'),
('76U6J','ASA12'),
('JH5GT','2SA21'),
('GFH54','DA221'),
('AHJ56','FFD33'),
('AJG56','GRT43'),
('GHJ55','ASA12'),
('JGHJ5','2SA21'),
('HF345','DA221'),
('FDE3D','FFD33'),
('AT34D','GRT43'),
('AS345','ASA12'),
('AS34T','2SA21'),
('A43RG','DA221');

DELETE FROM WineDB.Armazenado

SELECT * FROM WineDB.Armazenado

INSERT INTO WineDB.TemProdutos(ID_Armazem, ID_Venda) VALUES
('ASA12','AAAAAA'),
('2SA21','A1B2C3'),
('DA221','BBB123'),
('FFD33','A1B555'),
('GRT43','A5B222'),
('ASA12','BABA25'),
('2SA21','F0DA53'),
('DA221','CA4UE1'),
('FFD33','F00053'),
('GRT43','D4SSE1'),
('ASA12','ALEL14');

DELETE FROM WineDB.TemProdutos

SELECT * FROM WineDB.TemProdutos

INSERT INTO WineDB.Compra(ID_Venda, NIF) VALUES
('AAAAAA','345612398'),
('A1B2C3','334712345'),
('BBB123','276875341'),
('A1B555','345612398'),
('A5B222','287649264'),
('BABA25','295748365'),
('F0DA53','312876490'),
('CA4UE1','376598467'),
('F00053','376598467'),
('D4SSE1','245678345'),
('ALEL14','239817654');

DELETE FROM WineDB.Compra

SELECT * FROM WineDB.Compra

INSERT INTO WineDB.Trabalha(ID, NIF) VALUES
('FDG32', '227578689'),
('3DG43', '266699979'),
('FDG34', '227579113'),
('SDF34', '215256356'),
('GTFD3', '207206079'),
('FGDF4', '204009990');


DELETE FROM WineDB.Trabalha

SELECT * FROM WineDB.Trabalha