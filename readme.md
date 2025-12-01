<p align="center">
<img src="https://img.shields.io/static/v1?label=ASP.NET&message=Framework&color=blue&style=flat&logo=ASP.NET">
<img src="https://img.shields.io/github/commits-since/daiccordeiro/formacao-desenvolvedor.Net-Desenvolvedor.io-2024/v1.0.svg">
<img src="https://img.shields.io/github/license/daiccordeiro/formacao-desenvolvedor.Net-Desenvolvedor.io-2024">
<img src="http://img.shields.io/static/v1?label=Status&message=Em%20Desenvolvimento&color=yellow&style=flat&logo">
</p>

<p align="center">
 <a href="#sobre">Sobre</a> •
 <a href="#conteúdo">Conteúdo</a> • 
 <a href="#status">Status</a> •
 <a href="#tecnologias">Tecnologias</a> •
 <a href="#como-executar">Como Executar</a> • 
 <a href="#estrutura-de-pastas">Estrutura de Pastas</a> • 
 <a href="#licença">Licença</a> • 
</p>

---
**Estudos de C#, ASP.NET Core, Entity Framework e MVC. Através da plataforma [Desenvolvedor.io](https://desenvolvedor.io/)**
---

### Sobre
Este repositório reúne meus estudos sobre o ecossistema .NET, abrangendo desde Fundamentos da linguagem C# até desenvolvimento web utilizando ASP.NET Core, Entity Framework Core e o padrão MVC.

**O objetivo é:**
- Registrar minha evolução na plataforma .NET
- Organizar exercícios e exemplos práticos
- Servir como referência rápida para estudos e projetos futuros
Os conteúdos foram estruturados em módulos, cada um representado por uma pasta dedicada.
---

### Conteúdo
| Pasta                                      | Descrição                                                                               |
| ------------------------------------------ | --------------------------------------------------------------------------------------- |
| **01-Fundamentos-do-C#**                   | Fundamentos da linguagem C#: tipos, classes, interfaces, coleções, OOP e boas práticas. |
| **02-Iniciando-com-ASP.NET-Core**          | Introdução ao ASP.NET Core: configuração, middleware, controllers e rotas.              |
| **03-Introducao-Entity-Framework-Core**    | Primeiros conceitos do EF Core: DbContext, Migrations, CRUD, LINQ e relacionamentos.    | 
| **04-Fundamentos-do-ASP.NET-MVC**          | Estrutura do padrão MVC: Views, Controllers, Models, validação e fluxo de requisições.  | 
---

### Status
:warning: Projeto em Desenvolvimento
* Este repositório está sendo atualizado conforme avanço do estudo dos módulos.
--- 

### Tecnologias
- C#
- .NET 7/8/9/10
- ASP.NET Core
- Entity Framework Core
- ASP.NET MVC
- Visual Studio / VS Code 
---

### Como Executar
1. Clone o repositório:
``` 
git clone https://github.com/daiccordeiro/Formacao-Desenvolvedor.Net-Desenvolvedor.io-2024-e-2025
``` 
2. Entre na pasta do módulo desejado:
```
cd nome-do-modulo
```
3. Execute o projeto:
```
dotnet run
```
---

### Estrutura de Pastas
```
01-Fundamentos-do-C#/

02-Iniciando-com-ASP.NET-Core/
├── DemoAPI/
│   ├── Controllers/
│   ├── Models/
│   └── Properties/
├── DemoBlazorServer/
│   ├── Areas/
│   │   └── Identity/
│   │       └── Pages/
│   │           ├── Account/
│   │           └── Shared/
│   ├── Data/
│   │   └── Migrations/
│   ├── Pages/
│   ├── Properties/
│   ├── Shared/
│   └── wwwroot/
│       └── css/
│           ├── bootstrap/
│           └── open-iconic/
│               └── font/
│                   ├── css/
│                   └── fonts/
├── DemoBlazorWasm/
│   ├── Layout/
│   ├── Pages/
│   ├── Properties/
│   └── wwwroot/
│       ├── css/
│       │   └── bootstrap/
│       └── sample-data/
└── DemoMVC/
    ├── Areas/
    │   └── Identity/
    │       └── Pages/
    ├── Controllers/
    ├── Data/
    │   └── Migrations/
    ├── Models/
    ├── Properties/
    ├── Views/
    │   ├── Alunos/
    │   ├── Home/
    │   └── Shared/
    └── wwwroot/
        ├── css/
        ├── js/
        └── lib/
            ├── bootstrap/
            │   └── dist/
            │       ├── css/
            │       └── js/
            ├── jquery/            
            ├── jquery-validation/           
            └── jquery-validation-unobtrusive/

03-Introducao-Entity-Framework-Core/
└── CursoEFCore/
    ├── .vscode/
    ├── bin/
    │    └── Debug/
    │         └── net10.0/
    ├── Data/
    │    └── Configurations/
    ├── Domain/
    ├── Migrations/
    ├── obj/
    │    └── Debug/
    │         └── net10.0/
    └── ValueObjects/

04-Fundamentos-do-ASP.NET-MVC/
├── MinhaAppFuncional/
│   └── src/
│       └── AppMvcFuncional/
│           ├── Areas/
│           │   └── Identity/
│           │       └── Pages/
│           ├── bin/
│   			 └── Debug/
│                    └── net9.0/
│           ├── Controllers/
│           ├── Data/
│           │   └── Migrations/
│           ├── Models/
│           ├── obj/
│   		     └── Debug/
│                    └── net9.0/
│           ├── Properties/
│           ├── Views/
│           │   ├── Alunos/
│           │   ├── Home/
│           │   └── Shared/
│           └── wwwroot/
│               ├── css/
│               ├── js/
│               └── lib/
│                   ├── bootstrap/
│                   ├── font-awesome/
│                   ├── jquery/
│                   ├── jquery-validation/
│                   ├── jquery-validation-unobtrusive/
│                   └── webfonts/
└── PrimeiraApp/
    ├── bin/
    │   └── Debug/
    │       └── net8.0/
    │       └── net9.0/
    │       └── net9.0.7/
    ├── Controllers/
    ├── Data/
    ├── Migrations/
    ├── Models/
    ├── obj/
    │   └── Debug/
    │        └── net8.0/
    │        └── net9.0/
    │        └── net9.0.7/
    ├── Properties/
    ├── ViewComponents/
    ├── Views/
    │   ├── Alunos/
    │   ├── Home/
    │   ├── Shared/
    │       └── Components/
    │           └── SaudacaoAluno/
    │   └── Testes/
    └── wwwroot/
        ├── css/
        ├── js/
        └── lib/
            ├── bootstrap/
            ├── jquery/
            ├── jquery-validation/
            └── jquery-validation-unobtrusive/
```
---

### Licença
Este projeto está sob a ```Licença MIT```. 
- Sinta-se livre para usar o conteúdo como referência.
---
