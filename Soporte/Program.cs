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
        System.Console.Write("opcion: ");
    }
    static string Asignarprioridad(string tipo)
    {
        string t = tipo.Trim().ToLower();
        if(t== "pagos" || t== "plataforma")
        return "Alta";
        if(t == "matricula")
        return "Media";
        return "Baja";
    }
    static bool ValidarTexto(string texto)
    {
        if(texto == null ) return false;
        if(texto.Trim() == "") return false;
        return true;
    }
    static void MostrarResumen(string cod, string nom, string tipo,string desc, string pri)
    {
        System.Console.WriteLine("RESUMEN DE SOLICITUD");
        System.Console.WriteLine("codigo: " + cod);
        System.Console.WriteLine("Nombre " + nom);
        System.Console.WriteLine("Tipo: " + tipo);
        System.Console.WriteLine("Descripcion " + desc);
        System.Console.WriteLine("Prioridad " + pri);
    }
    static void Main()
{
    int registradas = 0;

    while (registradas < 3)
    {
        MostrarMenu();
        string opcion = Console.ReadLine();

        if (opcion == "2") break;

        if (opcion != "1")
        {
            Console.WriteLine("Opcion invalida.");
            continue;
        }

        Console.Write("Codigo: ");
        string codigo = Console.ReadLine();

        if (ValidarCodigo(codigo) == false)
        {
            Console.WriteLine("Error: codigo invalido.");
            continue;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        if (ValidarTexto(nombre) == false)
        {
            Console.WriteLine("Error: el nombre es obligatorio.");
            continue;
        }

        Console.Write("Tipo (matricula/pagos/constancia/plataforma/otro): ");
        string tipo = Console.ReadLine();

        if (ValidarTipo(tipo) == false)
        {
            Console.WriteLine("Error: tipo de consulta incorrecto.");
            continue;
        }

        Console.Write("Descripcion: ");
        string descripcion = Console.ReadLine();

        string prioridad = Asignarprioridad(tipo);
        MostrarResumen(codigo, nombre, tipo, descripcion, prioridad);

        registradas++;
    }

    Console.WriteLine("Total registradas: " + registradas);
}
}