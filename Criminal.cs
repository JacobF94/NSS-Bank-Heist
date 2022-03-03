using System;
namespace BankHeist
{
    class Criminal
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public float CourageFactor { get; set; }
        public Criminal(string name)
        {
            Name = name;
        }
        public void SetSkill(int skill)
        {
            SkillLevel = skill;
        }
        public void SetCourage(float courage)
        {
            CourageFactor = courage;
        }
    }
}