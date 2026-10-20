namespace _022_Tragaperras
{
    partial class fInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.lblXogadas = new System.Windows.Forms.Label();
            this.gbxMonedas = new System.Windows.Forms.GroupBox();
            this.bt20 = new System.Windows.Forms.Button();
            this.bt50 = new System.Windows.Forms.Button();
            this.bt01 = new System.Windows.Forms.Button();
            this.bt02 = new System.Windows.Forms.Button();
            this.gbPremios = new System.Windows.Forms.GroupBox();
            this.btConvertir = new System.Windows.Forms.Button();
            this.btDeter = new System.Windows.Forms.Button();
            this.btXogar = new System.Windows.Forms.Button();
            this.btAcumular = new System.Windows.Forms.Button();
            this.btCobrarAcumulado = new System.Windows.Forms.Button();
            this.btCobrarPremio = new System.Windows.Forms.Button();
            this.lblAcumulado = new System.Windows.Forms.Label();
            this.lblPremio = new System.Windows.Forms.Label();
            this.gbFrutas = new System.Windows.Forms.GroupBox();
            this.pbFruta2 = new System.Windows.Forms.PictureBox();
            this.pbFruta3 = new System.Windows.Forms.PictureBox();
            this.pbFruta1 = new System.Windows.Forms.PictureBox();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.gbxMonedas.SuspendLayout();
            this.gbPremios.SuspendLayout();
            this.gbFrutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "xogadas pendentes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXogadas
            // 
            this.lblXogadas.BackColor = System.Drawing.Color.Black;
            this.lblXogadas.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXogadas.ForeColor = System.Drawing.Color.Lime;
            this.lblXogadas.Location = new System.Drawing.Point(619, 222);
            this.lblXogadas.Name = "lblXogadas";
            this.lblXogadas.Size = new System.Drawing.Size(136, 44);
            this.lblXogadas.TabIndex = 19;
            this.lblXogadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxMonedas
            // 
            this.gbxMonedas.Controls.Add(this.bt20);
            this.gbxMonedas.Controls.Add(this.bt50);
            this.gbxMonedas.Controls.Add(this.bt01);
            this.gbxMonedas.Controls.Add(this.bt02);
            this.gbxMonedas.Location = new System.Drawing.Point(601, 15);
            this.gbxMonedas.Name = "gbxMonedas";
            this.gbxMonedas.Size = new System.Drawing.Size(171, 181);
            this.gbxMonedas.TabIndex = 23;
            this.gbxMonedas.TabStop = false;
            // 
            // bt20
            // 
            this.bt20.BackColor = System.Drawing.Color.Transparent;
            this.bt20.FlatAppearance.BorderSize = 0;
            this.bt20.Image = ((System.Drawing.Image)(resources.GetObject("bt20.Image")));
            this.bt20.Location = new System.Drawing.Point(90, 98);
            this.bt20.Name = "bt20";
            this.bt20.Size = new System.Drawing.Size(65, 65);
            this.bt20.TabIndex = 3;
            this.bt20.UseVisualStyleBackColor = false;
            // 
            // bt50
            // 
            this.bt50.Image = ((System.Drawing.Image)(resources.GetObject("bt50.Image")));
            this.bt50.Location = new System.Drawing.Point(19, 98);
            this.bt50.Name = "bt50";
            this.bt50.Size = new System.Drawing.Size(65, 65);
            this.bt50.TabIndex = 2;
            this.bt50.UseVisualStyleBackColor = true;
            // 
            // bt01
            // 
            this.bt01.Image = ((System.Drawing.Image)(resources.GetObject("bt01.Image")));
            this.bt01.Location = new System.Drawing.Point(90, 27);
            this.bt01.Name = "bt01";
            this.bt01.Size = new System.Drawing.Size(65, 65);
            this.bt01.TabIndex = 1;
            this.bt01.UseVisualStyleBackColor = true;
            // 
            // bt02
            // 
            this.bt02.Image = ((System.Drawing.Image)(resources.GetObject("bt02.Image")));
            this.bt02.Location = new System.Drawing.Point(19, 27);
            this.bt02.Name = "bt02";
            this.bt02.Size = new System.Drawing.Size(65, 65);
            this.bt02.TabIndex = 0;
            this.bt02.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt02.UseVisualStyleBackColor = true;
            // 
            // gbPremios
            // 
            this.gbPremios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbPremios.Controls.Add(this.btConvertir);
            this.gbPremios.Controls.Add(this.btDeter);
            this.gbPremios.Controls.Add(this.btXogar);
            this.gbPremios.Controls.Add(this.btAcumular);
            this.gbPremios.Controls.Add(this.btCobrarAcumulado);
            this.gbPremios.Controls.Add(this.btCobrarPremio);
            this.gbPremios.Controls.Add(this.lblAcumulado);
            this.gbPremios.Controls.Add(this.lblPremio);
            this.gbPremios.Location = new System.Drawing.Point(12, 284);
            this.gbPremios.Name = "gbPremios";
            this.gbPremios.Size = new System.Drawing.Size(760, 152);
            this.gbPremios.TabIndex = 22;
            this.gbPremios.TabStop = false;
            // 
            // btConvertir
            // 
            this.btConvertir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btConvertir.Enabled = false;
            this.btConvertir.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvertir.ForeColor = System.Drawing.Color.Red;
            this.btConvertir.Location = new System.Drawing.Point(264, 88);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(97, 48);
            this.btConvertir.TabIndex = 12;
            this.btConvertir.Text = "Convertir en Xogadas";
            this.btConvertir.UseVisualStyleBackColor = false;
            // 
            // btDeter
            // 
            this.btDeter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDeter.Enabled = false;
            this.btDeter.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeter.ForeColor = System.Drawing.Color.Red;
            this.btDeter.Location = new System.Drawing.Point(472, 24);
            this.btDeter.Name = "btDeter";
            this.btDeter.Size = new System.Drawing.Size(120, 104);
            this.btDeter.TabIndex = 11;
            this.btDeter.Text = "DETER";
            this.btDeter.UseVisualStyleBackColor = false;
            // 
            // btXogar
            // 
            this.btXogar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btXogar.Enabled = false;
            this.btXogar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXogar.ForeColor = System.Drawing.Color.Red;
            this.btXogar.Location = new System.Drawing.Point(624, 24);
            this.btXogar.Name = "btXogar";
            this.btXogar.Size = new System.Drawing.Size(120, 104);
            this.btXogar.TabIndex = 10;
            this.btXogar.Text = "XOGAR";
            this.btXogar.UseVisualStyleBackColor = false;
            // 
            // btAcumular
            // 
            this.btAcumular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btAcumular.Enabled = false;
            this.btAcumular.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcumular.ForeColor = System.Drawing.Color.Red;
            this.btAcumular.Location = new System.Drawing.Point(264, 24);
            this.btAcumular.Name = "btAcumular";
            this.btAcumular.Size = new System.Drawing.Size(97, 48);
            this.btAcumular.TabIndex = 9;
            this.btAcumular.Text = "Acumular";
            this.btAcumular.UseVisualStyleBackColor = false;
            // 
            // btCobrarAcumulado
            // 
            this.btCobrarAcumulado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCobrarAcumulado.Enabled = false;
            this.btCobrarAcumulado.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCobrarAcumulado.ForeColor = System.Drawing.Color.Red;
            this.btCobrarAcumulado.Location = new System.Drawing.Point(16, 88);
            this.btCobrarAcumulado.Name = "btCobrarAcumulado";
            this.btCobrarAcumulado.Size = new System.Drawing.Size(88, 48);
            this.btCobrarAcumulado.TabIndex = 8;
            this.btCobrarAcumulado.Text = "Cobrar Acumulado";
            this.btCobrarAcumulado.UseVisualStyleBackColor = false;
            // 
            // btCobrarPremio
            // 
            this.btCobrarPremio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCobrarPremio.Enabled = false;
            this.btCobrarPremio.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCobrarPremio.ForeColor = System.Drawing.Color.Red;
            this.btCobrarPremio.Location = new System.Drawing.Point(16, 24);
            this.btCobrarPremio.Name = "btCobrarPremio";
            this.btCobrarPremio.Size = new System.Drawing.Size(88, 48);
            this.btCobrarPremio.TabIndex = 7;
            this.btCobrarPremio.Text = "Cobrar Premio";
            this.btCobrarPremio.UseVisualStyleBackColor = false;
            // 
            // lblAcumulado
            // 
            this.lblAcumulado.BackColor = System.Drawing.Color.Black;
            this.lblAcumulado.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumulado.ForeColor = System.Drawing.Color.Lime;
            this.lblAcumulado.Location = new System.Drawing.Point(112, 88);
            this.lblAcumulado.Name = "lblAcumulado";
            this.lblAcumulado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAcumulado.Size = new System.Drawing.Size(144, 48);
            this.lblAcumulado.TabIndex = 6;
            this.lblAcumulado.Text = "0";
            this.lblAcumulado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPremio
            // 
            this.lblPremio.BackColor = System.Drawing.Color.Black;
            this.lblPremio.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio.ForeColor = System.Drawing.Color.Lime;
            this.lblPremio.Location = new System.Drawing.Point(112, 24);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPremio.Size = new System.Drawing.Size(144, 48);
            this.lblPremio.TabIndex = 5;
            this.lblPremio.Text = "0";
            this.lblPremio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbFrutas
            // 
            this.gbFrutas.BackColor = System.Drawing.Color.DarkGray;
            this.gbFrutas.Controls.Add(this.pbFruta2);
            this.gbFrutas.Controls.Add(this.pbFruta3);
            this.gbFrutas.Controls.Add(this.pbFruta1);
            this.gbFrutas.Enabled = false;
            this.gbFrutas.Location = new System.Drawing.Point(12, 12);
            this.gbFrutas.Name = "gbFrutas";
            this.gbFrutas.Size = new System.Drawing.Size(552, 256);
            this.gbFrutas.TabIndex = 21;
            this.gbFrutas.TabStop = false;
            // 
            // pbFruta2
            // 
            this.pbFruta2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFruta2.Image = ((System.Drawing.Image)(resources.GetObject("pbFruta2.Image")));
            this.pbFruta2.Location = new System.Drawing.Point(208, 24);
            this.pbFruta2.Name = "pbFruta2";
            this.pbFruta2.Size = new System.Drawing.Size(136, 200);
            this.pbFruta2.TabIndex = 1;
            this.pbFruta2.TabStop = false;
            // 
            // pbFruta3
            // 
            this.pbFruta3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFruta3.Image = ((System.Drawing.Image)(resources.GetObject("pbFruta3.Image")));
            this.pbFruta3.Location = new System.Drawing.Point(384, 24);
            this.pbFruta3.Name = "pbFruta3";
            this.pbFruta3.Size = new System.Drawing.Size(136, 200);
            this.pbFruta3.TabIndex = 2;
            this.pbFruta3.TabStop = false;
            // 
            // pbFruta1
            // 
            this.pbFruta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFruta1.Image = ((System.Drawing.Image)(resources.GetObject("pbFruta1.Image")));
            this.pbFruta1.Location = new System.Drawing.Point(32, 24);
            this.pbFruta1.Name = "pbFruta1";
            this.pbFruta1.Size = new System.Drawing.Size(136, 200);
            this.pbFruta1.TabIndex = 0;
            this.pbFruta1.TabStop = false;
            // 
            // temporizador
            // 
            this.temporizador.Interval = 200;
            // 
            // fInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblXogadas);
            this.Controls.Add(this.gbxMonedas);
            this.Controls.Add(this.gbPremios);
            this.Controls.Add(this.gbFrutas);
            this.Name = "fInicio";
            this.Text = "Tragaperras";
            this.gbxMonedas.ResumeLayout(false);
            this.gbPremios.ResumeLayout(false);
            this.gbFrutas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblXogadas;
        private System.Windows.Forms.GroupBox gbxMonedas;
        private System.Windows.Forms.Button bt20;
        private System.Windows.Forms.Button bt50;
        private System.Windows.Forms.Button bt01;
        private System.Windows.Forms.Button bt02;
        internal System.Windows.Forms.GroupBox gbPremios;
        internal System.Windows.Forms.Button btConvertir;
        internal System.Windows.Forms.Button btDeter;
        internal System.Windows.Forms.Button btXogar;
        internal System.Windows.Forms.Button btAcumular;
        internal System.Windows.Forms.Button btCobrarAcumulado;
        internal System.Windows.Forms.Button btCobrarPremio;
        internal System.Windows.Forms.Label lblAcumulado;
        internal System.Windows.Forms.Label lblPremio;
        internal System.Windows.Forms.GroupBox gbFrutas;
        internal System.Windows.Forms.PictureBox pbFruta2;
        internal System.Windows.Forms.PictureBox pbFruta3;
        internal System.Windows.Forms.PictureBox pbFruta1;
        private System.Windows.Forms.Timer temporizador;
    }
}

