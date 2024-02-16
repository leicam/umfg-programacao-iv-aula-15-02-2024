using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entidades;

namespace UMFG.ProgramacaoIV.Dominio.Interfaces
{
    public interface IClienteServico
    {
        void Adicionar(Cliente cliente);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorCpf(string cpf);
    }
}
