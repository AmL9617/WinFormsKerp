using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KnkForms.Classes;
using System.Windows.Forms;

namespace KnkForms.Services
{
    internal class CidadeServices
    {
        public async Task<List<Cidades>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Cidade");
            var jsonString = await response.Content.ReadAsStringAsync();

            try
            {
                List<Cidades> JsonObject = JsonConvert.DeserializeObject<List<Cidades>>(jsonString);
                return JsonObject;
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show($"Deserialização falhou: {ex.Message}");
                throw;
            }
        }
    }
}
