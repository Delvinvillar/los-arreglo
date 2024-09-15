

namespace inicArregloo
{
   public class arreglo
    {
        public void arreglo1()
        {
            int[] arreglo2 = new int[10];

            int contador = 0;

             Console.WriteLine( "{0} {1,8}" ,"inice ", " valor" );
            for (contador = 0; contador < arreglo2.Length; contador++)
            {
                Console.WriteLine("{0,5} {1,8}", contador, arreglo2[contador]);
                
            }
        }
    }
}
