using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plan your heist!! What will your team name be: ");
            string TeamNameInput = Console.ReadLine();
            Roster MyTeam = new Roster(TeamNameInput);
            bool Continue = true;
            while (Continue)
            {
                Console.Write("Let's get started, name your new criminal hire (If you are done hiring, enter a blank name to stop): ");
                string userNameInput = Console.ReadLine();
                if (userNameInput == "")
                {
                    Continue = false;
                    break;
                } else
                {
                Console.Write($"Excellent, {userNameInput} has been hired for this operation. What is their skill level: ");
                int inputSkill = int.Parse(Console.ReadLine());
                Console.Write($"Great, {userNameInput} has a skill level of {inputSkill}. Now, what is their courage level? Somewhere between 0.0 and 2.0: ");
                double inputCourage = double.Parse(Console.ReadLine());
                Criminal newCriminal = new Criminal(userNameInput, inputSkill, inputCourage);
                newCriminal.DisplayCriminal();
                MyTeam.AddMember(newCriminal);
            }
            }
            Console.WriteLine("Fantastic, the team has been assembled!");
            MyTeam.DisplayNumber();
            MyTeam.DisplayTeam();
        }
    }
}
