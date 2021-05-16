# Aula 33 - Estrutura IF/ELSE IF

* EstruturaIfElseIf.cs
* `{"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},`

* Com essa estrutura, poderemos trabalhar com múltiplas seleções, utilizando

## Conceito

* **`if()`** - para condição verdadeira
* **`else if()`** - associando uma outra condição para ser testada

```cs
 if (nota >= 9.0) {
     Console.WriteLine("Quadro de Honra!");
 } else {
     if (nota >= 7.0) {
         Console.WriteLine("Aprovado!");
     } else {
         if (nota >= 5.0) {
             Console.WriteLine("Recuperação");
         } else {
               Console.WriteLine("Te vejo na próxima...");
         }
     }
 }

 Console.WriteLine("Fim!");
```

### Simplificando

```cs
 if (nota >= 9.0) {
     Console.WriteLine("Quadro de Honra!");
 } else if (nota >= 7.0) {
     Console.WriteLine("Aprovado!");
 } else if (nota >= 5.0) {
     Console.WriteLine("Recuperação");
 } else {
     Console.WriteLine("Te vejo na próxima...");
 }

 Console.WriteLine("Fim!");
```
