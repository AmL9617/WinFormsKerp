using KnkForms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Services
{
    internal class RegiaoServices
    {
        public async Task<List<Regioes>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Regiao");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<Regioes> JsonObject = JsonConvert.DeserializeObject<List<Regioes>>(jsonString);
            return JsonObject;
        }
    }
}
