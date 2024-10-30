using Matriculas.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matriculas.Domain.Entities
{
    [Table("tb_Alumnos")]
    public class Alumno : BaseModel
    {
        [Key, Column("nIdAlumno")]
        public long IdAlumno { get; set; }

        [Column("sNombre")]
        public string Nombre { get; set; }
    }
}
