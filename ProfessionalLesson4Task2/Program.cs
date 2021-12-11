using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace ProfessionalLesson4Task2
{

    //    Задание 2
    //Напишите программу, которая бы позволила вам по указанному адресу web-страницы
    //выбирать все ссылки на другие страницы, номера телефонов, почтовые адреса и сохраняла
    //полученный результат в файл.

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stW = new Stopwatch();

            stW.Start();
            WebClient wc = new WebClient();
            FileInfo file = new FileInfo(@"C:\Users\user\Desktop\IO tests\Regex.txt");
            string web = wc.DownloadString("https://google.com/");
            Regex phonePattern = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            Regex webPattern = new Regex(@"(http(s)?://)([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?");
            Regex mailboxPattern = new Regex(@"a-z0-9!#$%&'*/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9?\.)]+a-z0-9?)");

            if (phonePattern.IsMatch(web) || webPattern.IsMatch(web) || mailboxPattern.IsMatch(web))
            {
                using (StreamWriter strWrt = new StreamWriter(file.FullName, false))
                {
                    strWrt.WriteLine($"Phone pattern matches: {phonePattern.Matches(web).Count}");
                    foreach (Match item in phonePattern.Matches(web))
                        strWrt.WriteLine(item);

                    strWrt.WriteLine(new string('-', 20));

                    strWrt.WriteLine($"Website pattern matches: {webPattern.Matches(web).Count}");
                    foreach (Match item in webPattern.Matches(web))
                        strWrt.WriteLine(item);

                    strWrt.WriteLine(new string('-', 20));

                    strWrt.WriteLine($"Mailbox pattern matches: {mailboxPattern.Matches(web).Count}");
                    foreach (Match item in mailboxPattern.Matches(web))
                        strWrt.WriteLine(item);

                    strWrt.WriteLine(new string('-', 20));

                    stW.Stop();
                    strWrt.WriteLine($"Time: {stW.Elapsed}");
                }

                Console.WriteLine($"Phone pattern matches: {phonePattern.Matches(web).Count}");
                foreach (Match item in phonePattern.Matches(web))
                    Console.WriteLine(item);

                Console.WriteLine(new string('-', 20));

                Console.WriteLine($"Website pattern matches: {webPattern.Matches(web).Count}");
                foreach (Match item in webPattern.Matches(web))
                    Console.WriteLine(item);

                Console.WriteLine(new string('-', 20));

                Console.WriteLine($"Mailbox pattern matches: {mailboxPattern.Matches(web).Count}");
                foreach (Match item in mailboxPattern.Matches(web))
                    Console.WriteLine(item);

                Console.WriteLine(new string('-', 20));

                Console.WriteLine($"Time: {stW.Elapsed}");
            }
        }
    }
}
