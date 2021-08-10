using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using XamAcApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamAcApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAccountPage : ContentPage
    {
        public Account account { get; set; }
        private const string Url = "https://xamapi.azurewebsites.net/api/accounts";
        public string UsrName { get; set; }
        public string Password { get; set; }

        public NewAccountPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private async void ToolbarSaveItem_Clicked(object sender, EventArgs e)
        {
            account = new Account
            {
                UsrName = this.UsrName,
                Password = this.Password
            };
            var serializeItem = JsonConvert.SerializeObject(account);
            StringContent body = new StringContent(serializeItem, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            var result = await client.PostAsync(Url,body);
            string data = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
                var answer = await DisplayAlert("Success", "Do you want to continue", "Yes", "No");
            }
            else
            {

            }
        }
    }
}