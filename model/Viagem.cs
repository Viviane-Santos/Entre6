using System.ComponentModel.DataAnnotations;

namespace imparviagem.model
{
    public class Viagem
    {
        [Key]
        public int Id_Viagem { get; set; }
        [Required(ErrorMessage = "Id_Viagem")]

        [StringLength(100, MinimumLength = 9, ErrorMessage = "O campo Destino deve entre 9 a 100 caracteres")]
        public string Destino { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Origem deve entre 3 a 50 caracteres")]
        public string Origem{ get; set; }

        [StringLength(3, MinimumLength = 8, ErrorMessage = "O campo Preço deve entre 3 a 8 caracteres")]
        public string Preço { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo nome deve entre 3 a 50 caracteres")]
        public string Nome { get; set; }
    }
}
