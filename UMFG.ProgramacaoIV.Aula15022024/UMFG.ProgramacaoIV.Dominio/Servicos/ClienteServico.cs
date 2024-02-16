using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Interfaces;

namespace UMFG.ProgramacaoIV.Dominio.Servicos
{
    public class ClienteServico : IClienteServico
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public void Adicionar(Cliente cliente) => _clientes.Add(cliente);
        
        public Cliente ObterPorCpf(string cpf)
            => _clientes.FirstOrDefault(x => x.CPF == cpf)
            ?? throw new ArgumentNullException(nameof(Cliente));

        public IEnumerable<Cliente> ObterTodos() => _clientes;
    }
}
