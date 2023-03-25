namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
        }
        [TearDown] 
        public void TearDown() 
        {
            arena = null;
        }

        [Test]
        public void Test_ArenaShoudBeVoidOnCreate()
        {
            arena = new Arena();

            Assert.AreEqual(0, arena.Count);
        }
        [Test]
        public void Test_Enroll()
        {
            Warrior sisi = new("Sisi", 100, 200);
            Warrior bolest = new("bolest", 10, 40);

            List<Warrior> list = new()
            {
                sisi,
                bolest
            };

            arena.Enroll(sisi);
            arena.Enroll(bolest);

            Assert.That(arena.Count, Is.EqualTo(2));
            Assert.That(arena.Warriors,Is.EqualTo(list));
        }
        [Test]
        public void Test_EnrollThrowIfEnroled()
        {
            Warrior sisi = new("Sisi", 100, 200);
            arena.Enroll (sisi);

            InvalidOperationException ex = Assert
                .Throws<InvalidOperationException>(() => arena.Enroll(sisi));

            Assert.That(ex.Message, Is.EqualTo("Warrior is already enrolled for the fights!"));
        }
        [Test]
        public void Test_FightLogic()
        {
            Warrior sisi = new("Sisi", 100, 200);
            Warrior bolest = new("bolest", 10, 40);

            arena.Enroll(sisi);
            arena.Enroll(bolest);

            arena.Fight("Sisi", "bolest");

            Assert.That(sisi.HP, Is.EqualTo(190));
            Assert.That(bolest.HP, Is.EqualTo(0));
        }
        [Test]
        public void Test_FightShouldThrowIfDefenderIsMissing()
        {
            arena.Enroll(new Warrior("Pesho", 5, 12));

            InvalidOperationException exeption = Assert
                .Throws<InvalidOperationException>(() => arena.Fight("Pesho", "Gosho"));
            Assert.That(exeption.Message, Is.EqualTo("There is no fighter with name Gosho enrolled for the fights!"));
        }

        [Test]
        public void Test_FightShouldThrowIfAttackerIsMissing()
        {
            arena.Enroll(new Warrior("Pesho", 5, 12));

            InvalidOperationException exeption = Assert
                .Throws<InvalidOperationException>(() => arena.Fight("Misho", "Pesho"));
            Assert.That(exeption.Message, Is.EqualTo("There is no fighter with name Misho enrolled for the fights!"));
        }
    }
}
