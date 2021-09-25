using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    
    class Program
    {
        enum account { saving, current };
        struct bank_account
        {
            public int number;
            public account type;
            public double balance;

        }
        enum univ { KGY, KAI, KHTI};
        struct worker 
        {
            public string name;
            public univ univer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            account ac1;
            ac1 = account.current;
            Console.WriteLine(ac1);
            account ac2;
            ac2 = account.saving;
            Console.WriteLine(ac2);
            Console.WriteLine("\nЗадание 3.2");
            bank_account acc1;
            acc1.balance = 7654;
            acc1.number = 43;
            acc1.type =account.saving;
            Console.WriteLine($"Number = {acc1.number} Type = {acc1.type} Balance = {acc1.balance}");
            Console.WriteLine("\nЗадание 3.1");
            worker Volodya;
            Volodya.name = "Yaroslav";
            Volodya.univer = univ.KAI;
            Console.WriteLine($"Name = {Volodya.name} Univer = {Volodya.univer}");
        }
       
    }
}
