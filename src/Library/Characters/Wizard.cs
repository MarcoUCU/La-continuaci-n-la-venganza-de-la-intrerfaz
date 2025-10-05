namespace Ucu.Poo.RoleplayGame;

public class Wizard: ICombatant
{

    public Wizard(string name)
    {
        this.Name = name;
        this.Health = InitialHealth;
    }

    public string Name { get; set; }

    public SpellsBook SpellsBook { get; set; }

    public Staff Staff { get; set; }

    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue;
        }
    }

    private int health;
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
    public int InitialHealth { get; } = 100;

    public void Attack(ICombatant target) //Allows this character to attack
    {
        target.ReceiveAttack(this.AttackValue);
    }
    public void GetHealed()
    {
        this.Health = this.InitialHealth;
    }
    public void HealOthers(ICombatant target) //Allows healing others
    {
        target.GetHealed();
    }

}
