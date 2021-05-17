# Aula 35 - Estrutura While

* EstruturaWhile.cs
* `{"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},`

## Conceito

* Associado ao `While` teremos uma sentença ou um  bloco de códigos
* e essa sentença ou bloco de código, será executada **enquanto** a expressão `While` for verdadeira

* Usado para uma quantidade de repetição **indeterminada**
  * Quando não sabemos quantas repetições exatamente serão executadas
  * via de regra o `While` vai se encaixar muito bem nesse cenário

### **`Random()`**

* Classe que gera número aleatório

### Sessão de declaração

```cs
 // Sessão de declaração
 int palpite = 0;
 Random random = new Random();

 int numeroSecreto = random.Next(1, 16);
 bool numeroEncontrado = false;
 int tentativasRestantes = 3;
 int tentativas = 0;
```

* iniciando a variável `palpite` em 0, que é diferente do valor que o usuário digitar

* **`Next(1, 16)`** - será gerado número aleatório entre
  * `1` - sendo este número *inclusivo* e
  * `16` - sendo este número *exclusivo*

* iniciando a variável booleana `numeroEncontrado` com `false`

* a variável `tentativasRestantes`, que irá controlar as repetições do **`While`**, será decrementada.

* a variável `tentativas`, iniciada com zero, terá funcionalidade
  * de incrementar o número de tentativas utilizadas
  * e será utilizada pelo `While` que irá comparar se o usuário atingiu o número de tentativas

### Sessão de Implementação

```cs
// Sessão de Implementação
while (tentativasRestantes > 0 && !numeroEncontrado) {
    ...
    if (numeroSecreto == palpite) {
        ...
        var corAnterior = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Green;
        ...
        Console.BackgroundColor = corAnterior;
    }
}
```

* **`var corAnterior = Console.BackgroundColor;`**
  * Pega a cor atual do background do console para armazenar em uma variável

* **`Console.BackgroundColor = ConsoleColor.Green;`**
  * Altera a cor do background do console para verde

* **`Console.BackgroundColor = corAnterior;`**
  * Restaura a cor padrão, armazenada anteriormente na variável

### Exemplo de Laço Infinito *(!CUIDADO)*

>```cs
> while(true) {
> 
> }
>```
