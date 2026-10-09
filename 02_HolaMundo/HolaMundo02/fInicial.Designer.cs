namespace HolaMundo02
{
    partial class fInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btCambiarSaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.BackColor = System.Drawing.Color.SpringGreen;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(67, 58);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(432, 79);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "saludo";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaludo.MouseEnter += new System.EventHandler(this.Cuando_Paso_Raton_x_Encima_Etiqueta);
            this.lblSaludo.MouseLeave += new System.EventHandler(this.Cuando_el_Raton_Abandona_Etiqueta);
            // 
            // btCambiarSaludo
            // 
            this.btCambiarSaludo.Location = new System.Drawing.Point(327, 233);
            this.btCambiarSaludo.Name = "btCambiarSaludo";
            this.btCambiarSaludo.Size = new System.Drawing.Size(166, 33);
            this.btCambiarSaludo.TabIndex = 1;
            this.btCambiarSaludo.Text = "cambiar saludo";
            this.btCambiarSaludo.UseVisualStyleBackColor = true;
            this.btCambiarSaludo.Click += new System.EventHandler(this.btCambiarSaludo_Click);
            // 
            // fInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 313);
            this.Controls.Add(this.btCambiarSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Name = "fInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btCambiarSaludo;
    }
}

