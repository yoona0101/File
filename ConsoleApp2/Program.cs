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
                StreamReader f = new StreamReader("salary.txt");
                string s;
                int count = 0;
                const int n = 20;
                int[] a = new int[n];
                string[] buf;
                while ((s = f.ReadLine()) != null)
                {
                    buf = s.Split(' ');
                    
                    for (int i = 0; i < buf.Length; ++i)
                    {
                        a[i] = Convert.ToInt32(buf[i]);
                        count++;
                    }
                    Console.WriteLine("{0} сумма: {1}", s, count);
                }
                f.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(" Проверьте правильность имени файла!"); return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message); return;
            }
        }
    }
}
