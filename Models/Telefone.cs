using ProjetoAgendamento;

namespace ProjetoAgendamento.Models
    {
    public class Telefone
        {
        public int IdTelefone { get; set; }
        public string TelefoneCliente { get; set; }
        public int CLienteId { get; set; }
        public Cliente Cliente { get; set; }
        }
    }
