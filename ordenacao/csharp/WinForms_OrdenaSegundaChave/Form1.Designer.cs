namespace WinForms_OrdenaSegundaChave {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbQtdDados = new System.Windows.Forms.TextBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.btAbrirArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDadosGerados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAplicarAlgoritmo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbConsole = new System.Windows.Forms.Label();
            this.pnAlgoritmo = new System.Windows.Forms.Panel();
            this.fdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnAlgoritmo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de dados";
            // 
            // tbQtdDados
            // 
            this.tbQtdDados.Location = new System.Drawing.Point(164, 23);
            this.tbQtdDados.Name = "tbQtdDados";
            this.tbQtdDados.Size = new System.Drawing.Size(120, 23);
            this.tbQtdDados.TabIndex = 1;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(27, 61);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(120, 23);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // btAbrirArquivo
            // 
            this.btAbrirArquivo.Location = new System.Drawing.Point(164, 61);
            this.btAbrirArquivo.Name = "btAbrirArquivo";
            this.btAbrirArquivo.Size = new System.Drawing.Size(120, 23);
            this.btAbrirArquivo.TabIndex = 3;
            this.btAbrirArquivo.Text = "Abrir arquivo";
            this.btAbrirArquivo.UseVisualStyleBackColor = true;
            this.btAbrirArquivo.Click += new System.EventHandler(this.btAbrirArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dados gerados ou carregados";
            // 
            // tbDadosGerados
            // 
            this.tbDadosGerados.Location = new System.Drawing.Point(27, 139);
            this.tbDadosGerados.Multiline = true;
            this.tbDadosGerados.Name = "tbDadosGerados";
            this.tbDadosGerados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDadosGerados.Size = new System.Drawing.Size(257, 283);
            this.tbDadosGerados.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algoritmo de ordenação";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 23);
            this.textBox1.TabIndex = 7;
            // 
            // btAplicarAlgoritmo
            // 
            this.btAplicarAlgoritmo.Location = new System.Drawing.Point(24, 60);
            this.btAplicarAlgoritmo.Name = "btAplicarAlgoritmo";
            this.btAplicarAlgoritmo.Size = new System.Drawing.Size(120, 23);
            this.btAplicarAlgoritmo.TabIndex = 8;
            this.btAplicarAlgoritmo.Text = "Aplicar";
            this.btAplicarAlgoritmo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(325, 283);
            this.textBox2.TabIndex = 10;
            // 
            // tbConsole
            // 
            this.tbConsole.AutoSize = true;
            this.tbConsole.Location = new System.Drawing.Point(24, 108);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(118, 15);
            this.tbConsole.TabIndex = 9;
            this.tbConsole.Text = "Console de respostas";
            // 
            // pnAlgoritmo
            // 
            this.pnAlgoritmo.Controls.Add(this.btAplicarAlgoritmo);
            this.pnAlgoritmo.Controls.Add(this.textBox2);
            this.pnAlgoritmo.Controls.Add(this.label3);
            this.pnAlgoritmo.Controls.Add(this.tbConsole);
            this.pnAlgoritmo.Controls.Add(this.textBox1);
            this.pnAlgoritmo.Enabled = false;
            this.pnAlgoritmo.Location = new System.Drawing.Point(302, 1);
            this.pnAlgoritmo.Name = "pnAlgoritmo";
            this.pnAlgoritmo.Size = new System.Drawing.Size(372, 450);
            this.pnAlgoritmo.TabIndex = 11;
            // 
            // fdFileDialog
            // 
            this.fdFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.pnAlgoritmo);
            this.Controls.Add(this.tbDadosGerados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAbrirArquivo);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.tbQtdDados);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ordenação de 2ª Fase";
            this.pnAlgoritmo.ResumeLayout(false);
            this.pnAlgoritmo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbQtdDados;
        private Button btGerar;
        private Button btAbrirArquivo;
        private Label label2;
        private TextBox tbDadosGerados;
        private Label label3;
        private TextBox textBox1;
        private Button btAplicarAlgoritmo;
        private TextBox textBox2;
        private Label tbConsole;
        private Panel pnAlgoritmo;
        private OpenFileDialog fdFileDialog;
    }
}