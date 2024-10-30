using Matriculas.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matriculas.Domain.Entities
{
    [Table("tb_Secciones")]
    public class Seccion : BaseModel
    {
        [Key, Column("nIdSeccion")]
        public long IdSeccion { get; set; }

        [ForeignKey("Aula"), Column("nIdAula")]
        public long IdAula { get; set; }
        public virtual Aula Aula { get; set; }

        //[ForeignKey("Curso"), Column("nIdCurso")]
        //public long IdCurso { get; set; }
        //public virtual Curso Curso { get; set; }

        public virtual List<Curso> Cursos { get; set; }

        [Column("sTurno")]
        public string Turno { get; set; }

        [Column("tHoraInicio")]
        public TimeOnly HoraInicio { get; set; }

        [Column("tHoraFin")]
        public TimeOnly HoraFin { get; set; }
    }
}
