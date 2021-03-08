using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Presenter;
using Presentation.View;

namespace Presentation.View
{
    public interface IViewAccueilAdmin
    {
        string Login { get; set; }
        int Id { get; set; }
        PresenterAccueilAdmin PresenterAccueilAdmin { get; set; }
        DataGridView DGVAlbumsDuMarche { get; set; }
    }
}
