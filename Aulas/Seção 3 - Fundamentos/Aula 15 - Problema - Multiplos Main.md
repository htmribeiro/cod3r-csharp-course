# Aula 15 - Problema - Multiplos Main

### Erro - CS0017

> *Programa tem mais de um ponto de entrada definido. Compilar com /main para especificar o tipo que contém o ponto de entrada.*

### Possíveis resoluções: 

* Resolução 1: Renomeando o método **`Main()`** em cada arquivo de classe.
  * Ex.: **`Main2()`**, no arquivo de classe *PrimeiroPrograma.cs*.

* Resolução 2: Alterando as propriedades do projeto
  * botão direito no projeto *CursoCSharp*
  * Opção "Propriedades" > Aplicativo
    * No campo *Objeto de inicialização:*
      * podemos definir qual ponto de entrada será lido prioritariamente pelo VS.
  * Mas para objetivo de aula iremos manter a opção *(Não definido)*, como padrão.

#### Resolução 3: