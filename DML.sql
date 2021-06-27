--INSERT DATA IN THE TABLES
INSERT INTO WineDB.Adega(ID,Nome,Endereco,Cap_Max,Num_Cubas, NIF_Gerente) VALUES
('6A3E4','Solar Dona Maria','Rua de Cima, 234, Ervedosa do Douro',350000,38, '237489547'),
('54W3T','Casa dos Vinhos','Estrada Municipal 501, 12, Soutelo do Douro',1250000,80, '233765487'),
('03ED5','Boa Uva','Travessa da Laranja, 12, Anadia',250000,32, '257483675'),
('6S4U3','Adega La Rose','Estrada Nacional 10, 123, Azeitão',900000,75, '374985902');

--Select * FROM WineDB.Adega

--DELETE FROM WineDB.Adega 

INSERT INTO WineDB.Pessoa(Nome, Morada, NIF, Data_Nasc, Genero, Telemovel) VALUES
('Alfredo Costa', 'Urbanização Chave, 23, Averio', 345612398, '1987-05-16', 'M', '923454876'),
('Alexandra Silva', 'Rua das Largadas, 45, Águeda', 334712345, '1998-06-29', 'F', '931256786'),
('Pedro Figueiredo', 'Rua Fundo de Vila, 13, Trancoso', 276875341, '1997-06-19', 'M', '963426457'),
('Eva Freixo', 'Avenida Batista Lemos, 66, Peso da Régua', 287649264, '1994-06-12', 'F', '913472345'),
('Filipe Sobral', 'Travessa de Baixo, 48, Ermesinde', 295748365, '1991-07-14', 'M', '934512876'),
('Andre Figueiredo', 'Avenida Dr. Lopes, 98, Évora', 312876490, '1989-06-18', 'M', '961298645'),
('Daniel Sousa', 'Rua Vasco da Gama, 73, Lisboa', 376598467, '1993-05-11', 'M', '912876345'),
('Tiago Costa', 'Rua da Avenida, 34, Leiria', 245678345, '1999-05-22', 'M', '962846581'),
('Beatriz Augusto', 'Avenidade Principal, 38, Lamego', 239817654, '1998-03-12', 'F', '934562398'),
('Anita Pinto', 'Rua Principal, 12, Mangualde', 237489547, '1976-01-11', 'F', '919873451'),
('Miguel Silva', 'Estrada Municipal 23, 1, Guarda', 233765487, '1994-07-18', 'M', '967893541'),
('Maria Trindade', 'Estrada Nacional 222, 56, Viseu', 257483675, '1989-03-01', 'F', '923456712'),
('Inês Sequeira', 'Bairro das Laranjas, 87, Vila Real', 374985902, '1976-04-15', 'F', '961234512'),
('Sofia Sousa', 'Bairro de Santiago, 51, Porto', 237598309, '1999-05-23', 'F', '934567123'),
('Laurindo Vilas', 'Avenida Dessarges, 100, S.J.Pesqueira', 235400888, '2000-04-23', 'M', '961051386'),
('Carla Setúbal', 'Rua Lisabon, 30, Porto', 236978309, '1960-10-13', 'F', '919898982'),
('Luis Lopes', 'Urbanização Chavinha, 52, Aveiro', 236696379, '1975-06-27', 'M', '924468103'),
('Mariana Rodriguez', 'Rua do Corvo, 33 , Setúbal', 237588123, '1995-07-28', 'F', '925562223'),
('Marta Fradique', 'Rua de Biana, 50, Esposende', 255246336, '1988-08-04', 'F', '934427533'),
('Joana Rafaela', 'Bairro de Nova Deli, 150, Porto', 237256978, '2001-01-03', 'F', '933458903'),
('João Cruz', 'Rua da Laranjeira, 56, Faro', 234555999, '2002-02-15', 'M', '964554668'),
('Luisa Setúbal', 'Rua Abon, 35, Funchal', 227578689, '1980-10-13', 'F', '915598982'),
('Vitor Sanches', 'Rua dos Gatos, 13, Arouca', 266699979, '1985-04-27', 'M', '923468103'),
('Raquel Silveira', 'Rua do Pássaro, 55 , Guimarães', 227579113, '1985-02-28', 'F', '921164443'),
('Ana Frades', 'Avenida Da Boa Vontade, 50, Lisboa', 215256356, '1999-09-09', 'F', '934447733'),
('Sofia Pereira', 'Rua Dali, 10, Vila Real', 207206079, '2001-01-01', 'F', '933278903'),
('André Matosinhos', 'Rua Além, 36, Matosinhos', 204009990, '2000-01-01', 'M', '962552660'),
('Carla Costa', 'Rua do Lado, 55, Felgueiras', 243119812, '1993-06-28', 'F', '912387615'),
('Joaquim Pinto', 'Rua Sobreiro, 78, Sangalhos', 256783987, '1997-01-05', 'M', '932234876'),
('Carlos Pinto', 'Rua Sobreiro, 78, Sangalhos', 256783988, '1997-01-05', 'M', '912475612'),
('Miguel Tavares', 'Rua Daires, 19, Vale de Cambra', 298745164, '1999-08-09', 'M', '912465712'),
('Jodiónisio Muachifi', 'Rua de Deus, 666, Paraíso', 267123876, '1995-09-11', 'M', '912345765'),
('João Gomes', 'Rua dos Gatões, 12, Tomar', 276581234, '1965-03-19', 'M', '962561123'),
('João Felisberto', 'Rua Vale Grande, 87, Albufeira', 298712621, '1987-11-29', 'M', '934876189'),
('Rubén Castelhano', 'Rua de Portugal, 45, Olivença', 256473612, '1976-12-12', 'M', '916748345');

