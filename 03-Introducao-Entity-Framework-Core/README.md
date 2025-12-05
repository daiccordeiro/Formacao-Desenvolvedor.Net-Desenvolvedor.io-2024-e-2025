## Introdução ao Entity Framework Core

<br>
Projeto desenvolvido durante o curso Introdução ao EFCore, para aprender e entender os conceitos básicos do EF: mapeamentos de entidades, configurações, DbContext, migrations e como o EF Core “pensa” quando está construindo o banco. 
<br>

---


## O que foi estudado
- Diferenças entre ORM e acesso tradicional a dados.
- Configuração do `DbContext` e do modelo usando Fluent API.
- Trabalho com:
    - Propriedades complexas (`Value Objects`)
    - Relacionamentos 1:N e N:N
    - Tipos enumerados personalizados
- Criação e aplicação de Migrations.
- Estrutura mínima para um projeto Code First bem organizado.
- Como manter o projeto organizado com pastas:
    - `Data`
        - `Configurations`
    - `Domain`  
    - `Migrations`
    - `ValueObjects`
- Boas práticas que deixam o código mais sustentável a longo prazo 

---

## Estrutura principal do projeto
- 📁Data/
    - Contém toda a infraestrutura do EF Core:
        - `ApplicationContext.cs`: onde o EF Core mora, respira e decide o destino das entidades.
    - 📁Configurations/
        - Mapeamentos de cada entidade via `Fluent API`.
- 📁 Domain/
    - Modelos principais da aplicação: `Cliente`, `Pedido`, `PedidoItem` e `Produto`.
- 📁 ValueObjects/
    - enums e estruturas de valor que deixam o domínio mais expressivo: `TipoFrete`, `StatusPedido` e `TipoProduto`.
- 📁 Migrations/
    - Scripts e classes geradas pelo EFCore para criar e versionar o banco.

---

## Estrutura do Projeto
```
Curso.sln
└── Curso/
    ├── CursoEFCore.csproj
    ├── Idempotente.SQL
    ├── PrimeiraMigracao.SQL
    ├── Program.cs
    ├── Readme_EntityEFCore.md
    │
    ├── Data/
    │   ├── ApplicationContext.cs
    │   └── Configurations/
    │       ├── ClienteConfiguration.cs
    │       ├── PedidoConfiguration.cs
    │       ├── PedidoItemConfiguration.cs
    │       └── ProdutoConfiguration.cs
    │
    ├── Domain/
    │   ├── Cliente.cs
    │   ├── Pedido.cs
    │   ├── PedidoItem.cs
    │   └── Produto.cs
    │
    ├── Migrations/
    │   ├── 20251123204737_PrimeiraMigracao.cs
    │   ├── 20251123204737_PrimeiraMigracao.Designer.cs
    │   └── ApplicationContextModelSnapshot.cs
    │
    └── ValueObjects/
        ├── StatusPedido.cs
        ├── TipoFrete.cs
        └── TipoProduto.cs
```

## Tecnologias
- .NET 10
- C#
- Entity Framework Core 10
- SQL Server (localdb)
- Migrations (Code First)
- Fluent API Mapping


## Como executar
```
# Restaurar pacotes
dotnet restore

# Criar o banco a partir das migrations
dotnet ef database update

# Executar o projeto
dotnet run
```

---

## Anotações importantes
- O curso é introdutório, mas cobre exatamente o que importa para começar a usar EF Core com segurança.
- Separar domínio, value objects e configurações já dá um ar muito mais profissional ao projeto.
- Fluent API > Data Annotations (na maior parte do tempo).
- Migrations salvam vidas — e evitam o famoso “quem foi que mexeu no banco?”.
- Projeto ótimo para revisitar quando eu quiser relembrar os fundamentos sem cair em documentação gigante.