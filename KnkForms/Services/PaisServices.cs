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
    internal class PaisServices
    {
        public async Task<List<Paises>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Pais");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<Paises> JsonObject = JsonConvert.DeserializeObject<List<Paises>>(jsonString);
            return JsonObject;
        }
    }
}
