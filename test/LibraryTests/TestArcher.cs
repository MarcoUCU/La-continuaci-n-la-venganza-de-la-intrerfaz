using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary;

public class TestArcher
{
    private Archer Archer1;
    private Archer Archer2;

    [SetUp]
    public void Setup()
    {
        Archer1 = new Archer("Fede The Magic Archer");
        Archer2 = new Archer("Marco The Mystical Archer");
    }

    [Test]
    public void TestReceiveAttack()
    {
        Archer1.ReceiveAttack(55);
        Assert.That(Archer1.Health, Is.EqualTo(45));
    }
    [Test]
    public void TestGetHealed()
    {
        Archer1.ReceiveAttack(40);
        Archer1.GetHealed();
        Assert.That(Archer1.Health, Is.EqualTo(Archer1.InitialHealth));
    }
    [Test]
    public void TestHealOthers()
    {
        Archer1.ReceiveAttack(30);       
        Archer2.HealOthers(Archer1);    
        Assert.That(Archer1.Health, Is.EqualTo(Archer1.InitialHealth));
    }

    [Test]
    public void TestAttack()
    {
        Archer1.Attack(Archer2);
        Assert.That(Archer2.Health, Is.EqualTo(Archer2.InitialHealth-Archer1.AttackValue));
    }
}
