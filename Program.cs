﻿using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plan your heist!! What will your team name be: ");
            string TeamNameInput = Console.ReadLine();
            Roster MyTeam = new Roster(TeamNameInput);
            Console.Write("Which bank will be your target: ");
            string InputBankName = Console.ReadLine();
            Bank TargetBank = new Bank(InputBankName);
            TargetBank.DifficultyLevel = 100;
            Random r = new Random();
            int LuckFactor = r.Next(-10, 10);
            TargetBank.DifficultyLevel += LuckFactor;
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
            MyTeam.TeamTotalSkill();
            Console.WriteLine($"{TargetBank.Name} has a difficulty rating of {TargetBank.DifficultyLevel}...");

            if (MyTeam.TotalSkill > TargetBank.DifficultyLevel)
            {
                Console.WriteLine("Congratulations criminals, you have secured the bag");
            } else
            {
                Console.WriteLine("Too bad, your whole team was arrested!");
            }
        }
    }
}