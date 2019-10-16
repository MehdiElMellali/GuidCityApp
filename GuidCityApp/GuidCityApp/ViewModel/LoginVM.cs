using GuidCityApp.ViewModel;
using GuidCityApp.Helpers;
using GuidCityApp.View;
using GuidCityApp.View.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using GuidCityApp;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace Mobile.ViewModel
{
    public class LoginVM : BaseViewModel
    {


        public string Username { get; set; } = Settings.FullName = "admin@admin.com";
        public string Password { get; set; } = Settings.Password = "admin";



        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (!AppHelper.IsConnected)
                    {
                        await MaterialDialog.Instance.AlertAsync(message: "This is an alert dialog.");
                        return;
                    }

                        App.MasterDetailPage = new MasterDetailPage
                        {
                            Master = new MenuView(),
                            Detail = new NavigationPage(new StoreListView()),
                        };
                        using (var dialog = await MaterialDialog.Instance.LoadingDialogAsync(message: "Connexion en cours", configuration: new XF.Material.Forms.UI.Dialogs.Configurations.MaterialLoadingDialogConfiguration() { TintColor = Xamarin.Forms.Color.FromHex("#289851") }))
                        {
                            await Task.Delay(5000); // Represents a task that is running.
                        }
                        App.Current.MainPage = App.MasterDetailPage;
                   
                });
            }
        }

       

    }
}
