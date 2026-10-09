namespace _014_Array
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIntroducir = new System.Windows.Forms.Label();
            this.btEngadir = new System.Windows.Forms.Button();
            this.tbNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblIntroducir
            // 
            this.lblIntroducir.AutoSize = true;
            this.lblIntroducir.Location = new System.Drawing.Point(40, 38);
            this.lblIntroducir.Name = "lblIntroducir";
            this.lblIntroducir.Size = new System.Drawing.Size(105, 13);
            this.lblIntroducir.TabIndex = 1;
            this.lblIntroducir.Text = "Introduce un número";
            // 
            // btEngadir
            // 
            this.btEngadir.Location = new System.Drawing.Point(31, 95);
            this.btEngadir.Name = "btEngadir";
            this.btEngadir.Size = new System.Drawing.Size(183, 57);
            this.btEngadir.TabIndex = 2;
            this.btEngadir.Text = "ENGADIR";
            this.btEngadir.UseVisualStyleBackColor = true;
            this.btEngadir.Click += new System.EventHandler(this.btEngadir_Click);
            // 
            // tbNumeros
            // 
            this.tbNumeros.FormattingEnabled = true;
            this.tbNumeros.Location = new System.Drawing.Point(31, 176);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(183, 212);
            this.tbNumeros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 420);
            this.Controls.Add(this.tbNumeros);
            this.Controls.Add(this.btEngadir);
            this.Controls.Add(this.lblIntroducir);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIntroducir;
        private System.Windows.Forms.Button btEngadir;
        private System.Windows.Forms.ListBox tbNumeros;
    }
}

