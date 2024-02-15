using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Dominio.Entidades
{
    public abstract class AbstractEntidade
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime DataAlteracao { get; private set; } = DateTime.Now;
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
        public string UsuarioAlteracao { get; private set; }
        public string UsuarioCadastro { get; private set; }
        public bool IsAtivo { get; private set; } = true;

        public AbstractEntidade(string usuarioAlteracao, string usuarioCadastro)
        {
            UsuarioAlteracao= string.IsNullOrWhiteSpace(usuarioAlteracao) 
                ? throw new ArgumentNullException(nameof(usuarioAlteracao)) : usuarioAlteracao;

            UsuarioCadastro = string.IsNullOrWhiteSpace(usuarioCadastro)
                ? throw new ArgumentNullException(nameof(usuarioCadastro)) : usuarioCadastro;
        }

        public void SetUsuarioAlteracao(string usuarioAlteracao)
        {
            UsuarioAlteracao = string.IsNullOrWhiteSpace(usuarioAlteracao)
                ? throw new ArgumentNullException(nameof(usuarioAlteracao)) : usuarioAlteracao;
        }

        public virtual void SetDataAlteracao() => DataAlteracao = DateTime.Now;
    }
}