using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public interface IAlbumRepository
    {
        IList <Album> GetAll();

        IList<Object> GetMesAlbums(int idUtilisateur);

        IList<Object> GetMesSouhaits(int idUtilisateur);
        
        void SaveMesAlbums(int idUtilisateur, int idAlbum);

        void SupprimerMesSouhaits(int idUtilisateur, int idAlbum);
        
        void SaveMesSouhaits(int idUtilisateur, int idAlbum);

        void Save(Album album);
    }
}
