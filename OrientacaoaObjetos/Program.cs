using System;

namespace OrientacaoaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.SetNome("Luiz Henrique");
            Console.WriteLine(produto.GetNome());

            Usuario usuario = new Usuario();
            usuario.Login = "arrozDoce";
            usuario.Idade = 30;
            usuario.Email = "email123@dominio.com";
            usuario.Senha = "123456";
            Console.WriteLine(usuario);

            Usuario usuario1 = new Usuario
            {
              Login = "teste", Email = "a@a.com",
              Senha = "123", Idade = 25  
            };
            Console.WriteLine(usuario1);
        }
    }
}
