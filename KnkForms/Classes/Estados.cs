using KnkForms.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KnkForms.Classes
{
    internal class Estados : Pai
    {
        protected string estado;
        protected string sigla;
        protected decimal? percIcms;
        protected decimal? icms;
        protected decimal? percRedST; //Percentual de Redução da Substituição Tributária 
        protected int? codWeb;

        //Placeholder
        protected int codPais;
        protected string pais;

        //Agregação
        protected Paises oPais;

        public Estados():base()
        {
            estado = "";
            sigla = ""; 
            codPais = 0;
            percIcms = 0;
            icms = 0;
            percRedST = 0;
            codWeb = 0;
            pais = "";
            oPais = new Paises();
        }

        public Estados(int cod, int codEmpresa, DateTime dataCadastro, DateTime dataModificacao, string estado, string sigla, char Ativo, int codPais, double percIcms, int icms, double percRedST, int codWeb, string pais, Paises oPais) : base(cod, codEmpresa, dataCadastro, dataModificacao)
        {
            estado = Estado;
            sigla = sigla;
            percIcms = percIcms;
            icms = icms;
            percRedST = percRedST;
            codWeb = codWeb;
            codPais = codPais;
            pais = pais;
            oPais = oPais;
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        [JsonProperty("IdPais")]
        public int CodPais
        {
            get { return codPais; }
            set { codPais = value; }
        }
        public decimal? PercIcms
        {
            get { return percIcms; }
            set { percIcms = value; }
        }

        [JsonProperty("IcmsInt")]
        public decimal? Icms
        {
            get { return icms; }
            set { icms = value; }
        }

        [JsonProperty("PerRedSt")]
        public decimal? PercRedST
        {
            get { return percRedST; }
            set { percRedST = value; }
        }

        [JsonProperty("CodigoWeb")]
        public int? CodWeb
        {
            get { return codWeb; }
            set { codWeb = value; }
        }

        public string NomePais
        {
            get { return pais; }
            set { pais = value; }
        }

        [JsonIgnore]
        public Paises Pais
        {
            get { return oPais; }
            set { oPais = value; }
        }
        public async void SalvarBD(Estados oEstado)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(oEstado, Formatting.Indented);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7231/Estado", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void AlterarBD(Estados oEstado)
        {
            int idEmp = 1;
            int id = oEstado.Cod;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string jsonItem = JsonConvert.SerializeObject(oEstado);
                    HttpContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await httpClient.PutAsync($"https://localhost:7231/Estado/{idEmp}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Item Atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async void ExcluirBD(int CodEstado)
        {
            int CodEmp = 1;
            using (HttpClient httpClient = new HttpClient())
            {

                EstadoServices buscaEstado = new EstadoServices();
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"https://localhost:7231/Estado/{CodEmp}/{CodEstado}");

                    response.EnsureSuccessStatusCode();
                    MessageBox.Show($"Deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
