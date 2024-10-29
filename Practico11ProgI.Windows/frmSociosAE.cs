using Practico11ProgI.Datos;
using Practico11ProgI.Entidades;

namespace Practico11ProgI.Windows
{
    public partial class frmSociosAE : Form
    {
        private Persona? persona;
        private RepositorioDeSocios? _repo;
        public frmSociosAE(RepositorioDeSocios repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (persona is not null)
            {
                txtDNI.Text = persona.Dni.ToString();
                txtDNI.Enabled=false;
                txtPrimerNombre.Text = persona.PrimerNombre;
                txtSegundoNombre.Text = persona.SegundoNombre;
                txtTercerNombre.Text=persona.TercerNombre;
                txtApellido.Text = persona.Apellido;

                dtpFechaNac.Value = persona.FechaNacimiento;
                cboLocalidades.SelectedItem =persona.Localidad;

                if (persona.Genero==Genero.Femenino)
                {
                    rbtFemenino.Checked = true;
                }
                else
                {
                    rbtMasculino.Checked = true;
                }

                chkActivo.Checked=persona.Activo;

            }
        }
        private void frmSociosAE_Load(object sender, EventArgs e)
        {
            chkActivo.Checked = true;
            dtpFechaNac.MaxDate = DateTime.Today.Date;
            CargarDatosComboLocalidades(ref cboLocalidades);
        }

        private void CargarDatosComboLocalidades(ref ComboBox cbo)
        {
            var localidades = Enum.GetValues(typeof(Localidad));
            cbo.DataSource = localidades;
            cbo.SelectedIndex = 0;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(persona is null)
                {
                    persona = new Persona();

                }
                persona.Dni=int.Parse(txtDNI.Text);
                persona.PrimerNombre = txtPrimerNombre.Text;
                persona.SegundoNombre=txtSegundoNombre.Text;
                persona.TercerNombre = txtTercerNombre.Text;
                persona.Apellido = txtApellido.Text;

                persona.Localidad =(Localidad) cboLocalidades.SelectedItem!;
                persona.Genero=rbtFemenino.Checked?Genero.Femenino:Genero.Masculino;

                persona.FechaNacimiento = dtpFechaNac.Value.Date;
                persona.Activo = chkActivo.Checked;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            var edad =(int)Math.Truncate(DateTime.Today.Subtract(dtpFechaNac.Value).TotalDays / 365.25);
            if (edad < 10)
            {
                valido = false;
                errorProvider1.SetError(dtpFechaNac, "Debe ser mayor a 10 años");
            }
            if (!ValidoDni(txtDNI.Text))
            {

                valido = false;
                errorProvider1.SetError(txtDNI, "DNI no válido");

            }
            else {
                if (_repo.GetSocios()!.Any(s => s.Dni == int.Parse(txtDNI.Text)))
                {
                    valido = false;
                    errorProvider1.SetError(txtDNI, "DNI existente!!!");
                }

            }
            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtPrimerNombre, "Primer nombre es requerido");
            }
            if(!string.IsNullOrEmpty(txtTercerNombre.Text) && string.IsNullOrEmpty(txtSegundoNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTercerNombre, "Debe tener segundo nombre");
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Apellido es requerido");
            }
            return valido;
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

        public Persona? GetPersona()
        {
            return persona;
        }

        public void SetSocio(Persona? p)
        {
            persona = p;
        }
    }
}
