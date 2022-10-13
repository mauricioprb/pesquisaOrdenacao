using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace metOrdenacao {
    public partial class Frame : Form {
        Infos infos = new Infos();
        Util util = new Util();
        Ordenacao ordenacao = new Ordenacao();

        int metodo;

        public Frame() {
            InitializeComponent();
        }

        private void btInfos_Click(object sender, EventArgs e) {
            metodo = Int32.Parse(cbMetodos.GetItemText(cbMetodos.SelectedIndex));
            tbInfos.Text = infos.informacoes(metodo);
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            tbInfos.Clear();
            tbDemo.Clear();
            tbNumeros.Clear();
            tbTempoExec.Clear();
        }

        private void btTestarOrdenacao_Click(object sender, EventArgs e) {
            int qtdNum = Int32.Parse(tbNumeros.Text);

            List<int> listaNum = util.popularLista(qtdNum);

            Stopwatch sw = new Stopwatch();

            if (metodo == 0) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.bolha(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 1) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.selecao(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 2) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.insercao(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 3) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.agitacao(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 4) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.pente(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 5) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.shell(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 6) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.quick(listaNum, 0, listaNum.Count - 1));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            } else if (metodo == 7) {
                sw.Start();
                tbDemo.Text = String.Join(Environment.NewLine, ordenacao.heap(listaNum));
                sw.Stop();
                tbTempoExec.Text = sw.ElapsedMilliseconds.ToString();
                sw.Reset();
            }
        }
    }
}