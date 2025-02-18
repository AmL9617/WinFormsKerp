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
    internal class RamoAtividadeServices
    {
        public async Task<List<RamoAtividades>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/RamoAtividades");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<RamoAtividades> JsonObject = JsonConvert.DeserializeObject<List<RamoAtividades>>(jsonString);
            return JsonObject;
        }
    }
}
