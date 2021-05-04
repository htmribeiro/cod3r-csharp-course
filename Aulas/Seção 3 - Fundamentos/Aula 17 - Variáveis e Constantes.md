# Aula 17 - Variáveis e Constantes

### Atalho

* **`CTRL` + `D`** - Duplicar linha

* Rotina de criação do arquivo da aula
  * Na pasta Fundamentos
    * `VariaveisEConstantes.cs`
  * No método **`Main()`** do **Program.cs**
    * `{"Variáveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},`

* C# é uma linguagem fortemente tipada

## Variáveis

Pode ser alterada durante a execução do algoritmo do programa

### Exemplo de Declaração:

* `double raio = 4.5;`
  * **`double`**: Tipo da variável (números de ponto flutuante)
  * **`raio`**: Nome da variável (identificador)
  * **`=`**: sinal de atribuição à variável
  * **`4.5`**: Valor atribuido à variável
  * **`;`**: para finalizar a sentença

## Constantes

Não permite que esse identificador seja alterado 
durante todo o algoritmo do programa

* `const double PI = 3.14;`
  * **`const`**: Define que o identificador será uma constante
  * **`double`**: Tipo da variável (números de ponto flutuante)
  * **`PI`**: Nome da variável (identificador)
  * **`=`**: sinal de atribuição à variável
  * **`3.14`**: Valor atribuido à variável
  * **`;`**: para finalizar a sentença

## Tipos Internos

### Tipo Booleano

* **bool** -> `true` e `false`

### Tipos Inteiros

* **byte** -> constituído por 8 Bits (0 a 255)
* **sbyte** -> tipo byte que aceita sinal, aceita um range entre positivos e negativos (-127 a 128)
  * `MinValue` -> método que exibe o valor mínimo
  * neste caso o menor valor de **sbyte**

* **short** -> constituído por 2 bytes (maior valor: 32767)

* **int** -> constituído por 4 bytes (menor valor: -2147483648)
  * Mais usado dos inteiros!
* **uint (unsigned Int)** -> constituído por 4 bytes sem sinal (menor valor: 0 - maior: 4.294.967.295)
  * `populacaoBrasileira = 207_600_000;`
  * podemos usar o "_" como separador universal
  * isso permite clareza na leitura do número no código

* **long** -> 8 bytes, range entre positivos e negativos
* **ulong (unsigned long)** -> apenas positivos
  * `populacaoMundial = 7_600_000_000;`
  * podemos usar o "_" como separador universal
  * isso permite clareza na leitura do número no código

### Tipos Reais

* **float** -> 4 bytes
  * deve ter a letra *f* após o número com ponto flutuante
  * sem essa notação o C# irá entender que o número é um **double** (que é dobro do float)

* **double** -> 8 bytes
  * Mais usado dos reais!
  * utilizar preferencialmente

* **decimal**
  * muito utilizado para números astronômicos
  * valor máximo: 79228162514264337593543950335

### Tipos Caracteres

* **char** -> 1 caractere
  * delimitado por aspas simples
  * Ex.: `char letra = 'b';`
    * se colocarmos mais de uma letra dentro das aspas simples o C# acusará erro

* **string** -> cadeia de caracteres
  * delimitado por aspas duplas
  * Ex.: `string texto = "Seja bem vindo ao Curso de C#!";`

## Notação

* **Camel Case** é a prática de escrever palavras compostas ou frases de modo que cada palavra ou abreviatura no meio da frase comece com uma letra maiúscula.

* **Pascal Case** é a prática de escrever palavras compostas ou frases de modo que cada palavra ou abreviatura comece com uma letra maiúscula.
