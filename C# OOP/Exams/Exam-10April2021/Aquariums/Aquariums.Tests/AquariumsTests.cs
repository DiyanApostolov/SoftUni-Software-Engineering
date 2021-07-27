namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class AquariumsTests
    {
        private Aquarium aquarium;

        [SetUp]
        public void Setup()
        {
            aquarium = new Aquarium("fishTank", 10);
        }

        [Test]
        public void NameGetterReturnsName()
        {
            Assert.AreEqual("fishTank", aquarium.Name);
        }

        [Test]
        public void CapacityGetterReturnsCapacity()
        {
            Assert.AreEqual(10, aquarium.Capacity);
        }

        [Test]
        public void CtorInitializesAquarium()
        {
            Assert.That(aquarium, Is.Not.Null);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ThrowExeptionWhenAquariumNameIsInvalid(string name)
        {
            Aquarium invalidNameAquarium;

            Assert.Throws<ArgumentNullException>(() => invalidNameAquarium = new Aquarium(name, 20));
        }

        [Test]
        public void ThrowExeptionWhenAquariumCapacityIsInvalid()
        {
            Aquarium invalidCapacityAquarium;

            Assert.Throws<ArgumentException>(() => invalidCapacityAquarium = new Aquarium("FishTank", -5));
        }

        [Test]
        public void AddFishToAquarium()
        {
            Fish fish = new Fish("Nemo");
            aquarium.Add(fish);

            Assert.AreEqual(aquarium.SellFish("Nemo"), fish);
        }

        [Test]
        public void AddMethodThrowsAnExceptionWhenCapacityIsExceeded()
        {
            for (int i = 0; i < 10; i++)
            {
                aquarium.Add(new Fish($"{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("Nemo")));
        }

        [Test]
        public void ReturnProperFishCount()
        {
            Fish firstFish = new Fish("Nemo");
            Fish secondFish = new Fish("Pesho");
            aquarium.Add(firstFish);
            aquarium.Add(secondFish);

            Assert.AreEqual(aquarium.Count, 2);
        }

        [Test]
        public void RemoveFishFromAquarium()
        {
            Fish fish = new Fish("Nemo");
            aquarium.Add(fish);
            aquarium.RemoveFish("Nemo");

            Assert.AreEqual(aquarium.Count, 0);
        }

        [Test]
        public void ThrowExeptionWhenRemoveInvalidFish()
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Nemo"));
        }

        [Test]
        public void SellFishFromAquarium()
        {
            Fish fish = new Fish("Nemo");
            aquarium.Add(fish);

            Assert.AreEqual(fish, aquarium.SellFish("Nemo"));
        }

        [Test]
        public void CheckFishAvailabilityAfterSell()
        {
            Fish fish = new Fish("Nemo");
            aquarium.Add(fish);
            aquarium.SellFish("Nemo");

            Assert.That(fish.Available, Is.False);
        }

        [Test]
        public void ReportMethodWorks()
        {
            List<string> fishList = new List<string>() { "Nemo", "Pesho", "Gosho" };

            foreach (string fish in fishList)
            {
                aquarium.Add(new Fish(fish));
            }

            string expected = $"Fish available at {aquarium.Name}: {string.Join(", ", fishList)}";

            string actual = aquarium.Report();

            Assert.AreEqual(expected, actual);
        }
    }
}
