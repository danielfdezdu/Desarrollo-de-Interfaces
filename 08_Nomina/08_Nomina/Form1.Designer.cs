namespace _08_Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFillos = new System.Windows.Forms.TextBox();
            this.tbIRPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbViuvo = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb10anos = new System.Windows.Forms.CheckBox();
            this.cbDpto = new System.Windows.Forms.CheckBox();
            this.cbMenor = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCampLiquido = new System.Windows.Forms.Label();
            this.lblCampIRPF = new System.Windows.Forms.Label();
            this.lblCampOutros = new System.Windows.Forms.Label();
            this.lblCampCivil = new System.Windows.Forms.Label();
            this.lblCampFil = new System.Windows.Forms.Label();
            this.lblCampBruto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoldo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFillos);
            this.groupBox1.Controls.Add(this.tbIRPF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(57, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Xerais";
            // 
            // tbFillos
            // 
            this.tbFillos.Location = new System.Drawing.Point(73, 78);
            this.tbFillos.Name = "tbFillos";
            this.tbFillos.Size = new System.Drawing.Size(49, 20);
            this.tbFillos.TabIndex = 11;
            // 
            // tbIRPF
            // 
            this.tbIRPF.Location = new System.Drawing.Point(73, 32);
            this.tbIRPF.Name = "tbIRPF";
            this.tbIRPF.Size = new System.Drawing.Size(49, 20);
            this.tbIRPF.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Fillos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "% IRPF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbViuvo);
            this.groupBox2.Controls.Add(this.rbCasado);
            this.groupBox2.Controls.Add(this.rbSolteiro);
            this.groupBox2.Location = new System.Drawing.Point(243, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rbViuvo
            // 
            this.rbViuvo.AutoSize = true;
            this.rbViuvo.Location = new System.Drawing.Point(18, 124);
            this.rbViuvo.Name = "rbViuvo";
            this.rbViuvo.Size = new System.Drawing.Size(63, 17);
            this.rbViuvo.TabIndex = 2;
            this.rbViuvo.TabStop = true;
            this.rbViuvo.Text = "Viúvo/a";
            this.rbViuvo.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(18, 79);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(72, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado/a";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Location = new System.Drawing.Point(18, 35);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(71, 17);
            this.rbSolteiro.TabIndex = 0;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro/a";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb10anos);
            this.groupBox3.Controls.Add(this.cbDpto);
            this.groupBox3.Controls.Add(this.cbMenor);
            this.groupBox3.Location = new System.Drawing.Point(408, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 211);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros Complementos";
            // 
            // cb10anos
            // 
            this.cb10anos.AutoSize = true;
            this.cb10anos.Location = new System.Drawing.Point(22, 124);
            this.cb10anos.Name = "cb10anos";
            this.cb10anos.Size = new System.Drawing.Size(146, 17);
            this.cb10anos.TabIndex = 2;
            this.cb10anos.Text = "+ de 10 anos na empresa";
            this.cb10anos.UseVisualStyleBackColor = true;
            // 
            // cbDpto
            // 
            this.cbDpto.AutoSize = true;
            this.cbDpto.Location = new System.Drawing.Point(22, 79);
            this.cbDpto.Name = "cbDpto";
            this.cbDpto.Size = new System.Drawing.Size(96, 17);
            this.cbDpto.TabIndex = 1;
            this.cbDpto.Text = "Dpto. Almacén";
            this.cbDpto.UseVisualStyleBackColor = true;
            // 
            // cbMenor
            // 
            this.cbMenor.AutoSize = true;
            this.cbMenor.Location = new System.Drawing.Point(22, 35);
            this.cbMenor.Name = "cbMenor";
            this.cbMenor.Size = new System.Drawing.Size(112, 17);
            this.cbMenor.TabIndex = 0;
            this.cbMenor.Text = "Menor de 50 anos";
            this.cbMenor.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCampLiquido);
            this.groupBox4.Controls.Add(this.lblCampIRPF);
            this.groupBox4.Controls.Add(this.lblCampOutros);
            this.groupBox4.Controls.Add(this.lblCampCivil);
            this.groupBox4.Controls.Add(this.lblCampFil);
            this.groupBox4.Controls.Add(this.lblCampBruto);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(622, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 359);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desglose Nómina";
            // 
            // lblCampLiquido
            // 
            this.lblCampLiquido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampLiquido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampLiquido.Location = new System.Drawing.Point(269, 258);
            this.lblCampLiquido.Name = "lblCampLiquido";
            this.lblCampLiquido.Size = new System.Drawing.Size(100, 27);
            this.lblCampLiquido.TabIndex = 11;
            this.lblCampLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampIRPF
            // 
            this.lblCampIRPF.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampIRPF.ForeColor = System.Drawing.Color.Red;
            this.lblCampIRPF.Location = new System.Drawing.Point(269, 204);
            this.lblCampIRPF.Name = "lblCampIRPF";
            this.lblCampIRPF.Size = new System.Drawing.Size(100, 27);
            this.lblCampIRPF.TabIndex = 10;
            this.lblCampIRPF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampOutros
            // 
            this.lblCampOutros.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampOutros.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampOutros.Location = new System.Drawing.Point(269, 137);
            this.lblCampOutros.Name = "lblCampOutros";
            this.lblCampOutros.Size = new System.Drawing.Size(100, 38);
            this.lblCampOutros.TabIndex = 9;
            this.lblCampOutros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampCivil
            // 
            this.lblCampCivil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampCivil.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampCivil.Location = new System.Drawing.Point(269, 100);
            this.lblCampCivil.Name = "lblCampCivil";
            this.lblCampCivil.Size = new System.Drawing.Size(100, 37);
            this.lblCampCivil.TabIndex = 8;
            this.lblCampCivil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampFil
            // 
            this.lblCampFil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampFil.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampFil.Location = new System.Drawing.Point(269, 68);
            this.lblCampFil.Name = "lblCampFil";
            this.lblCampFil.Size = new System.Drawing.Size(100, 32);
            this.lblCampFil.TabIndex = 7;
            this.lblCampFil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampBruto
            // 
            this.lblCampBruto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampBruto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampBruto.Location = new System.Drawing.Point(269, 42);
            this.lblCampBruto.Name = "lblCampBruto";
            this.lblCampBruto.Size = new System.Drawing.Size(100, 26);
            this.lblCampBruto.TabIndex = 6;
            this.lblCampBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "LIQUIDO A PERCIBIR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Desconto IRPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Outros Complementos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Complemento E. Civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Complemento Fillos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soldo Bruto";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(408, 447);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(179, 57);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular Nómina";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(877, 510);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(157, 31);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar Campos";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1064, 105);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nómina dos Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(889, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soldo Bruto";
            // 
            // tbSoldo
            // 
            this.tbSoldo.BackColor = System.Drawing.Color.LightBlue;
            this.tbSoldo.ForeColor = System.Drawing.Color.Red;
            this.tbSoldo.Location = new System.Drawing.Point(57, 161);
            this.tbSoldo.Name = "tbSoldo";
            this.tbSoldo.Size = new System.Drawing.Size(122, 20);
            this.tbSoldo.TabIndex = 12;
            this.tbSoldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1063, 537);
            this.Controls.Add(this.tbSoldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFillos;
        private System.Windows.Forms.TextBox tbIRPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbViuvo;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.CheckBox cb10anos;
        private System.Windows.Forms.CheckBox cbDpto;
        private System.Windows.Forms.CheckBox cbMenor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoldo;
        private System.Windows.Forms.Label lblCampLiquido;
        private System.Windows.Forms.Label lblCampIRPF;
        private System.Windows.Forms.Label lblCampOutros;
        private System.Windows.Forms.Label lblCampCivil;
        private System.Windows.Forms.Label lblCampFil;
        private System.Windows.Forms.Label lblCampBruto;
    }
}

