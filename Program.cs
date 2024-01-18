namespace MenuMatematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MENÚ -> OPCIÓ -> MÈTODE -> OPCIÓ -> MENÚ
            char opcio = '0';
            while (opcio != 'q' && opcio != 'Q') 
            {
                do
                {
                    Console.Clear();
                    Console.Write(Menu());
                    opcio = (char)Console.Read();
                }
                while (!ValidarOpcio(opcio));
                Console.Clear() ;
                switch (opcio)
                {
                    case '1':
                        //Maxim
                        int a = DemanarValor();
                        int b = DemanarValor();
                        Maxim(ref a, ref b);
                        Console.WriteLine($"El valor més gran és {a}");
                        break;
                    case '2':
                        //Mcd
                        break;
                    case '3':
                        //Mcm
                        break;
                    case '4':
                        //Factorial
                        break;
                    case '5':
                        //Combinatori
                        break;
                    case '6':
                        //MostrarDivisorMajor
                        break;
                    case '7':
                        //EsPrimer
                        break;
                    case '8':
                        //NPrimersPrimers
                        break;
                }
            }
            
        }
        // Mètode MENU
        static string Menu()
        {
            string menu;

            menu =
               $"+--------------------------------+ \n" +
               $"|       MENÚ MATEMÀTIC           | \n" +
               $"+--------------------------------+ \n" +
               $"|  1 - Calcular valor més gran   | \n" +
               $"|  2 - Màxim Comú Divisor        | \n" +
               $"|  3 - Mínim Comú Múltiple       | \n" +
               $"|  4 - Calcular Factorial        | \n" +
               $"|  5 - Calcular Combinatori      | \n" +
               $"|  6 - Calcular Divisor Major    | \n" +
               $"|  7 - És un número Primer?      | \n" +
               $"|  8 - Nombre de números Primers | \n" +
               $"|  q - exit                      | \n" +
               $"+--------------------------------+" +
               $"\n\n" + "Prem el botó per seleccionar la opció desitjada: ";

            return menu;
        }


        // Mètode ValidarOpció
        static bool ValidarOpcio(char lletra)
        {
            return (lletra > '0' && lletra < '9' || lletra == 'q' || lletra == 'Q');
        }

        // Mètode DemanarValor
        static int DemanarValor()
        {
            int valor;
            Console.WriteLine("Introdueix el valor desitjat");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

        // Mètode 1: Maxim
        static void Maxim(ref int num1, ref int num2)
        {
            // El mètode "màxim" ha d'assegurar-se que el valor "num1" sigui el més gran dels dos valors introduits
            int numAux;
            if (num2 > num1)
            {
                numAux = num2;
                num2 = num1;
                num1 = numAux;
            }

        }
        // Metode 2: Mcd
        static int Mcd(int num1, int num2)
        {
            int aux;
            if (num1 > num2) aux = num2;
            else aux = num1;
            int max = 1;
            for (int i = 1; i <= aux; i++)
            {
                if (num1 % i == 0 && num2 % i == 0) max = i;
            }
            return max;
        }

        // Mètode 3: Mcm
        static int Mcm(int num1, int num2)
        {
            int mcd = Mcd(num1, num2), mcm;
            mcm = (num1 * num2) / mcd;
            return mcm;
        }

        // Mètode 4: Factorial
        static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }


        // Mètode 5: Combinatori
        static int Combinatori(int num1, int num2)
        {
            int numerador=1, combinatori, i = 0;
            while (i < num2)
            {
                numerador *= num1;
                num1--;
                i++;
            }
            combinatori = numerador / Factorial(num2);
            return combinatori;
        }
        // Mètode 6: MostrarDivisorMajor
        static void MostrarDivisorMajor(int num)
        {
            int i = num/2;
            while(num % i != 0)
            {
                i--;
            }
            Console.WriteLine(i);
        }


        // Mètode 7: EsPrimer 
        static bool EsPrimer(int num)
        {
            int i = 2;
            bool primer = true;
            while (i <= num / 2)
            {
                if (num % i == 0) primer = false;
                i++;
            }

            return primer;

        }

        // Mètode 8: NPrimersPrimers
        static string NPrimersPrimers(int quant)
        {
            int i = 0, num = 1;
            string nPrimersPrimers = "";
            while (i < quant)
            {
                if (EsPrimer(num))
                {
                    i++;
                    nPrimersPrimers += $"{num}, ";
                }
                num++;
            }
            nPrimersPrimers = nPrimersPrimers.Remove(nPrimersPrimers.Length - 2, 2);
            return nPrimersPrimers;
        }



    }
}
