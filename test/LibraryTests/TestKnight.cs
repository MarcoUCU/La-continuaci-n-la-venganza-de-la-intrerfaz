using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary
{
    public class TestKnight
    {
        private Knight Knight1;
        private Knight Knight2;

        [SetUp]
        public void Setup()
        {
            Knight1 = new Knight("Vale The Mega Knight");
            Knight2 = new Knight("Sir Galahad");
        }

        [Test]
        public void TestReceiveAttack()
        {
            Knight1.ReceiveAttack(55);
            Assert.That(Knight1.Health, Is.EqualTo(84));
        }

        [Test]
        public void TestGetHealed()
        {
            Knight1.ReceiveAttack(40);
            Knight1.GetHealed();
            Assert.That(Knight1.Health, Is.EqualTo(Knight1.InitialHealth));
        }

        [Test]
        public void TestHealOthers()
        {
            Knight1.ReceiveAttack(30);       
            Knight2.HealOthers(Knight1);    
            Assert.That(Knight1.Health, Is.EqualTo(Knight1.InitialHealth));
        }

        [Test]
        public void TestAttack()
        {
            Knight1.Attack(Knight2);
            Assert.That(Knight2.Health, Is.EqualTo(100));
        }
    }
}
