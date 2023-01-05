using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice03
{
    public class BookManager
    {
        private List<Book> novels;
        private List<Book> essays;
        private List<Book> comics;
        public BookManager() 
        {
            novels = new List<Book>();
            essays= new List<Book>();
            comics = new List<Book>();  
        }
        public void AddBook(Book book)
        {
            book.Status = true;
           switch (book.TypeOfBook)
            {
                case TypeBook.Novel: 
                    novels.Add(book);
                    break;
                case TypeBook.Comic: 
                    comics.Add(book); 
                    break;
                case TypeBook.Essay: 
                    essays.Add(book);
                    break;
                default: 
                    break;
                
            }
        }
        public void RemoveBook(Book book)
        {
            
            switch (book.TypeOfBook)
            {
                case TypeBook.Novel:
                    novels.Remove(book);
                    break;
                case TypeBook.Comic:
                    comics.Remove(book);
                    break;
                case TypeBook.Essay:
                    essays.Remove(book);
                    break;
                default: 
                    break;
            }
        }

        public void LendBook(Book book, string NameLender)
        {
            switch (book.TypeOfBook)
            {
                case TypeBook.Novel:
                    InternalLend(book, NameLender, novels);
                    break;
                case TypeBook.Comic:
                    InternalLend(book, NameLender, comics);
                    break;
                case TypeBook.Essay:
                    InternalLend(book, NameLender, essays);
                    break;
                default:
                    break;
            }
        }

        private void InternalLend(Book book, string NameLender,  List<Book> books)
        {
            var resultEssay = books.First(x => x.CompareTo(book) && book.Status);
        
            if (resultEssay != null)
            {
                book.Status = false;
                book.LenderName = NameLender;
            }
        }

        public void Show()
        {
            //foreach (var item in novels)
            //{
            //    item.Show();
            //}
            //foreach (var item in comics)
            //{
            //    item.Show();
            //}
            //foreach (var item in essays)
            //{
            //    item.Show();
            //}
            /////////////
            novels.ForEach(x => x.Show());
            comics.ForEach(x => x.Show());
            essays.ForEach(x => x.Show());
            
            // novels.ForEach(x => Console.WriteLine("Titulo del libro es: {0}, Autor:{1}, Disponible para prestamo:{2}",x.Name,x.Author,x.Status));

        }
        public void FindBookByLenderName(string lendName)
        {
            var query = novels.Where(x => x.LenderName == lendName);
           // query.ForEach(x => Console.WriteLine(x.Name));
           foreach(var book in query)
            {
                Console.WriteLine("El cliente {0} se presto los libros {1} ",lendName, book.Name);
            }

        }

    }
}
