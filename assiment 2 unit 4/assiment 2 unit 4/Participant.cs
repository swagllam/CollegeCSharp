using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_2_unit_4
{
    class Participant
    {
        string personname;

        public void setName(string s)
        {
            this.personname = s;
        }
        public string getPersonname()
        {
            return personname;
        }

        public void printParticipant()
        {
            Console.WriteLine("A participant called " + personname);
        }


    }
}
   
