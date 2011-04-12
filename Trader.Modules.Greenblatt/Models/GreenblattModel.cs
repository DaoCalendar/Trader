namespace Trader.Modules.Greenblatt.Models
{
    public class GreenblattModel : IGreenblattModel
    {

        // Set up the example data with a value
        public GreenblattModel()
        {
            this.ImportantData = "Greenblatt";
        }

        // Example data
        public string ImportantData
        {
            get;
            set;
        }

    }
}
