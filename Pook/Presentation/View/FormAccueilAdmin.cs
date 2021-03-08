using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccess;
using Model;
using Presentation.Presenter;
using Presentation.View;

namespace Presentation.View
{
    public partial class FormAccueilAdmin : Form, IViewAccueilAdmin
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public PresenterAccueilAdmin PresenterAccueilAdmin { get; set; }
        public DataGridView DGVAlbumsDuMarche
        {
            get { return dgvAccueilAdmin; }
            set { dgvAccueilAdmin = value; }
        }

        public FormAccueilAdmin(string login, int id)
        {
            InitializeComponent();

            //remplit la dataGridView
            IAlbumRepository _albumRepository = PresenterConnexion._albumRepository;
            dgvAccueilAdmin.Rows.Clear();
            foreach (Album album in _albumRepository.GetAll())
            {
                dgvAccueilAdmin.Rows.Add(album.Decrire());
            }
        }

        private void btnAjouterUnAlbumAccueilAdmin_Click(object sender, EventArgs e)
        {
            PresenterAccueilAdmin.AjouterUnAlbum();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        }
    
}
