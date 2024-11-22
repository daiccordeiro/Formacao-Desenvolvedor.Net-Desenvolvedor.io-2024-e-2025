# Introdução ao ASP.NET-MVC

Padrão MVC no ASP.NET

MODELS: 
As models representam os dados da aplicação. Além disso, uma Model pode incluir a validação dos dados. Em resumo, o Model é 
a representação dos dados do mundo real que pode incluir validações de estado e regras de negócio.

VIEWS:
As Views são as "páginas" do site, responsáveis pela navegação, design, UX. Utilizamos HTML, CSS e JS. No caso do ASP.NET MVC 
temos um componente em especial, o Razor. Ele é responsável por montar e entregar a View pronta para exibição.

CONTROLLLER: 
Atua como intermediária entre a Model e a View. É a Controller que responde às ações do usuário, como cliques em botões ou links. 
Quando uma ação é disparada, a Controller é responsável por invocar o método correto que irá realiza o processamento e retornar 
os dados necessários. Então, a Controller passa esses dados para a View.