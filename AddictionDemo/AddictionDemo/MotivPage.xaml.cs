
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
    public partial class MotivPage : ContentPage 
    {
        public MotivPage()
        {
            InitializeComponent();
        }

       
        public async void ForgotPasswordButton_Clicked(object sender, EventArgs e)
        {

        }

        public async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        public async void LogInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotivationalPage());
        }

    }
}