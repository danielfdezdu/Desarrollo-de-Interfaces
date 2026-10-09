namespace _011_DepositoAgua
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblDeposito1 = new System.Windows.Forms.Label();
            this.lblDeposito2 = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblLitrosMax = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblValorDeposito1 = new System.Windows.Forms.Label();
            this.lblValorDeposito2 = new System.Windows.Forms.Label();
            this.gpModo = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomatico = new System.Windows.Forms.RadioButton();
            this.gpSeleccion = new System.Windows.Forms.GroupBox();
            this.rbDeposito2 = new System.Windows.Forms.RadioButton();
            this.rbDeposito1 = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.btIntroducir = new System.Windows.Forms.Button();
            this.nudIntroducir = new System.Windows.Forms.NumericUpDown();
            this.lblIntroducir = new System.Windows.Forms.Label();
            this.gpSalida = new System.Windows.Forms.GroupBox();
            this.btRetirar = new System.Windows.Forms.Button();
            this.nudRetirar = new System.Windows.Forms.NumericUpDown();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.btVaciar = new System.Windows.Forms.Button();
            this.gbDepositos = new System.Windows.Forms.GroupBox();
            this.gpModo.SuspendLayout();
            this.gpSeleccion.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntroducir)).BeginInit();
            this.gpSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetirar)).BeginInit();
            this.gbDepositos.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 41);
            this.progressBar1.Maximum = 2500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(341, 52);
            this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(15, 112);
            this.progressBar2.Maximum = 2500;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(341, 52);
            this.progressBar2.TabIndex = 1;
            // 
            // lblDeposito1
            // 
            this.lblDeposito1.AutoSize = true;
            this.lblDeposito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito1.Location = new System.Drawing.Point(24, 25);
            this.lblDeposito1.Name = "lblDeposito1";
            this.lblDeposito1.Size = new System.Drawing.Size(68, 13);
            this.lblDeposito1.TabIndex = 3;
            this.lblDeposito1.Text = "Depósito 1";
            // 
            // lblDeposito2
            // 
            this.lblDeposito2.AutoSize = true;
            this.lblDeposito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito2.Location = new System.Drawing.Point(24, 167);
            this.lblDeposito2.Name = "lblDeposito2";
            this.lblDeposito2.Size = new System.Drawing.Size(68, 13);
            this.lblDeposito2.TabIndex = 4;
            this.lblDeposito2.Text = "Depósito 2";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(12, 97);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(22, 13);
            this.lblLitros.TabIndex = 5;
            this.lblLitros.Text = "0 L";
            // 
            // lblLitrosMax
            // 
            this.lblLitrosMax.AutoSize = true;
            this.lblLitrosMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitrosMax.Location = new System.Drawing.Point(321, 97);
            this.lblLitrosMax.Name = "lblLitrosMax";
            this.lblLitrosMax.Size = new System.Drawing.Size(40, 13);
            this.lblLitrosMax.TabIndex = 6;
            this.lblLitrosMax.Text = "5000 L";
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(40, 96);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(275, 13);
            this.lblBarra.TabIndex = 7;
            // 
            // lblValorDeposito1
            // 
            this.lblValorDeposito1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorDeposito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDeposito1.Location = new System.Drawing.Point(362, 62);
            this.lblValorDeposito1.Name = "lblValorDeposito1";
            this.lblValorDeposito1.Size = new System.Drawing.Size(35, 13);
            this.lblValorDeposito1.TabIndex = 8;
            // 
            // lblValorDeposito2
            // 
            this.lblValorDeposito2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorDeposito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDeposito2.Location = new System.Drawing.Point(362, 129);
            this.lblValorDeposito2.Name = "lblValorDeposito2";
            this.lblValorDeposito2.Size = new System.Drawing.Size(35, 13);
            this.lblValorDeposito2.TabIndex = 9;
            // 
            // gpModo
            // 
            this.gpModo.Controls.Add(this.rbManual);
            this.gpModo.Controls.Add(this.rbAutomatico);
            this.gpModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpModo.Location = new System.Drawing.Point(12, 210);
            this.gpModo.Name = "gpModo";
            this.gpModo.Size = new System.Drawing.Size(115, 109);
            this.gpModo.TabIndex = 10;
            this.gpModo.TabStop = false;
            this.gpModo.Text = "Modo de Traballo";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManual.Location = new System.Drawing.Point(7, 75);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAutomatico
            // 
            this.rbAutomatico.AutoSize = true;
            this.rbAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutomatico.Location = new System.Drawing.Point(7, 38);
            this.rbAutomatico.Name = "rbAutomatico";
            this.rbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatico.TabIndex = 0;
            this.rbAutomatico.TabStop = true;
            this.rbAutomatico.Text = "Automático";
            this.rbAutomatico.UseVisualStyleBackColor = true;
            this.rbAutomatico.CheckedChanged += new System.EventHandler(this.OcultarVisualizarSeleccionDeposito);
            // 
            // gpSeleccion
            // 
            this.gpSeleccion.Controls.Add(this.rbDeposito2);
            this.gpSeleccion.Controls.Add(this.rbDeposito1);
            this.gpSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSeleccion.Location = new System.Drawing.Point(12, 325);
            this.gpSeleccion.Name = "gpSeleccion";
            this.gpSeleccion.Size = new System.Drawing.Size(115, 106);
            this.gpSeleccion.TabIndex = 11;
            this.gpSeleccion.TabStop = false;
            this.gpSeleccion.Text = "Seleccionar Depósito";
            // 
            // rbDeposito2
            // 
            this.rbDeposito2.AutoSize = true;
            this.rbDeposito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeposito2.Location = new System.Drawing.Point(7, 71);
            this.rbDeposito2.Name = "rbDeposito2";
            this.rbDeposito2.Size = new System.Drawing.Size(82, 17);
            this.rbDeposito2.TabIndex = 3;
            this.rbDeposito2.TabStop = true;
            this.rbDeposito2.Text = "Depósito -2-";
            this.rbDeposito2.UseVisualStyleBackColor = true;
            // 
            // rbDeposito1
            // 
            this.rbDeposito1.AutoSize = true;
            this.rbDeposito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeposito1.Location = new System.Drawing.Point(7, 38);
            this.rbDeposito1.Name = "rbDeposito1";
            this.rbDeposito1.Size = new System.Drawing.Size(82, 17);
            this.rbDeposito1.TabIndex = 2;
            this.rbDeposito1.TabStop = true;
            this.rbDeposito1.Text = "Depósito -1-";
            this.rbDeposito1.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.btIntroducir);
            this.gbEntrada.Controls.Add(this.nudIntroducir);
            this.gbEntrada.Controls.Add(this.lblIntroducir);
            this.gbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(133, 210);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(300, 109);
            this.gbEntrada.TabIndex = 11;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada de Agua";
            // 
            // btIntroducir
            // 
            this.btIntroducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIntroducir.Location = new System.Drawing.Point(203, 65);
            this.btIntroducir.Name = "btIntroducir";
            this.btIntroducir.Size = new System.Drawing.Size(73, 27);
            this.btIntroducir.TabIndex = 15;
            this.btIntroducir.Text = "Introducir";
            this.btIntroducir.UseVisualStyleBackColor = true;
            this.btIntroducir.Click += new System.EventHandler(this.btIntroducir_Click);
            // 
            // nudIntroducir
            // 
            this.nudIntroducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIntroducir.Location = new System.Drawing.Point(183, 39);
            this.nudIntroducir.Name = "nudIntroducir";
            this.nudIntroducir.Size = new System.Drawing.Size(93, 20);
            this.nudIntroducir.TabIndex = 1;
            // 
            // lblIntroducir
            // 
            this.lblIntroducir.AutoSize = true;
            this.lblIntroducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroducir.Location = new System.Drawing.Point(33, 39);
            this.lblIntroducir.Name = "lblIntroducir";
            this.lblIntroducir.Size = new System.Drawing.Size(130, 20);
            this.lblIntroducir.TabIndex = 0;
            this.lblIntroducir.Text = "Litros a introducir";
            // 
            // gpSalida
            // 
            this.gpSalida.Controls.Add(this.btRetirar);
            this.gpSalida.Controls.Add(this.nudRetirar);
            this.gpSalida.Controls.Add(this.lblRetirar);
            this.gpSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSalida.Location = new System.Drawing.Point(133, 325);
            this.gpSalida.Name = "gpSalida";
            this.gpSalida.Size = new System.Drawing.Size(300, 106);
            this.gpSalida.TabIndex = 11;
            this.gpSalida.TabStop = false;
            this.gpSalida.Text = "Salida de Agua";
            // 
            // btRetirar
            // 
            this.btRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetirar.Location = new System.Drawing.Point(203, 66);
            this.btRetirar.Name = "btRetirar";
            this.btRetirar.Size = new System.Drawing.Size(73, 27);
            this.btRetirar.TabIndex = 16;
            this.btRetirar.Text = "Retirar";
            this.btRetirar.UseVisualStyleBackColor = true;
            this.btRetirar.Click += new System.EventHandler(this.btRetirar_Click);
            // 
            // nudRetirar
            // 
            this.nudRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRetirar.Location = new System.Drawing.Point(183, 40);
            this.nudRetirar.Name = "nudRetirar";
            this.nudRetirar.Size = new System.Drawing.Size(93, 20);
            this.nudRetirar.TabIndex = 2;
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirar.Location = new System.Drawing.Point(57, 40);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(106, 20);
            this.lblRetirar.TabIndex = 1;
            this.lblRetirar.Text = "Litros a retirar";
            // 
            // btVaciar
            // 
            this.btVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVaciar.Location = new System.Drawing.Point(12, 437);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(421, 27);
            this.btVaciar.TabIndex = 13;
            this.btVaciar.Text = "Vaciar Depósitos";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // gbDepositos
            // 
            this.gbDepositos.Controls.Add(this.progressBar1);
            this.gbDepositos.Controls.Add(this.progressBar2);
            this.gbDepositos.Controls.Add(this.lblDeposito1);
            this.gbDepositos.Controls.Add(this.lblDeposito2);
            this.gbDepositos.Controls.Add(this.lblLitros);
            this.gbDepositos.Controls.Add(this.lblLitrosMax);
            this.gbDepositos.Controls.Add(this.lblBarra);
            this.gbDepositos.Controls.Add(this.lblValorDeposito2);
            this.gbDepositos.Controls.Add(this.lblValorDeposito1);
            this.gbDepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepositos.Location = new System.Drawing.Point(12, 12);
            this.gbDepositos.Name = "gbDepositos";
            this.gbDepositos.Size = new System.Drawing.Size(421, 192);
            this.gbDepositos.TabIndex = 14;
            this.gbDepositos.TabStop = false;
            this.gbDepositos.Text = "Vista Depósitos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 484);
            this.Controls.Add(this.gbDepositos);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.gpSalida);
            this.Controls.Add(this.gbEntrada);
            this.Controls.Add(this.gpSeleccion);
            this.Controls.Add(this.gpModo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpModo.ResumeLayout(false);
            this.gpModo.PerformLayout();
            this.gpSeleccion.ResumeLayout(false);
            this.gpSeleccion.PerformLayout();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntroducir)).EndInit();
            this.gpSalida.ResumeLayout(false);
            this.gpSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetirar)).EndInit();
            this.gbDepositos.ResumeLayout(false);
            this.gbDepositos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblDeposito1;
        private System.Windows.Forms.Label lblDeposito2;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblLitrosMax;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Label lblValorDeposito1;
        private System.Windows.Forms.Label lblValorDeposito2;
        private System.Windows.Forms.GroupBox gpModo;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAutomatico;
        private System.Windows.Forms.GroupBox gpSeleccion;
        private System.Windows.Forms.RadioButton rbDeposito2;
        private System.Windows.Forms.RadioButton rbDeposito1;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.Button btIntroducir;
        private System.Windows.Forms.NumericUpDown nudIntroducir;
        private System.Windows.Forms.Label lblIntroducir;
        private System.Windows.Forms.GroupBox gpSalida;
        private System.Windows.Forms.Button btRetirar;
        private System.Windows.Forms.NumericUpDown nudRetirar;
        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.GroupBox gbDepositos;
    }
}

