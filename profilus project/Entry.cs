using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace profilus_project
{
    struct Entry  // struct - ключевое слово создание структуры | entriy - Имя структуры.
    {
        public Entry(string k, int v) // Entry конструктор класса. 
        {
            key = k;
            value = v;
        }
        public string key { get; set; } // переменная key, string типа.
        public int value { get; set; }// переменная value, int типа.
    };

}
