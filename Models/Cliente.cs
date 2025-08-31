using System.ComponentModel.DataAnnotations;

namespace ProjetoAgendamento.Models
    {
    public class Cliente
        {
        public int IdCleinte { get; set; }
        public string NomeCliente { get; set; }
       

        public ICollection<Telefone> telefones { get; set; }
        public ICollection<Email> Emals { get; set; }

        }
    }
