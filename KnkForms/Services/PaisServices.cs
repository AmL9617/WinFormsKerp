using KnkForms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Services
{
    internal class PaisServices
    {
        public async Task<List<Paises>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Pais");
            var jsonString = await response.Content.ReadAsStringAsync();

            try
            {
                List<Paises> JsonObject = JsonConvert.DeserializeObject<List<Paises>>(jsonString);
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
