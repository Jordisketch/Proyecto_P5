namespace P520231.Formularios
{
    partial class FrmSede
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
            this.LblNombreSede = new System.Windows.Forms.Label();
            this.TxtSedeNombre = new System.Windows.Forms.TextBox();
            this.TxtUbicacionSede = new System.Windows.Forms.TextBox();
            this.LblUbicacionSede = new System.Windows.Forms.Label();
            this.TxtDescripcionSede = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreSede
            // 
            this.LblNombreSede.AutoSize = true;
            this.LblNombreSede.Location = new System.Drawing.Point(23, 9);
            this.LblNombreSede.Name = "LblNombreSede";
            this.LblNombreSede.Size = new System.Drawing.Size(32, 13);
            this.LblNombreSede.TabIndex = 0;
            this.LblNombreSede.Text = "Sede";
            // 
            // TxtSedeNombre
            // 
            this.TxtSedeNombre.Location = new System.Drawing.Point(26, 41);
            this.TxtSedeNombre.Name = "TxtSedeNombre";
            this.TxtSedeNombre.Size = new System.Drawing.Size(190, 20);
            this.TxtSedeNombre.TabIndex = 1;
            // 
            // TxtUbicacionSede
            // 
            this.TxtUbicacionSede.Location = new System.Drawing.Point(26, 124);
            this.TxtUbicacionSede.Name = "TxtUbicacionSede";
            this.TxtUbicacionSede.Size = new System.Drawing.Size(190, 20);
            this.TxtUbicacionSede.TabIndex = 3;
            // 
            // LblUbicacionSede
            // 
            this.LblUbicacionSede.AutoSize = true;
            this.LblUbicacionSede.Location = new System.Drawing.Point(23, 92);
            this.LblUbicacionSede.Name = "LblUbicacionSede";
            this.LblUbicacionSede.Size = new System.Drawing.Size(55, 13);
            this.LblUbicacionSede.TabIndex = 2;
            this.LblUbicacionSede.Text = "Ubicacion";
            // 
            // TxtDescripcionSede
            // 
            this.TxtDescripcionSede.Location = new System.Drawing.Point(279, 41);
            this.TxtDescripcionSede.Name = "TxtDescripcionSede";
            this.TxtDescripcionSede.Size = new System.Drawing.Size(190, 20);
            this.TxtDescripcionSede.TabIndex = 5;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(276, 9);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 4;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(279, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(439, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Ubicacion,
            this.descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(-25, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 220);
            this.dataGridView1.TabIndex = 8;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // FrmSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDescripcionSede);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtUbicacionSede);
            this.Controls.Add(this.LblUbicacionSede);
            this.Controls.Add(this.TxtSedeNombre);
            this.Controls.Add(this.LblNombreSede);
            this.Name = "FrmSede";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSedesGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombreSede;
        private System.Windows.Forms.TextBox TxtSedeNombre;
        private System.Windows.Forms.TextBox TxtUbicacionSede;
        private System.Windows.Forms.Label LblUbicacionSede;
        private System.Windows.Forms.TextBox TxtDescripcionSede;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}