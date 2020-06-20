using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using zvadohacks.Pages;

namespace zvadohacks
{   
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Get_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Introduction());
            BtnNavIntro.Opacity = 0;
            await BtnNavIntro.FadeTo(1, 4000);
        }

        async void Get_Installing_Kali(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InstallingKali());
            BtnNavInstallingKai.Opacity = 0;
            await BtnNavInstallingKai.FadeTo(1, 4000);
        }

        async void Get_Zvado_Tools(object sender, EventArgs e)
        {            
            await Navigation.PushAsync(new UsingZvadoTools());
            BtnUsingZvadoTools.Opacity = 0;
            await BtnUsingZvadoTools.FadeTo(1, 4000);
        }
    }
}
