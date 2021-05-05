# Aula 20 - Notação Ponto

* NotacaoPonto.cs
* {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},

* Utilizamos a **Notação Ponto** para acessar os membros de classe.
  * nos dá acesso a muitas funcionalidades 
  * sempre associado ao que está antes da **Notação Ponto**. Ex.:
    * Se for um **texto**, então funcionalidades referente a texto
    * Se for **número**, então funcionalidades referente a número
    * Se for algo que esteja **vázio**, podemos usar uma **`?`**
      >```cs
      > string valorImportante = null;
      > Console.WriteLine(valorImportante?.Length);
      >```

      * Isso faz com que esse valor só seja acessado
        * se de fato a variável **`valorImportante`**
        * esteja definida
        * se estiver vazia ela não será acessada e retonará um valor vazio
      * é o que chamamos de ***Navegação Segura*** entre as chamadas- (evitar erro)
      * ***Object reference not set to an instance of an object.***

```cs
var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
```

* A variável `saudacao` irá receber 
  * uma string "olá"
  * com a **Notação Ponto** serão chamadas
    * a funcionalidade **`ToUpper()`**, que transformará esse texto em maiúsculas "OLÁ"
    * a funcionalidade **`Insert()`**, que adicionará na posição 3, o texto " World!"
    * a funcionalidade **`Replace()`**, que substituirá
      * o texto "World!"
      * pelo texto "Mundo!"

* Podemos encadear várias chamadas em uma única sentença de código.

