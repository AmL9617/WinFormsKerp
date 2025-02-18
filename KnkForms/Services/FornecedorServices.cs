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
    internal class FornecedorServices
    {
        public async Task<List<Fornecedores>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Fornecedor");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<Fornecedores> JsonObject = JsonConvert.DeserializeObject<List<Fornecedores>>(jsonString);
            return JsonObject;
        }
    }
}
