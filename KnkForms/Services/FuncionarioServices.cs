﻿using KnkForms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KnkForms.Services
{
    internal class FuncionarioServices
    {
        public async Task<List<Funcionarios>> Dados()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7231/");
            var jsonString = await response.Content.ReadAsStringAsync();

            List<Funcionarios> JsonObject = JsonConvert.DeserializeObject<List<Funcionarios>>(jsonString);
            return JsonObject;
        }
    }
}