--SELECT * FROM WineDB.Pessoa

--DELETE FROM WineDB.Pessoa 

INSERT INTO WineDB.Cuba(ID, ID_Adega, Cap_Max) VALUES
(12452, '03ED5', 30093),
(23411, '03ED5', 234231),
(52143, '03ED5', 234231),
(47581, '03ED5', 234231),
(17543, '03ED5', 234231),
(54432, '03ED5', 30234),
(34234, '03ED5', 30234),
(43633, '03ED5', 30234),
(46423, '03ED5', 30234),
(16546, '03ED5', 30234),
(16453, '03ED5', 30234),
(16556, '03ED5', 30234),
(12342, '03ED5', 30234),
(15646, '03ED5', 45632),
(14564, '03ED5', 45632),
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
(19876, '54W3T', 123432),
(96755, '54W3T', 54564),
(86565, '54W3T', 54564),
(14574, '6A3E4', 54564),
(17576, '6A3E4', 54564),
(86785, '6A3E4', 54564),
(86865, '6A3E4', 54564),
(18755, '6A3E4', 54564),
(18626, '6A3E4', 54564),
(18656, '6A3E4', 54564),
(18655, '6S4U3', 54564),
(84565, '6S4U3', 35352),
(15474, '6S4U3', 35352),
(16586, '6S4U3', 35352),
(32423, '6S4U3', 35352),
(53455, '6S4U3', 35352),
(17657, '6A3E4', 35352),
(19788, '6A3E4', 35352),
(19877, '6A3E4', 35352),
(15657, '6A3E4', 35352),
(67865, '6A3E4', 423423),
(18687, '6A3E4', 423423);

--DELETE FROM WineDB.Cuba

--SELECT * from WineDB.Cuba

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

--DELETE FROM WineDB.TipoCuba

--SELECT * FROM WineDB.TipoCuba

