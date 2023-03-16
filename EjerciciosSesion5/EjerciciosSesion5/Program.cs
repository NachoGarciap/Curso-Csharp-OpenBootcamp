//Ejercicio 1
/*Escribe un programa que:
Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.*/


Console.WriteLine("Introduzca su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Introduzca su email: ");
string email = Console.ReadLine();

Console.WriteLine("Tienes un cupon: ");
string cupon = Console.ReadLine();

double descuento = 0;
Console.WriteLine("Introduce el precio del producto: ");
double precio = Double.Parse(Console.ReadLine());

if (cupon == "si")
{
    descuento = 0.20;
}
else
{
    Console.WriteLine("No tiene ningun descuento");
}

if (descuento > 0)
{
    double precioFinal = precio - (precio * descuento);
    Console.WriteLine("El precio final, con descuento será de: " + precioFinal + " euros");
}
else
{
    Console.WriteLine("El precio final, sin descuento será de: " + precio + " euros");
}

Console.WriteLine("");
//Ejercicio 2
/*Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y 
 pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.*/


string[] lenguaje = { "C#", "Java", "C++" };

Console.WriteLine("Seleccione uno de estos lenguajes: " + "\n 1. C#" + "\n 2. Java" + "\n 3. C++");

string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine("Has elegido C#");
        break;
    case "2":
        Console.WriteLine("Has elegido Java");
        break;
    case "3":
        Console.WriteLine("Has elegido C++");
        break;
}
