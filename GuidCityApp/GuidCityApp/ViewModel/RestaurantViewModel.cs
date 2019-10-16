using GuidCityApp.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GuidCityApp.ViewModel
{
    public class RestaurantViewModel : BaseViewModel
    {

        private ObservableCollection<Section> _sections;
        public ObservableCollection<Section> Sections
        {
            get
            {
                return _sections;
            }
            set
            {
                if (_sections != value)
                {
                    _sections = value;
                }
            }
        }

        private ObservableCollection<Restaurant> items;
        public ObservableCollection<Restaurant> Items
        {
            get { return items; }
            set
            {

                items = value;
            }
        }
        public RestaurantViewModel()
        {
            Items = new ObservableCollection<Restaurant>() {
                new Restaurant()
        {
            Id = 1,
                    Name = "Restaurant name",
                 Description    = "This text is an example of text that can be replaced in the same space",
                 Image = "imageList1.jpg",
                 Favorit = "heart.png"
                },
                  new Restaurant()
        {
           Id = 2,
                    Name = "Restaurant name",
                 Description    = "This text is an example of text that can be replaced in the same space",
                  Image = "imageList1.jpg",
                 Favorit = "heart.png"

                },
                     new Restaurant()
        {
           Id = 2,
                    Name = "Restaurant name",
                 Description    = "This text is an example of text that can be replaced in the same space",
                  Image = "imageList1.jpg",
                 Favorit = "heart.png"

                },
                     new Restaurant()
        {
           Id = 2,
                    Name = "Restaurant name",
                 Description    = "This text is an example of text that can be replaced in the same space",
                  Image = "imageList1.jpg",
                 Favorit = "heart.png"

                },

            };
        }


    }

    public class Section
    {
        public string Header { get; set; }
        public FormattedString Content { get; set; }
        public string Emoji { get; set; }
    };
}
