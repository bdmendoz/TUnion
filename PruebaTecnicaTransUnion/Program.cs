using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Linq;

namespace PruebaTecnicaTransUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios Prueba Tecnica!");
            // Ejercicio 1
            Ejercicio1("12/12/2020");
            Ejercicio1("07/04/2021");

            // Ejercicio 2
            Ejercicio2(new DateTime(2003, 04, 04));
            Ejercicio2(new DateTime(2003, 04, 07));
            // Ejercicio 3 - Ver SCRIPT SQL ADJUNTO A LA PRUEBA
            // Ejercicio 4
            //promedio 6 meses
            Ejercicio4(6);
            //promedio 3 meses
            Ejercicio4(3);
            //promedio 1 mes
            Ejercicio4(1);
            //Ejecución Ejercicio 5

            Ejercicio5("123457789", "123456789");
            Ejercicio5("123456789", "125456789");
            Ejercicio5("123456789", "125457789");  
            



        }
        static void Ejercicio1(string fecha)
        {
            Console.WriteLine("");
            Console.WriteLine("Ejecucion Ejercicio1 " + fecha);
            var esFechaVal = Utilities.IsValidDate(fecha);
            Console.WriteLine("La fecha {0} es {1}", fecha, esFechaVal ? "Valida" : "Invalida");
            Console.WriteLine("Condiciones \n  Fecha Menor a actual \n Fecha en Los primeros 15 dias del mes");

        }
        static void Ejercicio2(DateTime dateTime)
        {
            Console.WriteLine("");
            bool personaAdulta = Utilities.IsAdultPerson(dateTime);
            Console.WriteLine("Ejecucion Ejercicio2 : Persona con fecha Nacimiento {0}", dateTime.ToShortDateString());
            Console.WriteLine("Persona {0} mayor de edad", personaAdulta ? "es" : "no es");
        }
        static void Ejercicio4(int meses)
        {
            Console.WriteLine("");
            Console.WriteLine("Ejercicio 4 : XML");
            var xmlData = File.ReadAllText("data.xml");
            ListaSalarios ls;

            var ser = new XmlSerializer(typeof(ListaSalarios));
            using (var stringReader = new StringReader(xmlData))
            {
                ls = (ListaSalarios)ser.Deserialize(stringReader);
            }
            var salariosAnio = ls.Anualidad.Salarios;
            var promedio = salariosAnio.TakeLast(meses).Average(item => item.Valor);
            Console.WriteLine("el salario Promedio de los ultimos {0} meses corresponde a {1}", meses, promedio);
        }
        static void Ejercicio5(string a , string b)
        {
            Console.WriteLine("");
            bool esIdSimilar= Utilities.IsSimilarID(a, b);
            if (esIdSimilar)
            {
                Console.WriteLine("Las cadenas {0}, {1} son similares; no difieren por más de un caracter", a, b);
            }
            else {
                Console.WriteLine("Las cadenas {0}, {1} NO son similares; difieren por más de un caracter", a, b);
            }
        }
    }
}
