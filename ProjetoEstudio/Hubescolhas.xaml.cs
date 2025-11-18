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
    /// Interação lógica para Hubescolhas.xam
    /// </summary>
    public partial class Hubescolhas : Page
    {
        public Hubescolhas()
        {
            InitializeComponent();
        }

        private void Sair2Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "...", MessageBoxButton.YesNo);
            
            if(result == MessageBoxResult.Yes)
            {
            Application.Current.Shutdown();
            }          
        }

        private void ConfSeleButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
