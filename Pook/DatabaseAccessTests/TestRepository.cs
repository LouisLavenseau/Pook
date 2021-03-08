using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseAccess;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DatabaseAccessTests
{
    class TestRepository : Repository
    {
        internal static void ResetSchema()
        {
            //suppression manuelle des tables car sinon l'exécution du SchemaExport dit que la table "album" existe déjà
            Execute("drop table mesalbums;" + "drop table messouhaits;" + "drop table album;" + "drop table utilisateur;" +
            "drop table administrateur");
            DatabaseAccess.Repository.Session.Clear();

            new SchemaExport(Configuration).Execute(false, true, false);
        }

        internal static void ClearSession()
        {
            Session.Clear();
        }

        internal static void Execute(string sql)
        {
            ISQLQuery query = Session.CreateSQLQuery(sql);
            query.ExecuteUpdate();
        }

        /// <summary>
        /// Load database with test data
        /// </summary>
        public static void InitDB()
        {
            ResetSchema();

            Execute(
                "insert into utilisateur values (1, 'louloulala', 'mdp','Lavenseau_Louis.jpg');" +
                "insert into utilisateur values (2, 'cloclobribri', 'mdp','Brissaud_Cloe.jpg');" +
                "insert into utilisateur values (3, 'gege', 'mdp','chimpanze.jpg')"
                );

            Execute(
                "insert into album values (1,'Tintin au Congo','tintinAuCongo.jpg','12345678912','Hergé','BD','Aventure','Castermann',TRUE);" +
                "insert into album values (2, 'Candide', 'candide.jpg', '123456789112', 'Voltaire', 'Classique', 'Roman', 'Cramer', TRUE);" +
                "insert into album values (3, 'Martine', 'martineAuPaysDesContes.jpg', '121110987654321', 'Marcel Marlier, Gilbert Delahaye', 'Livre pour enfant', 'Album', 'Casterman', TRUE);" +
                "insert into album values (4, 'Seigneur Des Anneaux', 'leSeigneurDesAnneauxLaCommunauteDeLanneau.jpg', '123', 'J.R.R Tolkien', 'Heroic Fantasy', 'Album', 'editeur', TRUE)"
                );

            Execute(
                "insert into administrateur values (1, 'patrice', 'mdp');" +
                "insert into administrateur values (2, 'monika', 'mdp')"
                );

            Execute(
                "insert into mesAlbums values (1, 1);" +
                "insert into mesAlbums values (3, 1);" +
                "insert into mesAlbums values (2, 2)"
                );
            Execute(
                "insert into mesSouhaits values (1, 1);" +
                "insert into mesSouhaits values (3, 1);" +
                "insert into mesSouhaits values (2, 2)"
                );
        }
    }
}
