namespace pesquisaDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = tb_pesquisa.Text;
            int contador = 0;
            tb_areaTexto.Text = ToString();
            string sequencia;
            for (int i = 0; !texto.Equals("") && i <= tb_areaTexto.TextLength - texto.Length; i++)
            {
                sequencia = tb_areaTexto.SUBSTRING(i, i  + texto.Length);
                if (texto.Equals(sequencia, StringComparison.OrdinalIgnoreCase))
                {
                    contador++;
                    Console.WriteLine(texto);
                    tb_areaTexto.Replace(texto.ToUpper(), i, i + texto.Length); 
                }
                tb_localizado.Text = "" + contador;
            }
        }
    }
}