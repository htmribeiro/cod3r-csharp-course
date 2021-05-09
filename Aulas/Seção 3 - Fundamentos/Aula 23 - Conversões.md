# Aula 23 - Conversões

* Conversoes.cs
* {"Conversões - Fundamentos", Conversoes.Executar},

## Regras de conversão

* Sempre que na conversão houver possibilidade de perda de informação:
  * Devemos **explicitar** que queremos converter um tipo de número em outro

### Situações que podem haver perda de informação

1. Transformar um **número real** com casas decimais para um **inteiro**

2. **double** para **float** - onde o primeiro tem uma quantidade de armazenamento superior em relação ao segundo

> **O compilador não olha para o valor contido na variável e sim para o seu tipo, no momento da conversão.
> A menos que façamos a conversão de forma explícita, o compilador irá barrar a conversão.**

## Conversão Implícita

>```cs
> int inteiro = 10;
> double quebrado = inteiro;
>```

* Neste exemplo houve uma conversão, porém, devido a capacidade de
armazenamento do tipo **double** ser maior que a do tipo **inteiro**
o compilador não irá reclamar.

## Convesão Explícita 

### *Cast*

>```cs
> double nota = 9.7;
> int notaTruncada = (int) nota;
>```

> Obs.: Neste tipo de conversão o valor será truncado, ou seja, o decimal será **arrancado** fora.

* ***Caso a conversão não seja explicitada,***

  >```cs
  > double nota = 9.7;
  > int notaTruncada = nota;
  >```

* ***resultará no seguinte Erro:***
  > *Não é possível converter implicitamente tipo "double" em "int".
  > Existe uma conversão explícita (há uma conversão ausente?)*

### *Parse()*

>```cs
> string idadeString = Console.ReadLine();
> int idadeInteiro = int.Parse(idadeString);
>```

* ***Observação.:***
  > *Essa forma poderá gerar um erro para o programa, caso o que for digitado, não seja um número inteiro.*

### *Convert*

>```cs
> idadeInteiro = Convert.ToInt32(idadeString);
> Console.WriteLine("Resultado {0}", idadeInteiro);
>```

### *TryParse()*

* _Forma segura de realizar a conversão de **string** para **int**_
  > *Mesmo que se digite um valor que não é inteiro, será convertido para zero, __como padrão__, não gerando assim, erro no programa.*

>```cs
> Console.Write("Digite o primeiro número: ");
> string palavra = Console.ReadLine();
> int numero1;
> int.TryParse(palavra, out numero1);
> Console.WriteLine("Resultado 1: {0}", numero1);
>```

* Exemplo refatorado

>```cs
> Console.Write("Digite o segundo número: ");
> int.TryParse(Console.ReadLine(), out int numero2);
> Console.WriteLine("Resultado 2: {0}", numero2);
>```