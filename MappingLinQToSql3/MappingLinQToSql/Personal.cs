using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingLinQToSql
{
    [Table(Name = "Personal")]
    class Personal
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public Int64 Id { get; set; }
        [Column]
        public string Nombre { get; set; }
        [Column]
        public string Direccion { get; set; }
        [Column]
        public string Telefono { get; set; }
    }
}
