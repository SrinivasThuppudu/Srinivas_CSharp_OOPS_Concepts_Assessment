using System;

class Book
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;

    public Book() {}
    public Book(string title, string author)
    { 
        Title = title;
        Author = author;
    }
    public Book(string title, string author, string isbn) : this(title, author) 
    { 
        ISBN = isbn;
    }
}
