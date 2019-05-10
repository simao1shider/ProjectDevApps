using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Home : Form
    {
        private DateTime contadorTempo;

        public Home()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToLongTimeString();

        }
    }
}
