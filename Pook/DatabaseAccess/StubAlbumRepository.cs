using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public class StubAlbumRepository : Repository, IAlbumRepository

    {
        List<Album> _album;

        public StubAlbumRepository()
        {
            _album.Add(new Album(0, "Le rouge et le Noir", "image 1", "roman", "Stendhal", "français", "roman", "Flammarion",true));

        }
        public IList<Album> GetAll()
        {
            return _album;
        }

        public IList<Object> GetMesAlbums(int idUtilisateur)
        {
            return new List<Object> {};
        }
        public IList<Object> GetMesSouhaits(int idUtilisateur)
        {
            return new List<Object> { };
        }
        public void Save(Album album)
        {
            ;
        }

        public void SaveMesAlbums(int idUtilisateur, int idAlbum)
        { }
        public void SaveMesSouhaits(int idUtilisateur, int idAlbum)
        { }

        public void SupprimerMesSouhaits(int idUtilisateur, int idAlbum)
        { }
    }
}
