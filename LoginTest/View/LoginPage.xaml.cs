using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LoginTest.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void BtnLoginClicked(object sender, EventArgs e)
        {
            //Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            
            if(LoginUserName.Text.ToLower() == "admin" && LoginPassword.Text.ToLower() == "admin")
            {
                await Navigation.PushAsync(new MainTabbedPage());
                //await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
            {
                await DisplayAlert("Alert", "Invalid Login!", "OK");
            }
        }

        private async void Register(object sender, EventArgs e)
        {
            Console.WriteLine("url");
            await Browser.OpenAsync("http://xamarin.com", BrowserLaunchMode.SystemPreferred);
        }
    }
}