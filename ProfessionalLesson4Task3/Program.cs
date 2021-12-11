using System;
using System.Text.RegularExpressions;

namespace ProfessionalLesson4Task3
{
    //    Задание 3
    //Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы
    //заменить все предлоги на слово «ГАВ!».
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\b(of)\b|\b(with)\b|\b(at)\b|\b(from)\b|\b(into)\b|\b(during)\b|\b(including)\b|\b(until)\b|\b(against)\b| 
                                    \b(among)\b|\b(throughout)\b|\b(despite)\b|\b(towards)\b|\b(upon)\b|\b(concerning)\b|\b(to)\b|\b(in)\b|\b(for)\b| 
                                    \b(on)\b|\b(by)\b|\b(about)\b|\b(like)\b|\b(through)\b|\b(over)\b|\b(before)\b|\b(between)\b|\b(after)\b| 
                                    \b(since)\b|\b(without)\b|\b(under)\b|\b(within)\b|\b(along)\b|\b(following)\b|\b(across)\b|\b(behind)\b| 
                                    \b(beyond)\b|\b(plus)\b|\b(except)\b|\b(but)\b|\b(up)\b|\b(out)\b|\b(around)\b|\b(down)\b|\b(off)\b|\b(above)\b| 
                                    \b(near)\b");


            string text = "Spencer told The Straits Times he was approaching the gardens’ entrance on 30 November when he spotted about 20 otters" +
                           " crossing a path in front of him.";

            string output = Regex.Replace(text, reg.ToString(), "Gav");
            Console.WriteLine(output);
        }
    }
}
