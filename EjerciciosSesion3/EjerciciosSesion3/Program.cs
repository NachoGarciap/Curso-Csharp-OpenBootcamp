using System;

struct Cliente
{
    public string nombreCompleto;
    public string telefono;
    public string direccion;
    public string email;
    public bool esNuevoCliente;

    public void PresentarDatos()
    {
        Console.WriteLine("Nombre completo: " + nombreCompleto);
        Console.WriteLine("Teléfono: " + telefono);
        Console.WriteLine("Dirección: " + direccion);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Nuevo cliente: " + (esNuevoCliente ? "Sí" : "No"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente();
        cliente1.nombreCompleto = "Nacho Garcia";
        cliente1.telefono = "636599458";
        cliente1.direccion = "Calle Cordoba";
        cliente1.email = "nachogarcia@gmail.com";
        cliente1.esNuevoCliente = true;

        cliente1.PresentarDatos();

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
