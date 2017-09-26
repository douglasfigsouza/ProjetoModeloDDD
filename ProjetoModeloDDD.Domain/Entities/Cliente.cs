using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string nomeCli { get; set; }
        public string sobrenomeCli { get; set; }
        public DateTime dataCadastro{ get; set; }
        public bool ativoCli { get; set; }
        public string emailCli { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set;}

        public bool ClienteEspecial(Cliente cliente) {

            return cliente.ativoCli && DateTime.Now.Year - cliente.dataCadastro.Year >= 5;
        }
    }
}
