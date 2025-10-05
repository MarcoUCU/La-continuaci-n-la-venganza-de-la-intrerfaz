namespace Ucu.Poo.RoleplayGame;

    public class Staff : Iitems
    {
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public int HealingValue { get; set; }

        public Staff()
        {
            Name = "Staff";
            AttackValue = 100;
            DefenseValue = 100;
            HealingValue = 0;
        }
    }


