# Aula 21 - Lendo Dados do Console

* LendoDados.cs
* {"Lendo Dados do Console - Fundamentos", LendoDados.Executar},

## Recuperando informação do Console

* **`Console.ReadLine()`**
  * Sentença de código responsável por ler uma linha digitada no console
  * Utilizamos para pegar a entrada de dado pelo próprio console 
  * e armazenar de forma dinâmica na variável
  * Por padrão todo dado capturado pelo **`ReadLine`** é uma string

### Conversões

* Quando as informações capturadas forem dados do tipo numérico:
  * precisaremos converter conforme necessidade
  * Para isso utilizaremos o **`Parse()`**, Ex.:
  * conversão para um tipo inteiro

    >```cs
    > int idade = int.Parse(Console.ReadLine());
    >```

  * conversão para um tipo double

    >```cs
    > double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    >```

### System.Globalization

* Em relação ao *salário*, no terminal o separador de casas decimais deverá ser digitado com:
  * *vírgula*,  se a configuração do Sistema Operacional estiver em pt-BR.

  * *ponto*, se a configuração do Sistema Operacional estiver no padrão americano.

> Porém é possível padronizarmos o *ponto* como separador de casas decimais, independente da configuração do S.O.

Pra isso utilizaremos do **`System.Globalization;`** o
  * **`CultureInfo.InvariantCulture`**
  * Ou seja, utilizará a *cultura Invariante*
  * não olhando para o símbolos culturais configurados no S.O.