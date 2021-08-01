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

        public void DictionaryCountIsTwelve()
        { 
            
        }

        //[Test]
        //public void VaultCellsReturnsDictionaryAsReadOnlyCollection()
        //{
        //    Assert.That(bankVault.VaultCells, Is.InstanceOf<IReadOnlyCollection<string, Item>>());
        //}
    }
}