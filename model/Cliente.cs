using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace imparviagem.model
{
    public class Cliente
    {
        [Key]

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo nome deve entre 3 a 50 caracteres")]
        public string Nome { get; set; }

        [StringLength(8, MinimumLength = 6, ErrorMessage = "O campo datanascimento deve entre 6 a 8 caracteres")]
        public string Datanascimento { get; set; }

        [StringLength(20, MinimumLength = 9, ErrorMessage = "O campo Telefone deve entre 9 a 20 caracteres")]
        public string Telefone { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Email deve entre 3 a 50 caracteres")]
        public string Email { get; set; }

        [StringLength(12, MinimumLength = 8, ErrorMessage = "O campo Cpf deve entre 8 a 12 caracteres")]
        public string Cpf { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Senha deve entre 3 a 50 caracteres")]
        public string Senha { get; set; }
    }
}
