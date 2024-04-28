# Email API

Esta API foi desenvolvida utilizando ASP.NET Core 8 e segue a arquitetura DDD para Implementação de envio de email, utilizando autenticação JWT. 
Conta também interfaces e injeção de dependência para facilitar a manutenção e testabilidade do código.

## Estrutura do Projeto

A estrutura do projeto é organizada da seguinte forma:

- **/src**
  - **/Api**: Contém os controllers e configurações da API.
  - **/Application**: Lógica de aplicação, serviços e mapeamento de DTOs.
  - **/Domain**: Modelos de domínio, entidades.
  - **/Infrastructure**: Implementação de infraestrutura, acesso a dados e autenticação.
## Configuração

### Requisitos

- ASP.NET Core 8 SDK

### Configuração do envio de email

1. Configure o remetente para o envio de email na `appsettings.json`.
2. Configure o usuario e senha que pode acessar a api para autenticação JWT `appsettings.json`.
