using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Les17
{
    class Bank<T>
    {
       internal T Check { get; set; }
       internal double Balance { get; set; }
       internal string Name { get; set; }

       /* public Bank(T check, double balance, string name)
        {
            Check = check;
            Balance = balance;
            Name = name;
        }
       */

        public void ReadB()
    {
        Console.WriteLine($"Ваши данные считаны: номер счета - {Check}, ваш баланс - {Balance}, ваше имя - {Name}");
    }

        public void Input()
        {
            
            Check = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите 3 цифры с обратной стороны карточки");
            Thread.Sleep(1000);
            Console.WriteLine("Шутка, мы сами знаем эти цифры"+"\n");
        }

    }
    

}
