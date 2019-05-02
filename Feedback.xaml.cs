using AgencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgencyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feedback : ContentPage
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            bool isFeedbackEmpty = string.IsNullOrEmpty(entryFeedback.Text);
            if(isFeedbackEmpty)
            {
                DisplayAlert("Fail", "Please Type Your Feedback", "Ok");
            }
            else
            {
                DisplayAlert("Successful", "Thanks For Your Feedback", "Ok");
            }
        }
    }
}