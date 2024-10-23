﻿namespace Practico11ProgI.Windows
{
    partial class frmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocios));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbDetalles = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panelInformacion = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colDni = new DataGridViewTextBoxColumn();
            colSocio = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelInformacion.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, tsbDetalles, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 35);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 35);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 35);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbDetalles
            // 
            tsbDetalles.Image = (Image)resources.GetObject("tsbDetalles.Image");
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(52, 35);
            tsbDetalles.Text = "Detalles";
            tsbDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 35);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(33, 35);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panelInformacion
            // 
            panelInformacion.Controls.Add(txtCantidad);
            panelInformacion.Controls.Add(label1);
            panelInformacion.Dock = DockStyle.Bottom;
            panelInformacion.Location = new Point(0, 380);
            panelInformacion.Name = "panelInformacion";
            panelInformacion.Size = new Size(800, 70);
            panelInformacion.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(123, 20);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad Socios:";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 38);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 342);
            panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colDni, colSocio, colEdad, colCategoria, colGenero });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(800, 342);
            dgvDatos.TabIndex = 0;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colSocio
            // 
            colSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSocio.HeaderText = "Socio";
            colSocio.Name = "colSocio";
            colSocio.ReadOnly = true;
            // 
            // colEdad
            // 
            colEdad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEdad.HeaderText = "Edad";
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            colEdad.Width = 58;
            // 
            // colCategoria
            // 
            colCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colGenero
            // 
            colGenero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGenero.HeaderText = "Género";
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGrilla);
            Controls.Add(panelInformacion);
            Controls.Add(toolStrip1);
            Name = "frmSocios";
            Text = "frmSocios";
            Load += frmSocios_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panelInformacion;
        private TextBox txtCantidad;
        private Label label1;
        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colSocio;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colGenero;
        private ToolStripButton tsbDetalles;
    }
}