INSERT INTO WineDB.Casta(Nome, ID, Percentagem) VALUES
('Touriga Franca', 12452, 50.0),
('Touriga Franca', 23411, 30.0),
('Touriga Franca', 52143, 30.0),
('Touriga Franca', 47581, 25.8),
('Touriga Franca', 17543, 25.8),
('Touriga Franca', 54432, 25.8),
('Touriga Franca', 34234, 25.8),
('Touriga Franca', 43633, 50.0),
('Touriga Franca', 46423, 50.0),
('Touriga Franca', 16546, 40.5),
('Touriga Franca', 16453, 40.5),
('Touriga Nacional', 16556, 35.0),
('Touriga Nacional', 12342, 35.0),
('Touriga Nacional', 15646, 35.0),
('Touriga Nacional', 14564, 24.0),
('Touriga Nacional', 16565, 24.0),
('Touriga Nacional', 12131, 24.0),
('Touriga Nacional', 87665, 24.0),
('Touriga Nacional', 78665, 24.0),
('Touriga Nacional', 18666, 44.4),
('Touriga Nacional', 18768, 44.4),
('Touriga Nacional', 14243, 44.4),
('Rabigato Moreno', 16464, 25.0),
('Rabigato Moreno', 65435, 25.0),
('Rabigato Moreno', 17544, 15.9),
('Rabigato Moreno', 65543, 15.9),
('Rabigato Moreno', 75467, 15.9),
('Rabigato Moreno', 45645, 55.0),
('Rabigato Moreno', 18767, 55.0),
('Rabigato Moreno', 18735, 55.0),
('Rabigato Moreno', 78567, 55.0),
('Gouveio Preto', 19876, 25.0),
('Gouveio Preto', 96755, 25.0),
('Gouveio Preto', 86565, 25.0),
('Gouveio Preto', 14574, 25.0),
('Gouveio Preto', 17576, 25.0),
('Gouveio Preto', 86785, 25.0),
('Gouveio Preto', 86865, 25.0),
('Gouveio Preto', 18755, 25.0),
('Gouveio Preto', 18626, 25.0),
('Gouveio Preto', 18655, 25.0),
('Gouveio Preto', 84565, 25.0),
('Gouveio Preto', 15474, 25.0),
('Gouveio Preto', 16586, 25.0),
('Mourisco de Trevões', 32423, 50.5),
('Mourisco de Trevões', 53455, 50.5),
('Mourisco de Trevões', 15657, 50.5),
('Mourisco de Trevões', 17657, 33.5),
('Mourisco de Trevões', 19788, 33.2),
('Mourisco de Trevões', 19877, 33.2),
('Mourisco de Trevões', 67865, 33.2),
('Mourisco de Trevões', 18687, 22.2),
('Mourisco de Trevões', 18656, 22.2);

--Select * FROM WineDB.Casta

INSERT INTO WineDB.Vinho(ID, ID_Cuba, Nome, DOC, ID_Casta) VALUES
('AS3FR', 12452,'Vinho Velho', 'Douro', 12452),
('SF231', 23411,'Vinho Dão', 'DÃO', 16556),
('FGDF3', 52143,'Vinho Alegre', 'Alenquer', 23411),
('GDDF3', 47581,'Vale Dona Maria', 'Douro',52143 ),
('AG434', 17543,'Vinho Velho - 2017', 'Tejo',47581 ),
('GFH54', 54432,'VZ', 'Douro', 19876),
('H6G34', 34234,'VZ', 'Douro', 96755),
('G5325', 43633,'Bajancas', 'Douro', 86565),
('A34R2', 46423,'Bajancas', 'Tejo', 17543),
('23F54', 16546,'Bajancas', 'Alentejo', 14574),
('GTG45', 16453,'Bajancas', 'Alenquer', 17576),
('GTDT5', 16556,'Vallado`s', 'Douro', 54432),
('HYD54', 12342,'Vallado`s', 'Tejo', 34234),
('343SF', 15646,'Vallado`s', 'Dão', 43633),
('ADE23', 14564,'Vallado`s', 'Douro', 12342),
('AHYT3', 16565,'Vallado`s', 'Douro', 15646),
('ADF34', 12131,'Vinho Velho - 2017', 'Douro', 14564),
('B534F', 87665,'Dona Doroteia', 'Douro', 16565),
('343F4', 78665,'Dona Doroteia', 'Douro', 12131),
('FDS42', 18666,'Dona Doroteia', 'Douro', 87665),
('GDF43', 18768,'Dona Doroteia', 'Tejo', 46423),
('AGTG2', 14243,'Dona Doroteia', 'Douro', 19788),
('32DS2', 16464,'Dona Doroteia', 'Douro', 19877),
('ACVT4', 65435,'Dona Doroteia', 'Dão', 16546),
('AFS32', 17544,'Dona Doroteia', 'Douro', 16453),
('A323R', 65543,'Romaneira', 'Douro', 67865),
('AS323', 75467,'Romaneira', 'Douro', 18687),
('232SR', 45645,'Romaneira', 'Douro', 18735),
('FSD23', 18767,'Romaneira', 'Dão', 78567),
('434FD', 18735,'Romaneira', 'Douro', 16464),
('AGFD3', 78567,'Romaneira', 'Douro', 65435),
('A234F', 19876,'Romaneira', 'Douro', 17544),
('A5433', 96755,'Romaneira', 'Alentejo', 86785),
('FGD43', 86565,'Vinho Velho - 2017', 'Alentejo', 86865),
('AFSD3', 14574,'Vinho Velho - 2017', 'Tejo',18755),
('BN33F', 17576,'Cidrô', 'Alenquer', 18626),
('AR265', 86785,'Cidrô', 'DOU', 18655),
('AFSF2', 86865,'Cidrô', 'Dão', 65543),
('FSD42', 18755,'Cidrô', 'Dão', 75467),
('GDH56', 18626,'Cidrô', 'Dão', 45645),
('76U6J', 18656,'Cidrô', 'Dão', 18767),
('JH5GT', 18655,'Aneto, Grande Reservax', 'Dão', 84565),
('GKH54', 84565,'Aneto, Grande Reservax', 'Dão', 15474),
('AHJ56', 15474,'Aneto, Grande Reservax', 'Douro', 78665),
('AJG56', 16586,'Aneto, Grande Reservax', 'Douro', 18666),
('GHJ55', 32423, 'Aciprestes', 'Alentejo', 32423),
('JGHJ5', 53455, 'Aciprestes', 'Alentejo', 53455),
('HF345', 15657, 'Aciprestes', 'Alentejo', 15657),
('FDE3D', 17657, 'Aciprestes', 'Alentejo', 17657),
('AT34D', 19788, 'Vesúvio', 'Dão', 18768),
('AS345', 19877, 'Vesúvio', 'Dão', 14243),
('AS34T', 67865, 'Vesúvio', 'Douro', 16586),
('A43RG', 18687, 'Quinta da Velha Vesga', 'Douro', 18656);

