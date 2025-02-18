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
    internal class CondicaoPagamentoServices
    {
        public async Task<List<CondicaoPagamentos>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/CondPag");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<CondicaoPagamentos> JsonObject = JsonConvert.DeserializeObject<List<CondicaoPagamentos>>(jsonString);
            return JsonObject;
        }
    }
}
