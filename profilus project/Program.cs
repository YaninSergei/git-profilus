using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Program
{
    class Program
    {
        struct entry  // struct - ключевое слово создание структуры | entriy - Имя структуры.
        {
            public entry(string k, int v)
            {
                key = k;
                value = v;
            }
            public string key { get; set; } // переменная key, string типа.
            public int value { get; set; }// переменная value, int типа.
        };
        public
        static string PriemData = "AB =001, BC =002,CD =003, DE =004";

        static List<entry> entries = new List<entry>();
        static void Main(string[] args)
        {
            string[] datas = PriemData.Split(',');
            for (int i = 0; i < datas.Length; i++)
            {
                string[] fields = datas[i].Split("=");

                string name = fields[0];
                int value = Convert.ToInt32(fields[1]);
                // Если размер Fields не равен 2-м то я ни"я не делаю
                entry e = new entry(name, value);
                e.value = value;
                entries.Add(e);

            }


            print_entries(entries);
        }

        static void print_entries(List<entry> prientries)
        {
            Console.WriteLine(prientries.Count);
            for (int i = 0; i < prientries.Count; i++)
            {
                Console.Write("Ключ:" + prientries[i].key);
                Console.WriteLine("Значение:" + prientries[i].value);
            }
        }
    }
}