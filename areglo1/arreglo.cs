using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areglo1
{
    public class arreglo
    {
        public void arreglo0()
        {
            int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };
            int total = 0;

            int contador = 0;

            
            for (contador = 0; contador < arreglo.Length; contador++)
            {
                total += arreglo[contador];
              

            } 
            Console.WriteLine($"el total de los elementos del arreglo: {total}");

        }
    }
}
