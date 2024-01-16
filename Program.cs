namespace MenuMatematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test1");
            Console.WriteLine(Mcd(15,20));

            MostrarDivisorMajor(52);
            Console.WriteLine(Factorial(5));


            Console.WriteLine(EsPrimer(8));

            int a = 9, b = 10;
            Maxim(ref a, ref b);
            Console.WriteLine("test Major a:" + a + " b:" + b);

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
        //Metode 6: MostrarDivisorMajor
        static void MostrarDivisorMajor(int num)
        {
            int i = num/2;
            while(num % i != 0)
            {
                i--;
            }
            Console.WriteLine(i);
        }


        // Metode 7: EsPrimer 
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






    }
}
