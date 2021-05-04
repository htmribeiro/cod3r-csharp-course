# Aula 19 - Interpolação de Strings

* Interpolacao.cs
* `{"Interpolação de Strings - Fundamentos", Interpolacao.Executar},`

* Até aqui estavamos utilizando como padrão,
  * a **concatenação** para exibição do texto no console.
  * Ex.:
  
    >```cs
    > Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");
    >```

## Utilizando a interpolação

### Primeira forma: 

* Numerando as interpolações com índices

```cs
 Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco);
```

### Segunda forma:

* Informando os nomes das próprias variáveis
* para isso, add **`$`** (modificador) no início da string.

```cs
 Console.WriteLine($"A marca {marca} é legal!");
```