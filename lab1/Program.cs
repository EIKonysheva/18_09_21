using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Classwork
{ using System;
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("№1\n" +
                "int   " + int.MinValue.ToString() + "  " + int.MaxValue.ToString() +
               "\nfloat   " + float.MinValue.ToString() + "  " + float.MaxValue.ToString() +
               "\ndouble   " + double.MinValue.ToString() + "  " + double.MaxValue.ToString() +
               "\nDateTime   " + DateTime.MinValue.ToString() + "  " + DateTime.MaxValue.ToString() +
               "\nbyte   " + byte.MinValue.ToString() + "  " + byte.MaxValue.ToString() +
               "\nsbyte   " + sbyte.MinValue.ToString() + "  " + sbyte.MaxValue.ToString());
            Console.WriteLine("\n№2\nВведите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите PIN-код");
            string PIN = Console.ReadLine();
            Console.WriteLine("Имя: " + name + "   Город:" + city + "   Возраст:" + age + "   PIN-код:" + PIN);
            Console.WriteLine("\n№3\nВведите строку");
            string phrase = Console.ReadLine();
            string phrase1 = "";
            foreach (char c in phrase)
            {
                if (char.IsLower(c))
                    phrase1 += char.ToUpper(c);
                else
                    phrase1 += char.ToLower(c);
            }
            Console.WriteLine(phrase1);
            Console.WriteLine("\n№4\n Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите подстроку: ");
            string str2 = Console.ReadLine();
            int count = (str1.Length - str1.Replace(str2, "").Length) / str2.Length;
            Console.WriteLine("Количество вхождений: {0}", count);
            Console.WriteLine("\n№5 \nВведите скорость таракана в км/ч: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            int speed1 = Convert.ToInt32(speed * 1000 / 36);
            Console.WriteLine("Скорость таракана = " + speed1 + "cм/с");
            Console.WriteLine("\n№6\nВведите возраст отца: ");
            int ageDad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст сына: ");
            int ageSon = Convert.ToInt32(Console.ReadLine());
            int difference = ageDad - ageSon;
            if (ageDad - ageSon < 18)
                Console.WriteLine("Ошибка. Недопустимые значения.");
            else
            {
                if (difference == ageSon)
                    Console.WriteLine("Отец вдвое старше сына");
                else
                {
                    if (difference < ageSon)
                        Console.WriteLine($"Отец был старше сына в 2 раза {ageSon - difference} лет назад");

                    else
                    { Console.WriteLine($"Отец будет старше сына в 2 раза через {difference - ageSon} лет"); }
                }
            }
            Console.WriteLine("\n№7\nВведите стандартную цену бутылки: ");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в DutyFree:");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            int bottleNumber = holidayPrice / (normPrice * salePrice / 100);
            Console.WriteLine("Количество бутылок для окупаемости отпуска: {0}", bottleNumber);
            Console.ReadKey();
        }
    }  
}

