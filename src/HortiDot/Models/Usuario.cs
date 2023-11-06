using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome Completo*:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "E-mail*:")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "CPF*:")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome da Empresa*:")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "CNPJ*:")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public string Pedidos { get; set; }

        public string Contatos { get; set; }

        [Required]
        [Display(Name = "Tipo de usuário")]
        public string TipoDeUsuario { get; set; }

    }

    public enum TipoDeUsuario
    {
        Comprador,
        Fornecedor
    }
}
