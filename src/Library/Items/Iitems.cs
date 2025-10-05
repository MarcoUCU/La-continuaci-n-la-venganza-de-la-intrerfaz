namespace Ucu.Poo.RoleplayGame;
/// <summary>
/// Representa un item que un personaje puede usar en combate
/// un ítem puede proporcionar ataque, defensa o curación al personaje.
/// </summary>
public interface Iitems
{
    string Name { get; }
    int DefenseValue { get; }
    int AttackValue { get;  }
    int HealingValue { get; }
}
