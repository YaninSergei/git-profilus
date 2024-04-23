using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static profilus_project.Entry;
using static profilus_project.ConsoleShowData;

namespace profilus_project
{
    interface IShowEntries
    {
       void ShowEntries(List<Entry> prientries);
    }

}
