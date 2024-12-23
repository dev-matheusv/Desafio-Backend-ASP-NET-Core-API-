# Desafio Backend - C# ASP.NET Core API

Este projeto foi desenvolvido como parte de um desafio de backend. A aplicação foi construída utilizando C# e ASP.NET Core, seguindo as práticas de desenvolvimento em camadas (Layered Architecture), com as seguintes camadas principais:

## Camadas do Projeto

- **API / Controllers**: Responsável pelas interações com o cliente, onde as rotas são definidas.
- **Services**: Contém a lógica de negócios, realizando operações de manipulação de dados.
- **Repository**: Camada responsável pela interação direta com o banco de dados, utilizando Entity Framework Core para realizar as operações de CRUD.

## Entidades

O projeto representa duas entidades principais:

### User

- **ID**: Identificador único do usuário.
- **Nome**: Nome completo do usuário.
- **Nascimento**: Data de nascimento do usuário.
- **CPF**: CPF do usuário.

### Wallet

- **ID**: Identificador único da carteira.
- **UserID**: Relacionamento com o usuário.
- **ValorAtual**: Valor presente na carteira.
- **Banco**: Nome do banco associado à carteira.
- **UltimaAtualizacao**: Data e hora da última atualização da carteira.

Essas entidades são armazenadas em uma instância local do SQL Server.

## Funcionalidades

O objetivo do projeto é implementar duas APIs com as seguintes funcionalidades:

- **UserController**: Responsável por cadastrar um novo usuário.
- **WalletController**:
  - Cadastrar uma nova carteira.
  - Obter uma lista de carteiras associadas a um usuário.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework utilizado para o desenvolvimento da API.
- **Entity Framework Core**: Para gerenciamento de banco de dados e manipulação das entidades.
- **SQL Server**: Banco de dados utilizado para persistência de dados.
