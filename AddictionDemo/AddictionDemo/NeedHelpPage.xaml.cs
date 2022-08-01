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
    public partial class NeedHelpPage : ContentPage
    {
        public NeedHelpPage()
        {
            InitializeComponent();
        }

        private void CallMySponsorButton_Clicked(object sender, EventArgs e)
        {

        }

        private void EmergencyHotlineButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}