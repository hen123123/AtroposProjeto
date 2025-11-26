using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoEstudio
{
    internal class ConexaoBanco
    {
        public static MySqlConnection? Conexao { get; private set; }

        public static void AbrirConexao(string v)
        {
            try
            {
                if (Conexao == null)
                {
                    Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root;database=valhalla");
                    Conexao.Open();
                }
            }
            catch (Exception ex)
            {
                Conexao = null;
                MessageBox.Show(ex.ToString());
            }
        }

        public static void FecharConexao()
        {
            if (Conexao != null && Conexao.State == System.Data.ConnectionState.Open)
                Conexao.Close();
        }
    }
}
