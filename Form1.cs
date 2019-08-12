using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class Form1 : Form
    {
        FuncaoCalc calculadora = new FuncaoCalc();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão Valor Final
            if (txtVp.Text.Length == 0 || txtTaxa.Text.Length == 0 || txtTempo.Text.Length == 0)
            {
                MessageBox.Show("Erro Campos não preenchidos, somente o campo valor final deve ficar vazio, Tente novamente !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double valorVp = double.Parse(txtVp.Text);
                int valorNper = int.Parse(txtTempo.Text);
                double valorTaxa = double.Parse(txtTaxa.Text);

                txtVf.Text =String.Format("{0:0.00}", calculadora.CalcularVf(valorVp, valorNper, valorTaxa));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botão Taxa 

            if (txtVp.Text.Length == 0 || txtVf.Text.Length == 0 || txtTempo.Text.Length == 0)
            {
                MessageBox.Show("Erro Campos não preenchidos, somente o campo Taxa deve ficar vazio, Tente novamente !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double valorVp = double.Parse(txtVp.Text);
                int valorNper = int.Parse(txtTempo.Text);
                double valorFinal = double.Parse(txtVf.Text);

                txtTaxa.Text = calculadora.CalcularTaxa(valorVp, valorNper, valorFinal).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Botão Tempo

            if (txtVp.Text.Length == 0 || txtVf.Text.Length == 0 || txtTaxa.Text.Length == 0)
            {
                MessageBox.Show("Erro Campos não preenchidos, somente o campo Tempo(Meses) deve ficar vazio, Tente novamente !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                double valorVp = double.Parse(txtVp.Text);
                double taxa = double.Parse(txtTaxa.Text);
                double valorFinal = double.Parse(txtVf.Text);

                txtTempo.Text = calculadora.CalcularTempo(valorVp, taxa, valorFinal).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botão Valor Capital

            if (txtTempo.Text.Length == 0 || txtVf.Text.Length == 0 || txtTaxa.Text.Length == 0)
            {
                MessageBox.Show("Erro Campos não preenchidos, somente o campo Valor de Capital deve ficar vazio, Tente novamente !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                double valorTempo = double.Parse(txtTempo.Text);
                double taxa = double.Parse(txtTaxa.Text);
                double valorFinal = double.Parse(txtVf.Text);

                txtVp.Text = calculadora.CalcularValorCapital(valorTempo, taxa, valorFinal).ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularJurosComp_Click(object sender, EventArgs e)
        {
            // Botão Valor Final Juros Compostos
            if (txtCapitalJuosComp.Text.Length == 0 || txtTaxaJurosComp.Text.Length == 0 || txtTempoJurosComp.Text.Length == 0)
            {
                MessageBox.Show("Erro Campos não preenchidos, somente o campo valor final deve ficar vazio, Tente novamente !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double valorVp = double.Parse(txtCapitalJuosComp.Text);
                int valorNper = int.Parse(txtTempoJurosComp.Text);
                double valorTaxa = double.Parse(txtTaxaJurosComp.Text);
                
                txtValorFinalJurosComp.Text = String.Format("{0:0.00}", calculadora.CalcularValorFinalComposto(valorVp, valorNper, valorTaxa));
            }
            
        }
    }
}