--Select * FROM WineDB.Vinho

INSERT INTO WineDB.Terreno(ID, Nome, Localizacao, Ano_Plantacao, ID_Casta, Hectares, ID_Adega) VALUES
('FDG32', 'Curtinho', 'Vale de Vila', '2012', 12452, 2.34, '03ED5'),
('3DG43', 'Ervedeiro', 'Soutelo do Douro', '2015', 16556, 5.40, '03ED5'),
('FDG34', 'Sobreiro', 'Soutelo do Douro', '2011', 12342, 80.64, '03ED5'),
('SDF34', 'Serra - Sul', 'Soutelo do Douro', '2007', 15646, 56.78, '03ED5'),
('GTFD3', 'Poças de Cima', 'Soutelo do Douro', '2008', 16565, 245.98, '03ED5'),
('FGDF4', 'Fuseiro', 'Évora', '2018', 16464, 34.12, '54W3T'),
('F5G54', 'Vale de Parada', 'Évora', '2019', 65435, 56.42, '54W3T'),
('GDGH7', 'Montijinho', 'Évora', '2016', 43633, 78.23, '6A3E4'),
('54Y32', 'Fundeira', 'Santa Comba Dão', '2015',32423, 30.34, '6S4U3'),
('FY632', 'Sobreira', 'Santa Comba Dão', '2017', 53455, 23.64, '54W3T'),
('FDY56', 'Eucaliptal', 'Santa Comba Dão', '2018', 15657, 32.74, '54W3T'),
('JHY32', 'Pinheira', 'Santa Comba Dão', '2018',17657, 12.88, '54W3T'),
('5Y665', 'Ribeiro do Centro', 'Santa Comba Dão', '2019', 19788, 2.15, '54W3T'),
('F456G', 'Alijo de Cima', 'Ervedosa do Douro', '2020', 17544, 245.64, '6A3E4'),
('6YRG5', 'Ranhados', 'Ervedosa do Douro', '2012', 19876, 12.77, '6A3E4'),
('YYHF5', 'Mouristo', 'Ervedosa do Douro', '2013', 86565, 67.79, '54W3T'),
('MHFG5', 'Silveiro', 'Ervedosa do Douro', '2011', 15474, 123.45, '6A3E4'),
('NFGH5', 'Selvagem', 'Peso da Régua', '2010', 78665, 23.56, '6A3E4'),
('D5445', 'Torneira', 'Peso da Régua', '2009', 84565, 13.65, '6A3E4'),
('FH5D3', 'Hortinhas', 'Peso da Régua', '2007',18735, 54.44, '6A3E4'),
('EEFD4', 'Serra - Norte', 'Peso da Régua', '2014', 16453, 56.44, '54W3T');

--DELETE FROM WineDB.Terreno

--SELECT * FROM WineDB.Terreno

