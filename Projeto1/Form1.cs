using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        private int ID;
        public Form1(int controle)
        {
            InitializeComponent();
            if(controle == 2)
            {
                listView1.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
            }





        }

        private void UpdateListView()
        {

            listView1.Items.Clear();

            PerfilDisneyDAO perfilDisneyDAO = new PerfilDisneyDAO();
            List<PerfilDisney> perfils = perfilDisneyDAO.SelectPerfil();

            try
            {
                foreach (PerfilDisney perfil in perfils)
                {
                    ListViewItem lv = new ListViewItem(perfil.Id.ToString());
                    lv.SubItems.Add(perfil.CPF);
                    lv.SubItems.Add(perfil.TELEFONE);
                    lv.SubItems.Add(perfil.OPINIAO);
                    lv.SubItems.Add(perfil.OPINIAO2);
                    lv.SubItems.Add(perfil.FILMEPREFE);
                    lv.SubItems.Add(perfil.MUSICAPREFE);
                    lv.SubItems.Add(perfil.PERSONAGEMPREFE);
                    lv.SubItems.Add(perfil.DYSNEY);
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }




        }

        private bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }


        private void btnMickey_Click(object sender, EventArgs e)
        {
            try
            {
                PerfilDisney perfildisneyobjeto = new PerfilDisney(
                    mtxbCpf.Text,
                    mtxbNumber.Text,
                    txbNome.Text,
                    txbPront.Text,
                    txbQuest.Text,
                    txbMusic.Text,
                    txbPerson.Text,
                    txbDisney.Text
                    );

                PerfilDisneyDAO perfildysneyobjeto = new PerfilDisneyDAO();
                perfildysneyobjeto.InsertPerfil(perfildisneyobjeto);

                MessageBox.Show("Cadastrado com sucesso",
                 "AVISO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

            }
            catch(Exception error)    
            {
                MessageBox.Show(error.Message);
            }


            mtxbCpf.Clear();
            mtxbNumber.Clear();
            txbNome.Clear();
            txbPront.Clear();
            txbQuest.Clear();
            txbMusic.Clear();
            txbPerson.Clear();
            txbDisney.Clear();

            UpdateListView();

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

        private void txbMusic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                PerfilDisney perfildisneyobjeto = new PerfilDisney(
                    mtxbCpf.Text,
                    mtxbNumber.Text,
                    txbNome.Text,
                    txbPront.Text,
                    txbQuest.Text,
                    txbMusic.Text,
                    txbPerson.Text,
                    txbDisney.Text
                    );

                PerfilDisneyDAO perfildysneyobjeto = new PerfilDisneyDAO();
                perfildysneyobjeto.UpdatePerfil(perfildisneyobjeto);

                MessageBox.Show("Editado com sucesso",
                 "AVISO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            mtxbCpf.Clear();
            mtxbNumber.Clear();
            txbNome.Clear();
            txbPront.Clear();
            txbQuest.Clear();
            txbMusic.Clear();
            txbPerson.Clear();
            txbDisney.Clear();

            UpdateListView();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            ID = int.Parse(listView1.Items[index].SubItems[0].Text);
            mtxbCpf.Text = listView1.Items[index].SubItems[1].Text;
            mtxbNumber.Text = listView1.Items[index].SubItems[2].Text;
            txbNome.Text = listView1.Items[index].SubItems[3].Text;
            txbPront.Text = listView1.Items[index].SubItems[4].Text;
            txbQuest.Text = listView1.Items[index].SubItems[5].Text;
            txbMusic.Text = listView1.Items[index].SubItems[6].Text;
            txbPerson.Text = listView1.Items[index].SubItems[7].Text;
            txbDisney.Text = listView1.Items[index].SubItems[8].Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            PerfilDisneyDAO perfildisneyobjeto = new PerfilDisneyDAO();
            perfildisneyobjeto.DeletePerfil(ID);

                mtxbCpf.Clear();
                mtxbNumber.Clear();
                txbNome.Clear();
                txbPront.Clear();
                txbQuest.Clear();
                txbMusic.Clear();
                txbPerson.Clear();
                txbDisney.Clear();

                UpdateListView();

            MessageBox.Show("Deletado com sucesso",
             "AVISO",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);

        }

        private void mtxbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!IsCpf(mtxbCpf.Text))
            {
                MessageBox.Show("CPF inválido!!");
                mtxbCpf.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
