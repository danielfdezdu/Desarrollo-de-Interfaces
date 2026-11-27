namespace _021_ReservarEntrada
{
    partial class f_Inicial
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
            this.btEscoller = new System.Windows.Forms.Button();
            this.btEnderezo = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblGrada = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblEnderezo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblTitDatNac = new System.Windows.Forms.Label();
            this.dtpNacemento = new System.Windows.Forms.DateTimePicker();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEscoller
            // 
            this.btEscoller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEscoller.Location = new System.Drawing.Point(442, 144);
            this.btEscoller.Name = "btEscoller";
            this.btEscoller.Size = new System.Drawing.Size(162, 32);
            this.btEscoller.TabIndex = 29;
            this.btEscoller.Text = "Escoller Asiento";
            this.btEscoller.Click += new System.EventHandler(this.btEscoller_Click);
            // 
            // btEnderezo
            // 
            this.btEnderezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnderezo.Location = new System.Drawing.Point(442, 95);
            this.btEnderezo.Name = "btEnderezo";
            this.btEnderezo.Size = new System.Drawing.Size(162, 32);
            this.btEnderezo.TabIndex = 28;
            this.btEnderezo.Text = "Enderezo";
            this.btEnderezo.Click += new System.EventHandler(this.btEnderezo_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblGrada);
            this.gbDatos.Controls.Add(this.lblProvincia);
            this.gbDatos.Controls.Add(this.lblEnderezo);
            this.gbDatos.Controls.Add(this.lblData);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(12, 81);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(424, 280);
            this.gbDatos.TabIndex = 32;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Abonado";
            // 
            // lblGrada
            // 
            this.lblGrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrada.Location = new System.Drawing.Point(24, 192);
            this.lblGrada.Name = "lblGrada";
            this.lblGrada.Size = new System.Drawing.Size(214, 23);
            this.lblGrada.TabIndex = 4;
            this.lblGrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProvincia
            // 
            this.lblProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(24, 152);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(374, 23);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnderezo
            // 
            this.lblEnderezo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblEnderezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderezo.Location = new System.Drawing.Point(24, 112);
            this.lblEnderezo.Name = "lblEnderezo";
            this.lblEnderezo.Size = new System.Drawing.Size(374, 23);
            this.lblEnderezo.TabIndex = 2;
            this.lblEnderezo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(24, 72);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(374, 23);
            this.lblData.TabIndex = 1;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(374, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitNome
            // 
            this.lblTitNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitNome.Location = new System.Drawing.Point(12, 9);
            this.lblTitNome.Name = "lblTitNome";
            this.lblTitNome.Size = new System.Drawing.Size(104, 16);
            this.lblTitNome.TabIndex = 31;
            this.lblTitNome.Text = "nome abonado";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(12, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(456, 24);
            this.tbNome.TabIndex = 26;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // lblTitDatNac
            // 
            this.lblTitDatNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitDatNac.Location = new System.Drawing.Point(476, 9);
            this.lblTitDatNac.Name = "lblTitDatNac";
            this.lblTitDatNac.Size = new System.Drawing.Size(104, 16);
            this.lblTitDatNac.TabIndex = 30;
            this.lblTitDatNac.Text = "data nacemento";
            // 
            // dtpNacemento
            // 
            this.dtpNacemento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacemento.Location = new System.Drawing.Point(479, 28);
            this.dtpNacemento.Name = "dtpNacemento";
            this.dtpNacemento.Size = new System.Drawing.Size(97, 20);
            this.dtpNacemento.TabIndex = 27;
            this.dtpNacemento.ValueChanged += new System.EventHandler(this.dtpNacemento_ValueChanged);
            // 
            // f_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 376);
            this.Controls.Add(this.btEscoller);
            this.Controls.Add(this.btEnderezo);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblTitNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblTitDatNac);
            this.Controls.Add(this.dtpNacemento);
            this.Name = "f_Inicial";
            this.Text = "reservar entrada";
            this.gbDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btEscoller;
        internal System.Windows.Forms.Button btEnderezo;
        internal System.Windows.Forms.GroupBox gbDatos;
        internal System.Windows.Forms.Label lblGrada;
        internal System.Windows.Forms.Label lblProvincia;
        internal System.Windows.Forms.Label lblEnderezo;
        internal System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.Label lblTitNome;
        internal System.Windows.Forms.TextBox tbNome;
        internal System.Windows.Forms.Label lblTitDatNac;
        internal System.Windows.Forms.DateTimePicker dtpNacemento;
    }
}

