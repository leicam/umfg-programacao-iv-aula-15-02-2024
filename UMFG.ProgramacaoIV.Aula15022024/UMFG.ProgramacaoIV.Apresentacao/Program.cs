using UMFG.ProgramacaoIV.Dominio.Entidades;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        private const string C_USUARIO_PADRAO = "padrao@umfg.edu.br";

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe o nome do cliente: ");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe o CPF do cliente: ");
                var cpf = Console.ReadLine();

                var cliente = new Cliente(nome, cpf, C_USUARIO_PADRAO, C_USUARIO_PADRAO);

                Console.WriteLine(cliente.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}