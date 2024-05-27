namespace EstructuraDatos
{
    partial class frmBaseDatosRepasoOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSQL = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacion a realizar en la base de datos:";
            // 
            // cboSQL
            // 
            this.cboSQL.FormattingEnabled = true;
            this.cboSQL.Items.AddRange(new object[] {
            "ProyeccionSimple",
            "ProyeccionSimple2",
            "ProyeccionMultiatributo",
            "ProyeccionMultiatributo2",
            "Juntar",
            "Juntar2",
            "SeleccionSimple",
            "SeleccionSimple2",
            "SeleccionMultiatributo",
            "SeleccionMultiatributo2",
            "SeleccionConvolucion",
            "SeleccionConvolucion2",
            "Union",
            "Union2",
            "Interseccion",
            "Interseccion2",
            "Diferencia",
            "Diferencia2",
            "ProyeccionSimple3",
            "ProyeccionSimple4"});
            this.cboSQL.Location = new System.Drawing.Point(221, 13);
            this.cboSQL.Name = "cboSQL";
            this.cboSQL.Size = new System.Drawing.Size(370, 21);
            this.cboSQL.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(597, 11);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(87, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(669, 122);
            this.lblDescripcion.TabIndex = 3;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(15, 214);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(669, 236);
            this.Grilla.TabIndex = 4;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 462);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboSQL);
            this.Controls.Add(this.label1);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDatosRepasoOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSQL;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView Grilla;
    }
}