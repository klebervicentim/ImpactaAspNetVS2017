using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritimeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;

            resultadoListBox.Items.Add("a = " + a.ToString());
            resultadoListBox.Items.Add("b = " + b.ToString());
            resultadoListBox.Items.Add("c = " + c.ToString());
            resultadoListBox.Items.Add("d = " + d.ToString());

            resultadoListBox.Items.Add(new string('-',100));

            resultadoListBox.Items.Add("c vezes d = " + (c*d));
            resultadoListBox.Items.Add("c dividido a = " + (c/a));
            resultadoListBox.Items.Add("d mod de a = " + (d % a));
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x é :" + x);

            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("x é :" + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;

            resultadoListBox.Items.Add("Exemplo de pre incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + ++a = " + (2 + ++a));
            resultadoListBox.Items.Add("2 = " + a);

            a = 5;

            resultadoListBox.Items.Add("Exemplo de pos incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + a++ = " + (2 + a++));
            resultadoListBox.Items.Add("2 = " + a);
    }

        private void booleanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

            resultadoListBox.Items.Add("w é menor que x? " + (_w <= _x));
            resultadoListBox.Items.Add("x é igual a z? " + (_x == _z));
            resultadoListBox.Items.Add("x é diferente a z? " + (_x != _z));
        }

       

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();
            resultadoListBox.Items.Add("w <= x || y == 16 =" + (_w <= _x || _y == 16));
            resultadoListBox.Items.Add("x == z && z != x =" + (_x == _z && _z != _x));
            resultadoListBox.Items.Add("! (y é maior que w?) = " + (!(_y > _w)));

        }

        private void MostrarVariaveis()
        {
            resultadoListBox.Items.Add("x = " + _x.ToString());
            resultadoListBox.Items.Add("w = " + _w.ToString());
            resultadoListBox.Items.Add("y = " + _y.ToString());
            resultadoListBox.Items.Add("z = " + _z.ToString());
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
            ano = 2016;
            resultadoListBox.Items.Add("ano = " + ano);
            resultadoListBox.Items.Add(String.Format("O ano {0} é bissexto? {1} ",ano,(ano%4 == 0?"SIM":"NÃO")));

     
            ano = 2014;
            resultadoListBox.Items.Add("ano = " + ano);
            resultadoListBox.Items.Add(String.Format("O ano {0} é bissexto? {1} ", ano, (DateTime.IsLeapYear(ano)? "SIM" : "NÃO")));
        }
    }
}
