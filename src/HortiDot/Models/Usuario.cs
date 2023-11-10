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

        [AllowNull]
        [ForeignKey("Pedido")]
        public ICollection<Pedido> Pedidos { get; set; }

        [Required]
        [Display(Name = "Tipo de usuário")]
        public TipoDeUsuario TipoDeUsuario { get; set; }
    }

    public enum TipoDeUsuario
    {
        Comprador,
        Fornecedor
    }
}
