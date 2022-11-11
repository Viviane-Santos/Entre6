using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace imparviagem.model
{
    public class Hotel
    {
        [Key]
        public int Id_Hotel { get; set; }
        [Required(ErrorMessage = "Id_Hotel")]

        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Endereço deve entre 3 a 50 caracteres")]
        public string Endereço { get; set; }

        [StringLength(20, MinimumLength = 9, ErrorMessage = "O campo Telefone deve entre 9 a 20 caracteres")]
        public string Telefone { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Email deve entre 3 a 50 caracteres")]
        public string Email { get; set; }

        [StringLength(3, MinimumLength = 8, ErrorMessage = "O campo Preço deve entre 3 a 8 caracteres")]
        public string Preço { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo nome deve entre 3 a 50 caracteres")]
        public string Nome { get; set; }
    }
}
