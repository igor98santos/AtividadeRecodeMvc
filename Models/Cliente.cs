using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entrega.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }     
      
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public int NumeroDeTelefone { get; set; }
    }
           
}
