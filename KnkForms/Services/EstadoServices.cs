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
    internal class EstadoServices
    {
        public async Task<List<Estados>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/Estado");
            var jsonString = await response.Content.ReadAsStringAsync();
            try
            {
                List<Estados> JsonObject = JsonConvert.DeserializeObject<List<Estados>>(jsonString);
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
