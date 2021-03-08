using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.View;
using System.IO;
using System.Drawing;
using DatabaseAccess;
using Model;
using System.Windows.Forms;

namespace Presentation.Presenter
{
    public class PresenterCreerCompte
    {
        IViewCreerCompte _viewCreerCompte;

        public OpenFileDialog Dialog { get; set; }
        public string CheminImage { get; set; }

        public PresenterCreerCompte (IViewCreerCompte viewCreerCompte)
        {
            _viewCreerCompte = viewCreerCompte;
            viewCreerCompte.PresenterCreerCompte = this;
            Dialog = new OpenFileDialog();

        }

        public void ImporterImage ()
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image files (*.jpg, *.jpeg) | *.jpg; *.jpeg;";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CheminImage = Dialog.FileName;
                    _viewCreerCompte.NomImageRentre = Path.GetFileName(CheminImage);
                    string nouveauChemin = Path.Combine("../../Resources/", Path.GetFileName(CheminImage));
                    File.Copy(CheminImage, nouveauChemin, true);

                    Image image = new Bitmap(Path.Combine("../../Resources/", Path.GetFileName(CheminImage)));
                    if (image.Width < image.Height)
                    {
                        _viewCreerCompte.pictureBoxPdp.Image = new Bitmap(image, new Size((int)Math.Ceiling((double)image.Width / (image.Height / 85)), 85));
                    }
                    else
                    {
                        _viewCreerCompte.pictureBoxPdp.Image = new Bitmap(image, new Size(120, (int)Math.Ceiling((double)image.Height / (image.Width / 120))));
                    }

                    _viewCreerCompte.pictureBoxPdp.SizeMode = PictureBoxSizeMode.AutoSize;


                }
                catch (Exception)
                {
                    MessageBox.Show("Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }
    }
}
