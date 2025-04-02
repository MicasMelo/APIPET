using System.ComponentModel.DataAnnotations;

namespace APIPET.Model
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Nome { get; set; }
        [Required]
        [StringLength(12)]
        public string Especie { get; set; }
        [Required]
        public int Idade { get; set; }
    }
}
