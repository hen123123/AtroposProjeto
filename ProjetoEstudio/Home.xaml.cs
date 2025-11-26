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
    /// Interação lógica para Home.xam
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            // Abrir conexão com o banco quiz_jogador
            //ConexaoBanco.AbrirConexao("Server=localhost;Database=quiz_jogador;User Id=root;Password=root;");

            //if (ConexaoBanco.Conexao == null && ConexaoBanco.Conexao.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados.", "Erro de Conexão", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Loginpage());
        }

        private void BtnCadastro_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cadastropage());
        }
    }
}
