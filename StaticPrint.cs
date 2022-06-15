using System;
namespace StructuresPrint
{
    public enum ConsoleColor
    {
        Black = 0,
        Blue = 1,
        Red = 2,
        Yellow = 3,
        Gray = 4,
        Green = 5,
        White = 6,
    }

    public class StaticPrint
    {
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (System.ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}

