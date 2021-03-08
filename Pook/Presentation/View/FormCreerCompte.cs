using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Presenter;

namespace Presentation.View
{
    public partial class FormCreerCompte : Form, IViewCreerCompte
    {
        public string LoginRentre
        {
            get { return txtBoxLogin.Text; }
            set { txtBoxLogin.Text = value; }
        }

        public string MdpRentre
        {
            get { return txtBoxMdp.Text; }
            set { txtBoxMdp.Text = value; }
        }

        public string NomImageRentre { get; set; }

        public PictureBox pictureBoxPdp
        {
            get { return picBoxPdp; }
            set { picBoxPdp = value; }
        }

        public bool IdentifiantsRentres
        {
            get
            {
                if (txtBoxLogin.Text != "" && txtBoxMdp.Text != "")
                {
                    return true;
                }
                else { return false; }
            }
            set { IdentifiantsRentres = value; }
        }

        public bool AppuyeSurValide { get; set; }

        public PresenterCreerCompte PresenterCreerCompte { get; set; }

        public FormCreerCompte()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (PresenterCreerCompte.CheminImage != null && LoginRentre != "" && MdpRentre !="")
            {
                AppuyeSurValide = true;
                PresenterCreerCompte.CheminImage = null;
                Close();
            }
            else
            {
                MessageBox.Show("Vous avez oublié de remplir un champ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            PresenterCreerCompte.ImporterImage();
        }
    }
}
