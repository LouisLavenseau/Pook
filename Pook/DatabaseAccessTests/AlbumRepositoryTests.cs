using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DatabaseAccess;
using Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatabaseAccessTests
{
    [TestClass]
    public class AlbumRepositoryTests
    {
        AlbumRepository _albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _albumRepository = new AlbumRepository();
        }

        [TestMethod]
        public void TestAlbumRepo_GetAll()
        {
            var albums = _albumRepository.GetAll();
            Assert.AreEqual(4, albums.Count);
            var actual = albums.Select(util => util.Nom).ToList();
            var expected = new List<string> { "Tintin au Congo", "Candide", "Martine", "Seigneur Des Anneaux" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestAlbumRepo_GetMesAlbums()
        {
            var albums = _albumRepository.GetMesAlbums(1);
            Assert.AreEqual(2, albums.Count);
            //on passe par une liste qu'on remplit car le cast d'objet en album ne peut pas se faire à l'intérieur de la méthode "select"
            List<string> noms = new List<string> { };
            foreach (var album in albums)
            {
                Album albumParcouru = (Album)Convert.ChangeType(album, typeof(Album));
                noms.Add(albumParcouru.Nom);
            }
            var actual = noms.ToList();
            var expected = new List<string> { "Tintin au Congo", "Martine" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestAlbumRepo_Save()
        {
            var album = new Album(1,"Les Fourberies de Scapin", "lesFourberiesDeScapins.jpg", "879", "Voltaire","Piece de theatre","Comedie","Flammarion",true);
            _albumRepository.Save(album);

            TestRepository.ClearSession();
            // Recherche des albums portant le même titre
            var albums = _albumRepository.GetAll().Where(l => l.Nom ==
                "Les Fourberies de Scapin").ToList();
            // 1 seul livre correspondant dans le jeu de données de test
            Assert.AreEqual(1, albums.Count);
            Album nouvelAlbum = albums[0];
            Assert.AreEqual("Les Fourberies de Scapin", nouvelAlbum.Nom);
            Assert.AreEqual("lesFourberiesDeScapins.jpg", nouvelAlbum.ImageCouverture);
            Assert.AreEqual("Voltaire", nouvelAlbum.Auteurs);
            Assert.AreEqual("Comedie", nouvelAlbum.Genre);
            Assert.AreEqual("Piece de theatre", nouvelAlbum.Categorie);
            Assert.AreEqual("Flammarion", nouvelAlbum.Editeur);
            Assert.AreEqual(true, nouvelAlbum.CorrespondALaRecherche);
        }

        [TestMethod]
        public void TestAlbumRepo_SaveMesAlbums()
        {
            //var album = new Album(1, "Les Fourberies de Scapin", "lesFourberiesDeScapins.jpg", "879", "Voltaire", "Comedie", "Piece de theatre", "Flammarion", true);
            //var album = new Album(5, "Tintin au Congo", "tintinAuCongo.jpg", "12345678912", "Hergé", "Aventure", "BD", "Castermann", true);
            _albumRepository.SaveMesAlbums(1,2);

            TestRepository.ClearSession();
            // Recherche des albums portant le même titre
            var albums = _albumRepository.GetMesAlbums(1);
            List<Album> albumsBDD = new List<Album> { };

            //on passe par une liste qu'on remplit car le cast d'objet en album ne peut pas se faire à l'intérieur de la méthode "select"
            foreach (var album in albums)
            {
                Album albumParcouru = (Album)Convert.ChangeType(album, typeof(Album));
                if (albumParcouru.Nom == "Tintin au Congo")
                {
                    albumsBDD.Add(albumParcouru);
                }
                
            }
            // 1 seul album correspondant dans le jeu de données de test
            Assert.AreEqual(1, albumsBDD.Count);
            Album nouvelAlbum = albumsBDD[0];
            Assert.AreEqual("Tintin au Congo", nouvelAlbum.Nom);
            Assert.AreEqual("tintinAuCongo.jpg", nouvelAlbum.ImageCouverture);
            Assert.AreEqual("12345678912", nouvelAlbum.Serie);
            Assert.AreEqual("Hergé", nouvelAlbum.Auteurs);
            Assert.AreEqual("Aventure", nouvelAlbum.Genre);
            Assert.AreEqual("BD", nouvelAlbum.Categorie);
            Assert.AreEqual("Castermann", nouvelAlbum.Editeur);
            Assert.AreEqual(true, nouvelAlbum.CorrespondALaRecherche);
        }

        [TestMethod]
        public void TestAlbumRepo_GetMesSouhaits()
        {
            var albums = _albumRepository.GetMesSouhaits(1);
            Assert.AreEqual(2, albums.Count);
            //on passe par une liste qu'on remplit car le cast d'objet en album ne peut pas se faire à l'intérieur de la méthode "select"
            List<string> noms = new List<string> { };
            foreach (var album in albums)
            {
                Album albumParcouru = (Album)Convert.ChangeType(album, typeof(Album));
                noms.Add(albumParcouru.Nom);
            }
            var actual = noms.ToList();
            var expected = new List<string> { "Tintin au Congo", "Martine" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestAlbumRepo_SaveMesSouhaits()
        {
            _albumRepository.SaveMesSouhaits(1, 2);

            TestRepository.ClearSession();
            // Recherche des albums portant le même titre
            var albums = _albumRepository.GetMesSouhaits(2);
            List<Album> albumsBDD = new List<Album> { };

            //on passe par une liste qu'on remplit car le cast d'objet en album ne peut pas se faire à l'intérieur de la méthode "select"
            foreach (var album in albums)
            {
                Album albumParcouru = (Album)Convert.ChangeType(album, typeof(Album));
                if (albumParcouru.Nom == "Tintin au Congo")
                {
                    albumsBDD.Add(albumParcouru);
                }

            }
            // 1 seul album correspondant dans le jeu de données de test
            Assert.AreEqual(1, albumsBDD.Count);
            Album nouvelAlbum = albumsBDD[0];
            Assert.AreEqual("Tintin au Congo", nouvelAlbum.Nom);
            Assert.AreEqual("tintinAuCongo.jpg", nouvelAlbum.ImageCouverture);
            Assert.AreEqual("12345678912", nouvelAlbum.Serie);
            Assert.AreEqual("Hergé", nouvelAlbum.Auteurs);
            Assert.AreEqual("Aventure", nouvelAlbum.Genre);
            Assert.AreEqual("BD", nouvelAlbum.Categorie);
            Assert.AreEqual("Castermann", nouvelAlbum.Editeur);
            Assert.AreEqual(true, nouvelAlbum.CorrespondALaRecherche);
        }


        [TestMethod]
        public void TestAlbumRepo_SupprimerMesSouhaits()
        {
            _albumRepository.SupprimerMesSouhaits(1, 3);

            TestRepository.ClearSession();

            // Recherche des albums portant le même titre
            var albums = _albumRepository.GetMesSouhaits(1);
            List<Album> albumsBDD = new List<Album> { };

            //on passe par une liste qu'on remplit car le cast d'objet en album ne peut pas se faire à l'intérieur de la méthode "select"
            foreach (var album in albums)
            {
                Album albumParcouru = (Album)Convert.ChangeType(album, typeof(Album));
                if (albumParcouru.Nom == "Martine")
                {
                    albumsBDD.Add(albumParcouru);
                }

            }
            // 0 album correspondant dans le jeu de données de test
            Assert.AreEqual(0, albumsBDD.Count);
        }


    }
}
