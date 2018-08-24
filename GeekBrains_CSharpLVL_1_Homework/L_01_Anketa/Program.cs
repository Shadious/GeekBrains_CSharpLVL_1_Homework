//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
//В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добрый день. Пожалуйста, введите Ваше имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Пожалуйста, введите Вашу фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Пожалуйста, введите Ваш возраст: ");
            string age = Console.ReadLine();

            Console.Write("Пожалуйста, введите Ваш рост в сантиметрах: ");
            string height = Console.ReadLine();

            Console.Write("Пожалуйста, введите Ваш вес в килограммах: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Добро пожаловать, " + lastName + " " + firstName + "! Вам " + age + " лет, Ваш рост " + height + " сантиметров, а вес " + weight + " килограмм!");
            Console.WriteLine("Добро пожаловать, {0} {1}! Вам {2} лет, Ваш рост {3} сантиметров, а вес {4} килограмм!", lastName, firstName, age, height, weight);
            Console.WriteLine($"Добро пожаловать, {lastName} {firstName}! Вам {age} лет, Ваш рост {height} сантиметров, а вес {weight} килограмм!");

            Console.ReadKey();
        }
    }
}
