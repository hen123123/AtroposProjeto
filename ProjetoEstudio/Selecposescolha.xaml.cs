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
    }
}
