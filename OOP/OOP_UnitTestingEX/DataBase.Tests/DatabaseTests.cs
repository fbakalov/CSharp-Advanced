namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database _database;

        [SetUp]
        public void SetUp()
        {
            _database = new Database();
        }

        [TearDown]
        public void TearDown() 
        {
            _database = null;
        }

        [Test]
        public void Test_AddMethod()
        {
            _database.Add(5);
            int[] result = _database.Fetch();

            Assert.AreEqual(1, _database.Count);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(1, result.Length);
        }

        [Test]
        public void Test_ShouldAddMethodThrowIfMoreThenMaxLength()
        {
            _database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            InvalidOperationException ex = Assert
                .Throws<InvalidOperationException>(() => _database.Add(5));

            Assert.That(ex.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void Test_CreateDatabaseWith10Elements()
        {
            _database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Assert.That(_database.Count, Is.EqualTo(10));
        }

        [Test]
        public void Test_ShouldRemoveMethodThrowIfEmpty()
        {
            InvalidOperationException ex = Assert
                .Throws<InvalidOperationException>(() => _database.Remove());

            Assert.That(ex.Message, Is.EqualTo("The collection is empty!"));
        }

        [Test]
        public void Test_RemoveMethod()
        {
            _database = new Database(5, 12);

            _database.Remove();

            int[] result = _database.Fetch();

            Assert.That(_database.Count, Is.EqualTo(1));
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.That(result[0],Is.EqualTo(5));
        }

        [Test]
        public void Test_FetchMethod()
        {
            _database= new Database(1, 2, 3);

            int[] result = _database.Fetch();

            Assert.That(new int[] { 1, 2, 3 }, Is.EqualTo(result));
        }
    }
}
