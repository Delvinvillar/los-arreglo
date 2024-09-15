

namespace inicArreglo
{
public class Arreglo
    {
        public void arreglo0()
        {
            int[] arreglo2 =  { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            int contador = 0;

            Console.WriteLine("", "inice ", " valor");
           for (contador = 0; contador < arreglo2.Length; contador++)
          {
               Console.WriteLine("{0,5}{1,8}", contador, arreglo2[contador]);
              
           }
        
        }
    }
}
