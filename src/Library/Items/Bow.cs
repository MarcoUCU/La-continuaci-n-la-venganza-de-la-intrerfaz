using System.Dynamic;

namespace Ucu.Poo.RoleplayGame;

public class Bow : Iitems
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int HealingValue { get; set; }

    public Bow()
    {
        Name = "Bow";
        AttackValue = 15;
        DefenseValue = 0;
        HealingValue = 0;
    }
}
