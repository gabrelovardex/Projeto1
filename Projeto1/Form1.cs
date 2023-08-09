using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMickey_Click(object sender, EventArgs e)
        {
            string name = txbNome.Text;
            string enrollment = txbPront.Text;

            string message = "Nome: " + name +
                             "\nOpnião: " + enrollment;
            MessageBox.Show(
                message,
                "Disney",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                 );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
