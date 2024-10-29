namespace Practico11ProgI.Windows
{
    partial class frmDetallesSocio
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
            chkActivo = new CheckBox();
            btnOK = new Button();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            label5 = new Label();
            txtTercerNombre = new TextBox();
            label4 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            txtDNI = new TextBox();
            label1 = new Label();
            txtLocalidad = new TextBox();
            txtGenero = new TextBox();
            label8 = new Label();
            txtFechaNac = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(441, 22);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 20;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(200, 315);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 47);
            btnOK.TabIndex = 19;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 271);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Localidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 23);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 13;
            label6.Text = "Fec. Nacimiento:";
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
            groupBox1.Location = new Point(27, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 153);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = " Socio ";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
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
            txtTercerNombre.Enabled = false;
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
            txtSegundoNombre.Enabled = false;
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
            txtPrimerNombre.Enabled = false;
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
            // txtDNI
            // 
            txtDNI.Location = new Point(59, 20);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(114, 23);
            txtDNI.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 10;
            label1.Text = "DNI:";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Enabled = false;
            txtLocalidad.Location = new Point(92, 268);
            txtLocalidad.MaxLength = 8;
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(240, 23);
            txtLocalidad.TabIndex = 11;
            // 
            // txtGenero
            // 
            txtGenero.Enabled = false;
            txtGenero.Location = new Point(92, 225);
            txtGenero.MaxLength = 8;
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(240, 23);
            txtGenero.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 228);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 16;
            label8.Text = "Género:";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Enabled = false;
            txtFechaNac.Location = new Point(312, 20);
            txtFechaNac.MaxLength = 8;
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(114, 23);
            txtFechaNac.TabIndex = 11;
            // 
            // frmDetallesSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 388);
            ControlBox = false;
            Controls.Add(chkActivo);
            Controls.Add(btnOK);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtGenero);
            Controls.Add(txtLocalidad);
            Controls.Add(txtFechaNac);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            MaximumSize = new Size(531, 427);
            MinimumSize = new Size(531, 427);
            Name = "frmDetallesSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetallesSocio";
            Load += frmDetallesSocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkActivo;
        private Button btnOK;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtTercerNombre;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label3;
        private TextBox txtPrimerNombre;
        private Label label2;
        private TextBox txtDNI;
        private Label label1;
        private TextBox txtLocalidad;
        private TextBox txtGenero;
        private Label label8;
        private TextBox txtFechaNac;
    }
}