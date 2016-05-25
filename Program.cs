using System;


namespace Cajero_Banco_Estado
{
    class Program
    {

        static float retiro = 0;
        static float cuenta = 0;
        static float abono = 0;
        static int option = 0;
        static int option2 = 0;
        static int option3 = 0;

        static int monto1 = 20000;
        static int monto2 = 10000;
        static int monto3 = 5000;
        static int monto4 = 1000;
        static double cambio;
        static double cant;
        static int monedas;
        static int cont1 = 0;
        static int cont2 = 0;
        static int cont3 = 0;
        static int cont4 = 0;
        static int cont5 = 0;
        static int cont6 = 0;
        static int total = 0;
        static int user = 0;
        static int coins = 0;
        static int t1 = 0;
        static int t2 = 0;
        static int t3 = 0;
        static int t4 = 0;
        static int t5 = 0;
        static int t6 = 0;






        static void depositar_dinero(float abono)
        {
            if (option == 1)
            {
                cuenta = cuenta + abono + total;
            }
            else
                cuenta = cuenta - retiro;

        }
        static void retirar_dinero(float option2)
        {
            if (option == 2)
            {
                if (option2 == 1)
                {
                    cuenta = cuenta - monto1;
                }
                else if (option2 == 2)
                {
                    cuenta = cuenta - monto2;
                }
                else if (option2 == 3)
                {
                    cuenta = cuenta - monto3;

                }
                else if (option2 == 4)
                {
                    cuenta = cuenta - monto4;
                }

            }
        }
        static void indicar_tipodecambio(double cant)
        {
            if (option == 4)
            {
                if (option3 == 1)
                {
                    cambio = (cant * 0.0019);
                }
                else
                {
                    cambio = (cant * 534.95);
                }

            }

        }
        static void date()
        {
            DateTime mydate = DateTime.Now;
            Console.WriteLine(mydate.ToLongDateString());
            Console.WriteLine(mydate.ToShortTimeString());

        }
        static void recibir_monedas(int user)
        {
            total = (cont1 * 5) + (cont2 * 10) + (cont3 * 25) + (cont4 * 50) + (cont5 * 100) + (cont6 * 500);
            coins = cont1 + cont2 + cont3 + cont4 + cont5 + cont6;
            t1 = cont1 * 5;
            t2 = cont2 * 10;
            t3 = cont3 * 25;
            t4 = cont4 * 50;
            t5 = cont5 * 100;
            t6 = cont6 * 500;

        }

