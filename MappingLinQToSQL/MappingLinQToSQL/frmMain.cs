using MappingLinQToSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingLinQToSQL
{
    public partial class frmMain : Form
    {
        CursoNet db = new CursoNet();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var consulta = from d in db._Personal
                           select d;
            dgView.DataSource = consulta.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtAddress.Text != string.Empty && txtPhone.Text != string.Empty)
            {
                Personal _personal = new Personal()
                {
                    Nombre = txtName.Text,
                    Direccion = txtAddress.Text,
                    Telefono = txtPhone.Text
                };
                db._Personal.InsertOnSubmit(_personal);
                db.SubmitChanges();
                txtName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }
    }
}
