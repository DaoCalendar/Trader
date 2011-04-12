using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Unity;
using Trader.Modules.Greenblatt.Models;

namespace Trader.Modules.Greenblatt.ViewModels
{
    public class GreenblattViewModel : NotificationObject, IGreenblattViewModel
    {
        // Constructor resolves the model, sets a reference to it inside this object
        // then retrieves the important text!
        // The ICommand GoCommand is also set up to delegate responsibility to the
        // MyCommand function
        public GreenblattViewModel(IGreenblattModel model)
        {
            this.Model = model;
            this.Text = Model.ImportantData;
            this.GoCommand = new DelegateCommand(this.MyCommand);
        }

        // Greenblatt Model is a dependency, but is required in the constructor
        // and is therefore retrieved by constructor IoC/DI resolution
        public IGreenblattModel Model
        {
            get;
            set;
        }

        // Logger service is injected as a dependency, and is not required to be
        // used as part of the constructor.
        [Dependency]
        public ILoggerFacade Logger
        {
            get;
            set;
        }

        // Example text value to interface with the view
        public string Text
        {
            get;
            set;
        }

        // Example command
        public ICommand GoCommand
        {
            get;
            set;
        }
        
        // Example command logic
        private void MyCommand()
        {
            Text = "Button Pressed!";
            Logger.Log("BUTTON PRESSED, RED ALERT", Category.Warn, Priority.High);
            // Notify bound elements that the Text property has changed.
            this.RaisePropertyChanged(() => this.Text);
        }
    }
}
