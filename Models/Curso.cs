using AppEscolaDeMusica.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEscolaDeMusica.Models
{
    public class Curso
    {
        [Column("nivel")]
        public NivelCursoEnum Nivel { get; set; }
    }
}
