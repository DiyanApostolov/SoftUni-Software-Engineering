using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bankVault;

        [SetUp]
        public void Setup()
        {
            bankVault = new BankVault();
        }

        [Test]
        public void CtorInitializesCollectionOfItems()
        {
            Assert.That(bankVault.VaultCells, Is.Not.Null);
        }

        [Test]
        public void DictionaryCountIsTwelve()
        {
            Assert.AreEqual(bankVault.VaultCells.Count, 12);
        }

        [Test]
        public void ThrowExeptionWhenCellDoesntExist()
        {
            Item item = new Item("Pesho", "1");

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A8", item));
        }

        [Test]
        public void ThrowExeptionWhenCellIsAlreadyTaken()
        {
            Item itemOne = new Item("Pesho", "1");
            Item itemTwo = new Item("Gosho", "2");
           
            bankVault.AddItem("A1", itemOne);

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A1", itemTwo));
        }

        [Test]
        public void ThrowExeptionWhenItemAlreadyExist()
        {
            Item item = new Item("Pesho", "1");

            bankVault.AddItem("A1", item);

            Item newItem = new Item("Gosho", "1");

            Assert.Throws<InvalidOperationException>(() => bankVault.AddItem("A2", newItem));
        }

        [Test]
        public void AddItemAddsItemToTheVault()
        {
            Item item = new Item("Ivo", "1");

            bankVault.AddItem("A1", item);

            Assert.That(item, Is.EqualTo(bankVault.VaultCells["A1"]));
        }

        [Test]
        public void AddItemMethodReturnProperValue()
        {
            Item item = new Item("Pesho", "1");

            Assert.AreEqual(bankVault.AddItem("A1", item), "Item:1 saved successfully!");
        }

        [Test]
        public void ThrowExeptionWheTryToRemoveInvalidCell()
        {
            Item item = new Item("Pesho", "1");

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A8", item));
        }

        [Test]
        public void ThrowExeptionWheItemToRemoveDoesntExist()
        {
            Item item = new Item("Pesho", "1");

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A1", item));
        }

        [Test]
        public void RemoveMethodRemovesItem()
        {
            Item item = new Item("Ivo", "1");

            bankVault.AddItem("A1", item);

            bankVault.RemoveItem("A1", item);

            Assert.That(bankVault.VaultCells["A1"], Is.Null);
        }

        [Test]
        public void RemoveItemMethodReturnProperValue()
        {
            Item item = new Item("Pesho", "1");
            bankVault.AddItem("A1", item);

            Assert.AreEqual(bankVault.RemoveItem("A1", item), "Remove item:1 successfully!");
        }
    }
}