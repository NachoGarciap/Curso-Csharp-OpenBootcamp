////Ejercicio 1

///*Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 
//Es decir, un programa que presente para el 1:
//1 x 1 = 1
//1 x 2 = 2
//…
//1 x 10 = 10*/

Console.WriteLine("Introduce un numero");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Tabla de multiplicar del numero " + numero + " es: ");

int k = 1;
int resultado = 0;

while (k <= 10)
{
    resultado = numero * k;
    Console.WriteLine(numero + " x " + k + " = " + resultado);
    k++;
}
Console.WriteLine("");

//Ejercicio 2

/*Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
Tienes completa libertad para elegir el formato de la salida.*/

int numero2 = 0;
int contadorPositivos = 0;
int contadorNegativos = 0;

do
{
    Console.WriteLine("Introduce un numero");
    numero2 = int.Parse(Console.ReadLine());

    if (numero2 > 0)
    {
        contadorPositivos++;
    }
    else if (numero2 < 0)
    {
        contadorNegativos++;
    }
}
while (numero2 != 0);

Console.WriteLine("Cantidad de numeros positivos:" + contadorPositivos);
Console.WriteLine("Cantidad de numeros negativos:" + contadorNegativos);


Console.WriteLine("");


//Ejercicio 3

/*Escribe un programa que realice estos pasos:

Reciba 3 datos: ancho, alto, relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas 
y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o 
rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

****

****

Input: 3, 4, 1, relleno = false

Output:

***

**

**

*** */

Console.WriteLine("Introduce el ancho: ");
int ancho= int.Parse(Console.ReadLine());

Console.WriteLine("Introduce el alto: ");
int alto = int.Parse(Console.ReadLine());

Console.WriteLine("Tiene relleno? (s/n)");
bool relleno = (Console.ReadLine()=="s");

//si son iguales, un cuadrado
if (ancho==alto)
{
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if (relleno || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
            {
                Console.Write("*");//true
            }
            else
            {
                Console.Write(" ");//false
            }
        }
        Console.WriteLine();//hacer salto de linea
    }
}
else
{
    // Si no, dibujamos un rectángulo
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if (relleno || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
