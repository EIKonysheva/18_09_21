using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A1.1\nВведите количество секунд");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a)Количество полных часов с начала суток = " + num / 3600 +
                "\nб)Количество полных минут с начала очередного часа = " + (num % 3600) / 60 +
                "\nв)Количество полных секунд с начала очередной минуты = " + num % 60);
            Console.WriteLine("\nA1.2\n" + (540*130/130/130),//Площадь прямоугольника делим на площадь квадрата
                " квадратов со стороной 130 мм можно отрезать\n" +
                "A1.3\nВведите количество месяцев");
            int months = Convert.ToInt32(Console.ReadLine());
            if (months >= 12)//если больше года, значит нам надо начать новый отсчет
                Console.WriteLine("n = " + months + " x = " + (months % 12 + 1));
            else
                Console.WriteLine("n = " + months + " x = " + (months + 1) +
                    "\nA1.4\nВведите двузначное число: ");
            int sign = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a)число десятков = " + sign / 10 
                + "\nб)число единиц = " + sign % 10
                + "\nв)сумма его цифр = " + ((sign / 10) + (sign % 10))
                + "\nг)произведение его цифр = " + ((sign / 10) * (sign % 10))
                + "\nA1.5\nВведите трехзначное число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            string hundred = Convert.ToString(num3 / 100);
            Console.WriteLine(num3 % 100 + hundred +
                "\nA1.6\n");
            for (int number = 100; number < 999; number++)
            {
                if ((number % 10).ToString() + ((number - number % 10) / 10).ToString() == "237")
                {
                    Console.WriteLine(number);
                    break;
                }
            }
            Console.ReadKey();
            Console.WriteLine("\nA1.7\n");
        }
    }
}
