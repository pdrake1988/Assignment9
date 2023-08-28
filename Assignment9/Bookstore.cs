using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Bookstore
    {
        public List<Tuple<string, string, float>> books = new List<Tuple<string, string, float>>();

        public void NewBook(Tuple<string, string, float> book)
        {
            books.Add(book);
        }

        public void PriceOfBooks()
        {
            float price = 0;
            foreach (var book in books)
            {
                price += book.Item3;
            }
            Console.WriteLine(price);
        }
    }
}
