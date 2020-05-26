using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpaceStatistics.GraphPackage.GraphForm
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("GRLC.DRGR");
            rnd = new Random();
        }
        Random rnd;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Thread.Sleep(rnd.Next(1000, 2000));
            pictureBox1.Image = Image.FromFile("GRLC.DRGR");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Thread.Sleep(rnd.Next(1000, 2000));
            pictureBox1.Image = Image.FromFile("GRPCU.DRGR");
        }
    }
}
