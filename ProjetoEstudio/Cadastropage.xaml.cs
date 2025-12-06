using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoEstudio
{
    /// <summary>
    /// Interação lógica para Cadastropage.xam
    /// </summary>
    public partial class Cadastropage : Page
    {
        public Cadastropage()
        {
            InitializeComponent();
        }

        private void InserirDados(string usuario, string telefone, string senha, string agenda)
        {
            try
            {
                string sql = "INSERT INTO cadastro (usuario, telefone, senha, agenda, Servico) VALUES (@usuario, @telefone, @senha, @agenda, @Servico)";
                using (var cmdados = new MySqlCommand(sql, ConexaoBanco.Conexao))
                {
                    cmdados.Parameters.AddWithValue("@usuario", usuario);
                    cmdados.Parameters.AddWithValue("@telefone", telefone);
                    cmdados.Parameters.AddWithValue("@senha", senha);
                    cmdados.Parameters.AddWithValue("@agenda", agenda);
                    cmdados.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
            }
        }
        private void BtnVoltar_Click(object sender, RoutedEventArgs e)

        {
            NavigationService.Navigate(new Home());
        }

        public void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_senha.Password != PwdConfirmPassword.Password)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, tente novamente.");
                return;
            }
            InserirDados(Txtusuario.Text, TxtTelefone.Text, txt_senha.Password, "");
            MessageBox.Show("Cadastro realizado com sucesso!");

            Txtusuario.Clear();
            TxtTelefone.Clear();
            txt_senha.Clear();
            PwdConfirmPassword.Clear();

            NavigationService.Navigate(new Loginpage());

        }
    }
}
