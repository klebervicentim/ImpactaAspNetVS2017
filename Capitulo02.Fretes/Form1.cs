using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo02.Fretes
{
    public partial class fretesForm : Form
    {
        public fretesForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Calcular();
            }
        }

        private bool ValidarFormulario()
        {
            if (clienteTextBox.Text == string.Empty)
            {
                MessageBox.Show("O campo Cliente é obrigatório.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (valorTextBox.Text == string.Empty)
            {
                MessageBox.Show("O campo VALOR é obrigatório.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(valorTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("O campo VALOR não está preenchido corretamente.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return false;
                }
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o estado",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text);

            switch (ufComboBox.Text.ToUpper())
            {
                case "AM":
                    percentual = 0.6m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "RJ":
                    percentual = 0.3m;
                    break;
                case "SP":
                    percentual = 0.2m;
                    break;
                default:
                    percentual = 0.75m;
                    return;
            }
            freteTextBox.Text = percentual.ToString("p2");
            resultadoTextBox.Text = (valor * (1 + percentual)).ToString("c");
        }
    }
}
