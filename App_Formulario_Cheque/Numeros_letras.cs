using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Formulario_Cheque
{
    public partial class Numeros_letras : Form
    {
        public Numeros_letras()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (int.TryParse(this.textBox1.Text, out int num))
                {
                    //TODO: asignar cada entero al vector 
                    this.labLetras.Text = Clases.NumerosLetras.getLetras(num);
                    this.textBox1.Text = "";
                }
            }
        }
    }
}
