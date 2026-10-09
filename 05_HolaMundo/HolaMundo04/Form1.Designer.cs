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
            this.btMas = new System.Windows.Forms.Button();
            this.rbAmarillo = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.gbxColores = new System.Windows.Forms.GroupBox();
            this.btMenos = new System.Windows.Forms.Button();
            this.lbTamanio = new System.Windows.Forms.Label();
            this.gbxColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(75, 49);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(249, 38);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Hola Mundooooo....";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMas
            // 
            this.btMas.Location = new System.Drawing.Point(248, 301);
            this.btMas.Margin = new System.Windows.Forms.Padding(2);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(30, 20);
            this.btMas.TabIndex = 1;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // rbAmarillo
            // 
            this.rbAmarillo.AutoSize = true;
            this.rbAmarillo.Location = new System.Drawing.Point(18, 36);
            this.rbAmarillo.Margin = new System.Windows.Forms.Padding(2);
            this.rbAmarillo.Name = "rbAmarillo";
            this.rbAmarillo.Size = new System.Drawing.Size(60, 17);
            this.rbAmarillo.TabIndex = 2;
            this.rbAmarillo.TabStop = true;
            this.rbAmarillo.Text = "amarillo";
            this.rbAmarillo.UseVisualStyleBackColor = true;
            this.rbAmarillo.CheckedChanged += new System.EventHandler(this.rbAmarillo_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(18, 64);
            this.rbRojo.Margin = new System.Windows.Forms.Padding(2);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(42, 17);
            this.rbRojo.TabIndex = 3;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rbRojo_CheckedChanged);
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(18, 97);
            this.rbVerde.Margin = new System.Windows.Forms.Padding(2);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(52, 17);
            this.rbVerde.TabIndex = 4;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rbVerde_CheckedChanged);
            // 
            // gbxColores
            // 
            this.gbxColores.Controls.Add(this.rbAmarillo);
            this.gbxColores.Controls.Add(this.rbVerde);
            this.gbxColores.Controls.Add(this.rbRojo);
            this.gbxColores.Location = new System.Drawing.Point(125, 129);
            this.gbxColores.Margin = new System.Windows.Forms.Padding(2);
            this.gbxColores.Name = "gbxColores";
            this.gbxColores.Padding = new System.Windows.Forms.Padding(2);
            this.gbxColores.Size = new System.Drawing.Size(153, 134);
            this.gbxColores.TabIndex = 5;
            this.gbxColores.TabStop = false;
            // 
            // btMenos
            // 
            this.btMenos.Location = new System.Drawing.Point(97, 301);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(32, 20);
            this.btMenos.TabIndex = 6;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // lbTamanio
            // 
            this.lbTamanio.AutoSize = true;
            this.lbTamanio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamanio.Location = new System.Drawing.Point(135, 301);
            this.lbTamanio.Name = "lbTamanio";
            this.lbTamanio.Size = new System.Drawing.Size(108, 20);
            this.lbTamanio.TabIndex = 7;
            this.lbTamanio.Text = "Tamaño Letra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 359);
            this.Controls.Add(this.lbTamanio);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.gbxColores);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.lblSaludo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxColores.ResumeLayout(false);
            this.gbxColores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.RadioButton rbAmarillo;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.GroupBox gbxColores;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Label lbTamanio;
    }
}

