using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void valorPagoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            decimal troco = valorPago - valorCompra;


            //Isso é coisa minha
            if (troco<=0)
            {
                naoHaTrocoLabel.Text = "NÃO HÁ TROCO";
                naoHaTrocoLabel.Visible = true;
            }

            trocoTextBox.Text = troco.ToString("c");

            //ToDo: refatorar para usar estrutura de repetição

            int moedas100 = 0, moedas50 = 0, moedas25 = 0, moedas10 = 0, moedas5 = 0, moedas1 = 0;

            moedas100 = (int)troco;
            troco %= 1;

            moedas50 = (int)(troco/0.5m);
            troco %= 0.5m;

            moedas25 = (int)(troco / 0.25m);
            troco %= 0.25m;

            moedas10 = (int)(troco / 0.1m);
            troco %= 0.1m;

            moedas5 = (int)(troco / 0.05m);
            troco %= 0.05m;

            moedas1 = (int)(troco / 0.01m);
            troco %= 0.01m;

            moedasListView.Items[0].Text = Convert.ToString(moedas100);
            moedasListView.Items[1].Text = Convert.ToString(moedas50);
            moedasListView.Items[2].Text = Convert.ToString(moedas25);
            moedasListView.Items[3].Text = Convert.ToString(moedas10);
            moedasListView.Items[4].Text = Convert.ToString(moedas5);
            moedasListView.Items[5].Text = Convert.ToString(moedas1);
        }
    }
}
