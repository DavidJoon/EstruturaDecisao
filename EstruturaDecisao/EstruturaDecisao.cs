using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDecisao
{
    public partial class EstruturaDecisao : Form
    {
        public EstruturaDecisao()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int num01 = Convert.ToInt32(numericUpDown1.Value);
            int num02 = Convert.ToInt32(numericUpDown2.Value);
            int num03 = Convert.ToInt32(numericUpDown3.Value);
            int maior;

            if (num01 == num02 && num02 == num03) {
                labelResultado.Text = "Valores são iguais.";
                return;
            }

            if (num01 == num03 && num01 > num02 && num03 > num02)
            {
                labelResultado.Text = "Valores " + num01 + " e " + num03 + " são maiores.";
                return;
            }

            if (num02 == num03 && num02 > num01 && num03 > num01)
            {
                labelResultado.Text = "Valores " + num02 + " e " + num03 + " são maiores.";
                return;
            }

            if (num01 == num02 && num01 > num03 && num02 > num03)
            {
                labelResultado.Text = "Valores " + num01 + " e " + num02 + " são maiores.";
                return;
            }

            if (num01 > num02 && num01 > num03)
            {
                maior = num01;

            }else if(num02 > num01 && num02 > num03)
            {
                maior = num02;
            }else{
                maior = num03;
            }
            labelResultado.Text = "O número " + maior + " é o maior.";
        }
    }
}
