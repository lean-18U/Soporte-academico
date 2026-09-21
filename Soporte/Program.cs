using System;

class Program
{
    static bool ValidarCodigo(string codigo)
    {
        if (codigo == null || codigo.Trim() == "")
            return false;
        if (codigo.Trim().Length<5)
            return false;
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Sistema de soporte academico");

        Console.Write("Codigo: ");
        string codigo = Console.ReadLine();

        if (ValidarCodigo(codigo) == false)
        {
            Console.WriteLine("Error: codigo invalido");
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Descripcion: ");
        string descripcion = Console.ReadLine();

        Console.WriteLine("Datos capturados");
    }
}