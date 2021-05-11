# Aula 29 - Operadores Unários

* OperadoresUnarios.cs
* {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},

* **`-`:** Símbolo de **menos**
  * associado a um operando, ***inverte o sinal*** do valor aritmético contido na variável
  
  >```cs
  > var valorNegativo = -5;
  > Console.WriteLine(-valorNegativo); // output: 5
  >```

* **`!`:** Símbolo de **exclamação**
  * associado a um operando, faz uma ***negação lógica*** do resultado lógico da variável

  >```cs
  > var booleano = true;
  > Console.WriteLine(!booleano);
  >```

* **Incremento** 
  * acrescenta-se uma unidade da variável em si próprio
  * utilizando sintaxe com operador **Pós-fixado**
  * colocando o símbolo de incremento *depois do operando*

  >```cs
  > var numero1 = 2;
  > numero1++;
  > Console.WriteLine(numero1);
  >```

* **Decremento**
  * subtrai-se uma unidade da variável em si próprio
  * utilizando sintaxe com operador **Pré-fixado**
  * colocando o símbolo de decremento *antes do operando*

  >```cs
  > var numero1 = 2;
  > --numero1; //
  > Console.WriteLine(numero1);
  >```

***Observação:***

* a sintaxe **Pré-fixado** tem ordem de precedência maior que a sintaxe **Pós-fixado**
  * **`Console.WriteLine(numero1++ == --numero2);`**
    * `--numero2` - será decrementado antes da comparação
    * `numero1++` - será incrementado após a comparação
  
* O exemplo acima, fere os princípios de Boas práticas, pois mistura:
  * incremento
  * decremento
  * comparação
