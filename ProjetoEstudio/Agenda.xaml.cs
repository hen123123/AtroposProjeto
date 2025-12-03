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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            comboBox.Items.Add("08:30");
            comboBox.Items.Add("10:30");
            comboBox.Items.Add("13:30");
            comboBox.Items.Add("15:30");
            comboBox.Items.Add("17:30");
            comboBox.Items.Add("20:00");
            comboBox.Items.Add("22:30");
        }
    }
}
