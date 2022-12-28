// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLEvel1.Practice03;

Console.WriteLine("Hello, World!");
Book book1 = new Novel
{
    Name = "Cien Años de soledad",
    Author = "Gabriel Garcia Marquez",
    Genre = TypeGenre.Novel
};
Book book2 = new Novel
{
    Name = "Cien Años de soledad",
    Author = "Gabriel Garcia Marquez",
    Genre = TypeGenre.Novel
};
Book book3 = new Novel
{
    Name = "El principito",
    Author = "Antoine de Saint",
    Genre = TypeGenre.Novel
};
Book book4 = new Novel
{
    Name = "El principito",
    Author = "Antoine de Saint",
    Genre = TypeGenre.Romantic
};
Book book5 = new Novel
{
    Name = "Cien Años de soledad",
    Author = "Gabriel Garcia Marquez",
    Genre = TypeGenre.Resumen
};
Book book7 = new Novel
{
    Name = "Cien Años de soledad",
    Author = "Gabriel Garcia Marquez",
    Genre = TypeGenre.Resumen
};
BookManager bookManager=new BookManager();
bookManager.AddBook(book1);
bookManager.AddBook(book2);
bookManager.AddBook(book3);
bookManager.AddBook(book4);
bookManager.AddBook(book5);
bookManager.Show();
Console.WriteLine("=======================");
bookManager.RemoveBook(book1);
bookManager.Show();
Console.WriteLine("=======================");
bookManager.RemoveBook(book7);
bookManager.Show();

