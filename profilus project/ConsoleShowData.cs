using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profilus_project
{
    class ConsoleShowData : IShowEntries
    {
        public void ShowEntries(List<Entry> prientries)
        {
            Console.WriteLine("Начал Сообщение");
            Console.WriteLine(prientries);
            Console.WriteLine(prientries.Count);
            for (int i = 0; i < prientries.Count; i++)
            {
                Console.Write("Ключ:" + prientries[i].key);
                Console.WriteLine("Значение:" + prientries[i].value);

            }
            Console.WriteLine(" Конец Сообщение");
            Console.WriteLine("");
        }   
    }
}
