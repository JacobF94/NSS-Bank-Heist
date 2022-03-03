using System;

namespace BankHeist
{
    public class Criminal
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }
        public Criminal(string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }
        public void DisplayCriminal()
        {
            Console.WriteLine($"You have hired {Name} who has a skill level of {SkillLevel} and has a courage level of {CourageFactor}");
        }
    }
}