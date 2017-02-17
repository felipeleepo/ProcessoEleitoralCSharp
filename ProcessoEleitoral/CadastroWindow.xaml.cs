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
using System.IO;

namespace ProcessoEleitoral
{
    /// <summary>
    /// Interaction logic for CadastroWindow.xaml
    /// </summary>
    public partial class CadastroWindow : Window
    {
        public CadastroWindow()
        {
            InitializeComponent();
        }

        private void bNome1_Checked(object sender, RoutedEventArgs e)
        {
            tNome1.IsEnabled = true;
            tNumero1.IsEnabled = false;
        }

        private void bNumero1_Checked(object sender, RoutedEventArgs e)
        {
            tNome1.IsEnabled = false;
            tNumero1.IsEnabled = true;
        }

        private void novo1_Click(object sender, RoutedEventArgs e)
        {
            textboxNome1.IsEnabled = true;
            textboxNumero1.IsEnabled = true;
            dado1.Header = "Novo Eleitor";
        }

        private void fechar1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonBusca1_Click(object sender, RoutedEventArgs e)
        {
            dado1.Header = "Resultado";
            // Extrai todas as linha já existentes no arquivo e coloca-as em vetor de Strings
            // Depois Salva-as novamente
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleitores.txt");
            for (int i = 0; i < vetor.Length; i++)
            {
                String[] v = vetor[i].Split(';');
                if (bNome1.IsChecked == true)
                {
                    if (v[0] == tNome1.Text)
                    {
                        textboxNome1.Text = v[0];
                        textboxNumero1.Text = v[1];
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado.");
                        textboxNome1.Text = "";
                        textboxNumero1.Text = "";
                    }
                }
                else if (bNumero1.IsChecked == true)
                {
                    if (v[1] == tNumero1.Text)
                    {
                        textboxNome1.Text = v[0];
                        textboxNumero1.Text = v[1];
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado.");
                        textboxNome1.Text = "";
                        textboxNumero1.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                    textboxNome1.Text = "";
                    textboxNumero1.Text = "";
                }
            }
        }

        private void salvar1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Grava o Eleitor em uma linha do arquivo, retirando o "@".
                Eleitor eleitor = new Eleitor(textboxNome1.Text, int.Parse(textboxNumero1.Text));
                String s = eleitor.TratarDados();
                StreamWriter f = new StreamWriter("..\\..\\..\\Dados\\eleitores.txt", false, Encoding.Default);
                f.WriteLine(s.Remove(s.Length - 1));
                f.Close();
                MessageBox.Show("Salvo!");
            }
            catch (FormatException) { MessageBox.Show("Clique em Novo e preenchas os campos."); }
        }
    }
}
