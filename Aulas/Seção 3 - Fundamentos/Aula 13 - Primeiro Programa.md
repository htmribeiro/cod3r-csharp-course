# Primeiro Programa

## Criando uma nova pasta no Projeto

* Na tela de **Gerenciador de Soluções**
  * botão direito no projeto *CursoCSharp*
  * Adicionar > Nova Pasta
  * Nomear a pasta como *"Fundamentos"*

## Criando um novo arquivo na pasta Fundamentos

* Na tela de **Gerenciador de Soluções**
  * botão direito na pasta *Fundamentos*
  * Adicionar > Classe...
  * no campo **Nome**
    * Nomear como *PrimeiroPrograma.cs*
  * clicar no botão [Adicionar]
  * > ***Obs.:*** *não é necessário incluir o ".cs" pois o próprio VS inclui a extensão ".cs".*

### Conceito:

#### **using** - [7:13]

* `System.Console.Write("Primeiro ");`
  * a palavra reservada *System*, está em cinza porque não há a necessidade de usá-lo, uma vez que o *System* foi declarado no **`using System;`**
  * o que simplifica a utilização dos métodos da *classe System* 
durante o desenvolvimento do código.
  * se não utilizássemos o `using`, deveriamos escrever a nossa
sentença da seguinte forma:
>```cs
> System.Console.Write("Primeiro ");
> System.Console.WriteLine("Programa");
> System.Console.WriteLine("Terminou!");
>```
  * Para adequarmos a nossa sentença devemos retirar a palavra 
reservada *System* da sentença, mantendo-a apenas na declaração do `using`.
  * `Console.Write("Primeiro ");`

### [!Tips] 
* **`CTRL` + `.`**, exibe a resolução propósta pela IDE para
correção de erros na sintáxe do código e deixá-lo mais simples e elegante.

* **`cw`** - ao digitarmos e teclarmos `TAB` a IDE irá escrever o código `Console.WriteLine();`

#### **Console.Write** - [5:40]

* Significa que o texto será escrito na linha do *console* e o prompt permanecerá na mesma linha
  * > Escreve e permanece na mesma linha

#### **Console.WriteLine** - [5:59]

* Significa que o texto será escrito na linha do *console* e o prompt irá para uma nova linha.
  * > Escreve e quebra a linha

