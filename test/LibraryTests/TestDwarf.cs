using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary;

public class TestDwarf
{
    private Dwarf Dwarf1;
    private Dwarf Dwarf2;

    [SetUp]
    public void Setup()
    {
        Dwarf1 = new Dwarf("Fede The Tiniest Dwarf");
        Dwarf2 = new Dwarf("Napoleon Bonaparte");
    }

    [Test]
    public void TestReceiveAttack()
    {
        Dwarf1.ReceiveAttack(55);
        Assert.That(Dwarf1.Health, Is.EqualTo(45));
    }
    [Test]
    public void TestGetHealed()
    {
        Dwarf1.ReceiveAttack(40);
        Dwarf1.GetHealed();
        Assert.That(Dwarf1.Health, Is.EqualTo(Dwarf1.InitialHealth));
    }
    [Test]
    public void TestHealOthers()
    {
        Dwarf1.ReceiveAttack(30);       
        Dwarf2.HealOthers(Dwarf1);    
        Assert.That(Dwarf1.Health, Is.EqualTo(Dwarf1.InitialHealth));
    }

    [Test]
    public void TestAttack()
    {
        Dwarf1.Attack(Dwarf2);
        Assert.That(Dwarf2.Health, Is.EqualTo(Dwarf2.InitialHealth-Dwarf1.AttackValue));
    }
}
