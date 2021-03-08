using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DatabaseAccess;
using Model;

namespace DatabaseAccessTests
{
    [TestClass]
    public class UtilisateurRepositoryTests
    {
        private UtilisateurRepository _utilisateurRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _utilisateurRepository = new UtilisateurRepository();
        }

        [TestMethod]
        public void TestUtilRepo_GetAll()
        {
            var utilisateurs = _utilisateurRepository.GetAll();
            Assert.AreEqual(3, utilisateurs.Count);
            var actual = utilisateurs.Select(util => util.Login).ToList();
            var expected = new List<string> { "louloulala", "cloclobribri", "gege" };
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}
