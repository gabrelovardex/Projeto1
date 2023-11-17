using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    internal class PerfilDisneyDAO
    {

        public bool LoginPerfil(string usuario, string senha)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM disney_quiz WHERE" + 
                "USUARIO = @usuario AND SENHA = @senha";

            sqlCom.Parameters.AddWithValue("@usuario", usuario);
            sqlCom.Parameters.AddWithValue("@senha",senha);

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    return true;
                }

                dr.Close();
                return false;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }


        }
        public List<PerfilDisney> SelectPerfil()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM dysney_quiz";

            List<PerfilDisney> perfils = new List<PerfilDisney>(); 
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    PerfilDisney objeto = new PerfilDisney(
                    (int)(dr["ID"]),
                    (string)dr["CPF"],
                    (string)dr["TELEFONE"],
                    (string)dr["OPINIAO"],
                    (string)dr["OPINIAO2"],
                    (string)dr["FILMEPREFE"],
                    (string)dr["MUSICAPREFE"],
                    (string)dr["PERSONAGEMPREFE"],
                    (string)dr["DYSNEY"],
                    (string)dr["USUARIO"],
                    (string)dr["SENHA"]
                    );

                    perfils.Add(objeto);


                }
                dr.Close();
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }

            return perfils;

        }
        public void UpdatePerfil(PerfilDisney perfil)
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
             USUARIO = @usuario
             SENHA = @senha
             WHERE ID = @ID";

            sqlCommand.Parameters.AddWithValue("@CPF", perfil.CPF);
            sqlCommand.Parameters.AddWithValue("@TELEFONE", perfil.TELEFONE);
            sqlCommand.Parameters.AddWithValue("@OPINIAO", perfil.OPINIAO);
            sqlCommand.Parameters.AddWithValue("@OPINIAO2", perfil.OPINIAO2);
            sqlCommand.Parameters.AddWithValue("@FILMEPREFE", perfil.FILMEPREFE);
            sqlCommand.Parameters.AddWithValue("@MUSICAPREFE", perfil.MUSICAPREFE);
            sqlCommand.Parameters.AddWithValue("@PERSONAGEMPREFE", perfil.PERSONAGEMPREFE);
            sqlCommand.Parameters.AddWithValue("@DYSNEY", perfil.DYSNEY);
            sqlCommand.Parameters.AddWithValue("@usuario", perfil.USUARIO);
            sqlCommand.Parameters.AddWithValue("@senha", perfil.SENHA);
            sqlCommand.Parameters.AddWithValue("@ID", perfil.Id);

            sqlCommand.ExecuteNonQuery();
        }


        public void InsertPerfil(PerfilDisney perfil)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO disney_quiz VALUES 
            (@CPF, @TELEFONE, @OPINIAO, @OPINIAO2, @FILMEPREFE, @MUSICAPREFE, @PERSONAGEMPREFE, @DYSNEY)";

            sqlCommand.Parameters.AddWithValue("@CPF", perfil.CPF);
            sqlCommand.Parameters.AddWithValue("@TELEFONE", perfil.TELEFONE);
            sqlCommand.Parameters.AddWithValue("@OPINIAO", perfil.OPINIAO);
            sqlCommand.Parameters.AddWithValue("@OPINIAO2", perfil.OPINIAO2);
            sqlCommand.Parameters.AddWithValue("@FILMEPREFE", perfil.FILMEPREFE);
            sqlCommand.Parameters.AddWithValue("@MUSICAPREFE", perfil.MUSICAPREFE);
            sqlCommand.Parameters.AddWithValue("@PERSONAGEMPREFE", perfil.PERSONAGEMPREFE);
            sqlCommand.Parameters.AddWithValue("@DYSNEY", perfil.DYSNEY);
            sqlCommand.Parameters.AddWithValue("@usuario", perfil.USUARIO);
            sqlCommand.Parameters.AddWithValue("@senha", perfil.SENHA);

            sqlCommand.ExecuteNonQuery();

        }

        public void DeletePerfil(int ID)
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

            }
        }

    }
}
