using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Les17
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("Введите ваш номер счета цифрами");
                Bank<int> bank = new Bank<int>();
                double balance = 300;
                bank.Balance = balance;
                string name = "Ivanoff";
                bank.Name = name;
        try { 
                bank.Input();
                bank.ReadB();
                
            }

            catch
            {
                Console.WriteLine("Номер счета не состоял только из цифр. Попробуйте еще раз. Нажмите enter");
                Console.ReadKey();
            }
            Console.WriteLine("Введите ваш номер счета буквами");
            Bank<string> bank2 = new Bank<string>();
            double balance2 = 10000000;
            bank2.Balance = balance2;
            string name2 = "NeIvanoff";
            bank2.Name = name2;
            try
            {
                bank2.Input(); bank2.ReadB();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
     
        }
    }
}
