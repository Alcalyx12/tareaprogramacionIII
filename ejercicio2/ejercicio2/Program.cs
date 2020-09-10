using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int EDAD;
            String NOMBR;
            String SEXO;
            int NUMPULSAC = 0;

            Console.WriteLine("DIGITE SU NOMBRE");
             NOMBR = Console.ReadLine();

            Console.WriteLine("DIGITE SU EDAD");
            EDAD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE SU SEXO F/M ");
             SEXO = Console.ReadLine();

           

                 if (SEXO == "F")

                {
                    NUMPULSAC = (220 - EDAD) / 10;
                 }

                 else if (SEXO == "M")
                {
                    NUMPULSAC = (210 - EDAD)/10;
                 }


            Console.WriteLine("LAS PULSACIONES DE " + NOMBR + "  SON  " + NUMPULSAC);

            Console.ReadLine();
        }
    }
}
