using System;
using System.IO;
using System.Text;

namespace ProfessionalLesson4Task4
{

    //    Задание 4
    //Создайте текстовый файл-чек по типу «Наименование товара – 0.00 (цена) грн.» с
    //определенным количеством наименований товаров и датой совершения покупки.Выведите на
    //экран информацию из чека в формате текущей локали пользователя и в формате локали en-
    //US.

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            FileInfo output = new FileInfo(@"C:\Users\user\Desktop\IO tests\receipt.txt");

            Commodity c1 = new Commodity("Tea", 250, new DateTime(2021, 12, 10, 12, 57, 43));

            if (output.Exists)
            {
                Console.WriteLine("Do you want to rewrite file 'receipt.txt'?\nInput 'y' or 'n' and Enter.");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "y":
                        using (StreamWriter sw = new StreamWriter(new FileStream(output.FullName, FileMode.OpenOrCreate, FileAccess.Write)))
                        {
                            sw.Write(c1.ToString());
                            sw.Close();
                        }
                        Console.WriteLine("File was rewritten.");
                        break;
                    case "n":
                        Console.WriteLine("File was not rewritten.");
                        break;
                    default:
                        Console.WriteLine("Unknown action, please input 'y' or 'n'.");
                        return;
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(output.FullName, FileMode.OpenOrCreate, FileAccess.Write)))
                {
                    sw.Write(c1.ToString());
                    sw.Close();
                }
            }
        }
    }
}
