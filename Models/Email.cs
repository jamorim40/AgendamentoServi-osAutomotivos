using System.ComponentModel.DataAnnotations;

namespace ProjetoAgendamento.Models
    {
    public class Email
        {
        [Key]
        public int IdEmail { get; set; }

        [Required]
        [EmailAddress]
        public string Endereco { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Email() { }

        public Email(int idEmail, string endereco, int clienteId, Cliente cliente)
            {
            IdEmail = idEmail;
            Endereco = endereco;
            ClienteId = clienteId;
            Cliente = cliente;
            }
        }
    }