using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary
{
    public class TestWizard
    {
        private Wizard Wizard1;
        private Wizard Wizard2;

        [SetUp]
        public void Setup()
        {
            Wizard1 = new Wizard("Mark The Fire Wizard");
            Wizard2 = new Wizard("Gandalf");
        }

        [Test]
        public void TestReceiveAttack()
        {
            Wizard1.ReceiveAttack(55);
            Assert.That(Wizard1.Health, Is.EqualTo(45));
        }

        [Test]
        public void TestGetHealed()
        {
            Wizard1.ReceiveAttack(40);
            Wizard1.GetHealed();
            Assert.That(Wizard1.Health, Is.EqualTo(Wizard1.InitialHealth));
        }

        [Test]
        public void TestHealOthers()
        {
            Wizard1.ReceiveAttack(30);
            Wizard2.HealOthers(Wizard1);
            Assert.That(Wizard1.Health, Is.EqualTo(Wizard1.InitialHealth));
        }

        [Test]
        public void TestAttack()
        {
            Wizard1.Attack(Wizard2);
            Assert.That(Wizard2.Health, Is.EqualTo(Wizard2.InitialHealth - Wizard1.AttackValue));
        }
    }
}
