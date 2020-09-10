using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)

        {
            String AUX, NOMBRE;
            float NUM_CUENTA;
            float SALDO_INICIAL;
            float SALDO_CONSIGNACION;
            float SALDO_RETIRO;

            Console.WriteLine("DIGITE SU NOMBRE: ");
              NOMBRE = Console.ReadLine();

            Console.WriteLine("DIGITE SU NUMERO DE CUENTA: ");
                 AUX = Console.ReadLine();
           
            NUM_CUENTA = float.Parse(AUX);

            Console.WriteLine("DIGITE EL SALDO PARA LA APERTURA DE LA CUENTA: ");
                 AUX = Console.ReadLine();

            SALDO_INICIAL = float.Parse(AUX);

            Console.WriteLine("DIGITE EL MONTO A CONSIGNAR: ");
                 AUX = Console.ReadLine();

            SALDO_CONSIGNACION = float.Parse(AUX);

            SALDO_CONSIGNACION = SALDO_INICIAL + SALDO_CONSIGNACION;

            Console.WriteLine("SU SALDO ACTUAL ES DE:  " + SALDO_CONSIGNACION);

            Console.WriteLine("DIGITE EL MONTO A RETIRAR: ");

                 AUX = Console.ReadLine();

            SALDO_RETIRO = float.Parse(AUX);

            SALDO_RETIRO = SALDO_CONSIGNACION - SALDO_RETIRO;

            Console.WriteLine("SU SALDO ACTUAL ES DE:  " + SALDO_RETIRO);

            Console.ReadLine();
        }
    }
}
