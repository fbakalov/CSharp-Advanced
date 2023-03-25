namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System.Threading;
    using System.Xml.Linq;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;
        private Warrior bolest;
        private const int MIN_ATTACK_HP = 30;

        [SetUp]
        public void SetUp() 
        {
            warrior = new("Sisi", 100, 50);
            bolest = new("Bolest", 10, 140);
        }
        [TearDown] public void TearDown() 
        {
            warrior = null;
            bolest = null;
        }

        [Test]
        public void Test_WarriorCreate()
        {
            warrior = new("Sisi", 100, 50);

            Assert.That(warrior.Name, Is.EqualTo("Sisi"));
            Assert.That(warrior.Damage, Is.EqualTo(100));
            Assert.That(warrior.HP, Is.EqualTo(50));
        }
        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        public void Test_WarriorThrowIfNameIsNullOrWitheSpace(string name) 
        {
            ArgumentException ex = Assert
                .Throws<ArgumentException>(() => new Warrior(name, 100, 50));

            Assert.That(ex.Message, Is.EqualTo("Name should not be empty or whitespace!"));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-3)]
        public void Test_WarriorThrowIfDamageIsZeroOrNegative(int dmg) 
        {
            ArgumentException ex = Assert
                .Throws<ArgumentException>(() => new Warrior("Sisi", dmg, 50));

            Assert.That(ex.Message, Is.EqualTo("Damage value should be positive!"));
        }
        [Test]
        [TestCase(-3)]
        public void Test_WarriorThrowIfHPIsNegative(int hp)
        {
            ArgumentException ex = Assert
                .Throws<ArgumentException>(() => new Warrior("Sisi", 100, hp));

            Assert.That(ex.Message, Is.EqualTo("HP should not be negative!"));
        }
        [Test]
        public void Test_AttackLogic()
        {
            warrior.Attack(bolest);

            Assert.That(bolest.HP, Is.EqualTo(40));
            Assert.That(warrior.HP, Is.EqualTo(40));
        }
        [Test]
        public void Test_AttackIfItCanKill()
        {
            Warrior bolest = new("bolest", 10, 40);
            warrior.Attack(bolest);

            Assert.That(bolest.HP, Is.EqualTo(0));
        }
        [Test]
        [TestCase(30)]
        [TestCase(10)]
        public void Test_AttackThrowIfHPTooLow(int hp)
        {
            InvalidOperationException ex = Assert
                .Throws<InvalidOperationException>(() => new Warrior("Sisi", 100, hp).Attack(bolest));

            Assert.That(ex.Message, Is.EqualTo("Your HP is too low in order to attack other warriors!"));
        }
        [Test]
        [TestCase(30)]
        [TestCase(10)]
        public void Test_AttackThrowIfEnemyHPTooLow(int hp)
        {
            InvalidOperationException ex = Assert
                .Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("bolest", 10, hp)));

            Assert.That(ex.Message, Is.EqualTo($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!"));
        }
        [Test]
        public void Test_AttackThrowsIfAttackingStronger()
        {
            InvalidOperationException ex = Assert
                .Throws<InvalidOperationException>(() => new Warrior("bolest", 100, 40).Attack(warrior));

            Assert.That(ex.Message, Is.EqualTo($"You are trying to attack too strong enemy"));
        }
    }
}