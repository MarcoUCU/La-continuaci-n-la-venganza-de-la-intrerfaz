namespace Ucu.Poo.RoleplayGame;

    public class Helmet : IItem
    {
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public int HealingValue { get; set; }
        
        public Helmet()
        {
            Name = "Helmet";
            AttackValue = 0;
            DefenseValue = 18;
            HealingValue = 0;
        }
    }


