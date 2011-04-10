using System;
namespace Trader.Modules.Greenblatt.ViewModels
{
    public interface IGreenblattViewModel
    {
        System.Windows.Input.ICommand GoCommand { get; set; }
        Microsoft.Practices.Prism.Logging.ILoggerFacade Logger { get; set; }
        string Text { get; set; }
    }
}
