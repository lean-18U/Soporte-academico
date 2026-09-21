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
    static bool ValidarTipo(string tipo)
    {
        string t = tipo.Trim().ToLower();
        if (t == "matricula") return true;
        if (t == "pagos") return true;
        if (t == "constancia") return true;
        if (t == "plataforma") return true;
        if (t == "otro") return true;
        return false;
    }
    static void MostrarMenu()
    {
        System.Console.WriteLine("BIENVENIDOS AL SOPORTE ACADEMICO");
        System.Console.WriteLine("1.- Registrar solicitud");
        System.Console.WriteLine("2.- Salir");
        System.Console.WriteLine("opcion: ");
    }
    static void Main()
    {
        Console.WriteLine("Sistema de soporte academico");

        MostrarMenu();

        Console.Write("Codigo: ");
        string codigo = Console.ReadLine();

        if (ValidarCodigo(codigo) == false)
        {
            Console.WriteLine("Error: codigo invalido");
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Tipo (matricula/pago/plataforma virtual/otros): ");
        string tipo = Console.ReadLine();

        if(ValidarTipo(tipo) == false)
        {
            System.Console.WriteLine("Error: tipo de documento");
            return;
        }

        Console.Write("Descripcion: ");
        string descripcion = Console.ReadLine();

        Console.WriteLine("Datos capturados");
    }
}