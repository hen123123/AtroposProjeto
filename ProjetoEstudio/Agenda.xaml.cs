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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Selecposescolha.xaml", UriKind.Relative));
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VoltarHubClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Hubescolhas());
        }
    }
}
