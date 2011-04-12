using System.Windows.Controls;
using Trader.Modules.Greenblatt.ViewModels;

namespace Trader.Modules.Greenblatt.Views
{
    /// <summary>
    /// The view's responsibility is to define the structure and appearance 
    /// of what the user sees on the screen. Ideally, the code-behind of a 
    /// view contains only a constructor that calls the InitializeComponent 
    /// method. In some cases, the code-behind may contain UI logic code 
    /// that implements visual behavior that is difficult or inefficient to 
    /// express in Extensible Application Markup Language (XAML), such as 
    /// complex animations, or when the code needs to directly manipulate 
    /// visual elements that are part of the view. You should not put any 
    /// logic code in the view that you need to unit test. Typically, logic 
    /// code in the view's code-behind will be tested via a UI automation 
    /// testing approach.
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
