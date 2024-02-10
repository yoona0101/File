using System;
using System.IO;
namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            try
            {
                // работа с потоком байтов символы
                FileStream fchar = new FileStream("test1.txt", FileMode.Create, FileAccess.ReadWrite);
                char[] x = new char[10];
                Console.WriteLine("Введите 10 символов");
                for (int i = 0; i < 10; ++i)
                {
                    x[i] = (char)Console.Read();
                    fchar.WriteByte((byte)x[i]);   // записывается элемент массива 
                }
                Console.ReadLine();
                int a;
                fchar.Seek(0, SeekOrigin.Begin);    // текущий указатель - на начало 
                for (int i = 0; i < 10; i++)
                {
                    a = fchar.ReadByte();
                    if ((a >= 97) && (a <= 122))
                    {
                        Console.Write((char)a + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Текущая позиция в потоке " + fchar.Position);
                fchar.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка работы с файлом: " + e.Message);
            }
        }
    }
}
