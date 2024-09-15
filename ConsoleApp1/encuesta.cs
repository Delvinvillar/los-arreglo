

namespace ConsoleApp1
{
  public class encuesta
    {
        public static void Estudiantil()
        {
            int[] respuesta = {1,2,6,4,8,5,9,7,8,10,1,6,3,8,6,4,8,6,8,10 };
            int[] frecuencia = new int[11];
            for (int i = 0; i < respuesta.Length; i++)
            {
             ++frecuencia[respuesta[ i]];

            }
            Console.WriteLine("{0}{1,11}","calificacion","frcuencia");
            for (int j = 1; j < frecuencia.Length; j++)
            {
                Console.WriteLine("{0,12}{1,11}", j, frecuencia[j]);
            }
        }
    }
}
