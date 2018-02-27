using System;
using System.Linq;

namespace Problem02_BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string outhor = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(outhor, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(outhor, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }
}
