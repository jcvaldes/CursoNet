using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingLinQToSQL
{
    [Database(Name = "CursoNet")]
    class CursoNet : DataContext
    {
        public CursoNet()
            : base(new SqlConnection("Data Source=SWF-01;Initial Catalog=CursoNet;Integrated Security=True")){}
       
        public Table<Personal> _Personal;
    }
}
