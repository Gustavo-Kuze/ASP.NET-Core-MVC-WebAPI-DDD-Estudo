# ASP.NET-Core-MVC-WebAPI-DDD-Estudo

### O que é DDD
DDD (Domain-Drive Design) é uma padrão arquitetural implementado ao desenvolvimento de projetos, que visa separar as responsabilidades dos componentes da aplicação em camadas, tornando a escalabilidade e manutenção do sistema muito mais facil, independente das técnologias adotadas.

### Estrutura do projeto
Nosso projeto será dividido em quatro camadas principais:

1. **Camada de aplicação**: responsável pelo projeto principal, pois é onde será desenvolvido os controladores e serviços da API. Tem a função de receber todas as requisições e direcioná-las a algum serviço para executar uma determinada ação. 
**_Possui referências das camadas Service e Domain_**.
2. **Camada de domínio**: responsável pela implementação de classes/modelos, as quais serão mapeadas para o banco de dados, além de obter as declarações de interfaces, constantes, DTOs (Data Transfer Object) e enums. **_Esta camada "Não conhece ninguém"_**.
3. **Camada de serviço**: seria o “coração” do projeto, pois é nela que é feita todas as regras de negócio e todas as validações, antes de persistir os dados no banco de dados. 
**_Possui referências das camadas Domain, Infra.Data e Infra.CrossCutting_**.
4. **Camada de infraestrutura**: é dividida em *duas sub-camadas*
- _Data_: realiza a persistência com o banco de dados, utilizando, ou não, algum ORM.
- _Cross-Cutting_: uma camada a parte que não obedece a hierarquia de camada. Como o próprio nome diz, essa camada cruza toda a hierarquia. Contém as funcionalidades que pode ser utilizada em qualquer parte do código, como, por exemplo, validação de CPF/CNPJ, consumo de API externa e utilização de alguma segurança.
Possui referências da camada Domain.
