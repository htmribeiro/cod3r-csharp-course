# Aula 15 - Problema - Multiplos Main

### Erro - CS0017

> *Programa tem mais de um ponto de entrada definido. Compilar com /main para especificar o tipo que contém o ponto de entrada.*

### Possibilidades para resolver: 

* Resolução 1: Renomeando o método **`Main()`** em cada arquivo de classe.
  * Ex.: **`Main2()`**, no arquivo de classe *PrimeiroPrograma.cs*.

* Resolução 2: Alterando as propriedades do projeto
  * botão direito no projeto *CursoCSharp*
  * Opção "Propriedades" > Aplicativo
    * No campo *Objeto de inicialização:*
      * podemos definir qual ponto de entrada será lido prioritariamente pelo VS.
  * Mas para objetivo de aula iremos manter a opção *(Não definido)*, como padrão.

#### Resolução 3

* Nossas classes serão criadas com um padrão para cada aula.

>```cs
> public static void Executar() {}
>```

  * e iremos acrescentar ao nosso arquivo **Program.cs**, 
dentro do método **`Main()`** uma nova linha referenciando essa classe.  
Ex.:  
>```cs
> {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
>```

    * Descrição: *"Primeiro Programa - Fundamentos"* - para identificarmos o programa que será lido
    * Classe: *`PrimeiroPrograma`* - chamada da classe
    * Método: *`Executar`* - o método dentro dessa classe que será executado.