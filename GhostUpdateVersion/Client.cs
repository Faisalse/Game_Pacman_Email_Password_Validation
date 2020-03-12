using System;
using System.Collections.Generic;
using System.Text;

namespace GhostUpdateVersion
{  // Our respectable client: Dr muaaz niazi
    public class Client
    {
        //****Call PacManFSM class to access its events****
        PacManFsm pacManFsm = new PacManFsm();
        //*** Function to show all Pacman FSM events
        public void PacManEvents()
        {
            Console.WriteLine("Press 0: Pacman eat cheeze");
            Console.WriteLine("Press 1: Pacman eat SuperTab");
            Console.WriteLine("Press 2: Ghost eats Pacman");
            Console.WriteLine("Press 3: Pacman eats lastcheeze");
            Console.WriteLine("Press 4: Pacman life left");
            Console.WriteLine("Press 5: pacman no life left");
            Console.WriteLine("Press 6: pacman eats sacred ghost");
            Console.WriteLine("Press 7: pacman eats by brave ghost");
            Console.WriteLine("Press 8: Super pacman time out");
            Console.WriteLine("Press 9: Pacman moves to last level");
            Console.WriteLine("Press 10: last level....game up");
        }
        //Function to trigger Pacman FSM events...........
        public void triggerPacmanEvent()
        {
            Console.Write("Trigger the Event---->  ");
            int eventNumber = Convert.ToInt32(Console.ReadLine());
            pacManFsm.FireEvent(eventNumber);
            if (pacManFsm.inValid == true)
            {               
                Console.WriteLine("****  Invalid Event  ****");
                Console.WriteLine("Current state---> " + pacManFsm.getCurrentState());
                pacManFsm.inValid = false;           
                triggerPacmanEvent();
            }
            else
            {
                Console.WriteLine("Current state---> "+pacManFsm.getCurrentState());
                triggerPacmanEvent();
            }
        }


        //Declare object of GhostFSm Class to access its functions and attributes
        GhostFsm ghostFsm = new GhostFsm();
        //Function to show total number of events of Ghost FSM
        public void ghostEvents()
        {
            Console.WriteLine("Press 0: MoveRandom");
            Console.WriteLine("Press 1: Eat PacMan");
            Console.WriteLine("Press 2: PacMan Eat Super Tab");
            Console.WriteLine("Press 3: Pac Eat Scared Ghost");
            Console.WriteLine("Press 4: Super PacMan TimeOut,");
            Console.WriteLine("Press 5: Move To Intial State");
            Console.WriteLine("Press 6: Finish the game");
        }
        
        //Function to trigger the Ghost FSM events
        public void triggerEventForGhost()
        {           
            Console.Write("Trigger the Event---->  ");
            int eventNumber = Convert.ToInt32(Console.ReadLine());                       
            ghostFsm.fireEvent(eventNumber);                     
            //Conditions for checking valid or invalid events
            if (ghostFsm.inValid == true)
            {
                Console.WriteLine("****Invalid Event****");
                Console.WriteLine("Your current state---- > " + ghostFsm.get());
                ghostFsm.inValid = false;
                triggerEventForGhost();
            }           
            else
            {               
                Console.WriteLine("Your current state---->" + ghostFsm.get());
                triggerEventForGhost();
            }
        }
        //***** Staritng function of game****
        // we declare Ghost Fsm and Pacman Fsm objects in
        // startGame() function and use switch case statement to ask
        // client whether he wants to run ghost fsm or pacman Fsm
        public void startGame()
        {
            Console.WriteLine("Press 1: To start Pacman Fsm");
            Console.WriteLine("Press 2: To start Ghost Fsm");
            Console.Write("Trigger the event--->  ");
            int start = Convert.ToInt32(Console.ReadLine());
            switch (start)
            {
                case 1:
                    PacManEvents();
                    triggerPacmanEvent();
                    break;
                case 2:
                    ghostEvents();
                    triggerEventForGhost();
                    break;
                default:
                    Console.WriteLine("Your Input Invalid");
                    startGame();
                    break;
            }
        } 
        
        // Constructor of Client class to call start game function      
        public Client()
        {
            startGame();
        }

    }
}
