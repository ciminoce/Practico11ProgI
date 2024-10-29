using Practico11ProgI.Entidades;

namespace Practico11ProgI.Windows
{
    public partial class frmDetallesSocio : Form
    {
        private Persona? persona;
        public frmDetallesSocio()
        {
            InitializeComponent();
        }

        public void SetSocio(Persona? p)
        {
            persona = p;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetallesSocio_Load(object sender, EventArgs e)
        {
            txtDNI.Text = persona.Dni.ToString();
            txtDNI.Enabled = false;
            txtPrimerNombre.Text = persona.PrimerNombre;
            txtSegundoNombre.Text = persona.SegundoNombre;
            txtTercerNombre.Text = persona.TercerNombre;
            txtApellido.Text = persona.Apellido;

            txtFechaNac.Text = persona.FechaNacimiento.ToShortDateString();
            txtLocalidad.Text = persona.Localidad.ToString();

            txtGenero.Text = persona.Genero is Genero.Femenino ? "Femenino" : "Masculino";

            chkActivo.Checked = persona.Activo;

        }
    }
}
