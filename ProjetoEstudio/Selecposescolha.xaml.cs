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
    /// Interação lógica para Selecposescolha.xam
    /// </summary>
    public partial class Selecposescolha : Page
    {
        public Selecposescolha()
        {
            InitializeComponent();
            UpdateDados();
        }

        public class Agendamento
        {
            public string Agenda { get; set; }
            public string Servico { get; set; }
            public string Usuario { get; set; }

            public Agendamento(string agenda, string servico, string usuario)
            {
                Agenda = agenda;
                Servico = servico;
                Usuario = usuario;
            }
        }

        private void sairtudo_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "...", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (LstAgendamentos.SelectedItem != null)
            {

                try
                {

                    var items = (Agendamento)LstAgendamentos.SelectedItem;
                    string sql = $"UPDATE cadastro SET agenda = @agenda, Servico = @servico, usuario = @user  WHERE usuario = @usuario";
                    using (var cmdados = new MySqlCommand(sql, ConexaoBanco.Conexao))
                    {
                        cmdados.Parameters.AddWithValue("@agenda", items.Agenda);
                        cmdados.Parameters.AddWithValue("@servico", items.Servico);
                        cmdados.Parameters.AddWithValue("@user", items.Usuario);
                        cmdados.Parameters.AddWithValue("@usuario", items.Usuario);
                        cmdados.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao atualizar dados: " + ex.Message);
                }
                //NavigationService.Navigate(new Selecposescolha());
            }
        }

        private void UpdateDados()
        {
            string sql = $"select * from cadastro";
            MySqlCommand cmd = new MySqlCommand(sql, ConexaoBanco.Conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            var agendamentos = new List<Agendamento>();
            while (reader.Read())
            {
                var agenda = reader["agenda"].ToString();
                var servico = reader["Servico"].ToString();
                var usuario = reader["usuario"].ToString();

                agendamentos.Add(new Agendamento(agenda, servico, usuario));

            }
            reader.Close();
            LstAgendamentos.ItemsSource = agendamentos;
        }
    }
}
