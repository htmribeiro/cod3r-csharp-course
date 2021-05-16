# Aula 32 - Estrutura IF/ELSE

* EstruturaIfElse.cs
* `{"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar},`

* Sempre um dos dois será executado
* Nunca os dois serão executados

```cs
 double nota = 7.0;

 if (nota >= 7.0) {
     Console.WriteLine("Aprovado!");
     Console.WriteLine("Não fez mais que sua obrigação...");
 } else {
     Console.WriteLine("Recuperação");
 }
```

* **`if ()`**
  * A utilização das **`{}`** se dá por haver mais de uma sentença para ser executada.
  * Representando um bloco de código associado a ele

* **`else`**
  * a mesma sintaxe da utilização das **`{}`** no `if`, também serve para o `else`
  * por convenção estética aplicaremos as ***chaves*** em todos os blocos `else`
  * mesmo que haja apenas uma sentença para ser executada
