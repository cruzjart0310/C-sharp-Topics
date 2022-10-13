namespace Test.Net.DataStructure.Recursion
{
    public class Recursion
    {
        int[] valoresC = new int[40];

        public int Factorial(int n)
        {
            return(n == 1) ? 1 : n * Factorial(n -1);

            int r = 0;

            #region parte inductiva, parte que se va a ejecutar n veces
            if (n > 1)
            {
                r = n * Factorial(n - 1);
            }
            #endregion

            #region caso base, sirve para romper la ejecusion
            if (n == 1)
            {
                r = 1;
            }
            #endregion

            return r;
        }

        public int Fib(int n)
        {
            return (n == 1) ? 1 : Fib(n - 1)+ Fib(n-2);

            int r = 0;

            if (n > 1)
            {
                r = Fib(n - 1) + Fib(n - 2);
            }

            if (n <= 1)
            {
                r = 1;
            }

            return r;
        }

        public int FibM(int n)
        {
            if (valoresC[n] == -1)
            {
                if (n == 1)
                    valoresC[n] = 1;
                else if (n == 0)
                    valoresC[n] = 0;
                else
                    valoresC[n] = FibM(n - 1) + FibM(n - 2);
            }

            return valoresC[n];
        }


        public int FibT(int n)
        {
            int m = 0;
            int[] valores = new int[n + 1];

            valores[0] = 0;
            valores[1] = 1;

            for (m = 2; m <= n; m++)
            {
                valores[m] = valores[m - 1] + valores[m - 2];
            }

            return valores[n];
        }
    }
}
