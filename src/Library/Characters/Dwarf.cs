namespace Ucu.Poo.RoleplayGame;

public class Dwarf : ICombatant
{

    public Dwarf(string name)
    {
        this.Name = name;
        this.Health = InitialHealth;
    }

    public string Name { get; set; }

    public Axe Axe { get; set; }

    public Shield Shield { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Axe.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Shield.DefenseValue + Helmet.DefenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.Health;
        }

        set
        {
            this.Health = value < 0 ? 0 : value;
        }
    }
   public int InitialHealth { get; } = 100;

    public void Attack(ICombatant target) //Allows this character to attack
    {
        target.ReceiveAttack(this.AttackValue);
    }
    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
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
