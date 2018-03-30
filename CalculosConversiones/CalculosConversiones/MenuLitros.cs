using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Litros_Galones
{
    public partial class MenuLitros : Form
    {
        double Vlitros, Vgalones, result1, result2;
        public MenuLitros()
        {
            InitializeComponent();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            Vlitros = double.Parse(TXTlitros.Text);
            result1 = Vlitros * 0.26417205 / 1;
            TXTresultado1.Text = result1.ToString();

            Vgalones = double.Parse(TXTgalones.Text);
            result2 = Vgalones * 3.78541178 / 1;
            TXTresultado2.Text = result2.ToString();

        }
    }
}
