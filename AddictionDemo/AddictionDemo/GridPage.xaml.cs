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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JournalPage());
        }

        public async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NeedHelpPage());
        }

        public async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FindCommunityPage());
        }

        public async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScheduleMeetingPage());      
        }
    }
}