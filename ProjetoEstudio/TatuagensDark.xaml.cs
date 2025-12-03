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
    /// Interação lógica para TatuagensDark.xam
    /// </summary>
    public partial class TatuagensDark : Page
    {
        public TatuagensDark()
        {
            InitializeComponent();
        }


        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Hubescolhas());
        }

        private void Da_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            NavigationService.Navigate(new Agenda(btn.Name));
        }
    }
}
