using System.Windows.Controls;
using Trader.Modules.Greenblatt.ViewModels;

namespace Trader.Modules.Greenblatt.Views
{
    /// <summary>
    /// Interaction logic for GreenblattView.xaml
    /// </summary>
    public partial class GreenblattView : UserControl
    {
        public GreenblattView(IGreenblattViewModel model)
        {
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
