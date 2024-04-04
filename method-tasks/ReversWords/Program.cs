
namespace ReversWords
{
    internal class Program
    {
        static string ReverseWords(string[] text) 
        {
            Array.Reverse(text); 
            string addSeparator = string.Join(" ", text); 
            return addSeparator;
        }
        static string SplitWords(string text)  
        {
            string[] split = text.Split(' '); 
            string newText = ReverseWords(split); 
            return newText;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Фразу:");
            string sentence = Console.ReadLine();
            sentence = SplitWords(sentence);
            Console.WriteLine("Фраза наоборот:");
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
        
        
    }
}