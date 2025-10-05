namespace Ucu.Poo.RoleplayGame;

public class Axe : Iitems
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int HealingValue { get; set; }

    public Axe()
    {
        Name = "Axe";
        AttackValue = 25;
        DefenseValue = 0;
        HealingValue = 0;
    }
}

