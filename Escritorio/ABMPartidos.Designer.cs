namespace Escritorio
{
    partial class ABMPartidos
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
            this.lblNroPartido = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRival = new System.Windows.Forms.Label();
            this.txtNroPartido = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRival = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtGolesAFavor = new System.Windows.Forms.TextBox();
            this.txtGolesEnContra = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.btnRegistrarGoles = new System.Windows.Forms.Button();
            this.lblExplicacion = new System.Windows.Forms.Label();
            this.btnExpulsados = new System.Windows.Forms.Button();
            this.txtExpulsados = new System.Windows.Forms.TextBox();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.txtCantJugadores = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroPartido
            // 
            this.lblNroPartido.AutoSize = true;
            this.lblNroPartido.Location = new System.Drawing.Point(57, 39);
            this.lblNroPartido.Name = "lblNroPartido";
            this.lblNroPartido.Size = new System.Drawing.Size(80, 13);
            this.lblNroPartido.TabIndex = 0;
            this.lblNroPartido.Text = "Numero Partido";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(57, 98);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblRival
            // 
            this.lblRival.AutoSize = true;
            this.lblRival.Location = new System.Drawing.Point(57, 134);
            this.lblRival.Name = "lblRival";
            this.lblRival.Size = new System.Drawing.Size(31, 13);
            this.lblRival.TabIndex = 3;
            this.lblRival.Text = "Rival";
            // 
            // txtNroPartido
            // 
            this.txtNroPartido.Location = new System.Drawing.Point(157, 32);
            this.txtNroPartido.Name = "txtNroPartido";
            this.txtNroPartido.Size = new System.Drawing.Size(100, 20);
            this.txtNroPartido.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtRival
            // 
            this.txtRival.Location = new System.Drawing.Point(157, 134);
            this.txtRival.Name = "txtRival";
            this.txtRival.Size = new System.Drawing.Size(100, 20);
            this.txtRival.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(60, 169);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // txtGolesAFavor
            // 
            this.txtGolesAFavor.Location = new System.Drawing.Point(157, 169);
            this.txtGolesAFavor.Name = "txtGolesAFavor";
            this.txtGolesAFavor.Size = new System.Drawing.Size(39, 20);
            this.txtGolesAFavor.TabIndex = 4;
            // 
            // txtGolesEnContra
            // 
            this.txtGolesEnContra.Location = new System.Drawing.Point(242, 169);
            this.txtGolesEnContra.Name = "txtGolesEnContra";
            this.txtGolesEnContra.Size = new System.Drawing.Size(39, 20);
            this.txtGolesEnContra.TabIndex = 5;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(211, 172);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "a";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(85, 347);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(152, 23);
            this.button.TabIndex = 10;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // btnRegistrarGoles
            // 
            this.btnRegistrarGoles.Location = new System.Drawing.Point(85, 258);
            this.btnRegistrarGoles.Name = "btnRegistrarGoles";
            this.btnRegistrarGoles.Size = new System.Drawing.Size(152, 23);
            this.btnRegistrarGoles.TabIndex = 7;
            this.btnRegistrarGoles.Text = "Autores de Goles";
            this.btnRegistrarGoles.UseVisualStyleBackColor = true;
            this.btnRegistrarGoles.Click += new System.EventHandler(this.btnRegistrarGoles_Click);
            // 
            // lblExplicacion
            // 
            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Location = new System.Drawing.Point(253, 258);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(160, 39);
            this.lblExplicacion.TabIndex = 11;
            this.lblExplicacion.Text = "Primero ingrese resultado, luego \r\nregistre los autores de los goles\r\ndel partido" +
    "";
            // 
            // btnExpulsados
            // 
            this.btnExpulsados.Location = new System.Drawing.Point(85, 301);
            this.btnExpulsados.Name = "btnExpulsados";
            this.btnExpulsados.Size = new System.Drawing.Size(152, 23);
            this.btnExpulsados.TabIndex = 9;
            this.btnExpulsados.Text = "Expulsados";
            this.btnExpulsados.UseVisualStyleBackColor = true;
            this.btnExpulsados.Click += new System.EventHandler(this.btnExpulsados_Click);
            // 
            // txtExpulsados
            // 
            this.txtExpulsados.Location = new System.Drawing.Point(256, 301);
            this.txtExpulsados.Name = "txtExpulsados";
            this.txtExpulsados.Size = new System.Drawing.Size(40, 20);
            this.txtExpulsados.TabIndex = 8;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(85, 217);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(152, 23);
            this.btnAsistencia.TabIndex = 6;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // txtCantJugadores
            // 
            this.txtCantJugadores.Location = new System.Drawing.Point(256, 219);
            this.txtCantJugadores.Name = "txtCantJugadores";
            this.txtCantJugadores.Size = new System.Drawing.Size(40, 20);
            this.txtCantJugadores.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(157, 65);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 13;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(60, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // ABMPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 407);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCantJugadores);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.txtExpulsados);
            this.Controls.Add(this.btnExpulsados);
            this.Controls.Add(this.lblExplicacion);
            this.Controls.Add(this.btnRegistrarGoles);
            this.Controls.Add(this.button);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtGolesEnContra);
            this.Controls.Add(this.txtGolesAFavor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtRival);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNroPartido);
            this.Controls.Add(this.lblRival);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNroPartido);
            this.Name = "ABMPartidos";
            this.Text = "ABMPartidos";
            this.Load += new System.EventHandler(this.ABMPartidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroPartido;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRival;
        private System.Windows.Forms.TextBox txtNroPartido;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtRival;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtGolesAFavor;
        private System.Windows.Forms.TextBox txtGolesEnContra;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btnRegistrarGoles;
        private System.Windows.Forms.Label lblExplicacion;
        private System.Windows.Forms.Button btnExpulsados;
        private System.Windows.Forms.TextBox txtExpulsados;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.TextBox txtCantJugadores;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}