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
using System.Windows.Shapes;

namespace ProcessoEleitoral
{
    /// <summary>
    /// Interaction logic for CadastroEleicao.xaml
    /// </summary>
    public partial class CadastroEleicao : Window
    {
        public CadastroEleicao()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, RoutedEventArgs e)
        {
            AreaCadastro janela = new AreaCadastro();
            janela.ShowDialog();
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
