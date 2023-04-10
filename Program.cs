using System;

interface IPublish
{
    public void PrintBookName(string name);
    public void PrintBookAuthor(string name);
}

interface IBook : IPublish
{
    public void PrintBookDate<T>(T date);
    public void PrintBookPages(int count);
}

class Library : IBook
{
    public void PrintBookName(string name)
    {
        Console.WriteLine($"Название кники {name}");
    }
    public void PrintBookAuthor(string name)
    {
        Console.WriteLine($"Имя автора книги {name}");
    }
    public void PrintBookDate<T>(T date)
    {
        Console.WriteLine($"Книга написана в {date} году");
    }
    public void PrintBookPages(int count)
    {
        Console.WriteLine($"В книге {count} страниц");
    }
}

interface IUser
{
    public void PrintLogin<T>(T login);
    public void PrintPassword(string password);
}

class User : IUser
{
    public void PrintLogin<T>(T login)
    {
        Console.WriteLine($"Логин аккаунта: {login}");
    }
    public void PrintPassword(string password)
    {
        Console.WriteLine($"Пароль аккаунта: {password}");
    }
}

class Class : IBook, IUser
{
    public void PrintLogin<T>(T login)
    {
        Console.WriteLine($"Логин аккаунта: {login}");
    }
    public void PrintPassword(string password)
    {
        Console.WriteLine($"Пароль аккаунта: {password}");
    }
    public void PrintBookName(string name)
    {
        Console.WriteLine($"Название кники {name}");
    }
    public void PrintBookAuthor(string name)
    {
        Console.WriteLine($"Имя автора книги {name}");
    }
    public void PrintBookDate<T>(T date)
    {
        Console.WriteLine($"Книга написана в {date} году");
    }
    public void PrintBookPages(int count)
    {
        Console.WriteLine($"В книге {count} страниц");
    }
    
    public void PrintInfo(string name, string book)
    {
        Console.WriteLine($"Пользователь {name} купил кингу {book}");
    }
}

public class Program
{
    public static void Main()
    {
        Library library1 = new Library();
        Library library2 = new Library();
        library1.PrintBookDate("2022");
        library2.PrintBookDate(2015);

        User user1 = new User();
        User user2 = new User();
        user1.PrintLogin("login");
        user2.PrintLogin(2314);

        Class MyClass = new Class();
        MyClass.PrintInfo("Дмитрий", "Ужасы 2022");
    }
}