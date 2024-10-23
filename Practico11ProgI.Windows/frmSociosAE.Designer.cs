namespace Practico11ProgI.Windows
{
    partial class frmSociosAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtDNI = new TextBox();
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            label5 = new Label();
            txtTercerNombre = new TextBox();
            label4 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            label6 = new Label();
            dtpFechaNac = new DateTimePicker();
            groupBox2 = new GroupBox();
            rbtMasculino = new RadioButton();
            rbtFemenino = new RadioButton();
            label7 = new Label();
            cboLocalidades = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            chkActivo = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(60, 19);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(114, 23);
            txtDNI.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTercerNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSegundoNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrimerNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 153);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Socio ";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(122, 115);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 23);
            txtApellido.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 118);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Apellidos:";
            // 
            // txtTercerNombre
            // 
            txtTercerNombre.Location = new Point(122, 86);
            txtTercerNombre.MaxLength = 20;
            txtTercerNombre.Name = "txtTercerNombre";
            txtTercerNombre.Size = new Size(182, 23);
            txtTercerNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Tercer Nombre:";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(122, 57);
            txtSegundoNombre.MaxLength = 20;
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(182, 23);
            txtSegundoNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 0;
            label3.Text = "Segundo Nombre:";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(122, 28);
            txtPrimerNombre.MaxLength = 20;
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(182, 23);
            txtPrimerNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Primer Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 22);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 3;
            label6.Text = "Fec. Nacimiento:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(317, 21);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(94, 23);
            dtpFechaNac.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtMasculino);
            groupBox2.Controls.Add(rbtFemenino);
            groupBox2.Location = new Point(362, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(175, 81);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = " Género ";
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(11, 51);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 0;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Checked = true;
            rbtFemenino.Location = new Point(11, 25);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 0;
            rbtFemenino.TabStop = true;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 223);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Localidad";
            // 
            // cboLocalidades
            // 
            cboLocalidades.FormattingEnabled = true;
            cboLocalidades.Location = new Point(101, 221);
            cboLocalidades.Name = "cboLocalidades";
            cboLocalidades.Size = new Size(231, 23);
            cboLocalidades.TabIndex = 7;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(32, 266);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 47);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(131, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 47);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(367, 225);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSociosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 325);
            ControlBox = false;
            Controls.Add(chkActivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboLocalidades);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(dtpFechaNac);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            MaximumSize = new Size(578, 364);
            MinimumSize = new Size(578, 364);
            Name = "frmSociosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSociosAE";
            Load += frmSociosAE_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDNI;
        private GroupBox groupBox1;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtTercerNombre;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label3;
        private TextBox txtPrimerNombre;
        private Label label2;
        private Label label6;
        private DateTimePicker dtpFechaNac;
        private GroupBox groupBox2;
        private RadioButton rbtMasculino;
        private RadioButton rbtFemenino;
        private Label label7;
        private ComboBox cboLocalidades;
        private Button btnOK;
        private Button btnCancelar;
        private CheckBox chkActivo;
        private ErrorProvider errorProvider1;
    }
}