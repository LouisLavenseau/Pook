using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public IList<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public IList<Object> GetMesAlbums(int idUtilisateur)
        {
            return (List<Object>)Session.CreateQuery("select a from Album a join a.Possesseurs p where p.Id=:idUtilisateur").SetInt32("idUtilisateur", idUtilisateur).List();
        }

        public IList<Object> GetMesSouhaits(int idUtilisateur)
        {
            return (List<Object>)Session.CreateQuery("select a from Album a join a.PotentielsPossesseurs p where p.Id=:idUtilisateur").SetInt32("idUtilisateur", idUtilisateur).List();
        }

        public void SaveMesSouhaits(int idUtilisateur, int idAlbum)
        {
            // and album_id=:idAlbum2  where not exists (select utilisateur_id from messouhaits where utilisateur_id=:idUtilisateur2
            //*SetParameter("idUtilisateur2",idUtilisateur).SetParameter("idAlbum2",idAlbum).*/
            string requete = "insert into messouhaits values (:idUtilisateur,:idAlbum)"; 
            Session.CreateSQLQuery(requete).SetParameter("idUtilisateur", idUtilisateur).SetParameter("idAlbum", idAlbum).ExecuteUpdate();
        }
        
        public void SaveMesAlbums(int idUtilisateur, int idAlbum)
        {
            string requete = "insert into mesalbums values (:idUtilisateur,:idAlbum)";
            Session.CreateSQLQuery(requete).SetParameter("idUtilisateur", idUtilisateur).SetParameter("idAlbum", idAlbum).ExecuteUpdate();
        }

        public void SupprimerMesSouhaits(int idUtilisateur, int idAlbum)
        {
            string requete = "delete from messouhaits where utilisateur_id=:idUtilisateur and album_id=:idAlbum limit 1";
            Session.CreateSQLQuery(requete).SetParameter("idUtilisateur", idUtilisateur).SetParameter("idAlbum", idAlbum).ExecuteUpdate();

           
        }

        public void Save(Album album)
        {
            Session.Save(album);
            Session.Flush();
        }



    }
}
