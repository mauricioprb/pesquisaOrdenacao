using System.Collections;

namespace avaliacao1_interface_odenacao {
    public partial class Form1 : Form {
        static List<string> nomeAluno = new List<string>();
        static List<string> nomeCurso = new List<string>();

        public Form1() {
            InitializeComponent();
        }
        private void btSalvar_Click(object sender, EventArgs e) {
            Agitacao agitacao = new Agitacao();

            nomeAluno.Add(tbAluno.Text);
            nomeCurso.Add(tbCurso.Text);

            agitacao.agitacao(nomeAluno);
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            tbAluno.Text = "";
            tbCurso.Text = "";
            tbExibe.Text = "";
        }

        private void btListar_Click(object sender, EventArgs e) {
            Agitacao agitacao = new Agitacao();
            tbExibe.Text = agitacao.exibir(nomeAluno);
        }
    }
}