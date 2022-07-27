using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AddictionDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Animate();
        }
        
    

        public async Task Animate()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 3000);
            Application.Current.MainPage = new MotivPage();
        }


    }
}
