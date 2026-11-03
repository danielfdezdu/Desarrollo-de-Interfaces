namespace _27_Formularios
{
    partial class fSec_Uno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btIr_a_Sec_Dos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btIr_a_Sec_Dos
            // 
            this.btIr_a_Sec_Dos.Location = new System.Drawing.Point(391, 232);
            this.btIr_a_Sec_Dos.Name = "btIr_a_Sec_Dos";
            this.btIr_a_Sec_Dos.Size = new System.Drawing.Size(138, 39);
            this.btIr_a_Sec_Dos.TabIndex = 7;
            this.btIr_a_Sec_Dos.Text = "Ir a Sec_Dos";
            this.btIr_a_Sec_Dos.UseVisualStyleBackColor = true;
            this.btIr_a_Sec_Dos.Click += new System.EventHandler(this.btIr_a_Sec_Dos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(66, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 251);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "formulario INICIAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(391, 294);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(138, 39);
            this.cerrar.TabIndex = 8;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // fSec_Uno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 550);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.btIr_a_Sec_Dos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "fSec_Uno";
            this.Text = "fSec_Uno";
            this.Load += new System.EventHandler(this.fSec_Uno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIr_a_Sec_Dos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cerrar;
    }
}