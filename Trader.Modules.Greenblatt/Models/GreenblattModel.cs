namespace Trader.Modules.Greenblatt.Models
{
    public class GreenblattModel : IGreenblattModel
    {
        /// All view model and model classes accessible to the 
        /// view should implement the INotifyPropertyChanged or 
        /// INotifyCollectionChanged interfaces, as appropriate.
        /// (NotificationObject)


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
