namespace metOrdenacao {
    partial class Frame {
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
        private void InitializeComponent() {
            this.cbMetodos = new System.Windows.Forms.ComboBox();
            this.btInfos = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tbNumeros = new System.Windows.Forms.TextBox();
            this.btTestarOrdenacao = new System.Windows.Forms.Button();
            this.tbInfos = new System.Windows.Forms.TextBox();
            this.tbDemo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTempoExec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMetodos
            // 
            this.cbMetodos.FormattingEnabled = true;
            this.cbMetodos.Items.AddRange(new object[] {
            "Bubble sort",
            "Selection sort",
            "Insertion sort",
            "Cocktail sort",
            "Comb sort",
            "Shell sort",
            "Quick sort",
            "Heap sort"});
            this.cbMetodos.Location = new System.Drawing.Point(24, 25);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(212, 23);
            this.cbMetodos.TabIndex = 0;
            this.cbMetodos.Text = "Selecione o método de ordenação";
            // 
            // btInfos
            // 
            this.btInfos.Location = new System.Drawing.Point(253, 25);
            this.btInfos.Name = "btInfos";
            this.btInfos.Size = new System.Drawing.Size(75, 23);
            this.btInfos.TabIndex = 1;
            this.btInfos.Text = "Exibir Infos";
            this.btInfos.UseVisualStyleBackColor = true;
            this.btInfos.Click += new System.EventHandler(this.btInfos_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(334, 25);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // tbNumeros
            // 
            this.tbNumeros.Location = new System.Drawing.Point(627, 27);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(92, 23);
            this.tbNumeros.TabIndex = 3;
            this.tbNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btTestarOrdenacao
            // 
            this.btTestarOrdenacao.Location = new System.Drawing.Point(734, 27);
            this.btTestarOrdenacao.Name = "btTestarOrdenacao";
            this.btTestarOrdenacao.Size = new System.Drawing.Size(75, 23);
            this.btTestarOrdenacao.TabIndex = 4;
            this.btTestarOrdenacao.Text = "Testar";
            this.btTestarOrdenacao.UseVisualStyleBackColor = true;
            this.btTestarOrdenacao.Click += new System.EventHandler(this.btTestarOrdenacao_Click);
            // 
            // tbInfos
            // 
            this.tbInfos.Location = new System.Drawing.Point(24, 101);
            this.tbInfos.Multiline = true;
            this.tbInfos.Name = "tbInfos";
            this.tbInfos.ReadOnly = true;
            this.tbInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfos.Size = new System.Drawing.Size(383, 267);
            this.tbInfos.TabIndex = 5;
            // 
            // tbDemo
            // 
            this.tbDemo.Location = new System.Drawing.Point(428, 101);
            this.tbDemo.Multiline = true;
            this.tbDemo.Name = "tbDemo";
            this.tbDemo.ReadOnly = true;
            this.tbDemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDemo.Size = new System.Drawing.Size(386, 233);
            this.tbDemo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informações sobre o método de ordenação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Demonstração do método de ordenação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade de números para testar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "O tempo que o método levou para ordenar foi de";
            // 
            // tbTempoExec
            // 
            this.tbTempoExec.Location = new System.Drawing.Point(701, 345);
            this.tbTempoExec.Name = "tbTempoExec";
            this.tbTempoExec.ReadOnly = true;
            this.tbTempoExec.Size = new System.Drawing.Size(79, 23);
            this.tbTempoExec.TabIndex = 11;
            this.tbTempoExec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(786, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "ms";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTempoExec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDemo);
            this.Controls.Add(this.tbInfos);
            this.Controls.Add(this.btTestarOrdenacao);
            this.Controls.Add(this.tbNumeros);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btInfos);
            this.Controls.Add(this.cbMetodos);
            this.Name = "Frame";
            this.Text = "Métodos de Ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbMetodos;
        private Button btInfos;
        private Button btLimpar;
        private TextBox tbNumeros;
        private Button btTestarOrdenacao;
        private TextBox tbInfos;
        private TextBox tbDemo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTempoExec;
        private Label label5;
    }
}