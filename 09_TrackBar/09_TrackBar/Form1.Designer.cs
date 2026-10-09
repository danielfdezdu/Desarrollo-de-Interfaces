namespace _09_TrackBar
{
    partial class Form1
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
            this.tbProgreso = new System.Windows.Forms.TrackBar();
            this.lbValor = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMovil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProgreso
            // 
            this.tbProgreso.Location = new System.Drawing.Point(235, 149);
            this.tbProgreso.Maximum = 100;
            this.tbProgreso.Name = "tbProgreso";
            this.tbProgreso.Size = new System.Drawing.Size(527, 45);
            this.tbProgreso.TabIndex = 0;
            this.tbProgreso.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbValor
            // 
            this.lbValor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbValor.Location = new System.Drawing.Point(467, 181);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(35, 13);
            this.lbValor.TabIndex = 1;
            // 
            // lblMaximo
            // 
            this.lblMaximo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMaximo.Location = new System.Drawing.Point(768, 149);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(45, 13);
            this.lblMaximo.TabIndex = 2;
            this.lblMaximo.Text = "100";
            this.lblMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinimo
            // 
            this.lblMinimo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMinimo.Location = new System.Drawing.Point(184, 149);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(45, 13);
            this.lblMinimo.TabIndex = 3;
            this.lblMinimo.Text = "0";
            this.lblMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovil
            // 
            this.lblMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMovil.Location = new System.Drawing.Point(241, 122);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(16, 13);
            this.lblMovil.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 363);
            this.Controls.Add(this.lblMovil);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.tbProgreso);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbProgreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbProgreso;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMovil;
    }
}

