using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string nomeCli { get; set; }
        public string sobrenomeCli { get; set; }
        public DateTime dataNascimentoCli { get; set; }
        public bool ativoCli { get; set; }

        public bool ClienteEspecial(Cliente cliente) {

            return cliente.ativoCli && DateTime.Now.Year - cliente.dataNascimentoCli.Year >= 5;
        }
    }
}
