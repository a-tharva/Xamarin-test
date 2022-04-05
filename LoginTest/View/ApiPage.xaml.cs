using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LoginTest.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiPage : ContentPage
    {
        public ApiPage()
        {
            InitializeComponent();
        }

        public async void ApiCall(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var URL = "https://icanhazdadjoke.com/slack";
                string response = client.GetStringAsync(URL).Result;
                JObject jobj = JObject.Parse(response);

                ApiAnswer.Children.Clear();
                Label ans = new Label();
                ans.Text = (string)jobj["attachments"][0]["text"];
                ApiAnswer.Children.Add(ans);
            }
        }

    }
}