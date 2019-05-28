
DESAFIO TÉCNICO:

- O projeto contém uma aplicação Windows que faz cadastro de produtos e clientes em um banco de dados. 
- A aplicação Windows, também possui uma opção "Sincronizar" que irá enviar essas informações para a API da aplicação web. 
- Esta aplicação web, somente exibe esses clientes e produtos cadastrados no Windows.

--

ANTES DE COMEÇAR:

Execute os scripts de criação de base em seu SQL Server ou LocalDB, de sua preferência.
Altere os 3 arquivos de configuração das aplicações (Windows, API e MVC), atualizando a connection string para os bancos criados.
Alterar a URL da API no projeto Chronos.Windows no arquivo App.config.

--

OBJETIVOS:

- WINDOWS: APLICAÇÃO WINDOWS + LIBRARY COM AS INSTRUÇÕES 
Descrição:
	- Aplicação Windows que utiliza um arquitetura semelhante ao BOLOVO
	- Não possui tecnologias atuais, tendo características de aplicações "legadas".
Entregas:
	- Criar estruturas de tabelas que irão armazenar os pedidos no aplicativo Windows. Coloque este script no mesmo arquivo do script atual.
		- O pedido deve conter as seguintes informações mínimas:
			- Código,
			- Cliente,
			- Itens do pedido
				- Produto
				- Quantidade
	- Criar uma interface que irá cadastrar pedidos de venda.
	- Criar uma interface que irá listar os pedidos de venda cadastrados.
	- Criar forma de sincronização de pedidos para a API do aplicativo Web, seguindo padrões criados.

- WEB: APLICAÇÃO MVC E API:
Descrição:
	- Aplicação Web que utiliza uma arquitetura semelhante ao DDD.
	- Utilizando alguns frameworks que a Hiper utiliza, como AutoMapper, FluentValidation, Unity. Sinta-se livre para utilizá-los.
Entregas: 
	- Criar estruturas de tabelas que irão armazenar os pedidos no aplicativo Web. Coloque este script no mesmo arquivo do script atual.
	- Criar o domínio, serviços e outros padrões implementados para realizar o cadastro do pedido no aplicativo Web.
	- Criar o controller na API que irá receber as sincronizações de pedidos cadastrados no aplicativo Windows.
	- Criar controller e interface na aplicação MVC que irá listar os pedidos, e outra interface que irá detalhar o pedido.
	
--

BÔNUS:

- Talvez a aplicação possua erros que podem ser corrigidos...
- Sinta-se a vontade para realizar mudanças no projeto e mostrar pra gente que você sabe!
	
	
	