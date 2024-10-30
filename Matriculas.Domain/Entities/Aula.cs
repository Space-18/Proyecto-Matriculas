using Matriculas.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matriculas.Domain.Entities
{
    [Table("tb_Aulas")]
    public class Aula : BaseModel
    {
        [Key, Column("nIdAula")]
        public long IdAula { get; set; }

        [Column("nCapacidad")]
        public int Capacidad { get; set; }
    }
}
