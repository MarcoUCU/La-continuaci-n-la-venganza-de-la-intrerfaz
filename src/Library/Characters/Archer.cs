namespace Ucu.Poo.RoleplayGame;
/// <summary>
/// Representa un Archer que implementa ICombatant para definir acciones comunes de combate.
/// 
/// SRP: Esta clase solo maneja los comportamientos específicos de archers
/// Expert: Archer es experto en su propia información (vida, armas)
/// </summary>
public class Archer: ICombatant
{

    public Archer(string name)
    {
        this.Name = name;
        this.Health = InitialHealth;
        this.Bow = new Bow();     
        this.Helmet = new Helmet();
    }

    public string Name { get; set; }

    public Bow Bow { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Helmet.DefenseValue;
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
