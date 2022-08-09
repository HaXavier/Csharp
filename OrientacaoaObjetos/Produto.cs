using System;

namespace OrientacaoaObjetos 
{
    class Produto
    {
        private string Nome;
        private int Idade;
        private double CPF;

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

    }
}