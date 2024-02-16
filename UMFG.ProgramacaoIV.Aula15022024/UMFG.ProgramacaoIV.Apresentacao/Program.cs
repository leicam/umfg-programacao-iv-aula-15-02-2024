using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Interfaces;
using UMFG.ProgramacaoIV.Dominio.Servicos;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        private const string C_USUARIO_PADRAO = "padrao@umfg.edu.br";

        private static IClienteServico _servico = new ClienteServico();

        static void Main(string[] args)
        {
            var operacao = 0;

            do
            {
                Console.WriteLine("**MENU**");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar todos os clientes");
                Console.WriteLine("3 - Consultar cliente por CPF");
                Console.WriteLine("4 - Sair");
                
                int.TryParse(Console.ReadLine(), out operacao);

                switch (operacao)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Informe o nome do cliente: ");
                            var nome = Console.ReadLine();

                            Console.WriteLine("Informe o CPF do cliente: ");
                            var cpf = Console.ReadLine();

                            var cliente = new Cliente(nome, cpf, C_USUARIO_PADRAO, C_USUARIO_PADRAO);
                            _servico.Adicionar(cliente);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Retornando para o menu principal!");
                        }
                        break;
                    case 2:
                        try
                        {
                            foreach (var item in _servico.ObterTodos())
                                Console.WriteLine(item.ToString());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Retornando para o menu principal!");
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Digite o CPF para consulta: ");
                            Console.WriteLine(_servico.ObterPorCpf(Console.ReadLine()));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Retornando para o menu principal!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Até logo!");
                        break;
                    default:
                        Console.WriteLine("Operação inválida! Verifique.");
                        break;
                }
            } while (operacao != 4);
        }
    }
}