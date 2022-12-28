using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice03
{
    public abstract class  Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int LibraryCode { get; set; }
        public TypeGenre Genre { get; set; }
        public TypeBook TypeOfBook { get; internal protected set; }
        public string Language { get; set; }
        public bool Status { get; set; }
        public string LenderName { get; set; }
        public double PriceOfPurchase { get; set;}
        public string ISBN { get; set; }

        public bool CompareTo(Book book)
        {
            return book != null
                && book.Author == Author
                && book.Name == Name;
        }
        public void Show()
        {
            Console.WriteLine("Titulo del libro es: {0}, Autor:{1}, Disponible para prestamo:{2}", Name, Author, Status);
        }
    }
}
