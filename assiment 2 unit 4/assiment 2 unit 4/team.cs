using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_2_unit_4
{
    class team
    {
        string teamname;
        List<Participant> member=new List<Participant>();

        public void setName(string s)
        {
            this.teamname = s;
        }
        public string getName()
        {
            return teamname;
        }

        public void addParticipant(Participant p)
        {
            member.Add (p);
        }

        public void printTeam()
        {
            Console.WriteLine("A team called" + teamname);
            Console.WriteLine("It has the following members:");
            for (int i=0; i<member.Count; i++)
            {
                member[i].printParticipant();
            }

        }


    }

}
