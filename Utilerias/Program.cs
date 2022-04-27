using System;

namespace Utilerias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear archivo!");

            Archivos archivos = new Archivos();

            for(int i = 0; i<10; i++)
            {
                archivos.CreaCSV("D:\\Wolf\\Desktop\\JRH Logistica\\miSegundoCSV.csv", "Fabiola", "Rodriguez", 25);
            }

            Console.WriteLine("Archivo creado!");

        }
    }
}
