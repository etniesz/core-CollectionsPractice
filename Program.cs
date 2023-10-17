// Instrucciones
// Completa los siguientes ejercicios:​

// Tres matrices básicas
// Crea una matriz para contener los valores enteros 0 a 9.​
int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​
string[] namesArray = { "Tim", "Martin", "Nikki", "Sara" };
// Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​
bool[] booleanArray = new bool[10];
bool value = true;
for (int i = 0; i < booleanArray.Length; i++)
{
    booleanArray[i] = value;
    value = !value;

}

// Lista de Sabores
// Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​
List<string> iceCreamFlavors = new List<string>();
iceCreamFlavors.Add("Chocolate");
iceCreamFlavors.Add("Matcha");
iceCreamFlavors.Add("Vanilla");
iceCreamFlavors.Add("Teaberry");
iceCreamFlavors.Add("Strawberry");
// Imprime la longitud de esta lista después de construirla. ​
Console.WriteLine(iceCreamFlavors.Count());
// Imprime el tercer sabor de la lista y luego elimina ese valor.
Console.WriteLine(iceCreamFlavors[2]);
iceCreamFlavors.RemoveAt(2);
// Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​
Console.WriteLine(iceCreamFlavors.Count());

// Diccionario de Información del Usuario
// Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​
// Añade pares clave/valor a este diccionario donde:​
// cada clave sea un nombre de la matriz de nombres​
// cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
Dictionary<string, string> User = new Dictionary<string, string>();
foreach (string name in namesArray)
{
    Random rand = new Random();
    int index = rand.Next(0, iceCreamFlavors.Count);
    User.Add(name, iceCreamFlavors[index]);
}
// Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​
foreach (var entry in User)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}