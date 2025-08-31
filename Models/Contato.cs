using System.ComponentModel.DataAnnotations;

namespace ProjetoAgendamento.Models
    {
    public class Contato
        {
        [Key]
        public int IdContato { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Contato() { }

        public Contato(int idContato, string telefone, string email, int clienteId, Cliente cliente)
            {
            IdContato = idContato;
            Telefone = telefone;
            Email = email;
            ClienteId = clienteId;
            Cliente = cliente;
            }
        }
    }