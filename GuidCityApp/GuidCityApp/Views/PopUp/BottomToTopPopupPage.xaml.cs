using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuidCityApp.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomToTopPopupPage : Plugin.XF.Backdrop.BottomToTopBackdropPopupPage
    {

        public BottomToTopPopupPage()
        {
            InitializeComponent();
            UrlWebViewSource source = new UrlWebViewSource();
        }
    }
}