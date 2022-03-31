using System.ComponentModel.DataAnnotations;

namespace vet.Models {

    /// <summary>
    /// descrição dos dados dos clientes(donos dos animais) da clínica
    /// </summary>
    public class Donos {

        public Donos() {
            ListaAnimais = new HashSet<Animais>();
        }


        /// <summary>
        /// PK para o dono
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do dono do animal
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais do que {1} caracteres.")]
        [RegularExpression("[A-Za-záéíóúâêîôûàèìòùçñãõÁÉÍÓÚÂ '-]+",ErrorMessage ="Só pode usar letras no nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do dono
        /// Mm - masculino; Ff - feminino
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(1, ErrorMessage = "O {0} não pode ter mais do que {1} carácter.")]
        [RegularExpression("[MmFf]", ErrorMessage = "Só pode escrever F/f para feminino ou M/m para masculino")]
        public string Sexo { get; set; }

        /// <summary>
        /// Número de identificação fiscal do cliente
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter exatamente {1} caracteres.")]
        [RegularExpression("[0-9]{9}")]
        public string NIF { get; set; }

        /// <summary>
        /// Email do dono do animal
        /// </summary>
        [EmailAddress(ErrorMessage = "Deve escrever um {0} válido.")]
        public string Email { get; set; }

        /// <summary>
        /// lista dos animais do dono
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

    }
}
