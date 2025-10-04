namespace Ucu.Poo.RoleplayGame;

public interface ICombatant
{
 int Health { get; set; }
    int AttackValue { get;  }
    int DefenseValue { get; }
    void ReceiveAttack(int damage);
    void Attack(ICombatant target);
    void HealOthers(ICombatant target);
    void GetHealed();
}