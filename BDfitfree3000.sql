
CREATE DATABASE DBFITFREEV1
SET DATEFORMAT DMY
USE DBFITFREEV1

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


CREATE VIEW CLIENTVIEW 

AS 

SELECT 

	CLI_Nome as 'Nome',
	CLI_CPF as 'CPF',
    CLI_Ender as 'Endereço',
    CLI_Tel as 'Telefone',
    CLI_Email as 'e-mail',
    CLI_Nasc as 'Data de Nascimento',
    CLI_Medic as 'Status do Atestado Médico',
    CLI_MedVenc as 'Vencimento do Atestado Médico',
	PROF_Nome as 'Professor Responsável'

    from Cliente inner join Professor on Cliente.fk_Professor_PROF_CPF = Professor.PROF_CPF 
