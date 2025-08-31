using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoAgendamento.Models
    {
    public class Cliente
        {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string NomeCliente { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public Cliente() { }

        public Cliente(int idCliente, string nomeCliente, ICollection<Contato> contatos)
            {
            IdCliente = idCliente;
            NomeCliente = nomeCliente;
            Contatos = contatos;
            }
        }
    }