using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entrega.Models
{
    public class Voo
    {
        [Key]
        public int Id { get; set; }     
        [ForeignKey("Id_Voo")]
        public int Numero_Voo { get; set; }
        public virtual Voo ? voo { get; set; }
        public string? NomeDestino { get; set; }
        public string? CPF { get; set; }

        public int CartaoDeCredito { get; set; }
    }
}