INSERT INTO WineDB.Armazem(ID, Localizacao, Nome, ID_Adega) VALUES
('ASA12', 'Avenida Principal, 12, S.J. Pesqueira', 'Vinhos Douro', '54W3T'),
('DA221', 'Estrada Municipal 222, 23, Peso da Réguma', 'Peso dos Vinhos', '6A3E4'),
('FFD33', 'Estrada Nacional 23, 45, Santa Comba Dão', 'Santa Vinhos Dão', '03ED5'),
('GRT43', 'Rua do Lago, 23, Vila Nova de Gaia', 'Caves Gaia', '6S4U3');

--DELETE FROM WineDB.Armazem

--SELECT * FROM WineDB.Armazem

INSERT INTO WineDB.Venda(ID_Produto, Preco, IVA, Quantidade, NIF_Cliente) VALUES
('AS3FR', 25.0, DEFAULT , 2, 345612398),
('SF231',20.0, DEFAULT , 1, 345612398),
('FGDF3', 35.50 , DEFAULT , 1, 345612398),
('AFSF2', 10.50, DEFAULT , 2,276875341),
('76U6J', 50.0, DEFAULT ,1, 276875341),
('G5325', 17.50, DEFAULT , 1,287649264),
('JGHJ5', 13.50, DEFAULT , 1,287649264),
('G5325', 17.50, DEFAULT , 1,287649264),
('FGDF3', 35.50, DEFAULT , 1,287649264),
('AGTG2', 20.0, DEFAULT , 2,312876490),
('A5433', 15.99, DEFAULT , 2,312876490),
('BN33F', 35.99, DEFAULT , 3,376598467),
('BN33F', 35.99, DEFAULT , 1,376598467),
('ADE23', 15.99, DEFAULT , 2,245678345),
('AT34D', 9.99, DEFAULT , 3,239817654 );

--DELETE FROM WineDB.Venda

--SELECT * FROM WineDB.Venda

INSERT INTO WineDB.Cliente(NIF) VALUES
(345612398),
(334712345),
(276875341),
(287649264),
(295748365),
(312876490),
(376598467),
(245678345),
(239817654);

--DELETE FROM WineDB.Cliente

--SELECT * FROM WineDB.Cliente

INSERT INTO WineDB.Funcionario(NIF , IBAN, NUM_SS, Data_Inicio_Atividade) VALUES
(237489547 , 'PT85003506514866776619784', 52997233, '2001-12-25'),
(233765487 , 'PT02003506519431633932716', 30342326, '2010-05-13'),
(257483675 , 'PT89003506514424823965114', 41232386, '2015-05-13'),
(374985902 , 'PT51003506512227616567972', 12345678, '2013-11-22'),
(237598309 , 'PT10003506511968949842841', 35362376, '2020-01-03'),
(235400888 , 'PT50003506512332944435963', 24750178 ,'2021-06-01'),
(236978309 , 'PT88003506513388963216308', 52907436, '2005-06-11'),
(236696379 , 'PT42003506515288816766635', 53087191, '2017-01-31'),
(237588123 , 'PT73003506512872757694420', 51015954, '2016-02-28'),
(255246336 , 'PT07003506514334729721152', 41643902, '2015-12-03'),
(237256978 , 'PT65003506511853321374904', 36232808, '2011-10-13'),
(234555999 , 'PT56003506512556514255258', 25366797, '2019-05-12'),
(227578689 , 'PT56003506512556514212345', 25364357, '2014-10-12'),
(266699979 , 'PT56003506512551537485902', 25245667, '2013-10-11'),
(227579113 , 'PT56003506512556514209876', 25357487, '2016-05-10'),
(215256356 , 'PT56003506534251514255258', 25362345, '2018-10-09'),
(207206079 , 'PT56003506657485514255258', 25361235, '2013-12-08'),
(276581234 , 'PT56003506512556123456258', 25362389, '2011-01-07'),
(256473612 , 'PT56003506512512345677258', 25366237, '2010-03-06'),
(267123876 , 'PT56003501274893459348258', 25362153, '2009-05-05'),
(298712621 , 'PT56003506512511111111258', 25361298, '2009-07-04'),
(298745164 , 'PT56003506512556514000000', 25366123, '2014-08-03'),
(243119812 , 'PT56003506512500000000000', 22346673, '2016-09-02'),
(256783987 , 'PT56003506500000000000000', 25366434, '2013-10-01'),
(256783988 , 'PT56003506000000000000001', 25366123, '2019-06-12');

--DELETE FROM WineDB.Funcionario WHERE NIF = 234555999

