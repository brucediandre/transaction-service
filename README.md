# TransactionService

Microsserviço desenvolvido em C# com ASP.NET Core, seguindo os princípios da Clean Architecture, com foco na gestão de transações financeiras (crédito e débito).

##  Arquitetura do Projeto

A estrutura do projeto segue uma separação por responsabilidades:
```
TransactionService/
├── API/ → Camada de apresentação (Web API)
├── Application/ → Regras de negócio e interfaces
├── Domain/ → Entidades de domínio
├── Infrastructure/ → Integração com banco de dados (MongoDB)
```

## Funcionalidades Implementadas

- Criação de transações financeiras via API (`POST /transactions`)
- Listagem de transações (`GET /transactions`)
- Estrutura de entidades e serviços pronta para expansão

## Tecnologias Utilizadas

- .NET 8
- ASP.NET Core
- MongoDB (via MongoDB Atlas)
- Clean Architecture (Domain-Driven Design)
- C#

## Como Rodar Localmente 

### Pré-requisitos

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git
- Acesso à internet para conectar com o MongoDB Atlas

### Clonar o repositório

```
git clone https://github.com/seu-usuario/TransactionService.git
cd TransactionService
```
### Restaurar os pacotes e compilar

```
dotnet restore
dotnet build
```
## Pontos Pendentes
* Testes automatizados (xUnit)
* Integração completa com MongoDB (problemas técnicos durante a execução. Sistema Linux contém algumas interferências de versões) 
* Documentação com Swagger
* Validações adicionais e autenticação
  
## Contribuição
Este projeto foi desenvolvido como parte de um desafio técnico. Focado em arquitetura limpa, boas práticas e separação de responsabilidades.

## Status: 
   Projeto parcialmente implementado – base sólida para continuação e expansão futura.
   
## Autor (a)
Desenvolvido por Diandre Bruce

Desafio técnico para a Talent Lab - 2025


