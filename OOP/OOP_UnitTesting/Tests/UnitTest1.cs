namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_AxeDurabilityAfterAtack()
        {
            Axe axe = new(10, 10);
            Dummy dummy = new(10, 10);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");

        }

        [Test]
        public void Test_AxeAttackBroken()
        {
            Axe axe = new(10, 0);
            Dummy dummy = new(10, 10);

            bool cantHappen = false;
            try
            {
                axe.Attack(dummy);
            }
            catch (Exception)
            {
                cantHappen = true;
            }

            Assert.IsTrue(cantHappen);
        }

        [Test]
        public void Test_DummyLoosesHealthWhenAttacacked()
        {
            Axe axe = new(1, 10);
            Dummy dummy = new(10, 10);

            axe.Attack(dummy);

            Assert.That(dummy.Health , Is.EqualTo(9), "Dummy does not take dammage");
        }

        [Test]
        public void Test_DummyThrowsExeptionWhenDeadAndAttacked()
        {
            Axe axe = new(1, 10);
            Dummy dummy = new(0, 10);

            bool catchesExeption = false;
            try
            {
                axe.Attack(dummy);
            }
            catch (Exception)
            {
                catchesExeption = true;
            }

            Assert.IsTrue(catchesExeption);
        }

        [Test]
        public void Test_DummyCanGiveXpWhenDead()
        {
            Dummy dummy = new(0, 10);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(10), "Dummy does not give experience");
        }
    }
}