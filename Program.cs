using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

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
                    PintarMenu(Menu());
                    opcio = Console.ReadKey().KeyChar;
                }
                while (!ValidarOpcio(opcio));
                Console.Clear() ;
                MostrarOpcio(opcio);                
            }            
        }

        // Mètode MENU
        static string Menu()
        {
            string menu;

            menu =

               $"\n╔════════════════════════════════╗\n" +
               $"║       MENÚ MATEMÀTIC           ║\n" +
               $"╠════════════════════════════════╣\n" +
               $"║  1 - Calcular valor més gran   ║\n" +
               $"║  2 - Màxim Comú Divisor        ║\n" +
               $"║  3 - Mínim Comú Múltiple       ║\n" +
               $"║  4 - Calcular Factorial        ║\n" +
               $"║  5 - Calcular Combinatori      ║\n" +
               $"║  6 - Calcular Divisor Major    ║\n" +
               $"║  7 - És un número Primer?      ║\n" +
               $"║  8 - Nombre de números Primers ║\n" +
               $"║  q - exit                      ║\n" +
               $"╚════════════════════════════════╝";

            return menu;
        }

        // Mètode PintarMenu
        static void PintarMenu(string menu)
        {
            string linea = "", text = menu;
            while (text.Contains("\n"))
            {
                linea = text.Substring(0, text.IndexOf("\n"));
                Centrar(linea);
                text = text.Substring(text.IndexOf("\n") + 1);
            }
            Centrar(text);
        }
        static void PintarMenu(string menu, char i)
        {
            string linea = "", text = menu;
            while (text.Contains("\n"))
            {
                linea = text.Substring(0, text.IndexOf("\n"));
                Centrar(linea, i);
                text = text.Substring(text.IndexOf("\n") + 1);
            }
            Centrar(text);
        }

        // Mètode Centrar
        static void Centrar(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - (text.Length / 2) - 1) + "}", ""));
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(String.Format($"{text}"));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        static void Centrar(string text, char i)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - (text.Length / 2) - 1) + "}", ""));
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            if (text.Contains((i)))
            {
                Console.Write(text.Substring(0, text.IndexOf(i)));
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(String.Format($"{text.Substring(3, text.Length - 4)}"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write('║');
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(String.Format($"{text}"));
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }


        // Mètode Pintar
        static void Pintar(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(String.Format("{0," + (text.Length - 1) + "}", ""));
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(String.Format($"{text}"));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        // Mètode PintarOpcio
        static void PintarOpcio(string menu,char i)
        {
            string menuMat = Menu();
            PintarMenu(Menu(),i);
            Thread.Sleep(1000);
            Console.Clear();
        }

        // Mètode MostrarOpcio
        static void MostrarOpcio(int opcio)
        {
            int a, b;
            char c = (char) opcio;
            PintarOpcio(Menu(),c);
            switch (opcio)
            {
                case '1':
                    //Maxim
                    Pintar("\n\t-----MÀXIM-----".PadRight(41, '-'));
                    Console.WriteLine("\t*Retorna el maxim dels dos numeros.\n");
                    a = DemanarValor();
                    b = DemanarValor();
                    Maxim(ref a, ref b);
                    Console.WriteLine($"\n\tEl valor més gran és {a}");
                    PremPerContinuar();
                    break;

                case '2':
                    //Mcd
                    Pintar("\n\t-----MCD-----".PadRight(41, '-'));
                    Console.WriteLine("\tCalcula el minim comú divisor a partir de dos valors entrats per consola.\n");
                    a = DemanarValor();
                    b = DemanarValor();
                    Console.WriteLine($"\n\tEl Màxim Comú Divisor entre els dos valor és {Mcd(a, b)}");
                    PremPerContinuar();
                    break;

                case '3':
                    //Mcm
                    Pintar("\n\t-----MCM-----".PadRight(41, '-'));
                    Console.WriteLine("\tCalcula el Maxim Comú Multiple a partir de dos valors entrats per consola.\n");
                    a = DemanarValor();
                    b = DemanarValor();
                    Console.WriteLine($"\n\tEl Mínim Comú Múltiple entre els dos valor és {Mcm(a, b)}");
                    PremPerContinuar();
                    break;

                case '4':
                    //Factorial
                    Pintar("\n\t-----FACTORIAL-----".PadRight(41, '-'));
                    Console.WriteLine("\tCalcula el Facorial a partir d'un valor entrar per consola.\n");
                    a = DemanarValor();
                    Console.WriteLine($"\n\tEl Factorial de {a} és {Factorial(a)}");
                    PremPerContinuar();
                    break;

                case '5':
                    //Combinatori
                    Pintar($"\n\t-----COMBINATORI-----".PadRight(41, '-'));
                    Console.WriteLine($"\tEl programa calcularà el Combinatori entre els dos valors introduïts. " +
                        $"\n\tEs calcularà el combinatori del valor més gran sobre el més petit.\n");
                    a = DemanarValor();
                    b = DemanarValor();
                    Console.WriteLine($"\n\tEl Combinatori entre els dos valors introduïts és {Combinatori(a, b)}");
                    PremPerContinuar();
                    break;

                case '6':
                    //MostrarDivisorMajor
                    Pintar($"\n\t-----MOSTRAR EL DIVISOR MAJOR-----".PadRight(41, '-'));
                    Console.WriteLine($"\tEs mostrarà per pantalla el divisor major del valor introduït.\n");
                    a = DemanarValor();
                    Console.Write($"\n\tEl divisor major de {a} és ");
                    MostrarDivisorMajor(a);
                    PremPerContinuar();
                    break;

                case '7':
                    //EsPrimer
                    Pintar($"\n\t-----ÉS UN NÚMERO PRIMER?-----".PadRight(41, '-'));
                    Console.WriteLine($"\tEl programa dirà si el valor introduït és un NÚMERO PRIMER o no.\n");
                    a = DemanarValor();
                    if (EsPrimer(a)) Console.WriteLine($"\n\t{a} és un número primer");
                    else Console.WriteLine($"\n\t{a} no és un número primer");
                    PremPerContinuar();
                    break;

                case '8':
                    //NPrimersPrimers
                    Pintar($"\n\t-----NÓMBRE DE NÚMEROS PRIMERS-----".PadRight(41, '-'));
                    Console.WriteLine($"\tEl valor introduït són els 'x' primers NÚMEROS PRIMERS que vols mostrar per pantalla.\n");
                    a = DemanarValor();
                    Console.Write($"\n\tEls {a} primers números primers són ");
                    Console.WriteLine(NPrimersPrimers(a));
                    PremPerContinuar();
                    break;
            }
        }

        // Mètode PremPerContinuar
        static void PremPerContinuar()
        {
            Pintar($"\n\n\t-----------------------------------------");
            Console.WriteLine($"\tPrem qualsevol botó per tornar al menú...");
            char continuar = Console.ReadKey().KeyChar;
        }


        // Mètode ValidarOpció
        static bool ValidarOpcio(char lletra)
        {
            return (lletra > '0' && lletra < '9' || lletra == 'q' || lletra == 'Q');
        }

        // Mètode DemanarValor
        static int DemanarValor()
        {
            int valor=-1;
            while(valor < 0)
            {
                Console.WriteLine("\tIntrodueix el valor desitjat");
                Console.Write("\t");
                valor = Convert.ToInt32(Console.ReadLine());
            }
            
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
            Maxim(ref num1, ref num2);
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
