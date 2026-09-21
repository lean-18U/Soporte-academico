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

        if (ValidarTexto(nombre)== false) 
        {
            System.Console.WriteLine("ERROR: el nombre es obligatorio");
            return;
        }

        Console.Write("Tipo (matricula/pagos/constancia/plataforma/otro): ");
        string tipo = Console.ReadLine();

        if(ValidarTipo(tipo) == false)
        {
            System.Console.WriteLine("Error: tipo de documento");
            return;
        }

        Console.Write("Descripcion: ");
        string descripcion = Console.ReadLine();
        
        string prioridad = Asignarprioridad(tipo);
        MostrarResumen (codigo, nombre, tipo, descripcion, prioridad);

        Console.WriteLine("Datos capturados");
    }
}