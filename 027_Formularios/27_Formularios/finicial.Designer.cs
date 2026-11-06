namespace _27_Formularios
{
    partial class fInicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btIr_a_Sec_Uno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "formulario INICIAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 251);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(255, 146);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(157, 251);
            this.listBox2.TabIndex = 2;
            // 
            // btIr_a_Sec_Uno
            // 
            this.btIr_a_Sec_Uno.Location = new System.Drawing.Point(487, 252);
            this.btIr_a_Sec_Uno.Name = "btIr_a_Sec_Uno";
            this.btIr_a_Sec_Uno.Size = new System.Drawing.Size(138, 39);
            this.btIr_a_Sec_Uno.TabIndex = 3;
            this.btIr_a_Sec_Uno.Text = "Ir a Sec_Uno";
            this.btIr_a_Sec_Uno.UseVisualStyleBackColor = true;
            this.btIr_a_Sec_Uno.Click += new System.EventHandler(this.btIr_a_Sec_Uno_Click);
            // 
            // fInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 543);
            this.Controls.Add(this.btIr_a_Sec_Uno);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "fInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fInicial_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btIr_a_Sec_Uno;
    }
}

