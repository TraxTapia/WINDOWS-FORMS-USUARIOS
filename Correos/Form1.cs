using Correos.Datos;
using Correos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correos
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuarios data = new Usuarios();
        public Form1()
        {
            InitializeComponent();
            IniciarDataTable();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            IniciarDataTable();
            Limpiar();
            Consultar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void IniciarDataTable()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            dtUsuarios.DataSource = tabla;

        }
        private void Guardar()
        {
            UsuariosModels modelo = new UsuariosModels() {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            data.Guardar(modelo);
        }
        private void Consultar()
        {
            foreach (var item in data.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
               fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);

            }
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
        }
    }
}
