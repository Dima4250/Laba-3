using System;
using System.Numerics;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Это матричный калькулятор, выберите действие:");
            Console.WriteLine("1. - Операции с одной матрицей \n2. - Операции с двумя матрицами");

            string UserAnwsear = Console.ReadLine();

                switch (UserAnwsear)
                {
                    case "1":
                        Console.Write("Введите размер матрицы: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Матрица:\n");
                        SquareMatrix matrix1 = new SquareMatrix(n);

                        matrix1.PrintSquareMatrix();
                        Console.WriteLine("\n");
                        Console.WriteLine("1. Выполнить проверку на нулевую матрицу.");
                        Console.WriteLine("2. Создать клон матрицы.");
                        Console.WriteLine("3. Найти определитель матрицы.");
                        Console.WriteLine("4. Найти обратную матрицу.");

                        string UserChoice1 = Console.ReadLine();

                        if (UserChoice1 == "1")
                        {
                            Console.WriteLine($"Проеврка на нулевую матрицу: {matrix1.ZeroMatrix()}");
                        }
                        else if (UserChoice1 == "2")
                        {
                            Console.WriteLine("Клон матрицы:\n");
                            SquareMatrix clone = matrix1.Clone();
                            clone.PrintSquareMatrix();
                        }
                        else if (UserChoice1 == "3")
                        {
                            Console.WriteLine("Определитель матрицы:\n");
                            Console.WriteLine(matrix1.Determinant());
                        }
                        else if (UserChoice1 == "4")
                        {
                            Console.WriteLine("\nОбратная матрица A:");
                            Console.WriteLine(matrix1.Inverse());
                        }
                        break;

                    case "2":
                        Console.Write("Введите размер матрицы A: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Матрица A:\n");
                        SquareMatrix matrix2 = new SquareMatrix(m);
                        matrix2.PrintSquareMatrix();
                        Console.WriteLine("\n");

                        Console.Write("Введите размер матрицы B: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Матрица B:\n");
                        SquareMatrix matrix3 = new SquareMatrix(k);
                        matrix3.PrintSquareMatrix();
                        Console.WriteLine("\n");

                        Console.WriteLine("1. Сложить две матрицы.");
                        Console.WriteLine("2. Умножить матрицу A на B");
                        Console.WriteLine("3. Сравнить две матрицы");

                        string UserChoice2 = Console.ReadLine();

                        if (UserChoice2 == "1")
                        {
                            SquareMatrix matrix4 = matrix2 + matrix3;
                            matrix4.PrintSquareMatrix();
                        }
                        else if (UserChoice2 == "2")
                        {
                            Console.WriteLine("Полученная матрица:\n");
                            SquareMatrix matrix5 = matrix2 * matrix3;
                            matrix5.PrintSquareMatrix();
                            
                        }
                        else if (UserChoice2 == "3")
                        {
                            Console.WriteLine("Вы выбрали сравнение матриц");
                            Console.WriteLine(matrix2 == matrix3 ? "А = B" : "А != B");
                            Console.WriteLine(matrix2 > matrix3 ? "А > B" : "А <= B");
                        }

                        break;
                }
            }
            catch (MatrixSizeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

