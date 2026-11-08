namespace cs2_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*int[] A = new int[5];
            double[,] B = new double[3, 4];
            Random rand = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.Next(-100, 101);
                }
            }
            Console.WriteLine("\nArray A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\nArray B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double max = A[0];
            double min = A[0];

            double sum = 0;
            double product = 1;
            double evenSum = 0;
            double oddColumnsSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                sum += A[i];
                product *= A[i];
                if (A[i] % 2 == 0)
                {
                    evenSum += A[i];
                }  
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }
                    sum += B[i, j];
                    product *= B[i, j];
                    if (j % 2 != 0)
                    {
                        oddColumnsSum += B[i, j];
                    }  
                }
            }
            Console.WriteLine("\nMax num: " + max);
            Console.WriteLine("Min num: " + min);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Sum of even nums A: " + evenSum);
            Console.WriteLine("Sum of oddd columns B: " + oddColumnsSum);*/

            //2
            /*int[,] A = new int[5, 5];
            Random rand = new Random();
            int min = 100;
            int max = -100;
            int minId = 0;
            int maxId = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = rand.Next(-100, 101);
                }
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j] + "\t");
                    int index = i * 5 + j;
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        minId = index;
                    }
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        maxId = index;
                    }
                }
                Console.WriteLine();
            }
            int start = Math.Min(minId, maxId);
            int end = Math.Max(minId, maxId);
            int sum = 0;
            int index2 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (index2 > start && index2 < end)
                    {
                        sum += A[i, j];
                    }
                    index2++;
                }
            }
            Console.WriteLine("\bMin num: " + min);
            Console.WriteLine("Max num: " + max);
            Console.WriteLine("Sum between min and max: " + sum);*/

            //3
            /*Console.Write("Enter str: ");
            string str = Console.ReadLine();
            Console.Write("Enter shift: ");
            int shift = int.Parse(Console.ReadLine());
            string encrypted = "";
            string decrypted = "";

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + shift % 26);

                    if (ch > 'Z')
                        ch = (char)(ch - 26);
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch + shift % 26);

                    if (ch > 'z')
                        ch = (char)(ch - 26);
                }
                encrypted += ch;
            }
            Console.WriteLine("Encrypted: " + encrypted);

            for (int i = 0; i < encrypted.Length; i++)
            {
                char ch = encrypted[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch - shift % 26);

                    if (ch < 'A')
                        ch = (char)(ch + 26);
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - shift % 26);

                    if (ch < 'a')
                        ch = (char)(ch + 26);
                }
                decrypted += ch;
            }
            Console.WriteLine("Decrypted: " + decrypted);*/

            //4
            /*Matrix m1 = new Matrix(2, 2);
            Matrix m2 = new Matrix(2, 2);
            m1.FillRandom();
            m2.FillRandom();
            Console.WriteLine("\nMatrix 1:");
            m1.Print();
            Console.WriteLine("\nMatrix 2:");
            m2.Print();
            Console.WriteLine("\nMultiply by: ");
            Matrix result1 = m1.MultiplyByNumber(3);
            result1.Print();
            Console.WriteLine("\nAdd:");
            Matrix result2 = m1.Add(m2);
            result2.Print();
            Console.WriteLine("\nMultiply:");
            Matrix result3 = m1.Multiply(m2);
            result3.Print();*/

            //5
            Console.Write("Enter expression: ");
            string expression = Console.ReadLine();
            int result = 0;
            if (expression.Contains('+'))
            {
                string[] numbers = expression.Split('+');
                int num1 = int.Parse(numbers[0]);
                int num2 = int.Parse(numbers[1]);
                result = num1 + num2;
            }
            else if (expression.Contains('-'))
            {
                string[] numbers = expression.Split('-');
                int num1 = int.Parse(numbers[0]);
                int num2 = int.Parse(numbers[1]);
                result = num1 - num2;
            }
            Console.WriteLine("Result: " + result);
        }
    }
}
