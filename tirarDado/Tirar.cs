using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tirarDado
{
 public  class Tirar
    {
        public void  Dado() 
        {
            Random numeroAleatorio = new Random();
            int[] frecuencia =new int [7];

            for (int i = 1; i <= 6000; i++)
            {
                ++frecuencia[numeroAleatorio.Next(1, 7)];
                
            }
            Console.WriteLine("{0}{1,10}", "cara", "frecuencia");
            for (int cara = 1; cara < frecuencia.Length; cara++)
            {
                Console.WriteLine("{0,4}{1,10}",cara, frecuencia[cara]);
            
            }
        
        }
    }
}
