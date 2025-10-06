namespace Ucu.Poo.RoleplayGame;

public class Shield : IItem
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int HealingValue { get; set; }
    
    public Shield()
    {
        Name = "Shield";
        AttackValue = 0;
        DefenseValue = 14;
        HealingValue = 0;
    }
}
