## Principais Conceitos de POO e Classes em C#/.NET

Além dos pilares básicos (abstração, encapsulamento, herança e polimorfismo), é importante dominar também:

- **Interfaces e Classes Abstratas:**  
  Definem contratos e comportamentos que as classes concretas devem implementar, facilitando a criação de códigos
  flexíveis e reutilizáveis.

- **Delegates e Events:**  
  Permitem trabalhar com programação orientada a eventos e callbacks, essenciais para criar sistemas reativos e
  desacoplados.

- **Generics:**  
  Proporcionam segurança de tipo e reutilização de código sem a necessidade de casts, otimizando o trabalho com coleções
  e métodos.

- **Extension Methods:**  
  Permitem “estender” classes existentes sem modificá-las, adicionando funcionalidades de forma elegante.

- **Partial Classes e Static Classes:**  
  Facilitam a organização do código (dividindo a implementação de uma classe em vários arquivos) e a criação de
  utilitários sem instância.

- **SOLID e Design Patterns:**  
  Princípios e padrões que ajudam a escrever código limpo, modular e de fácil manutenção, sendo essenciais para a
  escalabilidade dos seus projetos.

- **Reflection e Atributos:**  
  Técnicas avançadas para inspecionar e manipular metadados em tempo de execução, úteis em cenários como frameworks de
  mapeamento objeto-relacional (ORM).

---

## Desafio Prático: Sistema de Gerenciamento de Biblioteca

**Objetivo:**  
Desenvolver uma aplicação de console que simule o gerenciamento de uma biblioteca, aplicando os conceitos avançados de
POO em C#.

**Requisitos do Desafio:**

1. **Modelagem de Classes:**
    - Crie uma classe base chamada `ItemBiblioteca` com propriedades comuns, como `Titulo`, `Autor`, `Ano`
      e `Quantidade`.
    - Crie classes derivadas para diferentes tipos de itens, por exemplo: `Livro`, `Revista` e `Ebook`. Cada uma pode
      ter atributos ou métodos específicos (ex.: `Livro` pode ter método para empréstimo, `Revista` pode incluir a
      periodicidade, e `Ebook` pode ter método de download).

2. **Abstração e Interfaces:**
    - Defina uma interface `IDescarte` que declare um método para descartar um item. As classes derivadas podem
      implementar esse método de forma diferenciada (ex.: descartar livro doado, revista reciclada, ebook deletado).

3. **Delegates e Events:**
    - Implemente um mecanismo de eventos para notificar quando a quantidade de um item estiver abaixo de um certo limite
      ou quando um empréstimo estiver vencido.
    - Use delegates para gerenciar essas notificações e exibir mensagens no terminal.

4. **Generics e Coleções:**
    - Utilize coleções genéricas (por exemplo, `List<ItemBiblioteca>`) para armazenar os itens cadastrados.
    - Permita operações de busca e listagem utilizando LINQ.

5. **Interação com o Usuário:**
    - Crie um menu interativo no terminal que permita ao usuário:
        - Cadastrar novos itens.
        - Listar todos os itens.
        - Buscar itens por título ou autor.
        - Realizar operações de empréstimo e devolução.
        - Descartar itens (invocando o método definido na interface).

6. **Princípios SOLID:**
    - Organize seu código aplicando os princípios SOLID (especialmente o Single Responsibility e Open/Closed) para que
      cada classe tenha apenas uma responsabilidade e o sistema seja facilmente extensível sem modificar código
      existente.

**Bônus:**

- Implemente logs simples que registrem as principais operações realizadas pelo usuário (cadastro, empréstimo,
  devolução, descarte).