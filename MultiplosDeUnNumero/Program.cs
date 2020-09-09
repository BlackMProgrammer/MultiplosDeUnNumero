using System;

namespace MultiplosDeUnNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplos de 5 que hay entre 1 y 1000");
            int numero = 5;

            for (int i = 0;  i < 1000; i++)
            {
                int numero2 = i % 5;

                if(numero2 == 0)
                {
                Console.WriteLine(" {0} es multiplo de 5.", i);
                }   
            }
        }
    }
}
