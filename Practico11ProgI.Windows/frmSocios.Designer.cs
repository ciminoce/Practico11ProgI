namespace Practico11ProgI.Windows
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
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbDetalles = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            géneroToolStripMenuItem = new ToolStripMenuItem();
            tcboGeneros = new ToolStripComboBox();
            localidadToolStripMenuItem = new ToolStripMenuItem();
            tcboLocalidades = new ToolStripComboBox();
            tsbBuscar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            edad09ToolStripMenuItem = new ToolStripMenuItem();
            edad90ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
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
            socioAZToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panelInformacion.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, tsbDetalles, toolStripSeparator1, tsbFiltrar, tsbBuscar, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.add_file_48px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(52, 67);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_48px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(52, 67);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_48px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 67);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbDetalles
            // 
            tsbDetalles.Image = Properties.Resources.content_48px;
            tsbDetalles.ImageScaling = ToolStripItemImageScaling.None;
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(52, 67);
            tsbDetalles.Text = "Detalles";
            tsbDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbDetalles.Click += tsbDetalles_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { géneroToolStripMenuItem, localidadToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filled_filter_48px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(61, 67);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // géneroToolStripMenuItem
            // 
            géneroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboGeneros });
            géneroToolStripMenuItem.Name = "géneroToolStripMenuItem";
            géneroToolStripMenuItem.Size = new Size(125, 22);
            géneroToolStripMenuItem.Text = "Género";
            // 
            // tcboGeneros
            // 
            tcboGeneros.Name = "tcboGeneros";
            tcboGeneros.Size = new Size(121, 23);
            tcboGeneros.SelectedIndexChanged += tcboGeneros_SelectedIndexChanged;
            // 
            // localidadToolStripMenuItem
            // 
            localidadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboLocalidades });
            localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            localidadToolStripMenuItem.Size = new Size(125, 22);
            localidadToolStripMenuItem.Text = "Localidad";
            // 
            // tcboLocalidades
            // 
            tcboLocalidades.Name = "tcboLocalidades";
            tcboLocalidades.Size = new Size(121, 23);
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = Properties.Resources.search_48px;
            tsbBuscar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(52, 67);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 67);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { edad09ToolStripMenuItem, edad90ToolStripMenuItem, socioAZToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.sorting_arrows_48px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 67);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // edad09ToolStripMenuItem
            // 
            edad09ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_12_480px;
            edad09ToolStripMenuItem.Name = "edad09ToolStripMenuItem";
            edad09ToolStripMenuItem.Size = new Size(180, 22);
            edad09ToolStripMenuItem.Text = "Edad (0-9)";
            edad09ToolStripMenuItem.Click += edad09ToolStripMenuItem_Click;
            // 
            // edad90ToolStripMenuItem
            // 
            edad90ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_21_480px;
            edad90ToolStripMenuItem.Name = "edad90ToolStripMenuItem";
            edad90ToolStripMenuItem.Size = new Size(180, 22);
            edad90ToolStripMenuItem.Text = "Edad (9-0)";
            edad90ToolStripMenuItem.Click += edad90ToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 70);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_48px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 67);
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
            panelGrilla.Location = new Point(0, 70);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 310);
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
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 310);
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
            // socioAZToolStripMenuItem
            // 
            socioAZToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_480px;
            socioAZToolStripMenuItem.Name = "socioAZToolStripMenuItem";
            socioAZToolStripMenuItem.Size = new Size(180, 22);
            socioAZToolStripMenuItem.Text = "Socio (A-Z)";
            socioAZToolStripMenuItem.Click += socioAZToolStripMenuItem_Click;
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
        private ToolStripButton tsbBuscar;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem géneroToolStripMenuItem;
        private ToolStripComboBox tcboGeneros;
        private ToolStripMenuItem localidadToolStripMenuItem;
        private ToolStripComboBox tcboLocalidades;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem edad09ToolStripMenuItem;
        private ToolStripMenuItem edad90ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem socioAZToolStripMenuItem;
    }
}