namespace _030_Bicicleta
{
    partial class fBicicleta
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnVerMarca = new System.Windows.Forms.Button();
            this.btnFrenarF = new System.Windows.Forms.Button();
            this.btnSprint = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(163, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 105;
            this.label3.Text = "modelo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(163, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 104;
            this.label2.Text = "marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(163, 104);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(150, 22);
            this.lblModelo.TabIndex = 103;
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(163, 48);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(150, 25);
            this.lblMarca.TabIndex = 102;
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerMarca
            // 
            this.btnVerMarca.Location = new System.Drawing.Point(20, 49);
            this.btnVerMarca.Name = "btnVerMarca";
            this.btnVerMarca.Size = new System.Drawing.Size(111, 38);
            this.btnVerMarca.TabIndex = 101;
            this.btnVerMarca.Text = "Ver Marca y Modelo";
            this.btnVerMarca.UseVisualStyleBackColor = true;
            this.btnVerMarca.Click += new System.EventHandler(this.btnVerMarca_Click);
            // 
            // btnFrenarF
            // 
            this.btnFrenarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrenarF.Location = new System.Drawing.Point(20, 169);
            this.btnFrenarF.Name = "btnFrenarF";
            this.btnFrenarF.Size = new System.Drawing.Size(45, 38);
            this.btnFrenarF.TabIndex = 100;
            this.btnFrenarF.Text = "Frenar fuerte";
            this.btnFrenarF.UseVisualStyleBackColor = true;
            this.btnFrenarF.Click += new System.EventHandler(this.btnFrenarF_Click);
            // 
            // btnSprint
            // 
            this.btnSprint.Location = new System.Drawing.Point(268, 169);
            this.btnSprint.Name = "btnSprint";
            this.btnSprint.Size = new System.Drawing.Size(45, 38);
            this.btnSprint.TabIndex = 99;
            this.btnSprint.Text = "Sprint";
            this.btnSprint.UseVisualStyleBackColor = true;
            this.btnSprint.Click += new System.EventHandler(this.btnSprint_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(68, 169);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(60, 38);
            this.btnFrenar.TabIndex = 96;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(208, 169);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(60, 38);
            this.btnAcelerar.TabIndex = 95;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(130, 169);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 15);
            this.Label1.TabIndex = 97;
            this.Label1.Text = "velocidad";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidad.Location = new System.Drawing.Point(130, 184);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(76, 23);
            this.lblVelocidad.TabIndex = 98;
            this.lblVelocidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fBicicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 237);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnVerMarca);
            this.Controls.Add(this.btnFrenarF);
            this.Controls.Add(this.btnSprint);
            this.Controls.Add(this.btnFrenar);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblVelocidad);
            this.Name = "fBicicleta";
            this.Text = "Bicicleta";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblModelo;
        internal System.Windows.Forms.Label lblMarca;
        internal System.Windows.Forms.Button btnVerMarca;
        internal System.Windows.Forms.Button btnFrenarF;
        internal System.Windows.Forms.Button btnSprint;
        internal System.Windows.Forms.Button btnFrenar;
        internal System.Windows.Forms.Button btnAcelerar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblVelocidad;
    }
}

