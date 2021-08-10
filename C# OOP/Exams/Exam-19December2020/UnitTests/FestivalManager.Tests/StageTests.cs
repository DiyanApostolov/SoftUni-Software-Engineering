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
        public void AddPerformerMethodWorkProper()
        {
            Performer performer = new Performer("Diyan", "Apostolov", 37);

            stage.AddPerformer(performer);

            Assert.AreEqual(1, stage.Performers.Count);
        }

        [Test]
        public void AddPerformerMethodThrowExeptionWhenPerformerIsNull()
        {
            Performer performer = null;

            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerMethodThrowExeptionWhenPerformerAgeIsUnderEighteen()
        {
            Performer performer = new Performer("Diyan", "Apostolov", 17);

            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddSongMethodWorkProper()
        {
            Song song = new Song("One", new TimeSpan(0, 6, 45));
            Performer performer = new Performer("Diyan", "Apostolov", 37);
            stage.AddPerformer(performer);
            stage.AddSong(song);

            string expected = "One (06:45) will be performed by Diyan Apostolov";

            string actual = stage.AddSongToPerformer("One", "Diyan Apostolov");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddSongMethodThrowExeptionWhenSongIsNull()
        {
            Song song = null;

            Assert.Throws<ArgumentNullException>(() => stage.AddSong(song));
        }

        [Test]
        public void AddSongMethodThrowExeptionWhenSongDurationIsUnderOneMinute()
        {
            Song song = new Song("One", new TimeSpan(0, 0, 45));

            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }

        [Test]
        public void AddSongToPerformerMethodWorkProper()
        {
            Song song = new Song("One", new TimeSpan(0, 6, 45));
            Performer performer = new Performer("Diyan", "Apostolov", 37);

            performer.SongList.Add(song);

            Assert.AreEqual(1, performer.SongList.Count);
        }

        [Test]
        public void PlayMethodTerurnProperValue()
        {
            Song song = new Song("One", new TimeSpan(0, 6, 45));
            Performer performer = new Performer("Diyan", "Apostolov", 37);
            stage.AddPerformer(performer);
            stage.AddSong(song);
            stage.AddSongToPerformer("One", "Diyan Apostolov");

            string expected = "1 performers played 1 songs";

            string actual = stage.Play();

            Assert.AreEqual(expected, actual);
        }
    }
}