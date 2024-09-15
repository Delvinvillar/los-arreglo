

namespace iinicArreglo
{
  public class arreglo
  {

        public void arreglo0()
        {
            const int longitud_arreglo = 10;
            int[] arreglo1 = new int[longitud_arreglo];

            int contador = 0;
            int numero = 2;


            for (contador = 0; contador < arreglo1.Length; contador++)
            {
                arreglo1[contador] = numero + 2 * contador;


            }
            Console.WriteLine("{0}{1,8}","indice ","valor ");
                for (contador = 0; contador < arreglo1.Length; contador++)
                {
                    Console.WriteLine(" {0,5}{1,8}",contador, arreglo1[contador ]);
                    
                }
               

            

        }
    }
}
