namespace Robots.Tests
{
    using System;
    using NUnit.Framework;

    public class RobotsTests
    {
        private RobotManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new RobotManager(10);
        }

        [Test]
        public void CapacityGetterReturnsCapacity()
        {
            Assert.AreEqual(10, manager.Capacity);
        }

        [Test]
        public void CtorInitializesRobootManager()
        {
            Assert.That(manager, Is.Not.Null);
        }

        [Test]
        public void ThrowExeptionWhenCapacityIsBelowZero()
        {
            RobotManager invalidManager;

            Assert.Throws<ArgumentException>(() => invalidManager = new RobotManager(-5));
        }

        [Test]
        public void AddRobotWorkProper()
        {
            Robot robot = new Robot("R2-D2", 20);
            manager.Add(robot);

            Assert.AreEqual(1, manager.Count);

            Robot secondRobot = new Robot("C3-PO", 25);
            manager.Add(secondRobot);

            Assert.AreEqual(2, manager.Count);
        }


        [Test]
        public void ReturnProperRobotsCount()
        {
            Robot firstRobot = new Robot("R2-D2", 20);
            Robot secondRobot = new Robot("C3-PO", 25);

            manager.Add(firstRobot);
            manager.Add(secondRobot);

            Assert.AreEqual(2, manager.Count);
        }

        [Test]
        public void AddMethodThrowExeptionWhenRobotAlreadyExist()
        {
            Robot robot = new Robot("R2-D2", 20);
            manager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => manager.Add(robot));
        }

        [Test]
        public void AddMethodThrowsAnExceptionWhenCapacityIsExceeded()
        {
            for (int i = 0; i < 10; i++)
            {
                manager.Add(new Robot($"{i}", i));
            }

            Assert.Throws<InvalidOperationException>(() => manager.Add(new Robot("R2-D2", 20)));
        }

        [Test]
        public void RemoveRobotFromRobotManager()
        {
            Robot firstRobot = new Robot("R2-D2", 20);
            Robot secondRobot = new Robot("C3-PO", 25);

            manager.Add(firstRobot);
            manager.Add(secondRobot);
            manager.Remove(firstRobot.Name);

            Assert.AreEqual(manager.Count, 1);
        }

        [Test]
        public void ThrowExeptionWhenRemoveInvalidRobot()
        {
            Assert.Throws<InvalidOperationException>(() => manager.Remove("Chubaka"));
        }

        [Test]
        public void WorkMethodThrowExeptionWhenRobotDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => manager.Work("C3-PO", "Kill R2-D2", 10));
        }

        [Test]
        public void WorkMethodThrowExeptionWhenRobotDoesntHaveEnoughBattery()
        {
            Robot robot = new Robot("C3-PO", 25);
            manager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => manager.Work("C3-PO", "Kill R2-D2", 30));
        }

        [Test]
        public void WorkMethodWorks()
        {
            Robot robot = new Robot("C3-PO", 25);
            manager.Add(robot);
            manager.Work("C3-PO", "Kill R2-D2", 15);

            Assert.AreEqual(10, robot.Battery);
        }

        [Test]
        public void ChargeMethodThrowExeptionWhenRobotDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => manager.Charge("C3-PO"));
        }

        [Test]
        public void ChargeMethodWorks()
        {
            Robot robot = new Robot("C3-PO", 25);
            manager.Add(robot);
            manager.Work("C3-PO", "Kill R2-D2", 15);
            manager.Charge("C3-PO");

            Assert.AreEqual(25, robot.Battery);
        }
    }
}
