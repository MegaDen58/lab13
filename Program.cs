using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        int x = 0;
        string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятницу", "Суббота", "Воскресенье" };

        Message message = (string[] array, ref int index) =>
        {
            if(index == 6)
            {
                Console.WriteLine(array[index]);
                index = 0;
            }
            else
            {
                Console.WriteLine(array[index]);
                index += 1;
            }
        };

        for(int i = 0; i < 16; i++)
        {
            message(day, ref x);
        }
    }
    delegate void Message(string[] array, ref int index);
}