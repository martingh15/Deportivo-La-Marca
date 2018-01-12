namespace Escritorio
{
    partial class Jugadores
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
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.goles,
            this.asistencia,
            this.fecha_nacimiento,
            this.estado});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvJugadores, 2);
            this.dgvJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJugadores.Location = new System.Drawing.Point(3, 3);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(661, 389);
            this.dgvJugadores.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "NroCamiseta";
            this.numero.HeaderText = "Numero Camiseta";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // goles
            // 
            this.goles.DataPropertyName = "Goles";
            this.goles.HeaderText = "Goles";
            this.goles.Name = "goles";
            this.goles.ReadOnly = true;
            // 
            // asistencia
            // 
            this.asistencia.DataPropertyName = "Asistencia";
            this.asistencia.HeaderText = "Asistencia";
            this.asistencia.Name = "asistencia";
            this.asistencia.ReadOnly = true;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "FechaNacimiento";
            this.fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "State";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJugadorToolStripMenuItem,
            this.editarJugadorToolStripMenuItem,
            this.borrarJugadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarJugadorToolStripMenuItem
            // 
            this.agregarJugadorToolStripMenuItem.Name = "agregarJugadorToolStripMenuItem";
            this.agregarJugadorToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.agregarJugadorToolStripMenuItem.Text = "Agregar Jugador";
            this.agregarJugadorToolStripMenuItem.Click += new System.EventHandler(this.agregarJugadorToolStripMenuItem_Click);
            // 
            // editarJugadorToolStripMenuItem
            // 
            this.editarJugadorToolStripMenuItem.Name = "editarJugadorToolStripMenuItem";
            this.editarJugadorToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.editarJugadorToolStripMenuItem.Text = "Editar Jugador";
            this.editarJugadorToolStripMenuItem.Click += new System.EventHandler(this.editarJugadorToolStripMenuItem_Click);
            // 
            // borrarJugadorToolStripMenuItem
            // 
            this.borrarJugadorToolStripMenuItem.Name = "borrarJugadorToolStripMenuItem";
            this.borrarJugadorToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.borrarJugadorToolStripMenuItem.Text = "Borrar Jugador";
            this.borrarJugadorToolStripMenuItem.Click += new System.EventHandler(this.borrarJugadorToolStripMenuItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(3, 398);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvJugadores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 424);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Jugadores";
            this.Text = "Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarJugadorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}