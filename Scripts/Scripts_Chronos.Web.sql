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

CREATE TABLE [dbo].[Pedido] (
    [Id]            INT             NOT NULL,
    [ClienteId]     INT             NOT NULL,
    [ValorBruto]    DECIMAL (10, 2) NOT NULL,
    [ValorLiquido]  DECIMAL (10, 2) NOT NULL,
    [ValorDesconto] DECIMAL (10, 2) CONSTRAINT [DF_pedido_valor_desconto] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[PedidoItem] (
    [Id]            INT             NOT NULL,
    [PedidoId]      INT             NOT NULL,
    [ProdutoId]     INT             NOT NULL,
    [Quantidade]    DECIMAL (10, 2) NOT NULL,
    [ValorUnitario] DECIMAL (10, 2) NOT NULL,
    [ValorBruto]    DECIMAL (10, 2) NOT NULL,
    [ValorLiquido]  DECIMAL (10, 2) NOT NULL,
    [ValorDesconto] DECIMAL (10, 2) DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_PedidoItem] PRIMARY KEY CLUSTERED ([Id] ASC)
);

