using System.Windows.Input;
using Microsoft.Practices.Prism.Logging;

namespace Trader.Modules.Greenblatt.ViewModels
{
    public interface IGreenblattViewModel
    {
        // Example command to bind to
        ICommand GoCommand { get; set; }

        // Example text to bind to
        string Text { get; set; }
    }
}
