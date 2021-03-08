using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace ModelTests
{
    /// <summary>
    /// Summary description for AlbumTests
    /// </summary>
    [TestClass]
    public class AlbumTests
    {
        private Album _album;
        private int _id = 1;
        private string _nom = "Kirikou et la Sorcière";
        private string _imageCouverture = "kirikou_et_la_sorciere.jpg";
        private string _serie = "123456789";
        private string _auteurs = "Michel Ocelot";
        private string _categorie = "BD";
        private string _genre = "Aventure";
        private string _editeur = "Milan";
        private bool _correspondALaRecherche = true;

        [TestInitialize()]
        public void Initialize()
        {
            _album = new Album(_id, _nom, _imageCouverture, _serie, _auteurs, _categorie, _genre, _editeur, _correspondALaRecherche);
        }

        [TestMethod]
        public void TestAlbum_Decrire()
        {
            string[] expected = { _nom, _id.ToString(), _serie, _auteurs, _categorie, _genre, _editeur };
            CollectionAssert.AreEquivalent(expected, _album.Decrire());
        }
    }
}
