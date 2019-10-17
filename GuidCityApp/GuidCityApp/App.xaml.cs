using GuidCityApp.View;
using GuidCityApp.View.Menu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GuidCityApp
{
    public partial class App : Application
    {

        public static MasterDetailPage MasterDetailPage;


       
        public App()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);

#if DEBUG
            HotReloader.Current.Run(this);
#endif

            MasterDetailPage = new MasterDetailPage
            {
                Master = new MenuView(),
                Detail = new NavigationPage(new StoreListView()),
            };


            #region Login Case

            if (AppHelper.IsTokenStillValid)
            {
                if (true)
                {
                    AppHelper.SetMainPageAsMasterDetailPage();
                }
                else
                {
                    AppHelper.SetMainPageAsMasterDetailPage(new StoreListView());
                 //   Constants.IsLoggedIn = true;
                }
            }
            else
            {
                MainPage = new NavigationPage(new Login());
            }


            #endregion



        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