        static int Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Cajero Banco Estado.");
                Console.WriteLine("1. Depósito de dinero.");
                Console.WriteLine("2. Retiro de dinero.");
                Console.WriteLine("3. Recibo de monedas.");
                Console.WriteLine("4. Consulta tipo de cambio.");
                Console.WriteLine("5. Salir. \n");
                Console.WriteLine("Seleccione una opción:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {


                    case 5:
                        //Salir
                        break;
                    case 1:
                        {
                            Console.Clear();

                            Console.WriteLine("Digite el monto que desea depositar: ");
                            abono = float.Parse(Console.ReadLine());
                            depositar_dinero(abono);
                            Console.WriteLine();
                            Console.WriteLine("Depósito: " + abono);
                            Console.WriteLine("El estado actual de su cuenta es: " + cuenta);
                            Console.WriteLine();
                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("El estado actual de su cuenta es: " + cuenta + "\n");
                            Console.WriteLine();
                            Console.WriteLine("Retiro en Colones:");
                            Console.WriteLine("1." + monto1);
                            Console.WriteLine("2." + monto2);
                            Console.WriteLine("3." + monto3);
                            Console.WriteLine("4." + monto4);

                            Console.WriteLine("Seleccione una opción: ");
                            option2 = int.Parse(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    {
                                        if (monto1 <= cuenta)
                                        {

                                            Console.WriteLine();
                                            retirar_dinero(option2);
                                            Console.WriteLine("Monto de retiro: " + monto1);
                                            Console.WriteLine("El estado actual de su cuenta es: " + cuenta + "\n");
                                            Console.WriteLine();
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }
                                        else if (cuenta == 0)
                                        {
                                            Console.WriteLine("Fondos insuficientes.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú.");
                                            Console.ReadKey();

                                        }
                                        else if (monto1 > cuenta)
                                        {
                                            Console.WriteLine("El monto de retiro es mayor al saldo de su cuenta.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }

                                        break;
                                    }

                                case 2:
                                    {
                                        if (monto2 <= cuenta)
                                        {

                                            Console.WriteLine();
                                            retirar_dinero(option2);
                                            Console.WriteLine("Monto de retiro: " + monto2);
                                            Console.WriteLine("El estado actual de su cuenta es: " + cuenta + "\n");
                                            Console.WriteLine();
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }
                                        else if (cuenta == 0)
                                        {
                                            Console.WriteLine("Fondos insuficientes.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú.");
                                            Console.ReadKey();

                                        }
                                        else if (monto2 > cuenta)
                                        {
                                            Console.WriteLine("El monto de retiro es mayor al saldo de su cuenta.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }
                                        break;
                                    }


                                case 3:
                                    {
                                        if (monto3 <= cuenta)
                                        {

                                            Console.WriteLine();
                                            retirar_dinero(option2);
                                            Console.WriteLine("Monto de retiro: " + monto3);
                                            Console.WriteLine("El estado actual de su cuenta es: " + cuenta + "\n");
                                            Console.WriteLine();
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }
                                        else if (cuenta == 0)
                                        {
                                            Console.WriteLine("Fondos insuficientes.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú.");
                                            Console.ReadKey();

                                        }
                                        else if (monto3 > cuenta)
                                        {
                                            Console.WriteLine("El monto de retiro es mayor al saldo de su cuenta.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }

                                        break;
                                    }

                                case 4:
                                    {
                                        if (monto4 <= cuenta)
                                        {

                                            Console.WriteLine();
                                            retirar_dinero(option2);
                                            Console.WriteLine("Monto de retiro: " + monto4);
                                            Console.WriteLine("El estado actual de su cuenta es: " + cuenta + "\n");
                                            Console.WriteLine();
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }
                                        else if (cuenta == 0)
                                        {
                                            Console.WriteLine("Fondos insuficientes.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú.");
                                            Console.ReadKey();

                                        }
                                        else if (monto4 > cuenta)
                                        {
                                            Console.WriteLine("El monto de retiro es mayor al saldo de su cuenta.\n");
                                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                            Console.ReadKey();
                                        }

                                        break;
                                    }
                                default:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Seleccione una opción válida..");
                                        Console.WriteLine("Presione la tecla INTRO para volver al menú");
                                        Console.ReadKey();

                                    }
                                    break;
                            }
                            break;
                        }

                    case 3:
                        {
                            do
                            {
                                Console.Clear();

                                Console.WriteLine("Digite el monto en monedas que desea depositar: ");
                                monedas = int.Parse(Console.ReadLine());

                                if (monedas == 5)
                                {

                                    cont1++;
                                    recibir_monedas(user);
                                    Console.WriteLine("Cantidad monedas de 5 colones: " + cont1);

                                    Console.WriteLine();
                                    Console.WriteLine("Cantidad en colones: " + t1 + "\n");

                                    Console.WriteLine("¿Desea continuar el déposito de monedas?\n");
                                    Console.WriteLine("1.Continuar.");
                                    Console.WriteLine("2.Desgloce total de movimientos.");
                                    Console.WriteLine("3.Finalizar depósito.");

                                    user = int.Parse(Console.ReadLine());
                                    switch (user)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine(" ");

                                            Console.WriteLine("======================================================================================\n" +

                                                                                     "                               " + "CAJERO BANCO ESTADO \n" +
                                                                "=====================================================================================");

                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Monedas                  Cantidad                   Total     ");
                                            Console.WriteLine("1)Monedas de 5:" + "             " + cont1 + "                         " + t1);
                                            Console.WriteLine("1)Monedas de 10:" + "            " + cont2 + "                         " + t2);
                                            Console.WriteLine("1)Monedas de 25:" + "            " + cont3 + "                         " + t3);
                                            Console.WriteLine("1)Monedas de 50:" + "            " + cont4 + "                         " + t4);
                                            Console.WriteLine("1)Monedas de 100:" + "           " + cont5 + "                         " + t5);
                                            Console.WriteLine("1)Monedas de 500:" + "           " + cont6 + "                         " + t6);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Cantidad total de monedas ingresadas: " + coins);
                                            Console.WriteLine("Total en colones:" + total);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("=========================================================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Precione 3 para volver al menú principal");
                                            user = int.Parse(Console.ReadLine());


                                            break;
                                        case 3:

                                            break;

                                    }

                                }


                                if (monedas == 10)
                                {

                                    cont2++;
                                    recibir_monedas(user);
                                    Console.WriteLine("Cantidad monedas de 10 colones:" + cont2);

                                    Console.WriteLine();
                                    Console.WriteLine("Cantidad en colones: " + t2 + "\n");
                                    Console.WriteLine("¿Desea continuar el déposito de monedas?\n");
                                    Console.WriteLine("1.Continuar.");
                                    Console.WriteLine("2.Desgloce total de movimientos.");
                                    Console.WriteLine("3.Finalizar depósito.");

                                    user = int.Parse(Console.ReadLine());
                                    switch (user)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine(" ");

                                            Console.WriteLine("======================================================================================\n" +

                                                                                     "                               " + "CAJERO BANCO ESTADO \n" +
                                                                "=====================================================================================");

                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Monedas                  Cantidad                   Total     ");
                                            Console.WriteLine("1)Monedas de 5:" + "             " + cont1 + "                         " + t1);
                                            Console.WriteLine("1)Monedas de 10:" + "            " + cont2 + "                         " + t2);
                                            Console.WriteLine("1)Monedas de 25:" + "            " + cont3 + "                         " + t3);
                                            Console.WriteLine("1)Monedas de 50:" + "            " + cont4 + "                         " + t4);
                                            Console.WriteLine("1)Monedas de 100:" + "           " + cont5 + "                         " + t5);
                                            Console.WriteLine("1)Monedas de 500:" + "           " + cont6 + "                         " + t6);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Cantidad total de monedas ingresadas: " + coins);
                                            Console.WriteLine("Total en colones:" + total);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("=========================================================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Precione 3 para volver al menú principal");
                                            user = int.Parse(Console.ReadLine());


                                            break;
                                        case 3:

                                            break;

                                    }

                                }
                                else { }
                                if (monedas == 25)
                                {

                                    cont3++;
                                    recibir_monedas(user);
                                    Console.WriteLine("Cantidad monedas de 25 colones:" + cont3);

                                    Console.WriteLine();
                                    Console.WriteLine("Cantidad en colones: " + t3 + "\n");
                                    Console.WriteLine("¿Desea continuar el déposito de monedas?\n");
                                    Console.WriteLine("1.Continuar.");
                                    Console.WriteLine("2.Desgloce total de movimientos.");
                                    Console.WriteLine("3.Finalizar depósito.");

                                    user = int.Parse(Console.ReadLine());
                                    switch (user)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine(" ");

                                            Console.WriteLine("======================================================================================\n" +

                                                                                     "                               " + "CAJERO BANCO ESTADO \n" +
                                                                "=====================================================================================");

                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Monedas                  Cantidad                   Total     ");
                                            Console.WriteLine("1)Monedas de 5:" + "             " + cont1 + "                         " + t1);
                                            Console.WriteLine("1)Monedas de 10:" + "            " + cont2 + "                         " + t2);
                                            Console.WriteLine("1)Monedas de 25:" + "            " + cont3 + "                         " + t3);
                                            Console.WriteLine("1)Monedas de 50:" + "            " + cont4 + "                         " + t4);
                                            Console.WriteLine("1)Monedas de 100:" + "           " + cont5 + "                         " + t5);
                                            Console.WriteLine("1)Monedas de 500:" + "           " + cont6 + "                         " + t6);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Cantidad total de monedas ingresadas: " + coins);
                                            Console.WriteLine("Total en colones:" + total);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("=========================================================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Precione 3 para volver al menú principal");
                                            user = int.Parse(Console.ReadLine());


                                            break;
                                        case 3:

                                            break;

                                    }

                                }
                                else { }
                                if (monedas == 50)
                                {

                                    cont4++;
                                    recibir_monedas(user);
                                    Console.WriteLine("Cantidad monedas de 50 colones:" + cont4);

                                    Console.WriteLine();
                                    Console.WriteLine("Cantidad en colones: " + t4 + "\n");
                                    Console.WriteLine("¿Desea continuar el déposito de monedas?\n");
                                    Console.WriteLine("1.Continuar.");
                                    Console.WriteLine("2.Desgloce total de movimientos.");
                                    Console.WriteLine("3.Finalizar depósito.");

                                    user = int.Parse(Console.ReadLine());
                                    switch (user)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine(" ");

                                            Console.WriteLine("======================================================================================\n" +

                                                                                     "                               " + "CAJERO BANCO ESTADO \n" +
                                                                "=====================================================================================");

                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Monedas                  Cantidad                   Total     ");
                                            Console.WriteLine("1)Monedas de 5:" + "             " + cont1 + "                         " + t1);
                                            Console.WriteLine("1)Monedas de 10:" + "            " + cont2 + "                         " + t2);
                                            Console.WriteLine("1)Monedas de 25:" + "            " + cont3 + "                         " + t3);
                                            Console.WriteLine("1)Monedas de 50:" + "            " + cont4 + "                         " + t4);
                                            Console.WriteLine("1)Monedas de 100:" + "           " + cont5 + "                         " + t5);
                                            Console.WriteLine("1)Monedas de 500:" + "           " + cont6 + "                         " + t6);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Cantidad total de monedas ingresadas: " + coins);
                                            Console.WriteLine("Total en colones:" + total);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("=========================================================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Precione 3 para volver al menú principal");
                                            user = int.Parse(Console.ReadLine());


                                            break;
                                        case 3:

                                            break;

                                    }

                                }
                                else { }
                                if (monedas == 100)
                                {

                                    cont5++;
                                    recibir_monedas(user);
                                    Console.WriteLine("Cantidad monedas de 100 colones:" + cont5);

                                    Console.WriteLine();
                                    Console.WriteLine("Cantidad en colones: " + t5 + "\n");
                                    Console.WriteLine("¿Desea continuar el déposito de monedas?\n");
                                    Console.WriteLine("1.Continuar.");
                                    Console.WriteLine("2.Desgloce total de movimientos.");
                                    Console.WriteLine("3.Finalizar depósito.");

                                    user = int.Parse(Console.ReadLine());
                                    switch (user)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine(" ");

                                            Console.WriteLine("======================================================================================\n" +

                                                                                     "                               " + "CAJERO BANCO ESTADO \n" +
                                                                "=====================================================================================");

                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Monedas                  Cantidad                   Total     ");
                                            Console.WriteLine("1)Monedas de 5:" + "             " + cont1 + "                         " + t1);
                                            Console.WriteLine("1)Monedas de 10:" + "            " + cont2 + "                         " + t2);
                                            Console.WriteLine("1)Monedas de 25:" + "            " + cont3 + "                         " + t3);
                                            Console.WriteLine("1)Monedas de 50:" + "            " + cont4 + "                         " + t4);
                                            Console.WriteLine("1)Monedas de 100:" + "           " + cont5 + "                         " + t5);
                                            Console.WriteLine("1)Monedas de 500:" + "           " + cont6 + "                         " + t6);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("----------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Cantidad total de monedas ingresadas: " + coins);
                                            Console.WriteLine("Total en colones:" + total);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("=========================================================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Precione 3 para volver al menú principal");
                                            user = int.Parse(Console.ReadLine());


                                            break;
                                        case 3:

                                            break;

                                    }

                                }
                                if (monedas == 500)
                                {

                                    cont6++;
                                    recibir_monedas(user);
                                    Console.WriteLine("Cantidad monedas de 500 colones:" + cont6);


                                    Console.WriteLine();

                                    Console.WriteLine("Cantidad en colones: " + t6 + "\n");
                                    Console.WriteLine("¿Desea continuar el déposito de monedas?\n");
                                    Console.WriteLine("1.Continuar.");
                                    Console.WriteLine("2.Desgloce total de movimientos.");
                                    Console.WriteLine("3.Finalizar depósito.");

                                    user = int.Parse(Console.ReadLine());
                                    switch (user)
                                    {
                                        case 1:

                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine(" ");

                                            Console.WriteLine("=========================================================================================\n" +

                                                                                     "                               " + "CAJERO BANCO ESTADO \n" +
                                                                "========================================================================================");

                                            Console.WriteLine(" ");
                                            Console.WriteLine("-------------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Monedas                  Cantidad                   Total     ");
                                            Console.WriteLine("1)Monedas de 5:" + "             " + cont1 + "                         " + t1);
                                            Console.WriteLine("1)Monedas de 10:" + "            " + cont2 + "                         " + t2);
                                            Console.WriteLine("1)Monedas de 25:" + "            " + cont3 + "                         " + t3);
                                            Console.WriteLine("1)Monedas de 50:" + "            " + cont4 + "                         " + t4);
                                            Console.WriteLine("1)Monedas de 100:" + "           " + cont5 + "                         " + t5);
                                            Console.WriteLine("1)Monedas de 500:" + "           " + cont6 + "                        " + t6);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("------------------------------------------------------------------------------------------");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Cantidad total de monedas ingresadas: " + coins);
                                            Console.WriteLine("Total en colones:" + total);
                                            Console.WriteLine(" ");
                                            Console.WriteLine("===========================================================================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Precione 3 para volver al menú principal");
                                            user = int.Parse(Console.ReadLine());


                                            break;
                                        case 3:

                                            break;

                                    }

                                }




                            } while (user != 3);




                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Tipo de cambio:");
                            Console.WriteLine("1. Colones-Dólares");
                            Console.WriteLine("2. Dólares-Colones");
                            Console.WriteLine();
                            Console.WriteLine("Seleccione una opción: ");
                            option3 = int.Parse(Console.ReadLine());
                            switch (option3)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Colones-Dólares. \n");
                                        Console.WriteLine("Digite el monto que desea consultar: ");

                                        cant = double.Parse(Console.ReadLine());
                                        indicar_tipodecambio(cant);
                                        Console.WriteLine();
                                        Console.WriteLine("Costa Rica Colón:" + cant);
                                        Console.WriteLine("US Dollar: " + cambio);
                                        Console.WriteLine();
                                        date();
                                        Console.WriteLine();
                                        Console.WriteLine("Presione la tecla INTRO para volver al menú");

                                        Console.ReadKey();

                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dólares-Colones. \n");

                                        Console.WriteLine("Digite el monto que desea consultar: ");
                                        cant = double.Parse(Console.ReadLine());
                                        indicar_tipodecambio(cant);
                                        Console.WriteLine();
                                        Console.WriteLine("US Dollar:" + cant);
                                        Console.WriteLine("Costa Rica Colón: " + cambio);
                                        Console.WriteLine();
                                        date();
                                        Console.WriteLine();
                                        Console.WriteLine("Presione la tecla INTRO para volver al menú");

                                        Console.ReadKey();
                                        break;
                                    }
                            }

                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida..");
                            Console.WriteLine("Presione la tecla INTRO para volver al menú");
                            Console.ReadKey();

                            break;

                        }
                }
            } while (option != 5);
            return 0;


        }
    }
}












