using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_2_unit_4
{
    class events
    {
        string eventName;
        List<string> types = new List<string>();
        string type;
        public events()
        {
            types.Add("academic");
            types.Add("sporting");
        }

        public void settypes(string s)
        {
            if (types.Contains(s))
            {
                type = s;
            }
            else
            {
                Console.WriteLine("This is not a valid type");
            }
        }
    }
}
