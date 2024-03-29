﻿using GuidCityApp.MenuItems;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuidCityApp.View.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage
    {
        public List<MasterPageItem> MenuList { get; set; }

        public MenuView()
        {
            InitializeComponent();
            MenuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection

            var page1 = new MasterPageItem() { Title = "Contrôler", Icon = "checkList", TargetType = typeof(ListView) };
            MenuList.Add(page1);


            var page3 = new MasterPageItem() { Title = "Se déconnecter", Icon = "logout", TargetType = typeof(Login) };


            // Adding menu items to menuList
            MenuList.Add(page3);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            App.MasterDetailPage.IsPresented = false;
            await Task.Delay(300);
            if (page == typeof(Login))
            {
              //  Settings.ClearSettings();
                App.Current.MainPage = new Login();
            }
            else
            {
                App.MasterDetailPage.Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            }
        }
    }
}