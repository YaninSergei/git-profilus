using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static profilus_project.Entry;
using static profilus_project.IShowEntries;
using profilus_project;

namespace Program
{


    class Program
    {
        static string PriemData = "AB =001, BC =002,CD =003, DE =004";

        static List<Entry> entries = new List<Entry>(); // Создаем список параметризуемый классом Entry


        static void Main(string[] args) // Метод Main - точка входа в пользовательский код, сигнатурный метод. 
        {
            string PriemData = "AB =001, BC =002,CD =003, DE =004";

            List<Entry> entries = new List<Entry>(); // Создаем список параметризуемый классом Entry

            WorkComPort (PriemData, entries);

            IShowEntries dataprint = new ConsoleShowData();


            dataprint.show_entries(entries);
        }


    static void WorkComPort(string PriemData, List<Entry> entries)
        {

            string[] datas = PriemData.Split(',');
            for (int i = 0; i < datas.Length; i++)
            {
                string[] fields = datas[i].Split("=");

                string name = fields[0];
                int value = Convert.ToInt32(fields[1]);
                // Если размер Fields не равен 2-м то я ни"я не делаю
                Entry e = new Entry(name, value);
                e.value = value;
                entries.Add(e);
            }


         }



    }
}

/*
namespace Program
{

    interface IPriemData
    {
        string GetData();
    }


    interface IDataEntries
    {
        void EnteriesData(IPriemData dataPrinyatie);
    }

    class ConsoleDataEntries : IDataEntries
    {
        public void EnteriesData(IPriemData dataPrinyatie)
        {
            Console.WriteLine(dataPrinyatie.GetData());
        }
    }

    class PeremennayaPriemData : IPriemData
    {
        public string GetData();
    }


    class Program
    {
        public static string Peremennya = "AB =001, BC =002,CD =003, DE =004";

        static void Main(string[] args)
        {
            IDataEntries dataEntries = new ConsoleDataEntries();
        }

    }

}
*/
