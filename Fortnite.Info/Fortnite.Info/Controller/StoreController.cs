using Fortnite.Info.Model;
using Newtonsoft.Json;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fortnite.Info.Controller
{
    public class StoreController
    {
        private readonly string baseURL = "https://fortniteapi.io/v2";
        private readonly string token = "d00b53cc-ee009e71-f203b3ab-88a45ced";

        public StoreResponse GetCurrentStore()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", token);

                string language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
                if (language.Equals("pt")) language += "-BR";

                HttpResponseMessage response = client.GetAsync($"{baseURL}/shop?lang={language}").Result;

                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        StoreResponse shop = JsonConvert.DeserializeObject<StoreResponse>(result);
                        return shop;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                CrossToastPopUp.Current.ShowToastMessage("Ocorreu um erro!");
                return null;
            }
        }
    }
}
