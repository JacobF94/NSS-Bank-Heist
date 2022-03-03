using System;
namespace BankHeist
{
    public class Bank
    {
        public string Name { get; set; }
        public int DifficultyLevel { get; set; }
        public Bank(string name)
        {
            Name = name;
        }
    }
}