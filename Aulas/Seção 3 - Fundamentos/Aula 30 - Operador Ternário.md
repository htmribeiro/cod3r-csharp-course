# Aula 30 - Operador Ternário

* OperadorTernario.cs
* {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

* **Operador ternário**
  * é um operador condicional
    * pode compor uma expressão relacional 
    * ou expressão relacional e lógica
    * retornará true ou false

* > Observação: Só existe um operador ternário.

  * 3 Partes do operador ternário

  >```cs
  > string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
  >```

    * Uma Expressão - que retorna verdadeiro ou falso
      * `nota >= 7.0`
    * Operando 1 - que será atribuído se a expressão for verdadeira
      * `? "Aprovado"`
    * Operando 2 - que será atribuído se a expressão for falsa
      * `: "Reprovado"`

  * **`?`** - Expressão **SE**
  * **`:`** - Expressão **SENÃO**

    * A atribução condicional, será feita conforme a sequências dos símbolos, por isso é muito importante posicionar as resposta corretamente.
