using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilerias
{
    public class Archivos
    {
        public void CreaCSV(string fileName, string nombre, string apellido, int edad)
        {
            int miEntero = 45;//En la asignación de un entero solo se ponen números
            string miString = "Hola Fabi tienes 25 pero te ves de 20";//Para la cadena solo se coloca el texto entre comillas dobles

            if (!File.Exists(fileName))
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                StreamWriter streamWriter = new StreamWriter(fileStream);

                StringBuilder stringBuilder = new StringBuilder();


                stringBuilder.Append("Nombre").Append(",").Append("Apellido").Append(",").Append("Edad").Append(",");

                streamWriter.WriteLine(stringBuilder);

                streamWriter.Flush();
                streamWriter.Close();
                fileStream.Close();
            }

            StreamWriter streamWriterRecords = new StreamWriter(fileName, true, Encoding.Latin1);
            StringBuilder stringBuilderRecord = new StringBuilder();

            stringBuilderRecord.Append(nombre).Append(",").Append(apellido).Append(",").Append(edad).Append(",");

            streamWriterRecords.WriteLine(stringBuilderRecord);

            //streamWriterRecords.WriteLine($"{nombre},{apellido},{edad},");// a mi me late esta

            string linea = nombre + "," + apellido + "," + edad + ",";

            //streamWriterRecords.WriteLine(linea);

            streamWriterRecords.Flush();
            streamWriterRecords.Close();

        }
    }
}
