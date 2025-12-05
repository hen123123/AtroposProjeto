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
    /// Interação lógica para Loginpage.xam
    /// </summary>
    public partial class Loginpage : Page
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Home());
        }

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = "Server=localhost;Database=valhalla;Uid=root;pwd=root;";

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM cadastro WHERE usuario = @usuario AND senha = @senha";
                using (var command = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", TxtUsername.Text);
                    command.Parameters.AddWithValue("@senha", PwdPassword.Password);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    if (userCount > 0)
                    {
                        NavigationService.Navigate(new Hubescolhas());
                        ((App)Application.Current).CurrentUser = TxtUsername.Text;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
