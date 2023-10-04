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

        public PerfilDisney(string cpf, 
                            string telefone, 
                            string opiniao, 
                            string opiniao2, 
                            string filmeprefe, 
                            string musicaprefe, 
                            string personagemprefe, 
                            string dysney){

            CPF = cpf;
            TELEFONE = telefone;
            OPINIAO = opiniao;
            OPINIAO2 = opiniao2;
            FILMEPREFE = filmeprefe;
            MUSICAPREFE = musicaprefe;
            PERSONAGEMPREFE = personagemprefe;
            DYSNEY = dysney;
        }

        public int id
        {
            set {_id = value;}
            get { return _id; } 
        }      

        public string CPF 
        { 
            set { _cpf = value; }
            get { return _cpf; }
        }
        
        public string TELEFONE
        { 
            set { _telefone = value; }
            get { return _telefone; }
        }
        
        public string OPINIAO
        { 
            set { _opiniao = value; }
            get { return _opiniao; }
        }
        
        public string OPINIAO2
        { 
            set { _opiniao2 = value; }
            get { return _opiniao2; }
        }
        
        public string FILMEPREFE
        { 
            set { _filmeprefe = value; }
            get { return _filmeprefe; }
        }
        
        public string MUSICAPREFE
        { 
            set { _musicaprefe = value; }
            get { return _musicaprefe; }
        }
        
        public string PERSONAGEMPREFE
        { 
            set { _personagemprefe = value; }
            get { return _personagemprefe; }
        }
        
        public string DYSNEY
        { 
            set { _dysney = value; }
            get { return _dysney; }
        }

    }
}