--SELECT * FROM WineDB.Funcionario
--SELECT * FROM WineDB.OperadorAdega

INSERT INTO WineDB.Gerente(NIF, Num_Func) VALUES
(237489547 , 1),
(233765487 , 2),
(257483675 , 3),
(374985902 , 4);

--DELETE FROM WineDB.Gerente

--SELECT * FROM WineDB.Gerente

INSERT INTO WineDB.OperadorAdega(NIF, Num_Func, ID_Adega) VALUES
(237598309, 5 ,'6A3E4'),
(235400888, 6 ,'6A3E4'),
(236978309, 7 ,'54W3T'),
(236696379, 8 ,'54W3T'),
(237588123, 9 ,'03ED5'),
(255246336, 10,'03ED5'),
(237256978, 11,'6S4U3'),
(234555999, 12,'6S4U3');

--DELETE FROM WineDB.OperadorAdega

--SELECT * FROM WineDB.OperadorAdega

INSERT INTO WineDB.OperadorAgricola(NIF, Num_Func ,ID_Terreno) VALUES
(227578689, 13,'FDG32'),
(266699979, 14,'3DG43'),
(227579113, 15,'FDG34'),
(215256356, 16,'SDF34'),
(207206079, 17,'GTFD3'),
(276581234, 18,'FGDF4'),
(256473612, 19,'F5G54'),
(267123876, 20,'GDGH7'),
(298712621, 21,'54Y32'),
(298745164, 22,'FY632'),
(243119812, 23,'FDY56'),
(256783987, 24,'JHY32'),
(256783988, 25,'5Y665');


--DELETE FROM WineDB.OperadorAgricola

--SELECT * FROM WineDB.OperadorAgricola


INSERT INTO WineDB.TipoTrabalho(NIF, Tipo_Trabalho) VALUES
(227578689,'Tratorista'),
(266699979,'Despejador de Baldes'),
(256473612,'Despejador de Baldes'),
(227579113,'Cortador de uvas'),
(215256356,'Cortador de uvas'),
(207206079,'Cortador de uvas'),
(276581234,'Cortador de uvas'),
(267123876,'Cortador de uvas'),
(298712621,'Cortador de uvas'),
(256783988,'Cortador de uvas'),
(298745164,'Cortador de uvas'),
(243119812,'Cortador de uvas'),
(256783987,'Cortador de uvas');

--DELETE FROM WineDB.TipoTrabalho

--SELECT * FROM WineDB.TipoTrabalho

INSERT INTO WineDB.Armazenado(ID_Vinho, ID_Armazem) VALUES
('AS3FR','ASA12'),
('FGDF3','DA221'),
('GDDF3','FFD33'),
('AG434','GRT43'),
('AG434','ASA12'),
('GFH54','ASA12'),
('H6G34','ASA12'),
('G5325','ASA12'),
('A34R2','ASA12'),
('23F54','ASA12'),
('GTG45','ASA12'),
('GTDT5','ASA12'),
('HYD54','ASA12'),
('343SF','ASA12'),
('ADE23','DA221'),
('AHYT3','DA221'),
('ADF34','DA221'),
('B534F','DA221'),
('343F4','DA221'),
('FDS42','DA221'),
('GDF43','DA221'),
('AGTG2','DA221'),
('32DS2','DA221'),
('ACVT4','DA221'),
('AFS32','FFD33'),
('A323R','FFD33'),
('AS323','FFD33'),
('232SR','FFD33'),
('FSD23','FFD33'),
('434FD','FFD33'),
('AGFD3','FFD33'),
('A234F','FFD33'),
('A5433','FFD33'),
('FGD43','FFD33'),
('AFSD3','FFD33'),
('BN33F','FFD33'),
('AR265','FFD33'),
('AFSF2','FFD33'),
('FSD42','GRT43'),
('GDH56','GRT43'),
('76U6J','GRT43'),
('JH5GT','GRT43'),
('GKH54','GRT43'),
('AHJ56','GRT43'),
('AJG56','GRT43'),
('GHJ55','GRT43'),
('JGHJ5','GRT43'),
('HF345','GRT43'),
('FDE3D','GRT43'),
('AT34D','GRT43'),
('AS345','GRT43'),
('AS34T','GRT43'),
('A43RG','GRT43');

--DELETE FROM WineDB.Armazenado

--SELECT * FROM WineDB.Armazenado