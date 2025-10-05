namespace Ucu.Poo.RoleplayGame;
/// <summary>
/// Representa un Dwarf que implementa ICombatant para definir acciones comunes de combate.
/// 
/// SRP: Esta clase solo maneja los comportamientos específicos de dwarfs
/// Expert: Dwarf es experto en su propia información (vida, armas)
/// </summary>
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
