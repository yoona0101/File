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
                FileStream f = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite);
                byte[] x = new byte[10];
                Random rd=new Random();
                for (byte i = 0; i < 10; ++i)
                {
                    rd.NextBytes(x);
                }
                f.Write(x, 0, 10);   // записывается 10 элементов массива 
                int a, count = 0;
                f.Seek(0, SeekOrigin.Begin);    // текущий указатель - на начало 
                for (int i = 0; i < 10; i++)
                {
                    a = f.ReadByte();
                    if (a % 2 != 0)
                    {
                        count++;
                    }
                    Console.Write(a + " ");    //контрольная печать считанного значения
                }
                Console.WriteLine();
                Console.WriteLine("count= " + count);
                Console.WriteLine("Текущая позиция в потоке " + f.Position);
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка работы с файлом: " + e.Message);
            }
        }
    }
}
