# Diário da Gratidão

Bem-vindo ao **Diário da Gratidão**, uma aplicação web desenvolvida com Blazor que ajuda os usuários a registrar momentos de gratidão e visualizar uma nota aleatória diariamente em um cartão colorido. Este projeto foi criado para promover reflexões positivas, permitindo que os usuários anotem pelo que são gratos e escolham cores personalizadas para os cartões.

## Descrição do Projeto

O Diário da Gratidão é uma aplicação que permite:
- **Registrar anotações**: Os usuários podem adicionar notas sobre coisas pelas quais são gratos.
- **Gerenciar cores**: Os usuários podem criar e gerenciar uma paleta de cores personalizadas para os cartões.
- **Sorteio diário**: Ao abrir o aplicativo, uma nota e uma cor aleatórias (ambas criadas pelo usuário) são exibidas em um cartão na tela inicial, incentivando uma reflexão positiva diária.

A aplicação possui três telas principais:
1. **Tela Inicial**: Exibe um cartão com uma nota sorteada e uma cor sorteada.
2. **CRUD de Notas**: Permite criar, ler, atualizar e deletar as anotações de gratidão.
3. **CRUD de Cores**: Permite criar, ler, atualizar e deletar as cores personalizadas.

## Estrutura do Projeto

O projeto é organizado em uma solução Blazor com três projetos principais:

- **`DiarioDaGratidaoV2`** (Projeto Server):
  - Contém a lógica do backend, incluindo o `Program.cs`, `NotaContext` (para conexão com o banco de dados), controllers, repositórios (`NotaRepository.cs`, `CorRepository.cs`), e configurações (`appsettings.json`).
  - Utiliza Entity Framework Core para gerenciar o banco de dados SQL Server Express.
  - Pasta `Migrations` com as migrações aplicadas (`migracao1`, `migrationPCnovo`, `migrationCor`).

- **`DiarioDaGratidaoV2.Client`** (Projeto Client):
  - Contém as páginas Razor (ex.: `Home.razor`, `Notas.razor`, `CorPage.razor`) que formam a interface do usuário.
  - Implementa a lógica do lado do cliente para interagir com o servidor.

- **`DiarioDaGratidaoV2.Shared`** (Projeto Shared):
  - Contém modelos e interfaces compartilhados, como `Nota.cs` e `Cor.cs`, usados por ambos Client e Server.

A estrutura de pastas reflete uma aplicação Blazor híbrida (Server e WebAssembly), com componentes interativos e integração com banco de dados.

## Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- **.NET 8.0 SDK** ou superior [](https://dotnet.microsoft.com/download/dotnet/8.0).
- **SQL Server Express** (ou outra edição do SQL Server) [](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
- **SQL Server Management Studio (SSMS)** (opcional, para gerenciar o banco) [](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).
- **Visual Studio 2022** (opcional, para desenvolvimento) com a carga de trabalho "Desenvolvimento ASP.NET e web".

## Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/DiarioDaGratidaoV2.git
   cd DiarioDaGratidaoV2\DiarioDaGratidaoV2\DiarioDaGratidaoV2
   ```
2. Restaure as dependências:
    ```bash
    dotnet restore
    ```
3. Instale a ferramenta EF Core CLI (se necessário):
    ```bash
    dotnet tool install --global dotnet-ef --version 8.0.10
    ```
4. Aplique as migrações para criar o banco de dados:
    ```bash
    dotnet ef database update --project DiarioDaGratidaoV2.csproj
    ```
5. Configure o certificado HTTPS (se ainda não configurado):
    ```bash
    dotnet dev-certs https --trust
    ```
6. Execute a aplicação:
    ```bash
    dotnet run --launch-profile https
    ```
Ou abra no Visual Studio, defina DiarioDaGratidaoV2 como Startup Project, selecione o perfil https e pressione F5.

A aplicação estará disponível em https://localhost:7030 (ou https://192.168.0.20:7030 na rede local).

Uso
- Tela Inicial: Ao abrir o app, veja um cartão com uma nota e cor aleatórias. Reflita sobre o conteúdo!
- CRUD de Notas: Acesse a tela de notas para adicionar, editar ou remover suas anotações de gratidão.
- CRUD de Cores: Gerencie as cores dos cartões, escolhendo nomes e códigos hexadecimais.
