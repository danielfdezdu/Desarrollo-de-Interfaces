namespace _07_Telefono
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
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbProvincial = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.cbTarifa = new System.Windows.Forms.CheckBox();
            this.cbChamada = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.gpTipo = new System.Windows.Forms.GroupBox();
            this.rbMobil = new System.Windows.Forms.RadioButton();
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).BeginInit();
            this.gpTipo.SuspendLayout();
            this.gpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblPrecio.Location = new System.Drawing.Point(175, 9);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(214, 25);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio da chamada";
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(6, 37);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 1;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // rbProvincial
            // 
            this.rbProvincial.AutoSize = true;
            this.rbProvincial.Location = new System.Drawing.Point(6, 60);
            this.rbProvincial.Name = "rbProvincial";
            this.rbProvincial.Size = new System.Drawing.Size(71, 17);
            this.rbProvincial.TabIndex = 2;
            this.rbProvincial.TabStop = true;
            this.rbProvincial.Text = "Provincial";
            this.rbProvincial.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Location = new System.Drawing.Point(6, 83);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(67, 17);
            this.rbNacional.TabIndex = 3;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(17, 25);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(112, 13);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración da chamada";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(6, 49);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 5;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(98, 49);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 6;
            this.lblSegundos.Text = "Segundos";
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(54, 46);
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(35, 20);
            this.nudMinutos.TabIndex = 7;
            // 
            // nudSegundos
            // 
            this.nudSegundos.Location = new System.Drawing.Point(159, 46);
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(35, 20);
            this.nudSegundos.TabIndex = 8;
            // 
            // cbTarifa
            // 
            this.cbTarifa.AutoSize = true;
            this.cbTarifa.Location = new System.Drawing.Point(9, 88);
            this.cbTarifa.Name = "cbTarifa";
            this.cbTarifa.Size = new System.Drawing.Size(97, 17);
            this.cbTarifa.TabIndex = 9;
            this.cbTarifa.Text = "Tarifa reducida";
            this.cbTarifa.UseVisualStyleBackColor = true;
            // 
            // cbChamada
            // 
            this.cbChamada.AutoSize = true;
            this.cbChamada.Location = new System.Drawing.Point(9, 111);
            this.cbChamada.Name = "cbChamada";
            this.cbChamada.Size = new System.Drawing.Size(161, 17);
            this.cbChamada.TabIndex = 10;
            this.cbChamada.Text = "Chamada ó mesmo operador";
            this.cbChamada.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(407, 76);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(121, 23);
            this.btCalcular.TabIndex = 11;
            this.btCalcular.Text = "Calcular Importe";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // gpTipo
            // 
            this.gpTipo.Controls.Add(this.rbMobil);
            this.gpTipo.Controls.Add(this.rbLocal);
            this.gpTipo.Controls.Add(this.rbProvincial);
            this.gpTipo.Controls.Add(this.rbNacional);
            this.gpTipo.Location = new System.Drawing.Point(12, 56);
            this.gpTipo.Name = "gpTipo";
            this.gpTipo.Size = new System.Drawing.Size(146, 143);
            this.gpTipo.TabIndex = 12;
            this.gpTipo.TabStop = false;
            this.gpTipo.Text = "tipo da chamada";
            // 
            // rbMobil
            // 
            this.rbMobil.AutoSize = true;
            this.rbMobil.Location = new System.Drawing.Point(6, 106);
            this.rbMobil.Name = "rbMobil";
            this.rbMobil.Size = new System.Drawing.Size(50, 17);
            this.rbMobil.TabIndex = 4;
            this.rbMobil.TabStop = true;
            this.rbMobil.Text = "Móbil";
            this.rbMobil.UseVisualStyleBackColor = true;
            // 
            // gpDatos
            // 
            this.gpDatos.Controls.Add(this.lblDuracion);
            this.gpDatos.Controls.Add(this.lblSegundos);
            this.gpDatos.Controls.Add(this.lblMinutos);
            this.gpDatos.Controls.Add(this.cbChamada);
            this.gpDatos.Controls.Add(this.nudMinutos);
            this.gpDatos.Controls.Add(this.cbTarifa);
            this.gpDatos.Controls.Add(this.nudSegundos);
            this.gpDatos.Location = new System.Drawing.Point(180, 51);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(200, 148);
            this.gpDatos.TabIndex = 13;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "datos da chamada";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(414, 116);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(104, 16);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "                                ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 243);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.gpTipo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lblPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).EndInit();
            this.gpTipo.ResumeLayout(false);
            this.gpTipo.PerformLayout();
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbProvincial;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.NumericUpDown nudSegundos;
        private System.Windows.Forms.CheckBox cbTarifa;
        private System.Windows.Forms.CheckBox cbChamada;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox gpTipo;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.RadioButton rbMobil;
        private System.Windows.Forms.Label lblResultado;
    }
}

