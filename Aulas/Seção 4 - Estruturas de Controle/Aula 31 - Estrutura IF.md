# Aula 31 - Estrutura IF

* EstruturaIf.cs
* `{"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},`

### Importando a nova estrutura no Program.cs

* `using CursoCSharp.EstruturasDeControle;`

## Funcionalidade

* Serve para selecionar num conjunto
  * uma ou mais sentença de códigos para ser executado ou não

* **`if(exp)`**
  * dentro dos parênteses terá uma expressão
  * Essa *expressão* pode ter: 
    * vários operandos
    * Essa expressão *sempre* irá retornar verdadeiro ou falso

  >```cs
  > if (exp)
  >     Sentenca;
  >```

  * a primeira sentença logo após o **`if`**
    * será executada se a *expressão* for verdadeira
    * caso contrário não será executada

* **`{ }`** - o uso das chaves são obrigatórias
  * quando tivermos mais de uma sentença associadas à *expressão*
  * serve para delimitar um bloco de sentenças

  >```cs
  > if (exp) {
  >     Sentenca;
  >     Sentenca;
  >     Sentenca;
  > }
  >```

  * Se a *expressão* for verdadeira o bloco associado será executado
  * Se a *expressão* for falsa o bloco associado não será executado

### Refatorando

> **Obs.:** Quando a variável é do tipo booleana, não é necessário fazer uma *comparação relacional* para saber se ela é verdadeira ou falsa.  

```cs
 bool bomComportamento = true;
 
 if (nota >= 9.0 && bomComportamento)
```

* nessa sentença a variável `bomComportamento` já é um operando lógico
* ou seja, **não precisamos** compará-la se verdadeira ou falsa, usando:
  * `bomComportamento == true`
  * isso seria como fazer a seguinte comparação `true == true`
* precisando testar o inverso
  * negamos ela com **`!`**
  * Ex.: **`!bomComportamento`**

* A expressão **`if (exp)`**, pode ser substituída pela seguinte expressão:

  ```cs
   bomComportamento = entrada == "S" || entrada == "s";
  ```

  * Uma vez que queremos atribuir **true**
    * à variável `bomComportamento`
    * se a expressão é *verdadeira*

* Podemos ainda utilizar uma outra sentença para substituir a comparação de **"S"** ou **"s"**

  ```cs
   bomComportamento = entrada.ToLower() == "s";
  ```

  * **`ToLower()`** - Função transformar todo caractere em minúsculo

### Advertência

* Na estrutura de controle não utilizamos o **`;`**.
  * Uma única excessão ocorrerá quando
    * 

* Estruturas de controle controlam a execução de uma ou mais sentenças

* A estrutura **`If`** controla se uma ou um bloco de sentença será executado ou não.
