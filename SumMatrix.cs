namespace SummMat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Сложение Матриц");
            Console.Write(" Количество строк: ");
            var rowCount = int.Parse(Console.ReadLine());
            Console.Write(" Количество столбцов: ");
            var colCount = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[rowCount, colCount];
            int[,] matrix2 = new int[rowCount, colCount];
            int[,] matrix3 = new int[rowCount, colCount];

            

            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    matrix1[row, col] = random.Next(10);
                    matrix2[row, col] = random.Next(10);
                }
            }

            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    matrix3[row, col] = matrix1[row, col] + matrix2[row, col];
                    
                }
            }

            Console.WriteLine("\nСложение Матриц:");
            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write($"{matrix1[row, col]}\t");
                    
                }
                Console.Write($"\t\t");
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write($"{matrix2[row, col]}\t");
                }
                Console.Write($"\t\t");
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write($"{matrix3[row, col]}\t");
                    
                }
                Console.WriteLine();
                

            }
           
           
        } 
}
}