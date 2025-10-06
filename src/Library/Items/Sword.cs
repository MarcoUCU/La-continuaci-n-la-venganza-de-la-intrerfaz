namespace Ucu.Poo.RoleplayGame;

public class Sword : IItem
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int HealingValue { get; set; }

    public Sword()
    {
        Name = "Sword";
        AttackValue = 20;
        DefenseValue = 0;
        HealingValue = 0;
    }
}
