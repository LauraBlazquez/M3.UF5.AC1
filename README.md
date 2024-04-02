# Webgrafía:

## Chat GPT:

- Prompt 1:
tengo esta lista en c#:
```
    List<Score> ranking = new List<Score>();
```
y quiero ordenarla de forma ascendente por el atributo scoring que tienen los objetos Score que forman esta lista. Como puedo hacerlo con una expresion lambda?

- Response:
Puedes ordenar la lista utilizando el método OrderBy de LINQ junto con una expresión lambda para especificar el atributo por el cual deseas ordenar. Aquí te muestro cómo puedes hacerlo:
```
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Definir la lista de objetos Score
        List<Score> ranking = new List<Score>
        {
            new Score { Name = "Player1", Scoring = 20 },
            new Score { Name = "Player2", Scoring = 15 },
            new Score { Name = "Player3", Scoring = 30 },
            new Score { Name = "Player4", Scoring = 10 }
        };

        // Ordenar la lista ascendente por el atributo scoring
        ranking = ranking.OrderBy(s => s.Scoring).ToList();

        // Mostrar la lista ordenada
        foreach (var score in ranking)
        {
            Console.WriteLine($"{score.Name}: {score.Scoring}");
        }
    }
}

// Clase Score
public class Score
{
    public string Name { get; set; }
    public int Scoring { get; set; }
}
```
En este código, la lista de objetos Score se ordena utilizando OrderBy en la expresión lambda s => s.Scoring, lo que significa que la lista se ordena en función del valor del atributo Scoring de cada objeto Score.


- Prompt 2: 
como puedo hacer para devolver esta lista ordenada de forma descendente?
```
    return ranking.OrderBy(x => x.Scoring).ToList();
```
- Response: 
Para devolver la lista ordenada de forma descendente, simplemente puedes usar el método OrderByDescending en lugar de OrderBy. Aquí está cómo puedes hacerlo:
```
    return ranking.OrderByDescending(x => x.Scoring).ToList();
```
Este cambio ordenará la lista ranking en función del atributo Scoring de forma descendente y luego la convertirá en una lista concreta antes de devolverla.

- Prompt 3:
se puede hacer un merge con dos listas?

- Response:
Sí, es posible realizar un merge (combinación) de dos listas en C#. Puedes lograrlo utilizando el método Concat de LINQ para concatenar las dos listas. Aquí tienes un ejemplo:
```
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista1 = new List<int> { 1, 2, 3 };
        List<int> lista2 = new List<int> { 4, 5, 6 };

        // Realizar un merge de las dos listas
        List<int> listaCombinada = lista1.Concat(lista2).ToList();

        // Mostrar la lista combinada
        foreach (var item in listaCombinada)
        {
            Console.WriteLine(item);
        }
    }
}
```
En este ejemplo, listaCombinada contendrá todos los elementos de lista1 seguidos por todos los elementos de lista2, en el mismo orden en que aparecen en cada lista original.
