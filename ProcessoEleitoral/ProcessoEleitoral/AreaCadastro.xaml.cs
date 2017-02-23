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
    /// Interaction logic for AreaCadastro.xaml
    /// </summary>
    public partial class AreaCadastro : Window
    {
        public AreaCadastro()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new MainWindow();
            janela.ShowDialog();
            this.Close();
        }

        private void buttonSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonEleitor_Click(object sender, RoutedEventArgs e)
        {
            CadastroEleitor janela = new CadastroEleitor();
            janela.ShowDialog();
            this.Close();
        }

        private void buttonCandidato_Click(object sender, RoutedEventArgs e)
        {
            CadastroCandidato janela = new CadastroCandidato();
            janela.ShowDialog();
            this.Close();
        }

        private void buttonEleicao_Click(object sender, RoutedEventArgs e)
        {
            CadastroEleicao janela = new CadastroEleicao();
            janela.ShowDialog();
            this.Close();
        }
    }
}
