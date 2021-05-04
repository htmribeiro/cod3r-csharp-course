# Aula 18 - Inferência de Tipos

* `Inferencia.cs`
* `{"Inferências - Fundamentos", Inferencia.Executar},`

* A **inferência** dentro do C# é tratada internamente pela linguagem
* Ex.: `var nome = "Hamilton";`
* **`var`**: mesmo não sendo um padrão de tipagem forte, o C# acata
  * internamente o C# olha para o valor `"Hamilton"`
    * por estar entre aspas duplas, ele infere que o valor é um tipo **string**
  * se tentarmos colocar um valor do tipo inteiro posteriormente
  * o C# reclamará erro de conversão do tipo int para string
    * entendendo que uma variável do tipo **string**
    * não pode receber um valor inteiro

* outra deficiência da **inferência**
  * quando se cria uma variável com tipo **`var`**
  * para que o próprio compilador descubra o seu tipo
  * essa variável não pode ser criada sem um valor definido
  * se ocorrer de fazermos a atribuição em outra linha o C# reclamará o seguinte erro:
    * > `var idade;` - **declaração**
    * > `idade = 41;` - **atribuição**
    * *Variáveis de tipo implícito devem ser inicializadas*
    * > `var idade = 41;` - **declaração e inicialização**