namespace Ucu.Poo.RoleplayGame;

    public class Spell 
    {
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public int HealingValue { get; set; }

        public Spell()
        {
            Name = "Spell";
            AttackValue = 70;
            DefenseValue = 70;
            HealingValue = 0;
        }
    }
}