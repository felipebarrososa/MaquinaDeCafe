using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaquinaDeCafe;


namespace MaquinaDeCafe
{

    public partial class frm_MaquinaCafe : Form
    {
        
        public frm_MaquinaCafe()
        {
           InitializeComponent();
        }

             

        private void btn_UmCentavo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A moeda não pode ser usada nessa Maquina", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void btn_CincoCentavos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A moeda não pode ser usada nessa Maquina", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_DezCentavos_Click(object sender, EventArgs e)
        {
            decimal ValorInformado = Convert.ToDecimal(txt_ValorInformado.Text + 0);
            float ValorMoeda = 0.10F;
            ValorInformado = Convert.ToDecimal(ValorInformado + Convert.ToDecimal(ValorMoeda));
            txt_ValorInformado.Text = string.Format("{0:#,##0.00}", ValorInformado);
        }
        private void btn_VintecincoCentavos_Click(object sender, EventArgs e)
        {
            decimal ValorInformado = Convert.ToDecimal(txt_ValorInformado.Text + 0);
            float ValorMoeda = 0.25F;
            ValorInformado = Convert.ToDecimal(ValorInformado + Convert.ToDecimal(ValorMoeda));
            txt_ValorInformado.Text = string.Format("{0:#,##0.00}", ValorInformado);

        }
        
        private void btn_CinquentaCentavos_Click(object sender, EventArgs e)
        {
            decimal ValorInformado = Convert.ToDecimal(txt_ValorInformado.Text + 0);
            float ValorMoeda = 0.50F;
            ValorInformado = Convert.ToDecimal(ValorInformado + Convert.ToDecimal(ValorMoeda));
            txt_ValorInformado.Text = string.Format("{0:#,##0.00}", ValorInformado);
        }

        private void btn_UmReal_Click(object sender, EventArgs e)
        {
            decimal ValorInformado = Convert.ToDecimal(txt_ValorInformado.Text + 0);
            float ValorMoeda = 1.00F;
            ValorInformado = Convert.ToDecimal(ValorInformado + Convert.ToDecimal(ValorMoeda));
            txt_ValorInformado.Text = string.Format("{0:#,##0.00}", ValorInformado);
        }

        public void btn_Cappuccino_Click(object sender, EventArgs e)
        {

            float ValorCafe = 3.50F;        
            
            txt_ValorCafe.Text = string.Format("{0:#,##0.00}", ValorCafe);

        }
        public void btn_Mocha_Click(object sender, EventArgs e)
        {

            float ValorCafe = 4.00F;

            txt_ValorCafe.Text = string.Format("{0:#,##0.00}", ValorCafe);

        }
        public void btn_CafeCLeite_Click(object sender, EventArgs e)
        {

            float ValorCafe = 3.00F;

            txt_ValorCafe.Text = string.Format("{0:#,##0.00}", ValorCafe);

        }

        // função para calcular o troco e a quantidades dividido por cada moeda
        public String calculaTroco(double valorInserido, double valorCafe)
        {
            valorInserido = Convert.ToDouble(txt_ValorInformado.Text);
            valorCafe = Convert.ToDouble(txt_ValorCafe.Text);
            int[] real = { 1 };
            int[] moedas = { 50, 25, 10, 5, 1 };
            String resultado;
            double troco;
            int i, valor, contador;

            troco = valorInserido - valorCafe;
            resultado = "\n Retire Seu Café\n" + " Troco = R$   " + troco + "\n\n";
            // definindo do troco (parte inteira)
            valor = (int)troco;
            i = 0; while (valor != 0)
            {
                contador = valor / real[i];
                // calculando a qtde de moedas de Um real
                if (contador != 0)
                {
                    resultado = resultado + (contador + " Moedas(s) de R$" + real[i] + "\n");
                    valor = valor % real[i];
                    // sobra
                }
                i = i + 1;
                // próxima moeda
            }
            resultado = resultado + "\n";
            // definindo os centavos do troco (parte fracionária)

            valor = (int)Math.Round((troco - (int)troco) * 100);
            i = 0;
            while (valor != 0)
            {
                contador = valor / moedas[i];
                // calculando a qtde de moedas
                if (contador != 0)
                {
                    resultado = resultado + (contador + " moeda(s) de " + moedas[i] + " centavo(s)\n");
                    valor = valor % moedas[i];
                    // sobra
                }
                i = i + 1;
                // próximo centavo
            }
            MessageBox.Show(resultado);
            return (resultado);
        }

        //Comando colocado dentro de um botão////



        private void btn_TirarCafé_Click(object sender, EventArgs e)         
	    {
            if (Convert.ToDecimal(txt_ValorCafe.Text) > Convert.ToDecimal(txt_ValorInformado.Text))
            {
                MessageBox.Show("O Valor Informado é Insuficiente para Adquirir esse Café", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else if (Convert.ToDecimal(txt_ValorCafe.Text) == 0)
            {
                MessageBox.Show("Por Favor selecione um Café", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               calculaTroco(Convert.ToDouble(txt_ValorInformado.Text), Convert.ToDouble(txt_ValorCafe.Text));
            }                    
                
            
            
        }

        
    }
}


