using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Microsoft.Practices.Prism.ViewModel;
using Trader.Modules.Greenblatt.Models;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using Microsoft.Practices.Prism.Logging;

namespace Trader.Modules.Greenblatt.ViewModels
{
    public class GreenblattViewModel : NotificationObject, IGreenblattViewModel
    {
        IGreenblattModel model;

        public ILoggerFacade Logger
        {
            get;
            set;
        }
        
        public GreenblattViewModel(IGreenblattModel model, ILoggerFacade logger)
        {
            this.model = model;
            this.Text = model.ImportantData;
            this.goCommand = new DelegateCommand(this.MyCommand);
            this.Logger = logger;
        }

        public string Text
        {
            get;
            set;
        }

        private ICommand goCommand;
        public ICommand GoCommand
        {
            get { return this.goCommand; }
            set { goCommand = value; }
        }

        private void MyCommand()
        {
            Text = "Button Pressed!";
            Logger.Log("BUTTON PRESSED, RED ALERT", Category.Warn, Priority.High);
            this.RaisePropertyChanged(() => this.Text);
        }
    }
}
