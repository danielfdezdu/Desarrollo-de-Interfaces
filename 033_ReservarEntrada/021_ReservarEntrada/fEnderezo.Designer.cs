namespace _021_ReservarEntrada
{
    partial class fEnderezo
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.tbEnderezo = new System.Windows.Forms.TextBox();
            this.lblEnderezo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(205, 85);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(174, 32);
            this.btAceptar.TabIndex = 15;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // cbProvincia
            // 
            this.cbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincia.Items.AddRange(new object[] {
            "A Coruña",
            "Lugo",
            "Ourense",
            "Pontevedra"});
            this.cbProvincia.Location = new System.Drawing.Point(12, 85);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(144, 26);
            this.cbProvincia.TabIndex = 14;
            // 
            // tbEnderezo
            // 
            this.tbEnderezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnderezo.Location = new System.Drawing.Point(12, 37);
            this.tbEnderezo.Name = "tbEnderezo";
            this.tbEnderezo.Size = new System.Drawing.Size(368, 24);
            this.tbEnderezo.TabIndex = 13;
            // 
            // lblEnderezo
            // 
            this.lblEnderezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderezo.Location = new System.Drawing.Point(12, 13);
            this.lblEnderezo.Name = "lblEnderezo";
            this.lblEnderezo.Size = new System.Drawing.Size(144, 23);
            this.lblEnderezo.TabIndex = 12;
            this.lblEnderezo.Text = "enderezo abonado";
            this.lblEnderezo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fEnderezo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 175);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.tbEnderezo);
            this.Controls.Add(this.lblEnderezo);
            this.Name = "fEnderezo";
            this.Text = "fEnderezo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btAceptar;
        internal System.Windows.Forms.ComboBox cbProvincia;
        internal System.Windows.Forms.TextBox tbEnderezo;
        internal System.Windows.Forms.Label lblEnderezo;
    }
}