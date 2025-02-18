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
    internal class ListaPrecoServices
    {
        public async Task<List<ListaPrecos>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Lista");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<ListaPrecos> JsonObject = JsonConvert.DeserializeObject<List<ListaPrecos>>(jsonString);
            return JsonObject;
        }
    }
}
