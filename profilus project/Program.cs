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
using static profilus_project.WProtocolParser;
namespace Program
{


    class Program
    {


        static List<Entry> entries = new List<Entry>(); // Создаем список параметризуемый классом Entry

        
        static void Main(string[] args) // Метод Main - точка входа в пользовательский код, сигнатурный метод. 
        {
            string PriemData = "AB=001,BC=002,\nCD=003,DE=004\n";
            WProtocolParser Parser = new WProtocolParser();

            List<Entry> entries = new List<Entry>(); // Создаем список параметризуемый классом Entry

            for (int i = 0; i < PriemData.Length; i++) 
            {
                Parser.WorkComPort(Convert.ToString(PriemData[i]), entries);
                
            }

            
            

        }







    }
}
