namespace Ucu.Poo.RoleplayGame;

public class Armor : IItem
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int HealingValue { get; set; }

    public Armor()
    {
        Name = "Armor";
        AttackValue = 0;
        DefenseValue = 25;
        HealingValue = 0;
    }
}