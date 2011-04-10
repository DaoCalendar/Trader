using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Trader.Modules.Greenblatt.ViewModels;
using Microsoft.Practices.Prism.Logging;

namespace Trader.Modules.Greenblatt.Views
{
    /// <summary>
    /// Interaction logic for GreenblattView.xaml
    /// </summary>
    public partial class GreenblattView : UserControl
    {
        public GreenblattView(GreenblattViewModel model)
        {
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
