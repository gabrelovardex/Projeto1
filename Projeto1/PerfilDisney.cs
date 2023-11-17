using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class PerfilDisney
    {
        private int _id;
        private string _cpf;
        private string _telefone;
        private string _opiniao;
        private string _opiniao2;
        private string _filmeprefe;
        private string _musicaprefe;
        private string _personagemprefe;
        private string _dysney;
        private string _usuario;
        private string _senha;   

        public PerfilDisney(string cpf,
                            string telefone,
                            string opiniao,
                            string opiniao2,
                            string filmeprefe,
                            string musicaprefe,
                            string personagemprefe,
                            string dysney,
                            string usuario,
                            string senha)
        {

            CPF = cpf;
            TELEFONE = telefone;
            OPINIAO = opiniao;
            OPINIAO2 = opiniao2;
            FILMEPREFE = filmeprefe;
            MUSICAPREFE = musicaprefe;
            PERSONAGEMPREFE = personagemprefe;
            DYSNEY = dysney;
            USUARIO = usuario;
            SENHA = senha;
         }
        public PerfilDisney(int id,
                            string cpf,
                            string telefone,
                            string opiniao,
                            string opiniao2,
                            string filmeprefe,
                            string musicaprefe,
                            string personagemprefe,
                            string dysney,
                            string usuario,
                            string senha)
        {
            Id = id; 
            CPF = cpf;
            TELEFONE = telefone;
            OPINIAO = opiniao;
            OPINIAO2 = opiniao2;
            FILMEPREFE = filmeprefe;
            MUSICAPREFE = musicaprefe;
            PERSONAGEMPREFE = personagemprefe;
            DYSNEY = dysney;
            USUARIO = usuario;
            SENHA = senha;
        }

        public int Id
        {
            set {_id = value;} // atribuir valor
            get { return _id; } // retorna valor
        }      

        public string CPF 
        { 
            set { 
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Campo CPF está vazio");

                _cpf = value; 
            }
            get { return _cpf; }
        }
        
        public string TELEFONE
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo TELEFONE está vazio");

                _telefone = value; }
            get { return _telefone; }
        }
        
        public string OPINIAO
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo OPINIAO está vazio");
               
                _opiniao = value; }
            get { return _opiniao; }
        }
        
        public string OPINIAO2
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo OPINIAO2 está vazio");

                _opiniao2 = value; }
            get { return _opiniao2; }
        }
        
        public string FILMEPREFE
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo FILME PREFERIDO está vazio");

                _filmeprefe = value; }
            get { return _filmeprefe; }
        }
        
        public string MUSICAPREFE
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo MUSICA PREFERIDA está vazio");

                _musicaprefe = value; }
            get { return _musicaprefe; }
        }
        
        public string PERSONAGEMPREFE
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo PERSONAGEM PREFERIDO está vazio");

                _personagemprefe = value; }
            get { return _personagemprefe; }
        }
        
        public string DYSNEY
        { 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo DYSNEY está vazio");

                _dysney = value; }
            get { return _dysney; }
        }

        public string USUARIO
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo USUARIO está vazio");

                _usuario = value;
            }
            get { return _usuario; }
        }

        public string SENHA
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo SENHA está vazio");

                _senha = value;
            }
            get { return _senha; }
        }

    }
}
