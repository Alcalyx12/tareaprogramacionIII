using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, PROMED;
            String contador;

              Console.WriteLine("DIGITE SU PRIMER NOTA");
                contador = Console.ReadLine();


            N1 = float.Parse(contador);
              Console.WriteLine("DIGITE SU SEGUNDA NOTA");
                contador = Console.ReadLine();

            N2 = float.Parse(contador);
              Console.WriteLine("DIGITE SU TERCER NOTA");
                contador = Console.ReadLine();

            N3 = float.Parse(contador);


            PROMED = (N1+N2+N3)/3;

                if (PROMED< 3)
              {

              Console.WriteLine("USTED HA REPROBADO CON UN PROMEDIO DE: " + PROMED);

                }

                else if (PROMED>= 3)
              {

              Console.WriteLine("USTED APROBO CON UN PROMEDIO DE: " + PROMED);

                }

            Console.ReadLine();
        }
    }
}
