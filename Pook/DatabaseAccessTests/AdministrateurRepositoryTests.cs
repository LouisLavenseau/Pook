using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DatabaseAccess;
using Model;

namespace DatabaseAccessTests
{
    [TestClass]
    public class AdministrateurRepositoryTests
    {
        private AdministrateurRepository _administrateurRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _administrateurRepository = new AdministrateurRepository();
        }

        [TestMethod]
        public void TestAdministrateurRepo_GetAll()
        {
            var administrateurs = _administrateurRepository.GetAll();
            Assert.AreEqual(2, administrateurs.Count);
            var actual = administrateurs.Select(util => util.Login).ToList();
            var expected = new List<string> {"patrice" , "monika" };
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}
