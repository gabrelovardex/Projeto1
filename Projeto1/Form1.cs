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
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {

            listView1.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM disney_quiz";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    ID = (int)(dr["ID"]);
                    string cpf = (string)dr["CPF"];
                    string number = (string)dr["TELEFONE"];
                    string name = (string)dr["OPINIAO"];
                    string enrollment = (string)dr["OPINIAO2"];
                    string answer = (string)dr["FILMEPREFE"];
                    string music = (string)dr["MUSICAPREFE"];
                    string person = (string)dr["PERSONAGEMPREFE"];
                    string disney = (string)dr["DYSNEY"];

                    ListViewItem lv = new ListViewItem(ID.ToString());
                    lv.SubItems.Add(cpf);
                    lv.SubItems.Add(number);
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(enrollment);
                    lv.SubItems.Add(answer);
                    lv.SubItems.Add(music);
                    lv.SubItems.Add(person);
                    lv.SubItems.Add(disney);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }



        }


        private void btnMickey_Click(object sender, EventArgs e)
        {
            //string name = txbNome.Text;
            //string enrollment = txbPront.Text;
            //string answer =txbQuest.Text;
            //string music = txbMusic.Text;   
            //string person = txbPerson.Text;
            //string disney = txbDisney.Text;
            //string cpf = mtxbCpf.Text;
            //string number = mtxbNumber.Text;

            //string message = "\nNome: " + name +
            //                 "\nOpnião: " + enrollment +
            //                 "\nResposta: " + answer +
            //                 "\nMúsica: " + music +
            //                 "\nPersonagem: " + person +
            //                 "\nOpnião: " + disney +
            //                 "\nCPF: " + cpf +
            //                 "\nNUMER O:" + number;




            //MessageBox.Show(
            //    message,
            //    "QUIZ: ",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //     );

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO disney_quiz VALUES 
            (@CPF, @TELEFONE, @OPINIAO, @OPINIAO2, @FILMEPREFE, @MUSICAPREFE, @PERSONAGEMPREFE, @DYSNEY)";

            sqlCommand.Parameters.AddWithValue("@CPF", mtxbCpf.Text);
            sqlCommand.Parameters.AddWithValue("@TELEFONE", mtxbNumber.Text);
            sqlCommand.Parameters.AddWithValue("@OPINIAO", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@OPINIAO2", txbPront.Text);
            sqlCommand.Parameters.AddWithValue("@FILMEPREFE", txbQuest.Text);
            sqlCommand.Parameters.AddWithValue("@MUSICAPREFE", txbMusic.Text);
            sqlCommand.Parameters.AddWithValue("@PERSONAGEMPREFE", txbPerson.Text);
            sqlCommand.Parameters.AddWithValue("@DYSNEY", txbDisney.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
             "AVISO",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);

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
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE disney_quiz SET
             CPF = @CPF, 
             TELEFONE = @TELEFONE, 
             OPINIAO = @OPINIAO, 
             OPINIAO2 = @OPINIAO2, 
             FILMEPREFE = @FILMEPREFE, 
             MUSICAPREFE = @MUSICAPREFE, 
             PERSONAGEMPREFE = @PERSONAGEMPREFE, 
             DYSNEY = @DYSNEY
             WHERE ID = @ID";

            sqlCommand.Parameters.AddWithValue("@CPF", mtxbCpf.Text);
            sqlCommand.Parameters.AddWithValue("@TELEFONE", mtxbNumber.Text);
            sqlCommand.Parameters.AddWithValue("@OPINIAO", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@OPINIAO2", txbPront.Text);
            sqlCommand.Parameters.AddWithValue("@FILMEPREFE", txbQuest.Text);
            sqlCommand.Parameters.AddWithValue("@MUSICAPREFE", txbMusic.Text);
            sqlCommand.Parameters.AddWithValue("@PERSONAGEMPREFE", txbPerson.Text);
            sqlCommand.Parameters.AddWithValue("@DYSNEY", txbDisney.Text);
            sqlCommand.Parameters.AddWithValue("@ID", ID);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Editado com sucesso",
             "AVISO",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);

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

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM disney_quiz WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
                
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
        }
    }
}
