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

        void Get_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Introduction());
        }

        void Get_Installing_Kali(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstallingKali());
        }

        void Get_Zvado_Tools(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsingZvadoTools());
        }
    }
}
