# Desafio: Sistema de Gerenciamento de Biblioteca Avançado

## Contexto

Você foi desafiado a desenvolver uma aplicação de console que simule o gerenciamento de uma biblioteca. O objetivo é colocar em prática conceitos avançados de Programação Orientada a Objetos (POO) em C#/.NET, integrando diversas técnicas além dos pilares básicos (abstração, encapsulamento, herança e polimorfismo).

## Objetivos do Desafio

- **Modelagem de Classes e Herança:**  
  Crie uma classe base `ItemBiblioteca` que contenha propriedades comuns a todos os itens da biblioteca (como `Titulo`, `Autor`, `Ano` e `Quantidade`). A partir dela, derive classes específicas para diferentes tipos de itens, como:
  - `Livro` – com funcionalidades de empréstimo;
  - `Revista` – que possua atributos como periodicidade;
  - `Ebook` – com propriedades como tamanho (em MB) e link de download.

- **Interfaces e Abstração:**  
  Defina uma interface `IDescarte` que declare um método para descartar um item. Cada classe derivada deverá implementar esse método de forma específica (ex.: descartar livro doado, revista reciclada, ebook deletado).

- **Delegates e Events:**  
  Implemente um mecanismo de eventos para notificar quando a quantidade de um item estiver abaixo de um certo limite ou quando houver algum evento relevante (como um empréstimo vencido). Utilize delegates para gerenciar essas notificações e exibir mensagens no terminal.

- **Coleções Genéricas e LINQ:**  
  Armazene os itens cadastrados em uma coleção genérica (por exemplo, `List<ItemBiblioteca>`) e implemente operações de busca e listagem utilizando LINQ.

- **Interação com o Usuário:**  
  Desenvolva um menu interativo no terminal que permita:
  - Cadastrar novos itens (livros, revistas e ebooks);
  - Listar todos os itens cadastrados, com a distinção entre os tipos;
  - Buscar itens por título ou autor;
  - Realizar operações de empréstimo (para itens físicos) e devolução;
  - Discarte de itens, acionando o método definido na interface `IDescarte`.

- **Princípios SOLID e Organização de Código:**  
  Estruture o código de modo que cada classe tenha uma única responsabilidade e o sistema seja facilmente extensível sem a necessidade de modificar classes já existentes. Crie classes separadas para gerenciar a lógica de empréstimos/devoluções e para operações de cadastro.

- **Bônus - Logging:**  
  Implemente um mecanismo simples de logs para registrar as principais operações (cadastro, empréstimo, devolução, descarte) realizadas pelo usuário.

## Requisitos Funcionais

1. **Cadastro de Itens:**
   - O sistema deve permitir a adição de novos itens (livros, revistas e ebooks).
   - Cada item deve possuir propriedades como título, autor, ano e quantidade.
   - Itens específicos devem ter atributos adicionais:
     - **Livro:** Pode incluir o número de exemplares e permitir operações de empréstimo.
     - **Revista:** Deve possuir atributos para periodicidade (ex.: mês e ano de publicação).
     - **Ebook:** Deve ter informações sobre tamanho (MB) e um link para download.

2. **Empréstimos e Devoluções (para itens físicos):**
   - Permitir a realização de empréstimos, decrementando a quantidade disponível.
   - Na devolução, a quantidade disponível deve ser incrementada.
   - Caso não haja exemplares disponíveis, o sistema deve informar que o item não está disponível para empréstimo.

3. **Notificações:**
   - Utilizar delegates e events para disparar notificações quando a quantidade de um item estiver abaixo de um valor definido.

4. **Busca e Listagem:**
   - Permitir a listagem de todos os itens cadastrados com uma distinção clara entre os tipos.
   - Possibilitar a busca por título ou autor utilizando LINQ.

5. **Descarte de Itens:**
   - Implementar a interface `IDescarte` para definir o comportamento de descarte para cada tipo de item.

## Requisitos Não Funcionais

- **Utilização de POO Avançada:**
  - Aplicar os conceitos de encapsulamento, herança, interfaces, polimorfismo, delegates e events.
  - Usar generics para manipulação de coleções.
  
- **Organização e Qualidade do Código:**
  - Seguir os princípios SOLID para manter um código limpo, modular e de fácil manutenção.
  - Separar as responsabilidades (por exemplo, a lógica de empréstimos não deve estar dentro das classes de itens).

## Comportamento Esperado

- O sistema deve permitir o cadastro e a categorização correta de itens (livro, revista e ebook).
- Para itens físicos, operações de empréstimo e devolução devem atualizar corretamente a quantidade disponível.
- A listagem deve exibir todos os itens com suas respectivas informações.
- O relatório (ou notificações) deve indicar quando um item está com baixa quantidade.
- Ao descartar um item, o método definido na interface `IDescarte` deve ser invocado, alterando a situação do item conforme o tipo.

## Como Executar

1. Clone este repositório.
2. Abra o projeto em sua IDE favorita (Visual Studio, Visual Studio Code ou Rider).
3. Compile o projeto utilizando o .NET SDK (ex.: `dotnet build`).
4. Execute o projeto via terminal (ex.: `dotnet run`).

## Estrutura Sugerida do Projeto

```
/BibliotecaChallenge
├── /Models
│   ├── ItemBiblioteca.cs
│   ├── Livro.cs
│   ├── Revista.cs
│   └── Ebook.cs
├── /Interfaces
│   └── IDescarte.cs
├── /Services
│   ├── EmprestimoService.cs
│   └── LogService.cs
├── Program.cs
└── README.md
```

## Conclusão

Este desafio é uma oportunidade para colocar em prática diversos conceitos avançados de POO em C#. Ao concluir o projeto, você terá desenvolvido uma aplicação de console robusta, modular e escalável, que integra técnicas de herança, interfaces, delegates, generics, SOLID e muito mais.