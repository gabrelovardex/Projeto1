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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // se passar 1 gestão total, 2 apenas cadastro 
            Form1 form1 = new Form1 (2);
            form1.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Form2 perfildisneyobjeto = new PerfilDisneyDAO();
            //perfildisneyobjeto.DeletePerfil(ID);

            //txbUsuario.clear();
            //txbSenha.clear();

            //UpdateListView();

            //MessageBox.Show("Deletado com sucesso",
            // "AVISO",
            // MessageBoxButtons.OK,
            // MessageBoxIcon.Information);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Text;
            string senha = txbSenha.Text;

            PerfilDisneyDAO perfil = new PerfilDisneyDAO();

            if(perfil.LoginPerfil(usuario, senha))
            {
                Form1 form1 = new Form1(1);
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique os dados inseridos!",
                    "ERROU!!!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
