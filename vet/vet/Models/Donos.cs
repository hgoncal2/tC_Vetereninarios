namespace vet.Models {

    /// <summary>
    /// descrição dos dados dos clientes(donos dos animais) da clínica
    /// </summary>
    public class Donos {

        public Donos() {
            ListaAnimais=new HashSet<Animais>();
        }


        /// <summary>
        /// PK para o dono
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do dono do animal
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Sexo do dono
        /// Mm - masculino; Ff - feminino
        /// </summary>
        public string Sexo { get; set; }
        /// <summary>
        /// Número de identificação fiscal do cliente
        /// </summary>
        public string NIF { get; set; }

        // lista dos animais do dono
        public ICollection<Animais> ListaAnimais { get; set; }

    }
}
