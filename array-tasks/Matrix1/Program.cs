using System;
namespace Matrix1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Случайная Матрица ");
            Console.Write(" Количество строк: ");
            var rowCount = int.Parse(Console.ReadLine());
            Console.Write(" Количество столбцов: ");
            var colCount = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowCount, colCount];


            int sum = 0;

            for (var row = 0; row < rowCount; row++)
            {
                Console.WriteLine();
                for (var col = 0; col < colCount; col++)
                {

                    matrix[row,col] = random.Next(10);
                    Console.Write($"{matrix[row, col]}\t");
                }
                
            }
            
            foreach (int i in matrix)
            {
                sum += i;
            }
           
            Console.WriteLine($"\nСумма: " + sum);



            Console.ReadKey();
        } 
    }
}