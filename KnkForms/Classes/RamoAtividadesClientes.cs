using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnkForms.Classes
{
    internal class RamoAtividadesClientes:RamoAtividades
    {
        protected int codClienteFornecedor;
        protected int prioridade;
        
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\GitHub\\WinFormsKerp\\KnkForms\\localKerp.mdf;Integrated Security=True;Connect Timeout=30";
        //"Server=192.168.20.150,49172;Database=kerp;User Id=Administrador;Password=T0r1@2017;";


        protected Clientes clientes;
        protected RamoAtividades ramoAtiv;
        public RamoAtividadesClientes()
        {
            codClienteFornecedor = 0;
            prioridade = 0;
            clientes = new Clientes();
            ramoAtiv = new RamoAtividades();
        }

        public int CodClienteFornecedor
        {
            get { return codClienteFornecedor; }
            set { codClienteFornecedor = value; }
        }

        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
        public Clientes Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        public RamoAtividades RamoAtiv
        {
            get { return ramoAtiv; }
            set { ramoAtiv = value; }
        }
        public void SalvarBD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO RamoAtividadeClientes (IdEmpresa, IdRamo, IdFornCliente, Prioridade) VALUES (@IdEmpresa, @IdRamo, @IdFornCliente, @Prioridade)";

                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdRamo", Cod);
                        command.Parameters.AddWithValue("@IdFornCliente", CodClienteFornecedor);
                        command.Parameters.AddWithValue("@Prioridade", Prioridade);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso", "Sucesso", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
        public void AlterarBD(int CodRamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE RamoAtividadeClientes SET IdEmpresa=@IdEmpresa, IdFornCliente=@IdFornCliente, Prioridade=@Prioridade WHERE IdRamo = @IdRamo";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdEmpresa", CodEmpresa);
                        command.Parameters.AddWithValue("@IdFornCliente", CodClienteFornecedor);
                        command.Parameters.AddWithValue("@Prioridade", Prioridade);
                        command.Parameters.AddWithValue("@IdRamo", CodRamo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados atualizados com sucesso", "Sucesso", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
        public void ExcluirBD(int CodRegiao)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM RamoAtividadeClientes WHERE IdRamo = @IdRamo";
                    using (var command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@IdRamo", CodRegiao);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados deletados com sucesso", "Sucesso", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
