
CREATE DATABASE FITFREEDB
SET DATEFORMAT DMY
USE FITFREEDB

CREATE TABLE Auth (
	Authlog		VARCHAR(20)		PRIMARY KEY,
	Authpw		VARCHAR(20)		NOT NULL
	)



CREATE TABLE Cliente (
    CLI_CPF					VARCHAR(20)						PRIMARY KEY,
    CLI_Nome				VARCHAR(70),
    CLI_Ender				VARCHAR(100),
    CLI_Tel					VARCHAR(20),
    CLI_Email				VARCHAR(40),
    CLI_Nasc				DATE,
    CLI_Medic				CHAR(1),
    CLI_MedVenc				DATE,
    fk_Professor_PROF_CPF	VARCHAR(20)
);

CREATE TABLE Mensalidade (
    PG_ID					INT IDENTITY						PRIMARY KEY,
    PG_Valor				SMALLMONEY,
    PG_Ref					DATE,
	fk_Cliente_CLI_CPF		VARCHAR(14)
);

CREATE TABLE Treino (
    TR_ID					INT IDENTITY					PRIMARY KEY,
    TR_Tipo					VARCHAR(10),
    TR_Reps					CHAR(1),
    TR_Exerc1				TEXT,
    TR_Exerc2				TEXT,
    TR_Exerc3				TEXT,
    TR_Obs					TEXT,
);

CREATE TABLE Professor (
    PROF_CPF				VARCHAR(20)						PRIMARY KEY,
    PROF_Nome				VARCHAR(60),
    PROF_Ender				VARCHAR(100),
    PROF_Tel				VARCHAR(20),
    PROF_Nasc				DATE
);

ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_2
    FOREIGN KEY (fk_Professor_PROF_CPF)
    REFERENCES Professor (PROF_CPF)
	ON DELETE CASCADE;


ALTER TABLE Mensalidade ADD CONSTRAINT FK_Mensalidade_2
    FOREIGN KEY (fk_Cliente_CLI_CPF)
    REFERENCES Cliente (CLI_CPF)
	ON DELETE CASCADE;




create view PROFCPF

as

select PROF_Nome as 'Nome', PROF_CPF as 'CPF' FROM Professor

    PROF_Ender				VARCHAR(100),
    PROF_Tel				VARCHAR(20),
    PROF_Nasc				DATE
);



CREATE VIEW CLIENTVIEW 

AS 

SELECT 

	CLI_Nome as 'Nome',
	CLI_CPF as 'CPF',
    CLI_Ender as 'Endere�o',
    CLI_Tel as 'Telefone',
    CLI_Email as 'e-mail',
    CLI_Nasc as 'Data de Nascimento',
    CLI_Medic as 'Status do Atestado M�dico',
    CLI_MedVenc as 'Vencimento do Atestado M�dico',
	PROF_Nome as 'Professor Respons�vel'

FROM Cliente inner join Professor on Cliente.fk_Professor_PROF_CPF = Professor.PROF_CPF 


CREATE VIEW ProfCadastros

as

select PROF_Nome as 'Nome', PROF_CPF as 'CPF',  PROF_Ender as 'Endere�o', PROF_Tel as 'Telefone', PROF_Nasc	as 'Data de Nascimento' FROM Professor


		


CREATE VIEW Boleto

AS

SELECT PG_ID as 'N�mero', PG_Valor as 'Valor', PG_Ref as 'M�s Referente', CLI_Nome as 'Nome do Cliente'
FROM Mensalidade inner join Cliente on Mensalidade.fk_Cliente_CLI_CPF = CLI_CPF



