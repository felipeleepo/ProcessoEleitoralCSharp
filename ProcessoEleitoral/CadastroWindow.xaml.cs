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
        int count;
        int countCand;
        int countEleicao;


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
            // Habilitar os campos e gerar o número de série
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleitores.txt");
            count = vetor.Length + 1;
            textboxSerie1.Text = count.ToString();
            textboxNome1.IsEnabled = true;
            textboxNumero1.IsEnabled = true;
            textboxCPF1.IsEnabled = true;
            textboxZona.IsEnabled = true;
            textboxSecao.IsEnabled = true;
            dado1.Header = "Novo Eleitor";
            //Esvaziar campos da busca e Novos Exceto a Série
            tNome1.Text = "";
            tNumero1.Text = "";
            textboxNome1.Text = "";
            textboxNumero1.Text = "";
            textboxCPF1.Text = "";
            textboxZona.Text = "";
            textboxSecao.Text = "";
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
                    if (v[1] == tNome1.Text)
                    {
                        textboxSerie1.Text = v[0];
                        textboxNome1.Text = v[1];
                        textboxNumero1.Text = v[2];
                        textboxCPF1.Text = v[3];
                        textboxZona.Text = v[4];
                        textboxSecao.Text = v[5];
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado.");
                        textboxSerie1.Text = "";
                        textboxNome1.Text = "";
                        textboxNumero1.Text = "";
                        textboxCPF1.Text = "";
                        textboxZona.Text = "";
                        textboxSecao.Text = "";
                    }
                }
                else if (bNumero1.IsChecked == true)
                {
                    if (v[2] == tNumero1.Text)
                    {
                        textboxSerie1.Text = v[0];
                        textboxNome1.Text = v[1];
                        textboxNumero1.Text = v[2];
                        textboxCPF1.Text = v[3];
                        textboxZona.Text = v[4];
                        textboxSecao.Text = v[5];
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
                    textboxSerie1.Text = "";
                    textboxNome1.Text = "";
                    textboxNumero1.Text = "";
                    textboxCPF1.Text = "";
                    textboxZona.Text = "";
                    textboxSecao.Text = "";
                }
            }
        }

        private void salvar1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Instancia um Eleitor e trata seus dados para o arquivo.
                Eleitor eleitor = new Eleitor(count, textboxNome1.Text, int.Parse(textboxNumero1.Text), int.Parse(textboxCPF1.Text), int.Parse(textboxZona.Text), int.Parse(textboxSecao.Text));
                String s = eleitor.TratarDados();
                // Cria um vetor de linhas que já existem no arquivo
                String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleitores.txt");
                // Sobrescreve as linhas no arquivo
                StreamWriter f = new StreamWriter("..\\..\\..\\Dados\\eleitores.txt", false, Encoding.Default);
                for (int i = 0; i < vetor.Length; i++)
                    f.WriteLine(vetor[i]);
                // Escreve a nova linha
                f.WriteLine(s.Remove(s.Length - 1));
                f.Close();
                MessageBox.Show("Salvo!");
            }
            catch (FormatException) { MessageBox.Show("Clique em Novo e preenchas os campos."); }
        }

        private void bNome2_Checked(object sender, RoutedEventArgs e)
        {
            tNome2.IsEnabled = true;
            tNumero2.IsEnabled = false;
        }

        private void bNumero2_Checked(object sender, RoutedEventArgs e)
        {
            tNome2.IsEnabled = false;
            tNumero2.IsEnabled = true;
        }

        private void buttonBusca2_Click(object sender, RoutedEventArgs e)
        {
            dado2.Header = "Resultado";
            // Extrai todas as linha já existentes no arquivo e coloca-as em vetor de Strings
            // Depois Salva-as novamente
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\candidatos.txt");
            for (int i = 0; i < vetor.Length; i++)
            {
                String[] v = vetor[i].Split(';');
                if (bNome2.IsChecked == true)
                {
                    if (v[1] == tNome2.Text)
                    {
                        textboxSerie2.Text = v[0];
                        textboxNome2.Text = v[1];
                        textboxNumero2.Text = v[2];
                        textboxPartido.Text = v[3];
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado.");
                        textboxSerie2.Text = "";
                        textboxNome2.Text = "";
                        textboxNumero2.Text = "";
                        textboxPartido.Text = "";
                    }
                }
                else if (bNumero1.IsChecked == true)
                {
                    if (v[2] == tNumero2.Text)
                    {
                        textboxSerie2.Text = v[0];
                        textboxNome2.Text = v[1];
                        textboxNumero2.Text = v[2];
                        textboxPartido.Text = v[3];
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado.");
                        textboxNome2.Text = "";
                        textboxNumero2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum dado encontrado.");
                    textboxSerie2.Text = "";
                    textboxNome2.Text = "";
                    textboxNumero2.Text = "";
                    textboxPartido.Text = "";
                }
            }
        }

        private void novo2_Click(object sender, RoutedEventArgs e)
        {
            // Habilitar os campos e gerar o número de série
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\candidatos.txt");
            countCand = vetor.Length + 1;
            textboxSerie2.Text = count.ToString();
            textboxNome2.IsEnabled = true;
            textboxNumero2.IsEnabled = true;
            textboxPartido.IsEnabled = true;
            dado1.Header = "Novo Candidato";
            //Esvaziar campos da busca e Novos Exceto a Série
            tNome2.Text = "";
            tNumero2.Text = "";
            textboxNome2.Text = "";
            textboxNumero2.Text = "";
            textboxPartido.Text = "";
        }

        private void salvar2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Instancia um Eleitor e trata seus dados para o arquivo.
                Candidato cand = new Candidato(countCand, textboxNome2.Text, int.Parse(textboxNumero2.Text), textboxPartido.Text);
                String s = cand.TratarDados();
                // Cria um vetor de linhas que já existem no arquivo
                String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\candidatos.txt");
                // Sobrescreve as linhas no arquivo
                StreamWriter f = new StreamWriter("..\\..\\..\\Dados\\candidatos.txt", false, Encoding.Default);
                for (int i = 0; i < vetor.Length; i++)
                    f.WriteLine(vetor[i]);
                // Escreve a nova linha
                f.WriteLine(s.Remove(s.Length - 1));
                f.Close();
                MessageBox.Show("Salvo!");
            }
            catch (FormatException) { MessageBox.Show("Clique em Novo e preenchas os campos."); }
        }

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleicoes.txt");
            countEleicao = vetor.Length + 1;
            textboxSerie3.Text = countEleicao.ToString();
        }

        private void salvar3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Instancia um Eleitor e trata seus dados para o arquivo.
                Eleicao ele = new Eleicao(countEleicao, textboxCargo.Text, textboxLocal.Text, int.Parse(textboxAno.Text));
                String s = ele.TratarDados();
                // Cria um vetor de linhas que já existem no arquivo
                String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleicoes.txt");
                // Sobrescreve as linhas no arquivo
                StreamWriter f = new StreamWriter("..\\..\\..\\Dados\\eleicoes.txt", false, Encoding.Default);
                for (int i = 0; i < vetor.Length; i++)
                    f.WriteLine(vetor[i]);
                // Escreve a nova linha
                f.WriteLine(s.Remove(s.Length - 1));
                f.Close();
                MessageBox.Show("Salvo!");
            }
            catch (FormatException) { MessageBox.Show("Clique em Novo e preenchas os campos."); }
        }

       

        private void listView_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\candidatos.txt");
            for (int i = 0; i < vetor.Length; i++)
                listView.Items.Add(vetor[i]);
        }

        private void atualizar_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Clear();
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleicoes.txt");
            for (int i = 0; i < vetor.Length; i++)
                comboBox.Items.Add(vetor[i]);
            if (comboBox.SelectedItem != null)
            {
                listView.IsEnabled = true;
                MessageBox.Show("True");
            }
            else
            {
                listView.IsEnabled = false;
                MessageBox.Show("false");
            }
        }

        private void comboBox_Initialized(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            MessageBox.Show("oi");
            String[] vetor = File.ReadAllLines("..\\..\\..\\Dados\\eleicoes.txt");
            for (int i = 0; i < vetor.Length; i++)
                comboBox.Items.Add(vetor[i]);
          /*  if (comboBox.SelectedItem != null)
            {
                listView.IsEnabled = true;
                MessageBox.Show("True");
            }
            else
            {
                listView.IsEnabled = false;
                MessageBox.Show("false");
            }*/
        }
    }
    

}
