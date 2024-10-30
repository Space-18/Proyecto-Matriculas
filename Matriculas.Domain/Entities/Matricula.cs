using Matriculas.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matriculas.Domain.Entities
{
    [Table("tb_Matricula")]
    public class Matricula : BaseModel
    {
        [Key, Column("nIdRegistro")]
        public long IdRegistro { get; set; }

        [ForeignKey("Alumno"), Column("nIdAlumno")]
        public long IdAlumno { get; set; }
        public virtual Alumno Alumno { get; set; }

        [ForeignKey("Seccion"), Column("nIdSeccion")]
        public long IdSeccion { get; set; }
        public virtual Seccion Seccion { get; set; }

        [Required]
        public long IdCurso { get; set; }
    }
}
