using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_2_unit_4
{
    class Program
    {
        static void Main(string[] args)
        {
            team t = new team();
            t.setName("james's team");
            t.printTeam();

            Participant p = new Participant();
            p.setName("James");
            p.printParticipant();
        }
    }
}
