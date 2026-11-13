namespace Seguro
{
    partial class fSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSeguro));
            this.btNovoAsegurado = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lbxDatosAsegurado = new System.Windows.Forms.ListBox();
            this.btDatosAsegurado = new System.Windows.Forms.Button();
            this.btOutrosDatos = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.btTelefonos = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbxEnderezo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btNovoAsegurado
            // 
            this.btNovoAsegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoAsegurado.Location = new System.Drawing.Point(442, 373);
            this.btNovoAsegurado.Name = "btNovoAsegurado";
            this.btNovoAsegurado.Size = new System.Drawing.Size(99, 54);
            this.btNovoAsegurado.TabIndex = 25;
            this.btNovoAsegurado.Text = "Novo Asegurado";
            this.btNovoAsegurado.UseVisualStyleBackColor = true;
            this.btNovoAsegurado.Click += new System.EventHandler(this.btNovoAsegurado_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(0, -1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(559, 33);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Seguros MiViDA";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 201);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(525, 16);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "datos asegurado";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxDatosAsegurado
            // 
            this.lbxDatosAsegurado.Enabled = false;
            this.lbxDatosAsegurado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDatosAsegurado.FormattingEnabled = true;
            this.lbxDatosAsegurado.ItemHeight = 14;
            this.lbxDatosAsegurado.Location = new System.Drawing.Point(16, 220);
            this.lbxDatosAsegurado.Name = "lbxDatosAsegurado";
            this.lbxDatosAsegurado.Size = new System.Drawing.Size(525, 144);
            this.lbxDatosAsegurado.TabIndex = 22;
            // 
            // btDatosAsegurado
            // 
            this.btDatosAsegurado.Enabled = false;
            this.btDatosAsegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatosAsegurado.Location = new System.Drawing.Point(16, 170);
            this.btDatosAsegurado.Name = "btDatosAsegurado";
            this.btDatosAsegurado.Size = new System.Drawing.Size(166, 28);
            this.btDatosAsegurado.TabIndex = 21;
            this.btDatosAsegurado.Text = "ver datos asegurado";
            this.btDatosAsegurado.UseVisualStyleBackColor = true;
            this.btDatosAsegurado.Click += new System.EventHandler(this.btDatosAsegurado_Click);
            // 
            // btOutrosDatos
            // 
            this.btOutrosDatos.Enabled = false;
            this.btOutrosDatos.Image = ((System.Drawing.Image)(resources.GetObject("btOutrosDatos.Image")));
            this.btOutrosDatos.Location = new System.Drawing.Point(455, 125);
            this.btOutrosDatos.Name = "btOutrosDatos";
            this.btOutrosDatos.Size = new System.Drawing.Size(86, 36);
            this.btOutrosDatos.TabIndex = 20;
            this.btOutrosDatos.UseVisualStyleBackColor = true;
            this.btOutrosDatos.Click += new System.EventHandler(this.btOutrosDatos_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(455, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 16);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "outros datos";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTelefonos
            // 
            this.btTelefonos.Enabled = false;
            this.btTelefonos.Image = ((System.Drawing.Image)(resources.GetObject("btTelefonos.Image")));
            this.btTelefonos.Location = new System.Drawing.Point(455, 65);
            this.btTelefonos.Name = "btTelefonos";
            this.btTelefonos.Size = new System.Drawing.Size(86, 36);
            this.btTelefonos.TabIndex = 18;
            this.btTelefonos.UseVisualStyleBackColor = true;
            this.btTelefonos.Click += new System.EventHandler(this.btTelefonos_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(455, 50);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 16);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "telefonos";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(13, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(404, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "enderezo";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxEnderezo
            // 
            this.tbxEnderezo.Enabled = false;
            this.tbxEnderezo.Location = new System.Drawing.Point(12, 125);
            this.tbxEnderezo.Name = "tbxEnderezo";
            this.tbxEnderezo.Size = new System.Drawing.Size(405, 20);
            this.tbxEnderezo.TabIndex = 15;
            this.tbxEnderezo.Leave += new System.EventHandler(this.tbxEnderezo_Leave);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(404, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "nome";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxNome
            // 
            this.tbxNome.Enabled = false;
            this.tbxNome.Location = new System.Drawing.Point(12, 77);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(405, 20);
            this.tbxNome.TabIndex = 13;
            this.tbxNome.Leave += new System.EventHandler(this.tbxNome_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a coruña",
            "lugo",
            "ourense",
            "pontevedra"});
            this.comboBox1.Location = new System.Drawing.Point(228, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // fSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 433);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btNovoAsegurado);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lbxDatosAsegurado);
            this.Controls.Add(this.btDatosAsegurado);
            this.Controls.Add(this.btOutrosDatos);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btTelefonos);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbxEnderezo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tbxNome);
            this.Name = "fSeguro";
            this.Text = "seguros vida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btNovoAsegurado;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListBox lbxDatosAsegurado;
        internal System.Windows.Forms.Button btDatosAsegurado;
        internal System.Windows.Forms.Button btOutrosDatos;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btTelefonos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tbxEnderezo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

