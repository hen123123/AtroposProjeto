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

        private void SumiButton(object sender, RoutedEventArgs e)
        {
            TxtDescription.Text = "Suminagashi é um estilo de design que enfatiza a simplicidade e a \n funcionalidade. Caracteriza-se por linhas limpas, cores neutras e uma abordagem minimalista que elimina elementos desnecessários. O objetivo\n do Suminagashi é criar espaços visuais tranquilos e organizados, promovendo uma sensação de calma e clareza. Esse estilo é frequentemente utilizado em design de interiores, moda e design gráfico para transmitir elegância e sofisticação através da simplicidade.";
        }

        private void BlackButton(object sender, RoutedEventArgs e)
        {
            TxtDescription.Text = "O estilo BlackWork é caracterizado pelo uso predominante da cor preta,\n transmitindo uma sensação de elegância, sofisticação e mistério. Esse estilo é frequentemente associado a ambientes modernos e\n contemporâneos, onde o preto é utilizado para criar contrastes marcantes com outras cores ou para destacar elementos específicos do design. No design de interiores, o estilo Black pode ser visto em móveis, acessórios e acabamentos que utilizam tons escuros para criar uma atmosfera intimista e dramática. Na moda, o estilo Black é sinônimo de roupas clássicas e atemporais, como o 'pretinho básico', que nunca sai de moda. Em resumo, o estilo Black é uma escolha ousada que evoca poder e estilo através do uso da cor preta.";
        }

        private void DarkButton(object sender, RoutedEventArgs e)
        {
            TxtDescription.Text = "O estilo DarkOrnamental é caracterizado por uma paleta de cores escuras \n e tons profundos, criando uma atmosfera misteriosa, sofisticada e muitas vezes dramática. Esse estilo é frequentemente associado a elementos\n góticos, industriais ou contemporâneos, onde o uso de preto, cinza, azul escuro e outras cores sombrias predominam. No design de interiores, o estilo Dark pode incluir móveis robustos, iluminação suave e texturas ricas que adicionam profundidade ao ambiente. Na moda, o estilo Dark é representado por roupas que transmitem uma sensação de rebeldia e individualidade, muitas vezes incorporando elementos como couro, metal e tecidos pesados. Em resumo, o estilo Dark é uma escolha ousada que evoca emoções intensas e um senso de mistério através do uso de cores escuras e design arrojado.";
        }
    }
}
