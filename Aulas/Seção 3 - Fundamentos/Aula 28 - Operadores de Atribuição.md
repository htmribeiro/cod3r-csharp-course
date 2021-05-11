# Aula 28 - Operadores de Atribuição

* OperadoresAtribuicao.cs
* {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},

## Operador binário de Atribuição

* **Atribuição substitutiva** - substitui-se o valor existente na variável

  >```cs
  > var num1 = 3;
  > num1 = 7; 
  >```

* **Atribuição aditiva** - acrescenta-se um valor ao valor existente na variável

  >```cs
  > var num1 = 3;
  > num1 += 10; // num1 = num1 + 10;
  >```

* **Atribuição subtrativa** - subtrai-se um valor do valor existente na variável

  >```cs
  > var num1 = 3;
  > num1 += 10; // num1 = num1 + 10;
  > num1 -= 3; // num1 = num1 - 3;
  >```

* **Atribuição Multiplicativa** - multiplica-se um valor ao valor existente na variável

  >```cs
  > var num1 = 3;
  > num1 += 10; // num1 = num1 + 10;
  > num1 -= 3; // num1 = num1 - 3;
  > num1 *= 5; // num1 = num1 * 5;
  >```

* **Atribuição divisiva** - divide-se um valor ao valor existente na variável

  >```cs
  > var num1 = 3;
  > num1 += 10; // num1 = num1 + 10;
  > num1 -= 3; // num1 = num1 - 3;
  > num1 *= 5; // num1 = num1 * 5;
  > num1 /= 2; // num1 = num1 / 2;
  >```

* **Atribuição por valor (cópia)** - atribui-se o valor de uma variável à outra variável

  >```cs
  > int a = 1; // atribuição a partir de um literal
  > int b = a; // atribuição a partir de uma variável
  >```

## Operador unário de Atribuição

### Ocorre uma atribuição implícita

* **Atribuição com operador unário de incremento** - acrescenta-se uma unidade da variável em si próprio

  >```cs
  > a++; // a = a + 1;
  >```

* **Atribuição com operador unário de decremento** - subtrai-se uma unidade da variável em si próprio

  >```cs
  > b--; // b = b - 1;
  >```

* **Atribuição por referência** - atribui-se um valor a um local de memória referenciado na variável

  >```cs
  > dynamic c = new System.Dynamic.ExpandoObject();
  > c.nome = "João";
  >
  > dynamic d = c;
  > d.nome = "Maria";
  >
  > Console.WriteLine(c.nome);
  >```
  