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
            string answer =txbQuest.Text;
            string music = txbMusic.Text;   
            string person = txbPerson.Text;
            string disney = txbDisney.Text;
            string cpf = mtxbCpf.Text;
            string number = mtxbNumber.Text;

            string message = "\nNome: " + name +
                             "\nOpnião: " + enrollment +
                             "\nResposta: " + answer +
                             "\nMúsica: " + music +
                             "\nPersonagem: " + person +
                             "\nOpnião: " + disney +
                             "\nCPF: " + cpf +
                             "\nNUMER O:" + number;




            MessageBox.Show(
                message,
                "QUIZ: ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                 );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblperson_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisney_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
