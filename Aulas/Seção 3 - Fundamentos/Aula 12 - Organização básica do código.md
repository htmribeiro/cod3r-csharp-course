# Organização Básica do Código

* Códigos em C# são organizados por sentenças de códigos 
  * Uma sentença de código é finalizada com **;**
  * pode estar em mais de uma linha
 
* Pares de chaves **{ }**
  * chaves de abertura e de fechamento
  * denominam um bloco
  * servem para agrupar um conjunto de sentenças

* Ponto **.** (separador)

* Aspas duplas **" "** - delimitadores de texto livre (Strings)

```cs
using System;

namespace CursoCSharp 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

## Executando o código criado

* Clicando no botão **Play** da IDE (modo Debug)
* Tecla **`F5`** (modo Debug)
* **`CTRL`** + **`F5`** - Mantém o terminal aberto apresentando a saída do código, até que seja precionada uma tecla para fechá-lo.