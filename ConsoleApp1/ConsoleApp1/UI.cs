using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament
{
    class UI
    {

        public void Mainmenu()
        {
            string choice = "star";
            while (!choice.Equals("quit"))
            Console.WriteLine("1 - entere a new participant");
            Console.WriteLine("or type quit");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();
                    Participant p = new Participant();
                    p.setName(name);
                    p.printParticipant();
                    break;
                case "2":
                    Console.WriteLine("enter name");
                    name = Console.ReadLine();
                    Team t = new Team();
                    t.setName(name);
                    t.printTeam();
                    break;
                case "3":
                    Console.WriteLine("enter name");
                     name = Console.ReadLine();
                    Event e = new Event();
                    e.setName(name);
                    e.printevent();
                    break;
                case "4":
                    Console.WriteLine("enter name");
                     name = Console.ReadLine();
                    Tournament s = new Tournament();
                    s.setName(name);
                    s.printTournament();
                    break; 
                    



            }
        }
    }

}