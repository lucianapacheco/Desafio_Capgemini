# Desafio_Capgemini
Sistema de cadastro de anúncios, desenvolvido na linguagem C# com ADO.NET(procedures) em uma aplicação Windows Forms utilizando o Sql Server 2019.
Criado por: Luciana Maria Pacheco de Melo.
Data: 16/05/2021

Para compilar o sistema: 
Abra o aquivo ddl.sql que está no destino: Business\DataBase\Transact-SQL\ddl, para poder criar as estruturas de banco de dados e da tabela.

Abra o aquivo stp_anuncio.sql que está no destino: Business\DataBase\Transact-SQL\Stored Procedures, para criar as procedures de criação, alteraração, remoção e pesquisa (CRUD).

Abra o aquivo view_anuncio.sql que está no destino: Business\DataBase\Transact-SQL\Stored Objects, para criar a View de anúncios.

O arquivo executável está na pasta Business com o nome "Anuncios.exe", ao abrir o mesmo, a pessoa é direcionada para a página inicial do sistema, onde terá uma tabela contendo os anúncios já cadastrados e um menu lateral com os botões de Cadastrar, Remover, Relatórios e Att Grid.

-Cadastrar, ao clicar no mesmo, abrirá a página de Cadastro de Anúncios, onde terá os campos necessários para o cadastro (Nome do anúncio, Cliente, Data de início, Data de término, Investimento por dia) e um botão "Cadastrar" para finalizar o cadastro.

-Remover - Selecionar a linha do anúncio na tabela e clicar no botão "Remover", este anúncio selecionado será removido do sistema.

-Relatórios, ao clicar no mesmo, abrirá a página de Relatórios de Anúncios, onde o anúncio poderá ser filtrado pelo nome do cliente e intervalo de tempo. Basta escrever o nome do Cliente no campo e marcar o checkbox "Habilitar" para poder pesquisar as Data de início e Data término. Por fim, clicar no botão "Filtrar" para realizar a filtragem.

-Att Grid: Para atualizar os anúncios da tabela, página inicial. 


OBS: Como foi utilizado um banco de dados local Sql Server 2019, a connectionstring que está no arquivo AnuncioPst.cs, na linha 22, no caminho Business\Anuncios\Persistence, está apontando para minha instância local. Para executá-lo será preciso alterar a instância.




