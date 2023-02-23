# Avaliação Final Minsait - .Net e Angular

<h1 align="center" > Sobre o Desafio </h1>
<p align="center">
 Desenvolver um sistema de gerenciamento de livros que atenda as necessidades e ajude a livraria a se modernizar as novas tencologias online. O Atual problema da livraria que possui um grande estoque de livros, os quais não estão cadastrados em nenhum sistema, o que dificulda a identificação dos livros disponiveis e quais precisam de reposição. O sistema vem para permitir que a livraria gerencia melhor o seu estoque na forma de cadastrar novos livros, atualização dos livros cadastrados, exclusão de livros, e busca por diversos criérios como titulo, autor, editora, edição entre outros.
</p>

<h1 align="center" > Aplicação </h1>

 ###  Desenvolvimento da API utilizando dotnet 6 com Swagger, acesso ao banco de dados SQLServer com Entity Framework.
<p align="center">
  
  ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
  ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Sever-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
  ![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)
 </p>

A aplicação Consiste em duas entidades <b>Livros</b> e <b>Autores</b>, onde Livro possui uma Lista de autores com uma ligação de um para muitos. Os atributos do Livro é mostrado na tabela abaixo, o mesmo possui seu repositório e controller com as principais funções de uma API como cadastrar, atualizar, remover e pegar todos. O qual se comunica com a aplicação do front desenvolvida em Angular [aqui](https://github.com/Romenildo/Livroteria).


<h1 align="center" > Como executar a aplicação</h1>

Os recursos necessários são uma IDE para executar o codigo como o Visual Studio e o banco de dados que na aplicação é o SQL Server, e caso queria visualizar melhor a estrutura do banco de dados utiliza-se um gerenciador como SQL management.
   
- [Visual Studio ](https://visualstudio.microsoft.com/pt-br/downloads/)
- [Sql Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)   
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)


Para baixar a aplicação na sua máquina pode ser feito baixando pelo próprio github ou pelo seguinte comando:
```sh
git clone https://github.com/Romenildo/Livroteria-back.git
```

Em seguida basta abrir a aplicação no Visual studio e executá-lo.

<h1 align="center" > Mais detalhes sobre o desafio </h1>

<h2> Requisitos não funcionais</h2>

- Utilizar o .Net verão 3.1 ou superior, utilizando as dependências, tecnologias e conceitos aprendidos no
treinamento e adicionais que julgar melhor;
- Utilizar o banco de dados relacional (SQL Server ou PostgreSQL);
- É necessário persistir os dados em uma base de dados;
- Não utilize soluções prontas;

<h2> Requisitos Funcionais</h2>

- Criação do banco de dados</b>: Crie um banco de dados para armazenar as informações dos livros. O banco
de dados pode incluir tabelas para livros e autores e outras informações relevantes, conforme a tabela
abaixo:     

![imagem](https://github.com/Romenildo/Treinamento-GIT/blob/master/image.png)

- <b>Criação da interface de usuário</b>: Crie uma interface de usuário para o cadastro de livros, permitindo que
o usuário insira informações como título, subtítulo, resumo, quantidade de páginas, data de publicação,
editora, edição e autor.
- <b>Validação de dados</b>: Certifique-se de que as informações inseridas pelo usuário estejam corretas e
completas antes de serem armazenadas no banco de dados. Por exemplo, verifique se o título do livro não está em branco ou se o mesmo não está cadastrado. Siga o modelo de dados da tabela do banco para as validações.
- <b>Listagem de livros</b>: Crie uma página que liste todos os livros cadastrados no banco de dados, permitindo
que o usuário filtre usando os campos de buscas.
- <b>Edição de livros</b>: Crie uma funcionalidade que permita ao usuário editar informações de um livro já
cadastrado no banco de dados.
- <b>Exclusão de livros</b>: Crie uma funcionalidade que permita ao usuário excluir um livro já cadastrado no
banco de dados.
- <b>Testes</b>: Certifique-se de testar o aplicativo para garantir que todas as funcionalidades funcionem
corretamente e sem erros.

<h2> O que será avaliado</h2>

- Estrutura do código;    
- Boas práticas;    
- Componentes visuais;    
- Criatividade;    
- Qualidade;    
- Desenvolvimento dos requisitos mínimos.    