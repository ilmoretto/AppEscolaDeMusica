using AppEscolaDeMusica.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEscolaDeMusica.Models
{
    public class Contrato
    {
        [Column("status_contrato")]
        public StatusContratoEnum StatusContrato { get; set; }
    }
}
