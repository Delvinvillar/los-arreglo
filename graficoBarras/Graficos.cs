

namespace graficoBarras
{
   public class Graficos
    {
        public static void GBarras()
        {
            int[] arreglo = { 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };
            Console.WriteLine("distribucion de las calificaciones ");

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("100");
                }
                else
                {
                    Console.Write("{0:d2}-{1:d2}: ", i * 10, i * 10 + 9);
                }
                for (int j = 0; j < arreglo[i]; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
