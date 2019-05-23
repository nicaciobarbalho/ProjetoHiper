-- Scripts de criação da estrutura da aplicação Chronos Web
USE [master]
CREATE DATABASE [chronos-web];

GO

USE [chronos-web];

CREATE TABLE [Cliente] (
	Id int NOT NULL,
	Nome varchar(60) NOT NULL,
	Cpf varchar(11) NOT NULL,
	Endereco varchar(60),
	NumeroDoEndereco varchar(20),
	Bairro varchar(60),
	Cidade varchar(60),
	Uf varchar(2),
    CONSTRAINT PK_Cliente PRIMARY KEY (Id),
    CONSTRAINT UK_Cliente_Cpf UNIQUE (Cpf)
);

CREATE TABLE [Produto] (
	Id int NOT NULL,
	Nome varchar(60) NOT NULL,
	Preco decimal(12, 2) NOT NULL,
    CONSTRAINT PK_Produto PRIMARY KEY (Id)
);