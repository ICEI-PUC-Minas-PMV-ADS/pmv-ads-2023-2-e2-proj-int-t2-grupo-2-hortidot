using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HortiDot.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite sua mensagem.")]
        public string Mensagem { get; set; }

        public string Destinatario { get; set; }

        [AllowNull]
        public virtual Usuario Comprador { get; set; }

        public string? Assunto { get; set; }
    }
}


//        public EstadoMsg EstadoMsg { get; set; }
//    }
//    public enum EstadoMsg
//    {
//        enviado,
//        favorito,
//        recebido
//    }
//}


