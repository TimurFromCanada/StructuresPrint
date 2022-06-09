using System;

namespace StructuresPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var stroka = Console.ReadLine();
                var number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 6)
                {
                    Console.WriteLine("Цвета с таким номером не существует");
                    continue;
                }
                    
                StaticPrint.Print(stroka, number);
            }
        }
    }
}
