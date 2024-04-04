namespace separation
{
    internal class Program
    {
          public static string[] SplitText(string text)
          {
              return text.Split(' ');
          }
        static void PrintWords(string[] parts)
        {
            foreach (string part in parts)
            {
                Console.WriteLine($"Слово: {part} "); 
            }
        }
          static void Main(string[] args)
          {
            Console.WriteLine("Введите Фразу:");
            PrintWords(SplitText(Console.ReadLine()));
          } 
    }
}


