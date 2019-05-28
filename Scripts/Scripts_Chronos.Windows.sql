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


CREATE TABLE [dbo].[pedido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cliente_id] [int] NOT NULL,
	[valor_bruto] [decimal](10, 2) NOT NULL,
	[valor_liquido] [decimal](10, 2) NOT NULL,
	[valor_desconto] [decimal](10, 2) NOT NULL,
	[pedido_situacao_id] [int] NOT NULL,
	[sincronizar] [bit] NOT NULL,
 CONSTRAINT [PK_pedido] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido_item]    Script Date: 28/05/2019 08:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido_item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pedido_id] [int] NOT NULL,
	[produto_id] [int] NOT NULL,
	[quantidade] [decimal](10, 2) NOT NULL,
	[valor_unitario] [decimal](10, 2) NOT NULL,
	[valor_bruto] [decimal](10, 2) NOT NULL,
	[valor_liquido] [decimal](10, 2) NOT NULL,
	[valor_desconto] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_pedido_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido_situacao]    Script Date: 28/05/2019 08:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido_situacao](
	[id] [int] NOT NULL,
	[descricao] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_pedido_situacao] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[pedido] ADD  CONSTRAINT [DF_pedido_valor_desconto]  DEFAULT ((0)) FOR [valor_desconto]
GO
ALTER TABLE [dbo].[pedido] ADD  DEFAULT ((1)) FOR [pedido_situacao_id]
GO
ALTER TABLE [dbo].[pedido] ADD  DEFAULT ((1)) FOR [sincronizar]
GO
ALTER TABLE [dbo].[pedido_item] ADD  CONSTRAINT [DF_pedido_item_valor_desconto]  DEFAULT ((0)) FOR [valor_desconto]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [FK_pedido_cliente] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [FK_pedido_cliente]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [FK_pedido_situacao] FOREIGN KEY([pedido_situacao_id])
REFERENCES [dbo].[pedido_situacao] ([id])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [FK_pedido_situacao]
GO
ALTER TABLE [dbo].[pedido_item]  WITH CHECK ADD  CONSTRAINT [FK_pedido_item_pedido] FOREIGN KEY([pedido_id])
REFERENCES [dbo].[pedido] ([id])
GO
ALTER TABLE [dbo].[pedido_item] CHECK CONSTRAINT [FK_pedido_item_pedido]
GO
ALTER TABLE [dbo].[pedido_item]  WITH CHECK ADD  CONSTRAINT [FK_pedido_item_produto] FOREIGN KEY([produto_id])
REFERENCES [dbo].[produto] ([id])
GO
ALTER TABLE [dbo].[pedido_item] CHECK CONSTRAINT [FK_pedido_item_produto]
GO
INSERT INTO pedido_situacao VALUES(1, 'DIGITANDO');
INSERT INTO pedido_situacao VALUES(2, 'FINALIZADO');
