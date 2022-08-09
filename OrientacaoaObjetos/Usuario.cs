using System;

namespace OrientacaoaObjetos 
{
    class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"------- \nLogin: { Login }; \n Idade: {Idade}; \n Email: {Email}; \n Senha: {Senha};";
        }
    }
}