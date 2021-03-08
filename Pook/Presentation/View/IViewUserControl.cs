using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Presenter;
using System.Windows.Forms;

namespace Presentation.View
{
    public interface IViewUserControl
    {
        PresenterUserControl PresenterUserControl { get; set; }
        FlowLayoutPanel FlowLayoutPanel { get; set; }
    }
}
