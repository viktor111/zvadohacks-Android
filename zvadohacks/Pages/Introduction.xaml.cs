using System;
using Xamarin.Forms;

namespace zvadohacks.Pages
{
    public partial class Introduction : ContentPage
    {
        public Introduction()
        {
            InitializeComponent();
        }

        void Cell_1_Tapped(object sender, EventArgs e)
        {
            const string Detail = "You will learn what is kali how to install and set it up.";       
            CellInstallingKali.Detail = Detail;                      
        }
        void Cell_2_Tapped(object sender, EventArgs e)
        {
            const string Detail = "You will learn how to install and use zvado hacking tools";
            CellUsingZvadoTool.Detail = Detail;
        }
    }
}   
