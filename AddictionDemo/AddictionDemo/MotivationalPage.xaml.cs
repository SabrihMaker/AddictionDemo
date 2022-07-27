using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddictionDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MotivationalPage : ContentPage
    {
        public MotivationalPage()
        {
            InitializeComponent();
        }

        public async void NextButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync (new GridPage());
        }
    }
}