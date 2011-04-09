using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Microsoft.Practices.Prism.ViewModel;
using Trader.Modules.Greenblatt.Models;

namespace Trader.Modules.Greenblatt.ViewModels
{
    class GreenblattViewModel : NotificationObject
    {
        GreenblattModel model;

        public GreenblattViewModel()
        {
            model = new GreenblattModel();
        }

        public string Text
        {
            get
            {
                return this.model.ImportantData;
            }
        }
    }
}
