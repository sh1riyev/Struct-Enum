using Sealed_Struct_Enum_Nullable;

Book book = new();

book.Name = "salam";

//Console.WriteLine(book.Name);

//EmptyClass emptyClas = new();

string name = null;
int ? num = null;

//Console.WriteLine(book.Id);

//if (book.Id == null)
//{
//    Console.WriteLine("Book not found");
//}

Book book1 = new()
{
    Id = 1,
    Name = "iskendername",
    Author = new Author() { Name = "Nizami", Id = 2 }
};

Book book2 = new()
{
    Id = 2,
    Name = "xosrov ve shirin"
};

//Console.WriteLine("Book:"+ book2.Name + "  Author:" + book2.Author?.Name.Substring(1,3));




Book[] books = { book1, book2 };

//void GetById(Book[] books,int ? id =null)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }

//    Book result = books.FirstOrDefault(m => m.Id == id);

//    Console.WriteLine(result.Name);

//    string? name = null;

//}
//GetById(null);


//Level level = Level.Low;

//Console.WriteLine((int)level==1);

void GetLevel(string levelNum)
{
    switch (levelNum)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof (Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof (Level.High):
            Console.WriteLine("High");
            break;
        default:
            Console.WriteLine("Salam");
            break;
    }
}

GetLevel("Low");