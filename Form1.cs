using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButton08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btrezerviraj_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb1.AppendText("Odabrali ste: \r\n");

            if (rbautobus.Checked)
            {
                tb1.AppendText("Autobus \r\n");
            }
            if (rbavion.Checked)
            {
                tb1.AppendText("Avion \r\n");
            }
            if (rbvlastit.Checked)
            {
                tb1.AppendText("Vlastit prijevoz \r\n");
            }
        }
    }
}
