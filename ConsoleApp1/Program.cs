using LibraryYesNoAnagrams;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new YesNoAnagrams();
            obj.CheckAnagrams("rAIl2 saf3ety", "fairy tales");
            obj.CheckAnagrams("Hello World", "Goodbye World");
        }
    }
}