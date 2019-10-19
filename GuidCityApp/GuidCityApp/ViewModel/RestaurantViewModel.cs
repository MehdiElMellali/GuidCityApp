using GuidCityApp.Models;
using GuidCityApp.Views.PopUp;
using System.Collections.ObjectModel;
using System.Windows.Input;
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
        public ICommand OpenPopUpCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new BottomToTopPopupPage());
                });
            }
        }


        public ICommand GetListCommand
        {
            get
            {
                return new Command<string>(async (x) =>
                {
                    switch (x)
                    {
                        case "1":
                            ColorChaletsButton = "#FFB71A";
                            ColorRestaurantsButton = "#e3e5e5";
                            ColorHouseButton = "#e3e5e5";
                            ColorHotelsButton = "#e3e5e5";

                            break;
                        case "2":
                            ColorRestaurantsButton = "#FFB71A";
                            ColorChaletsButton = "#e3e5e5";
                            ColorHouseButton = "#e3e5e5";
                            ColorHotelsButton = "#e3e5e5";

                            break;
                        case "3":
                            ColorHotelsButton = "#FFB71A"; 
                            ColorChaletsButton = "#e3e5e5";
                            ColorRestaurantsButton = "#e3e5e5";
                            ColorHouseButton = "#e3e5e5";

                            break;
                        case "4":
                            ColorHouseButton = "#FFB71A";
                            ColorChaletsButton = "#e3e5e5";
                            ColorRestaurantsButton = "#e3e5e5";
                            ColorHotelsButton = "#e3e5e5";

                            break;
                    }
                   
                });
            }
        }

        public string ColorChaletsButton { get; set; }
        public string ColorRestaurantsButton { get; set; }
        public string ColorHotelsButton { get; set; }
        public string ColorHouseButton { get; set; }
    }

    public class Section
    {
        public string Header { get; set; }
        public FormattedString Content { get; set; }
        public string Emoji { get; set; }
    };
}
