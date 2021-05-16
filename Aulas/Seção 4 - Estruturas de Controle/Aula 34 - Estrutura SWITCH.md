# Aula 34 - Estrutura Switch

* EstruturaSwitch.cs
* `{"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},`

### Conceito

* Implementação de seleções múltiplas

```cs
 int nota = 0;
 
 switch (nota) {
     case 0:
         Console.WriteLine("Péssimo");
         break;
 }
```

* **`switch (int) {}`** - onde `int` é um valor numérico

* **`case 0:`** - onde `0` é um inteiro, sendo ele a primeira seleção

* **`break;`** - utilizado para encerrar estrutura atual e vá para a linha posterior, após sua execução
  * sendo obrigatório o uso dessa palavra reservada para cada `case` declarado

> Observação: 

* Dentro de um `case`
  * podemos ter mais de uma sentença de código, além do `break;`

  >```cs
  > int nota = 5;
  > 
  > switch (nota) {
  >     case 5:
  >         Console.WriteLine("Ótimo");
  >         Console.WriteLine("Parabéns");
  >         break;
  > }
  >```

  * assim como também podemos ter um bloco de códigos `{}`

  >```cs
  > int nota = 5;
  > 
  > switch (nota) {
  >     case 5: {
  >             Console.WriteLine("Ótimo");
  >             Console.WriteLine("Parabéns");
  >             break;
  >          }
  > }
  >```
