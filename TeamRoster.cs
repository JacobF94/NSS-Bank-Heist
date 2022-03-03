using System;
using System.Collections.Generic;

namespace BankHeist
{
    public class Roster
    {
        public string Name { get; set; }
        private List<Criminal> _EvilTeam = new List<Criminal>();
        public Roster(string TeamName)
        {
            Name = TeamName;
        }
        public void AddMember(Criminal criminalName)
        {
            _EvilTeam.Add(criminalName);
        }
        public void DisplayTeam()
        {
            foreach (Criminal criminal in _EvilTeam)
            {
                Console.WriteLine($"{criminal.Name} has a skill level of {criminal.SkillLevel} and a courage level of {criminal.CourageFactor}.");
            }
        }
        public void DisplayNumber()
        {
            Console.WriteLine($"your team has {_EvilTeam.Count} memberes");
        }
    }
}