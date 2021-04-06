using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PruebaTecnicaTransUnion
{
    class Utilities
    {


        /*
         *  EJERCICIO 1 : Fecha menor a hoy que esté en los 15 primeros del mes
         */
        public static bool IsValidDate(string date)
        {
            var now = DateTime.Now;
            CultureInfo provider = CultureInfo.InvariantCulture;
            try
            {   
                var enterDate = DateTime.ParseExact( date, "dd/MM/yyyy", provider);
                if (enterDate < now && enterDate.Day < 15)
                {
                    return true;
                }
                else {
                    return false;
                }   
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
                
            }
        }
        
        /*
         *  EJERCICIO 2 : Si desde la fecha de nacimiento de una persona han pasado Mas de 18 Años
         */
        public static bool IsAdultPerson(DateTime date) {
            if ((DateTime.Now - date).Days/365.25 > 18) 
                return true;
            return false;
        }
        /** EJERCICIO 5
         * Busca diferencias entre dos ID;
         * Asume que la longitud de los mismos es identica, como en los casos de prueba descritos
         **/
        public static bool IsSimilarID(string ID1, string ID2) {
            int differentDigits = 0;
            for (int i = 0; i < ID1.Length; i++) {
                if (ID1.Substring(i, 1) != ID2.Substring(i, 1)) {
                    differentDigits++;
                    if (differentDigits > 1) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
