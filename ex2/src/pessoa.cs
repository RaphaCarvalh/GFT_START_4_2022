using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2.src
{
    public class pessoa

     {
        private String nome;
        private String endereco;
        private int telefone;
 
        public pessoa(String nome, String endereco, int telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
     
        }

        public pessoa()
        {
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
 
        public String getNome()
        {
            return this.nome;
        }

        internal void settelefone(string v)
        {
            throw new NotImplementedException();
        }

        public void setendereco(String endereco)
        {
            this.endereco = endereco;
        }
 
        public String getendereco()
        {
            return this.endereco;
        }
 
        public void settelefone(int telefone)
        {
            this.telefone = telefone;
        }
 
        public int gettelefone()
        {
            return this.telefone;
        }
    }
}
             


    
