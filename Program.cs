using System;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Greetings... Plan your heist, name your new criminal hire: ");
            string userInput = Console.ReadLine();
            Criminal UserCriminal = new Criminal(userInput);
            Console.Write($"Excellent, {userInput} has been hired for this operation. What is their skill level: ");
            int inputSkill = int.Parse(Console.ReadLine());
            UserCriminal.SetSkill(inputSkill);
            Console.Write($"Great, {userInput} has a skill level of {inputSkill}. Now, what is their courage level? Somewhere between 0.0 and 2.0: ");
            float inputCourage = float.Parse(Console.ReadLine());
            UserCriminal.SetCourage(inputCourage);
            UserCriminal.DisplayCriminal();
        }
    }
}
