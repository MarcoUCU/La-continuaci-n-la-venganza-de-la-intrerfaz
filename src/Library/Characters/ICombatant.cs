namespace Ucu.Poo.RoleplayGame;
// Defines the basic contract for any character that can participate in combat.
// Every combatant has life points, can attack, defend, take damage, heal, and heal others.
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