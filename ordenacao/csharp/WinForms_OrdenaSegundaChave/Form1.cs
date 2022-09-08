using System.Windows.Forms;

namespace WinForms_OrdenaSegundaChave {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e) {
            lista.Clear();
            tbDadosGerados.Clear();
            Dado dado;
            Random gerador = new Random();

            try {
                long qtdNumeros = long.Parse(tbQtdDados.Text);

                for (; qtdNumeros > 0; qtdNumeros--) {
                    dado = new Dado(gerador.Next(0, 100), gerador.Next(0, 500));
                }
                tbQtdDados.Text = "";

            } catch (FormatException) {
                tbQtdDados.Text = "";
                MessageBox.Show("Confira seus dados no campo de texto", "Alerta");
            } catch (Exception) {
                MessageBox.Show("Confira seus dados no campo de texto", "Alerta");
            }


        }
        List<Dado> lista = new List<Dado>();

        private void btAbrirArquivo_Click(object sender, EventArgs e) {
            lista.Clear();
            tbDadosGerados.Clear();
            OpenFileDialog fdFileDialog;

            try {
                fdFileDialog = new OpenFileDialog();
                fdFileDialog.InitialDirectory = @"C:\";
                fdFileDialog.DefaultExt = "txt";
                fdFileDialog.RestoreDirectory = true;
                fdFileDialog.ShowDialog();
                Dado dado;
                fdFileDialog.ShowDialog();
                MessageBox.Show(fdFileDialog.FileName, "Aviso");
                string[] linhas = File.ReadAllLines(fdFileDialog.FileName);
                string[] numeros;

                for (int i = 0; i < linhas.Length; i++) {
                    numeros = linhas[i].Split(';');
                    dado = new Dado(int.Parse(numeros[0]), int.Parse(numeros[1]));
                    lista.Add(dado);
                    tbDadosGerados.AppendText(dado.Chave1 + " - " + dado.Chave2 + Environment.NewLine);
                }

            } catch (Exception) {

            }

        }
    }
}