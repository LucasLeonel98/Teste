namespace CalculadoraJuros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtVp = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtVf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVf = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorFinalJurosComp = new System.Windows.Forms.TextBox();
            this.txtTaxaJurosComp = new System.Windows.Forms.TextBox();
            this.txtTempoJurosComp = new System.Windows.Forms.TextBox();
            this.txtCapitalJuosComp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCalcularJurosComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVp
            // 
            this.txtVp.Location = new System.Drawing.Point(178, 39);
            this.txtVp.Name = "txtVp";
            this.txtVp.Size = new System.Drawing.Size(100, 20);
            this.txtVp.TabIndex = 0;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(178, 86);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 1;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(178, 123);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(100, 20);
            this.txtTaxa.TabIndex = 2;
            // 
            // txtVf
            // 
            this.txtVf.Location = new System.Drawing.Point(178, 169);
            this.txtVf.Name = "txtVf";
            this.txtVf.Size = new System.Drawing.Size(100, 20);
            this.txtVf.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor de Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tempo(Meses)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taxa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "VC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVf
            // 
            this.btnVf.Location = new System.Drawing.Point(341, 169);
            this.btnVf.Name = "btnVf";
            this.btnVf.Size = new System.Drawing.Size(75, 20);
            this.btnVf.TabIndex = 9;
            this.btnVf.Text = "VF";
            this.btnVf.UseVisualStyleBackColor = true;
            this.btnVf.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Taxa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 11;
            this.button4.Text = "Tempo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Para calcular o Valor de Capital informe o Valor Final, Tempo e Taxa.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Para calcular o Valor Final informe o Capital, Tempo e Taxa.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Para calcular a Taxa de juros informe o Capital, Tempo e Valor Final.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Para calcular o Tempo  informe o Capital, Valor Final e Taxa.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Juros Simples";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Valor Final";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Taxa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tempo(Meses)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Valor de Capital";
            // 
            // txtValorFinalJurosComp
            // 
            this.txtValorFinalJurosComp.Location = new System.Drawing.Point(168, 399);
            this.txtValorFinalJurosComp.Name = "txtValorFinalJurosComp";
            this.txtValorFinalJurosComp.Size = new System.Drawing.Size(100, 20);
            this.txtValorFinalJurosComp.TabIndex = 20;
            // 
            // txtTaxaJurosComp
            // 
            this.txtTaxaJurosComp.Location = new System.Drawing.Point(168, 353);
            this.txtTaxaJurosComp.Name = "txtTaxaJurosComp";
            this.txtTaxaJurosComp.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaJurosComp.TabIndex = 19;
            // 
            // txtTempoJurosComp
            // 
            this.txtTempoJurosComp.Location = new System.Drawing.Point(168, 316);
            this.txtTempoJurosComp.Name = "txtTempoJurosComp";
            this.txtTempoJurosComp.Size = new System.Drawing.Size(100, 20);
            this.txtTempoJurosComp.TabIndex = 18;
            // 
            // txtCapitalJuosComp
            // 
            this.txtCapitalJuosComp.Location = new System.Drawing.Point(168, 269);
            this.txtCapitalJuosComp.Name = "txtCapitalJuosComp";
            this.txtCapitalJuosComp.Size = new System.Drawing.Size(100, 20);
            this.txtCapitalJuosComp.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(418, 359);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(289, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Para calcular o Valor Final informe o Capital, Tempo e Taxa.";
            // 
            // btnCalcularJurosComp
            // 
            this.btnCalcularJurosComp.Location = new System.Drawing.Point(337, 352);
            this.btnCalcularJurosComp.Name = "btnCalcularJurosComp";
            this.btnCalcularJurosComp.Size = new System.Drawing.Size(75, 20);
            this.btnCalcularJurosComp.TabIndex = 26;
            this.btnCalcularJurosComp.Text = "Calcular Total";
            this.btnCalcularJurosComp.UseVisualStyleBackColor = true;
            this.btnCalcularJurosComp.Click += new System.EventHandler(this.btnCalcularJurosComp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCalcularJurosComp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValorFinalJurosComp);
            this.Controls.Add(this.txtTaxaJurosComp);
            this.Controls.Add(this.txtTempoJurosComp);
            this.Controls.Add(this.txtCapitalJuosComp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVf);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtVp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVp;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtVf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorFinalJurosComp;
        private System.Windows.Forms.TextBox txtTaxaJurosComp;
        private System.Windows.Forms.TextBox txtTempoJurosComp;
        private System.Windows.Forms.TextBox txtCapitalJuosComp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCalcularJurosComp;
    }
}

