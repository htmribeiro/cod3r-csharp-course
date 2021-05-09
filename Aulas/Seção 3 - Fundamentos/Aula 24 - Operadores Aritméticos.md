# Aula 24 - Operadores Aritméticos

* OperadoresAritmeticos.cs
* {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},

## Soma, Subtração e Multiplicação

```cs
// Preço Desconto
var preco = 1000.0;
var imposto = 355;
var desconto = 0.1;

double total = preco + imposto;
var totalComDesconto = total - (total * desconto);
Console.WriteLine("O preço final é {0}", totalComDesconto);
```

## Divisão e Potência

```cs
// IMC
double peso  = 93.2;
double altura = 1.88;
double imc = peso / Math.Pow(altura, 2);
Console.WriteLine($"IMC é {imc}.");
```

* **`Math.Pow()`**
  * 1o. argumento, refere-se a ***base***
  * 2o. argumento, refere-se ao ***expoente***

## Operador Módulo

```cs
// Número Par/Impar
int par = 24;
int impar = 55;
Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
```
