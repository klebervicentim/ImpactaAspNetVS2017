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

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago= Convert.ToDecimal(valorPagoTextBox.Text);

            decimal troco = valorPago - valorCompra ;

            trocoTextBox.Text = troco.ToString("c");

            var moedas = new decimal[6] {1, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m};

            for (int i = 0; i < 6; i++)
            {
                var quantidadedeMoedas = (int)(troco / moedas[i]);
                troco %= moedas[i];
                moedasListView.Items[i].Text = quantidadedeMoedas.ToString();
            }

        }
    }
}
