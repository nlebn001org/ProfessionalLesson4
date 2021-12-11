using System;
using System.Text.RegularExpressions;

namespace ProfessionalLesson4Task1
{
    //    Напишите консольное приложение, позволяющие пользователю зарегистрироваться под
    //«Логином», состоящем только из символов латинского алфавита, и пароля, состоящего из
    //цифр и символов.

    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string password;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Input your username which is longer than 5 characters, less than 11 characters and " +
                                      "consists of only a-z letters.");
                    string str = Console.ReadLine();
                    if (new Regex(@"^([a-z]{5,11})").IsMatch(str) && str.Length < 11)
                    {
                        name = str;
                        break;
                    }
                    Console.WriteLine("Try one more.");
                }

                while (true)
                {
                    Console.WriteLine("Input your password which is longer than 8 characters, less than 15 characters " +
                                       "and consists of digits and characters.");
                    string str = Console.ReadLine();
                    if (new Regex(@"^([0-9a-zA-Z!@#$%^&*()]{8,15})").IsMatch(str) && str.Length < 16)
                    {
                        password = str;
                        break;
                    }
                    Console.WriteLine("Try to enter other password.");
                }
                Console.WriteLine($"Your name is: {name}, your password is: {password}.");
            }

        }
    }
}
