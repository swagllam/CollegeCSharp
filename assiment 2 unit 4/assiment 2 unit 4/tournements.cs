using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_2_unit_4
{
    class tournments
    {
        String tounementsName;
        List<events> events = new List<events>();
        
        public void addevets(events e)
        {
            if (events.Count >= 5)
            {
                Console.WriteLine("Team is full"); 
            }

            else
            {
                events.Add(e);
            }
        }
    }
}
