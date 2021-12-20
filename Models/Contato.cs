using System.ComponentModel.DataAnnotations;

namespace Entrega.Models
{
    public class Contato
    {   
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }

        public int NumeroDeTelefone { get; set; }

    }
}
