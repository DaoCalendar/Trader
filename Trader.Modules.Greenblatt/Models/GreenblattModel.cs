using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trader.Modules.Greenblatt.Models
{
    public class GreenblattModel : IGreenblattModel
    {
        string importantData;

        public GreenblattModel()
        {
            importantData = "Greenblatt";
        }

        public string ImportantData
        {
            get
            {
                return this.importantData;
            }
        }

    }
}
