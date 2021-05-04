# Aula 16 - Comentários de Código

## Iniciando a Rotina de aula

* Criar um arquivo dentro do nosso projeto
  * Botão direito na pasta *Fundamentos*
  * Adicionar > Novo item...
  * Itens do Visual C# > Classe
  * No campo *Nome:* - nomeie o arquivo
    * Ex.: *Comentarios.cs*
  * Botão Adicionar para concluir o processo.

* Criar um método `Executar()`
  * dentro da `class Comentarios {}`

    >```cs
    > public static void Executar() {}
    >```

* Add a referência do exercício dentro de *Program.cs*
  * dentro do método **`Main()`**

    > ```cs
    > {"Comentários - Fundamentos", Comentarios.Executar},
    >```

## Comentários de Código - (2:59)

* **`//`** - Comentário de linha
  * Utilizamos para comentar uma linha de código específica
  * Para adicionar algum comentário simples sobre o trecho de código a seguir

* **`///`** - XML Comments
  * o C# tem o comentário que cria tags XML
  * como por exemplo: `<summary></summary>`
  * onde podemos criar um sumário do código desenvolvido
  * especificando, por exemplo, o que o método faz
  * especificação sobre um parâmetro se colocarmos o 
*XML Comments* diretamente acima da método com parametros
  * o C# irá criar as tags `<param></param>`
  * e tudo isso serve também para gerar documentação fora do código
  * que poderá se consumida em um formato mais amigável
    * Ex.: tag `<see cref=""/>`
      * que faz uma referência para outra parte da documentação

* **`/* */`** - Comentários de Múltipas linhas
  * Utilizamos para adicionar comentários que ocupará mais de uma linha
  * também utilizado para comentar blocos de códigos

## Boas práticas

* Faz com que tenhamos pouca necessidade de comentários no meio do código
  * Código claro
  * Bons nomes
  * fácil leitura

* Num contexto de CURSO é importante que todo o código seja comentado

* Em um contexto REAL, não faz sentido o uso de um comentário óbivio

#### Teclas de atalho

* **`CRTL`+ `C`** - para comentar uma linha ou um trecho de código selecionado

* **`CTRL` + `U`** - para descomentar uma linha ou um trecho de código selecionado

#### Menu 
* Editar > Avançado
  * Definir Seleção Como Comentário
  * Remover definição de seleção como comentário