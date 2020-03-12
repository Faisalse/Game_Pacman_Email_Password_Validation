using System;

namespace GhostUpdateVersion
{
    class Program
    {
        public void functionToProgram()
        {
            // Declare object of Client class to run its constructor
            Console.WriteLine("Finite state machine vs Email & password validation");
            Console.WriteLine("Press 0: Finite state machine");
            Console.WriteLine("Press 1: Password email validation");
            Console.Write("Press the button--> ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Client client = new Client();
                    break;
                case 1:
                    PasswordEmailHandling validation = new PasswordEmailHandling();
                    break;
                default:
                    Console.WriteLine("Enter the correct value");
                    functionToProgram();
                    break;

            }
        }
        

        static void Main(string[] args)
        {
            Program program = new Program();
            program.functionToProgram();
        }
    }
}
