using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите дату рождения слитно, например 19112018 (19 ноября 2018)");
            string strng = Console.ReadLine();
            int num;
            if (int.TryParse(strng, out num) == true)
            {
                while (num >= 10)
                {
                    num = Sum(num);
                }
                Console.WriteLine("Число судьбы " + num);
                Console.WriteLine("Вы можете узнать значение вашего 'Числа судьбы' здесь  http://www.sonniki.net.ru/numerologia/chislo-rojdenia.html");
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }

        }

        private static int Sum(int num)
        {
            int sum = 0;
            for (; num != 0; num /= 10)
                sum += num % 10;
            return sum;



        }

    }
}
//Пентинен А.О