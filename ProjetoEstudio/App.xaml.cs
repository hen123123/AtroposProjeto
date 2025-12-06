using System.Configuration;
using System.Data;
using System.Windows;

namespace ProjetoEstudio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public string CurrentUser { get; internal set; }
        public string Servico { get; internal set; }

        public string Horario { get; internal set; }
    }

    public class Agendas
    {
        public string DataHora { get; set; }
        public string Servico { get; set; }
        public string Cliente { get; set; }

        public Agendas(string dataHora, string servico, string cliente)
        {
            DataHora = dataHora;
            Servico = servico;
            Cliente = cliente;
        }
    }

}
