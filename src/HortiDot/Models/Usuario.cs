using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HortiDot.Models
{
    [Table(name:"Usuários")]
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome Completo*:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [Display(Name = "E-mail*:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [RegularExpression(@"^[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}$", ErrorMessage = "CPF inválido.")]
        [Display(Name = "CPF*:")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Telefone*:")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome da Empresa*:")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "CNPJ*:")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Endereço*:")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Senha*:")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [AllowNull]
        public virtual List<Pedido> Pedidos { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Tipo de usuário*:")]
        public TipoDeUsuario TipoDeUsuario { get; set; }
    }

    public enum TipoDeUsuario
    {
        Comprador,
        Fornecedor
    }
}
