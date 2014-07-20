using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingLinQToSql
{
    public partial class LinQToSql : Form
    {
        CursoNet db = new CursoNet();

        public LinQToSql()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Personal _personal = new Personal()
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };
            db._Personal.InsertOnSubmit(_personal);
            db.SubmitChanges();
        }

     
    }
}
