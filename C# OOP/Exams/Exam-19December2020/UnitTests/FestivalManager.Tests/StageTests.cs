// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
	public class StageTests
    {
		private Stage stage;

		[SetUp]
	    public void Setup()
	    {
			stage = new Stage();
		}

        [Test]
        public void PerformensReturnsListAsReadOnlyCollection()
        {
            Assert.That(stage.Performers, Is.InstanceOf<IReadOnlyCollection<Performer>>());
        }

        [Test]
        public void AddPerformerMthodWorkProper()
        {
            Performer performer = new Performer("Diyan", "Apostolov", 37);

            stage.AddPerformer(performer);

            Assert.AreEqual(1, stage.Performers.Count);
        }

        [Test]
        public void AddPerformerThrowExeptionWhenPerformerIsNull()
        {
            Performer performer = null;

            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerThrowExeptionWhenPerformerAgeIsUnderEighteen()
        {
            Performer performer = new Performer("Diyan", "Apostolov", 17);

            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }


    }
}