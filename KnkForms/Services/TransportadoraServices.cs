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
    internal class TransportadoraServices
    {
        public async Task<List<Transportadoras>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<Transportadoras> JsonObject = JsonConvert.DeserializeObject<List<Transportadoras>>(jsonString);
            return JsonObject;
        }
    }
}
