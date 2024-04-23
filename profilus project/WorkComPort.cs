using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profilus_project
{
    class WProtocolParser
    {
        string Akumulator = new String("");

       
        public void WorkComPort(string PriemData, List<Entry> entries)
        {
            if (PriemData == "\n")
            {
                string[] datas = Akumulator.Split(',');
                for (int i = 0; i < datas.Length; i++)
                {
                    if (datas[i] != "")
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

                IShowEntries dataprint = new ConsoleShowData();

                dataprint.ShowEntries(entries);
                Akumulator = "";
                entries.Clear();


            }
            else
            {
                Akumulator = Akumulator + PriemData;

            }



        }
    }
}

