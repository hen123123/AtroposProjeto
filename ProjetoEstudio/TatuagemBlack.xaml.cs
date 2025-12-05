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
    /// Interação lógica para TatuagemBlack.xam
    /// </summary>
    public partial class TatuagemBlack : Page
    {
        public TatuagemBlack()
        {
            InitializeComponent();
        }

        private void BtnSelecionar1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;

            var sql = $"UPDATE cadastro SET Servico = '{btn.Name}' WHERE usuario = '{((App)Application.Current).CurrentUser}' ";
            MySqlCommand cmd = new MySqlCommand(sql, ConexaoBanco.Conexao);
            cmd.ExecuteNonQuery();

            NavigationService.Navigate(new Agenda(btn.Name));
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Hubescolhas());
        }
    }
}
