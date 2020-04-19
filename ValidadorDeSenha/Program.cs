using System;

namespace ValidadorDeSenha
{
    class Program
    {
        /// <summary>
        /// A senha correta é 2002
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool senhaValida = false;
            string senha;

            while (!senhaValida)
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                if (senha.Equals("2002"))
                    senhaValida = true;
                else
                    Console.WriteLine("Senha inválida");
            }

            Console.Write("Acesso Permitido");
        }
    }
}
