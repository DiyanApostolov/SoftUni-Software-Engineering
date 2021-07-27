namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Bag bag;

        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
        }

        [Test]
        public void CtorInitializesCollectionOfPresents()
        {
            Assert.That(bag, Is.Not.Null);
        }

        [Test]
        public void ThrowExeptionWhenPresentIsNull()
        {
            Present nullPresent = null;

            Assert.Throws<ArgumentNullException>(() => bag.Create(nullPresent));
        }

        [Test]
        public void ThrowExeptionWhenPresentAlreadyExist()
        {
            Present present = new Present("Truck", 25.5);

            bag.Create(present);

            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void AddPresentToTheBag()
        {
            Present present = new Present("Truck", 25.5);

            bag.Create(present);

            Assert.That(present, Is.EqualTo(bag.GetPresent(present.Name)));
        }

        [Test]
        public void ReturnProperMessage()
        {
            Present present = new Present("Truck", 25.5);

            string expectedMsg = $"Successfully added present {present.Name}.";

            string actual = bag.Create(present);

            Assert.That(expectedMsg, Is.EqualTo(actual));
        }

        [Test]
        public void RemovePresentFromTheBag()
        {
            Present present = new Present("Truck", 25.5);

            bag.Create(present);
            bag.Remove(present);

            Assert.That(bag.GetPresent(present.Name), Is.Null);
        }

        [Test]
        public void RemoveReturnsBoolean()
        {
            Present present = new Present("Truck", 25.5);

            Assert.IsFalse(bag.Remove(present));

            bag.Create(present);

            Assert.IsTrue(bag.Remove(present));
        }

        [Test]
        public void GetPresentWithLeastMagicWorks()
        {
            Present presentOne = new Present("Truck", 25);
            Present presentTwo = new Present("Duck", 30);
            Present presentThree = new Present("Stick", 10);

            bag.Create(presentOne);
            bag.Create(presentTwo);
            bag.Create(presentThree);

            Assert.That(presentThree, Is.EqualTo(bag.GetPresentWithLeastMagic()));
        }

        [Test]
        public void GetPresentReturnPresent()
        {
            Present present = new Present("Truck", 25.5);

            bag.Create(present);

            Assert.AreEqual(present, bag.GetPresent(present.Name));
        }

        [Test]
        public void GetPresentsReturnsBagAsReadOnlyCollection()
        {
            Assert.That(bag.GetPresents(), Is.InstanceOf<IReadOnlyCollection<Present>>());
        }
    }
}
