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
    class GreenblattViewModel : NotificationObject
    {
        GreenblattModel model;
        ILoggerFacade logger;

        public GreenblattViewModel(ILoggerFacade logger)
        {
            model = new GreenblattModel();
            Text = model.ImportantData;
            this.goCommand = new DelegateCommand(this.MyCommand);
            this.logger = logger;
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
            Text = "BLAH!";
            this.RaisePropertyChanged(() => this.Text);
        }
    }
}
