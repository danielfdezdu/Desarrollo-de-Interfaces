namespace HolaMundo04
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btAplicar = new System.Windows.Forms.Button();
            this.rbAmarillo = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.gbxColores = new System.Windows.Forms.GroupBox();
            this.gbxColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(112, 75);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(374, 59);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Hola Mundooooo....";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAplicar
            // 
            this.btAplicar.Location = new System.Drawing.Point(394, 235);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(105, 68);
            this.btAplicar.TabIndex = 1;
            this.btAplicar.Text = "aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // rbAmarillo
            // 
            this.rbAmarillo.AutoSize = true;
            this.rbAmarillo.Location = new System.Drawing.Point(27, 55);
            this.rbAmarillo.Name = "rbAmarillo";
            this.rbAmarillo.Size = new System.Drawing.Size(88, 24);
            this.rbAmarillo.TabIndex = 2;
            this.rbAmarillo.TabStop = true;
            this.rbAmarillo.Text = "amarillo";
            this.rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(27, 99);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(60, 24);
            this.rbRojo.TabIndex = 3;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(27, 149);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(73, 24);
            this.rbVerde.TabIndex = 4;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            // 
            // gbxColores
            // 
            this.gbxColores.Controls.Add(this.rbAmarillo);
            this.gbxColores.Controls.Add(this.rbVerde);
            this.gbxColores.Controls.Add(this.rbRojo);
            this.gbxColores.Location = new System.Drawing.Point(66, 180);
            this.gbxColores.Name = "gbxColores";
            this.gbxColores.Size = new System.Drawing.Size(200, 219);
            this.gbxColores.TabIndex = 5;
            this.gbxColores.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 451);
            this.Controls.Add(this.gbxColores);
            this.Controls.Add(this.btAplicar);
            this.Controls.Add(this.lblSaludo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxColores.ResumeLayout(false);
            this.gbxColores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.RadioButton rbAmarillo;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.GroupBox gbxColores;
    }
}

