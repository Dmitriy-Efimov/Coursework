using System;

namespace KR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество альтернатив:");

            if (!int.TryParse(Console.ReadLine(), out int alternativesCount))
            {
                throw new Exception("Введено было не число!");
            }

            double[,] criteriaArray = new double[alternativesCount, 3];

            for (int i = 0; i < alternativesCount; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Введите альтернативу " + i);

                Console.Write("Критерий k1 для альтернативы {0} = ", i);

                if (!double.TryParse(Console.ReadLine(), out criteriaArray[i, 0]))
                {
                    throw new Exception("Введено было не число!");
                }

                Console.Write("Критерий k2 для альтернативы {0} = ", i);

                if (!double.TryParse(Console.ReadLine(), out criteriaArray[i, 1]))
                {
                    throw new Exception("Введено было не число!");
                }

                Console.Write("Критерий k3 для альтернативы {0} = ", i);

                if (!double.TryParse(Console.ReadLine(), out criteriaArray[i, 2]))
                {
                    throw new Exception("Введено было не число!");
                }
            }

            Console.WriteLine();
            Console.Write("Массив критериев:");
            PrintDoubleArray(criteriaArray);

            double[,] normalizedCriteriaArray = new double[alternativesCount, 3];

            for (int l = 0; l < 3; l++)
            {
                double minElement = criteriaArray[0, l];

                for (int i = 0; i < alternativesCount; i++)
                {
                    minElement = Math.Min(minElement, criteriaArray[i, l]);
                }

                double maxElement = criteriaArray[0, l];

                for (int i = 0; i < alternativesCount; i++)
                {
                    maxElement = Math.Max(maxElement, criteriaArray[i, l]);
                }

                for (int j = 0; j < alternativesCount; j++)
                {
                    normalizedCriteriaArray[j, l] = (criteriaArray[j, l] - minElement) / (maxElement - minElement);
                }
            }

            Console.WriteLine();
            Console.Write("Нормализованный массив критериев:");
            PrintDoubleArray(normalizedCriteriaArray);

            string[] criteria = new string[3];
            Console.WriteLine();

            Console.Write("К чему стремится критерий k1 -> ");
            criteria[0] = Console.ReadLine();

            Console.Write("К чему стремится критерий k2 -> ");
            criteria[1] = Console.ReadLine();

            Console.Write("К чему стремится критерий k3 -> ");
            criteria[2] = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (!(criteria[i] == "максимум" || criteria[i] == "минимум"))
                {
                    throw new Exception("Критерий k[i] не может стремиться к чему-то другому, кроме максимума или минимума!");
                }

                if (criteria[i].Equals("минимум"))
                {
                    for (int j = 0; j < alternativesCount; j++)
                    {
                        normalizedCriteriaArray[j, i] = -normalizedCriteriaArray[j, i];
                    }
                }
            }

            double[] optimalOptionsArray = new double[alternativesCount];

            for (int i = 0; i < alternativesCount; i++)
            {
                optimalOptionsArray[i] = normalizedCriteriaArray[i, 0] + normalizedCriteriaArray[i, 1] +
                    normalizedCriteriaArray[i, 2];
            }

            Console.WriteLine();
            Console.WriteLine("Массив оптимальных вариантов:");
            PrintArray(optimalOptionsArray);
            FindMaxOptimalOption(optimalOptionsArray);
        }

        public static void FindMaxOptimalOption(double[] array)
        {
            double maxElement = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                maxElement = Math.Max(maxElement, array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Максимальный оптимальный вариант равен {0}", maxElement);
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public static void PrintDoubleArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
