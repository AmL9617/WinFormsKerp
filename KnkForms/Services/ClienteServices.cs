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
    internal class ClienteServices
    {
        public async Task<List<Clientes>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Cliente");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<Clientes> JsonObject = JsonConvert.DeserializeObject<List<Clientes>>(jsonString);
            return JsonObject;
        }
    }
}
