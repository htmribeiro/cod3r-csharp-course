# Aula 22 - Formatando Números

* FormatandoNumero.cs
* {"Formatando Número - Fundamentos", FormatandoNumero.Executar},

## Símbolos de Formatação

>```cs
> double valor = 15.175;
> Console.WriteLine(valor.ToString("F1"));
>```

* **`ToString("F1")`**
  * Transformamos o valor numérico para uma string
  * Dentro dele informamos qual o tipo de critério/formatação ele deve usar

  * **`"F1"`(float)** - Formata o número decimal com apenas **uma casa decimal**
    * as casas decimais serão arredondadas para exibir apenas um valor após a vírgula

  * **`"C"` (currency)** - Formata o **`valor`** e exibe como um valor monetário

  * **`"P"` (Percent)** - Multiplica o **`valor`** por 100 e Formata a exibição em percentual

  * **`"#.##"`** - Formatação como máscara para ser exibido
    * as casas decimais também sofrerão arredondamento

  * para este exemplo podemos padronizar a *cultura* de exibição
  * independente da configuração do SO, pra isso:
    > `using System.Globalization;`

>```cs
> CultureInfo culturaBr = new CultureInfo("pt-BR");
> Console.WriteLine(valor.ToString("C0", culturaBr));
>```

* 1º parâmetro: **`"C0"`** - Currency sem casas decimais
* 2º parâmetro: **`cultura`** - exibir conforme a cultura parametrizada

>```cs
> int inteiro = 256;
> Console.WriteLine(inteiro.ToString("D10"));
>```

* **`"D10"`** - Formata para *decimal* com 10 posições, completando com **zeros a esquerda**
