namespace _010_TrackbarColores
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
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.lblValorRed = new System.Windows.Forms.Label();
            this.lblValorGreen = new System.Windows.Forms.Label();
            this.lblValorBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(177, 98);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(383, 45);
            this.tbRed.TabIndex = 0;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(177, 204);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(383, 45);
            this.tbGreen.TabIndex = 1;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(177, 319);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(383, 45);
            this.tbBlue.TabIndex = 2;
            // 
            // lblValorRed
            // 
            this.lblValorRed.AutoSize = true;
            this.lblValorRed.Location = new System.Drawing.Point(567, 98);
            this.lblValorRed.Name = "lblValorRed";
            this.lblValorRed.Size = new System.Drawing.Size(35, 13);
            this.lblValorRed.TabIndex = 3;
            this.lblValorRed.Text = "label1";
            // 
            // lblValorGreen
            // 
            this.lblValorGreen.AutoSize = true;
            this.lblValorGreen.Location = new System.Drawing.Point(566, 204);
            this.lblValorGreen.Name = "lblValorGreen";
            this.lblValorGreen.Size = new System.Drawing.Size(35, 13);
            this.lblValorGreen.TabIndex = 4;
            this.lblValorGreen.Text = "label2";
            // 
            // lblValorBlue
            // 
            this.lblValorBlue.AutoSize = true;
            this.lblValorBlue.Location = new System.Drawing.Point(566, 319);
            this.lblValorBlue.Name = "lblValorBlue";
            this.lblValorBlue.Size = new System.Drawing.Size(35, 13);
            this.lblValorBlue.TabIndex = 5;
            this.lblValorBlue.Text = "label3";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(183, 82);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(15, 13);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "R";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.Lime;
            this.lblGreen.Location = new System.Drawing.Point(183, 188);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(15, 13);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "G";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.Aqua;
            this.lblBlue.Location = new System.Drawing.Point(183, 303);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(14, 13);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.Text = "B";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(681, 98);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(169, 234);
            this.lblColor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 503);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblValorBlue);
            this.Controls.Add(this.lblValorGreen);
            this.Controls.Add(this.lblValorRed);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label lblValorRed;
        private System.Windows.Forms.Label lblValorGreen;
        private System.Windows.Forms.Label lblValorBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblColor;
    }
}

