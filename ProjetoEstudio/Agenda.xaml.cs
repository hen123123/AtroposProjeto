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
    /// Interação lógica para Agenda.xam
    /// </summary>
    public partial class Agenda : Page
    {
        public string Tatoo { get; set; }
        public Agenda(string tatoo)
        {
            InitializeComponent();
            txTatoo.Text = tatoo;
            ((App)Application.Current).Servico = tatoo;
            txt_cliente.Text = ((App)Application.Current).CurrentUser;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Selecposescolha());
        }

        private void VoltarHubClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Hubescolhas());
        }

        private void Txt_Cliente(object sender, TextChangedEventArgs e)
        {

        }
    }
}
