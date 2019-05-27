-- Scripts de criação da estrutura da aplicação Chronos Windows
USE [master]
CREATE DATABASE [chronos-windows];

GO

USE [chronos-windows];
CREATE TABLE cliente
(
	id INT NOT NULL IDENTITY,
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(11) NOT NULL,
	endereco VARCHAR(100) NULL,
	numero_endereco VARCHAR(10) NULL,
	bairro VARCHAR(40) NULL,
	cidade VARCHAR(40) NULL,
	uf VARCHAR(2) NULL,
	sincronizar BIT NOT NULL,
	CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED (id ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE produto
(
	id INT NOT NULL IDENTITY,
	nome VARCHAR(100) NOT NULL,
	preco DECIMAL(10,2) NOT NULL,
	sincronizar BIT NOT NULL,
	CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED (id ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[pedido] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [cliente_id]     INT             NOT NULL,
    [valor_bruto]    DECIMAL (10, 2) NOT NULL,
    [valor_liquido]  DECIMAL (10, 2) NOT NULL,
    [valor_desconto] DECIMAL (10, 2) CONSTRAINT [DF_pedido_valor_desconto] DEFAULT ((0)) NOT NULL,
	[pedido_situacao_id]     INT     CONSTRAINT [DF_pedido_situacao_id] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_pedido] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_pedido_cliente] FOREIGN KEY ([cliente_id]) REFERENCES [dbo].[cliente] ([id]),
	CONSTRAINT [FK_pedido_situacao] FOREIGN KEY ([pedido_situacao_id]) REFERENCES [dbo].[pedido_situacao] ([id])
)

GO

CREATE TABLE [dbo].[pedido_item] (
    [id]             INT             NOT NULL,
    [pedido_id]      INT             NOT NULL,
    [produto_id]     INT             NOT NULL,
    [quantidade]     DECIMAL (10, 2) NOT NULL,
    [valor_unitario] DECIMAL (10, 2) NOT NULL,
    [valor_bruto]    DECIMAL (10, 2) NOT NULL,
    [valor_liquido]  DECIMAL (10, 2) NOT NULL,
    [valor_desconto] DECIMAL (10, 2) CONSTRAINT [DF_pedido_item_valor_desconto] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_pedido_item] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_pedido_item_produto] FOREIGN KEY ([produto_id]) REFERENCES [dbo].[produto] ([id]),
    CONSTRAINT [FK_pedido_item_pedido] FOREIGN KEY ([pedido_id]) REFERENCES [dbo].[pedido] ([id])
)


GO

CREATE TABLE [dbo].[pedido_situacao] (
    [id]        INT   NOT NULL,
    [descricao] NVARCHAR (20) NOT NULL
);

INSERT INTO pedido_situacao VALUES(1, 'DIGITANDO');
INSERT INTO pedido_situacao VALUES(2, 'FINALIZADO');