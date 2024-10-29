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
            frmSociosAE frm = new frmSociosAE(repo!) { Text = "Nuevo Socio" };
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
            CargarDatosComboGeneros(ref tcboGeneros);
            cantidadSocios = repo!.GetCantidad();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            listaSocios = repo!.GetSocios();
            MostrarDatosEnGrilla();
            MostrarTotales();
        }

        private void CargarDatosComboGeneros(ref ToolStripComboBox tcboGeneros)
        {
            var listaGeneros = Enum.GetValues(typeof(Genero));
            tcboGeneros.Items.Add("Seleccione");
            foreach (var item in listaGeneros)
            {
                tcboGeneros.Items.Add(item);
            }
            tcboGeneros.SelectedIndex = 0;
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
            var rSeleccionada = dgvDatos.SelectedRows[0];
            Persona? p = (Persona)rSeleccionada.Tag!;
            frmSociosAE frm = new frmSociosAE(repo!) { Text = "Editar Socio" };
            frm.SetSocio(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            p = frm.GetPersona();
            SetearFila(rSeleccionada, p);
            MessageBox.Show("Registro editado!!", "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Persona p = (Persona)r.Tag;
            frmDetallesSocio frm = new frmDetallesSocio() { Text = "Detalles del Socio" };
            frm.SetSocio(p);
            frm.ShowDialog(this);
        }

        private void tcboGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcboGeneros.SelectedIndex == 0)
            {
                return;
            }
            tsbFiltrar.Enabled = false;
            Genero genero = (Genero)tcboGeneros.SelectedItem;
            listaSocios = repo.FiltrarPorGenero(genero);
            cantidadSocios = repo.GetCantidad(genero);
            MostrarDatosEnGrilla();
            MostrarTotales();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            cantidadSocios = repo.GetCantidad();
            RecargarGrilla();
            tsbFiltrar.Enabled = true;

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string dniString = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DNI",
        "Buscar por DNI", "0");
                if (string.IsNullOrEmpty(dniString))
                {
                    return;
                }
                if (ValidoDni(dniString))
                {
                    bool existe = repo.BuscarPorDni(int.Parse(dniString));
                    if (existe)
                    {
                        SeleccionarFila(int.Parse(dniString));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("DNI no encontrado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("DNI no válido", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void SeleccionarFila(int dni)
        {
            dgvDatos.ClearSelection();
            foreach (DataGridViewRow item in dgvDatos.Rows)
            {
                if ((int)item.Cells[0].Value == dni)
                {
                    item.Selected = true;
                }
            }
        }

        private bool ValidoDni(string dniString)
        {
            if (dniString.Length < 8)
            {
                return false;
            }
            if (!int.TryParse(dniString, out _))
            {
                return false;
            }
            return true;
        }

        private void edad09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaSocios = repo.OrdernarAsc();
            MostrarDatosEnGrilla();
        }

        private void edad90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaSocios = repo.OrdernarDesc();
            MostrarDatosEnGrilla();

        }

        private void socioAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaSocios = repo.OrdenarAlfa();
            MostrarDatosEnGrilla();
        }
    }
}
