using pryEmpresa.DAO;
using pryEmpresa.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEmpresa
{
    public partial class Form1 : Form
    {

        private EmpleadoDAO control = new EmpleadoDAO();
        public Form1()
        {
            InitializeComponent();
            ListarTodosEmpleados();
            txtID.Text =""+ control.CodigoActual();
        }
       

        public void ListarTodosEmpleados()
        {
            
            dtgEmpleados.Rows.Clear();
            foreach(Empleado e in control.getListaEmpleado()){
                dtgEmpleados.Rows.Add(e.getId_emp(),e.getNombre_emp(),e.getPaterno_emp(),e.getMaterno_emp(),e.getFechaNaci_emp(),e.getRol_emp(),e.Sueldo());
            }
        }

        public void LimpiarCasillas()
        {
            txtID.Text = ""+control.CodigoActual();
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtFecha.Text = "";
            boxRol.Text="[ Seleccionar ]";
            dtgEmpleados.ClearSelection();

            btnAgregarEmpleado.Enabled = true;
            btnCancelarOperacion.Enabled = false;
            btnEditarEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            String nombre = txtNombre.Text;
            String paterno = txtPaterno.Text;
            String materno = txtMaterno.Text;
            String fecha = txtFecha.Text;
            String rol = boxRol.Text;

            if (txtNombre.Text.Trim().Length < 1)
            {
                MessageBox.Show("ERROR, SE DETECTÓ NOMBRE NULO"); return;
            }

            if (txtPaterno.Text.Trim().Length < 1)
            {
                MessageBox.Show("ERROR, SE DETECTÓ A.PATERNO NULO"); return;
            }

            if (txtMaterno.Text.Trim().Length < 1)
            {
                MessageBox.Show("ERROR, SE DETECTÓ A.MATERNO NULO"); return;
            }

            if (txtFecha.Text.Trim().Length < 1)
            {
                MessageBox.Show("ERROR, SE DETECTÓ F.NACIMIENTO NULO"); return;
            }

            if (boxRol.Text.Equals("[ Seleccionar ]"))
            {
                MessageBox.Show("SELECCONAR ROL"); return;
            }

            Empleado emp = new Empleado(nombre,paterno,materno,fecha,rol);
            control.AgregarEmpleado(emp);
            ListarTodosEmpleados();
            LimpiarCasillas();

        }

        private void dtgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            txtID.Text = dtgEmpleados.Rows[indice]      .Cells[0].Value.ToString();
            txtNombre.Text = dtgEmpleados.Rows[indice]  .Cells[1].Value.ToString();
            txtPaterno.Text = dtgEmpleados.Rows[indice] .Cells[2].Value.ToString();
            txtMaterno.Text = dtgEmpleados.Rows[indice] .Cells[3].Value.ToString();
            txtFecha.Text = dtgEmpleados.Rows[indice]   .Cells[4].Value.ToString();
            boxRol.Text = dtgEmpleados.Rows[indice]     .Cells[5].Value.ToString();

            btnAgregarEmpleado.Enabled = false;
            btnCancelarOperacion.Enabled = true;
            btnEditarEmpleado.Enabled = true;
            btnEliminarEmpleado.Enabled = true;
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            String ID = txtID.Text;
            control.EliminarEmpleado(ID);
            ListarTodosEmpleados();
            LimpiarCasillas();
            rbTodos.Checked = true;
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {

            Empleado emp = new Empleado();

            emp.setId_emp(txtID.Text);
            emp.setNombre_emp(txtNombre.Text);
            emp.setPaterno_emp(txtPaterno.Text);
            emp.setMaterno_emp(txtMaterno.Text);
            emp.setFechaNaci_emp(txtFecha.Text);
            emp.setRol_emp(boxRol.Text);

            control.EditarEmpleado(emp);

            ListarTodosEmpleados();
            LimpiarCasillas();
            rbTodos.Checked = true;

        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
            rbTodos.Checked = true;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            ListarTodosEmpleados();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dtgEmpleados.Rows.Clear();
            foreach (Empleado x in control.getListaEmpleado())
            {
                if (x.getRol_emp().Equals("Desarrollador full-stack"))
                {
                    dtgEmpleados.Rows.Add(x.getId_emp(), x.getNombre_emp(), x.getPaterno_emp(), x.getMaterno_emp(), x.getFechaNaci_emp(), x.getRol_emp(), x.Sueldo());
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dtgEmpleados.Rows.Clear();
            foreach (Empleado x in control.getListaEmpleado())
            {
                if (x.getRol_emp().Equals("Desarrollador front-end"))
                {
                    dtgEmpleados.Rows.Add(x.getId_emp(), x.getNombre_emp(), x.getPaterno_emp(), x.getMaterno_emp(), x.getFechaNaci_emp(), x.getRol_emp(), x.Sueldo());
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtgEmpleados.Rows.Clear();
            foreach (Empleado x in control.getListaEmpleado())
            {
                if (x.getRol_emp().Equals("Desarrollador back-end"))
                {
                    dtgEmpleados.Rows.Add(x.getId_emp(), x.getNombre_emp(), x.getPaterno_emp(), x.getMaterno_emp(), x.getFechaNaci_emp(), x.getRol_emp(), x.Sueldo());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dtgEmpleados.Rows.Clear();
            foreach (Empleado x in control.getListaEmpleado())
            {
                if (x.getNombre_emp().Contains(txtFiltro.Text))
                {
                    dtgEmpleados.Rows.Add(x.getId_emp(), x.getNombre_emp(), x.getPaterno_emp(), x.getMaterno_emp(), x.getFechaNaci_emp(), x.getRol_emp(), x.Sueldo());
                }
            }
        }
    }
}
