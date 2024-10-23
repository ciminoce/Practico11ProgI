using Practico11ProgI.Datos;
using Practico11ProgI.Entidades;

namespace Practico11ProgI.Windows
{
    public partial class frmSocios : Form
    {
        private RepositorioDeSocios? repo;
        private List<Persona>? listaSocios;
        private int cantidadSocios;
        public frmSocios()
        {
            InitializeComponent();
            repo = new RepositorioDeSocios();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repo.GuardarDatos();
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmSociosAE frm = new frmSociosAE() { Text = "Nuevo Socio" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Persona? personaIngresada = frm.GetPersona();
            if (personaIngresada is null)
            {
                return;
            }
            repo!.Agregar(personaIngresada);
            var r = ConstruirFila(dgvDatos);
            SetearFila(r, personaIngresada);
            AgregarFila(r, dgvDatos);
            cantidadSocios = repo!.GetCantidad();
            MostrarTotales();
            MessageBox.Show("Socio agregado!!",
                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            listaSocios = repo!.GetSocios();
            cantidadSocios = repo!.GetCantidad();
            MostrarDatosEnGrilla();
            MostrarTotales();
        }

        private void MostrarTotales()
        {
            txtCantidad.Text = cantidadSocios.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var socio in listaSocios!)
            {
                DataGridViewRow r = ConstruirFila(dgvDatos);
                SetearFila(r, socio);
                AgregarFila(r, dgvDatos);
            }
        }

        private void SetearFila(DataGridViewRow r, Persona socio)
        {
            r.Cells[colDni.Index].Value = socio.Dni;
            r.Cells[colSocio.Index].Value = socio.NombreCompleto();
            r.Cells[colEdad.Index].Value = socio.GetEdad();
            r.Cells[colCategoria.Index].Value = repo!.GetCategoria(socio);
            r.Cells[colGenero.Index].Value = socio.Genero.ToString();

            r.Tag = socio;
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var rSeleccionada = dgvDatos.SelectedRows[0];
            Persona personaBorrar = (Persona)rSeleccionada.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar a {personaBorrar!.NombreCompleto()}?",
                "Confirmar Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            repo!.Borrar(personaBorrar);
            QuitarFila(rSeleccionada, dgvDatos);
            cantidadSocios = repo!.GetCantidad();
            MostrarTotales();
            MessageBox.Show("Registro eliminado!!", "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var rSeleccionada= dgvDatos.SelectedRows[0];
            Persona? p = (Persona)rSeleccionada.Tag!;
            frmSociosAE frm = new frmSociosAE() { Text = "Editar Socio" };
            frm.SetSocio(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            p = frm.GetPersona();
            SetearFila(rSeleccionada, p);
            MessageBox.Show("Registro editado!!", "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
