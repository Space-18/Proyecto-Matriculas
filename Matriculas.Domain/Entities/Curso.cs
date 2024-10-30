using Matriculas.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matriculas.Domain.Entities
{
    [Table("tb_Cursos")]
    public class Curso : BaseModel
    {
        [Key, Column("nIdCurso")]
        public long IdCurso { get; set; }

        [Column("sDesCurso")]
        public string DesCurso { get; set; }

        [ForeignKey("Seccion"), Column("nIdSeccion")]
        public long IdSeccion { get; set; }
        public virtual Seccion Seccion { get; set; }
    }
}
