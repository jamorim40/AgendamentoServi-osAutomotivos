

using System.ComponentModel.DataAnnotations;

namespace ProjetoAgendamento.Models
    {
    public class Telefone
        {
        [Key]
        public int IdTelefone { get; set; }
        [Required]
        public string TelefoneCliente { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Telefone() { }

        public Telefone(int idTelefone, string telefoneCliente, int cLienteId, Cliente cliente)
            {
            IdTelefone = idTelefone;
            TelefoneCliente = telefoneCliente;
            ClienteId = cLienteId;
            Cliente = cliente;
            }
        }
    }
