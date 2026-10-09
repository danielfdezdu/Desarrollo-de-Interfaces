namespace _13_Sender
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
            this.btUNO = new System.Windows.Forms.Button();
            this.btDOS = new System.Windows.Forms.Button();
            this.btTRES = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUNO
            // 
            this.btUNO.Location = new System.Drawing.Point(159, 112);
            this.btUNO.Name = "btUNO";
            this.btUNO.Size = new System.Drawing.Size(75, 34);
            this.btUNO.TabIndex = 0;
            this.btUNO.Text = "Uno";
            this.btUNO.UseVisualStyleBackColor = true;
            this.btUNO.Click += new System.EventHandler(this.revisaBoton);
            // 
            // btDOS
            // 
            this.btDOS.Location = new System.Drawing.Point(159, 173);
            this.btDOS.Name = "btDOS";
            this.btDOS.Size = new System.Drawing.Size(75, 33);
            this.btDOS.TabIndex = 1;
            this.btDOS.Text = "Dos";
            this.btDOS.UseVisualStyleBackColor = true;
            this.btDOS.Click += new System.EventHandler(this.revisaBoton);
            // 
            // btTRES
            // 
            this.btTRES.Location = new System.Drawing.Point(159, 246);
            this.btTRES.Name = "btTRES";
            this.btTRES.Size = new System.Drawing.Size(75, 33);
            this.btTRES.TabIndex = 2;
            this.btTRES.Text = "Tres";
            this.btTRES.UseVisualStyleBackColor = true;
            this.btTRES.Click += new System.EventHandler(this.revisaBoton);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensaje.Location = new System.Drawing.Point(324, 167);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(159, 44);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "lblMensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 492);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btTRES);
            this.Controls.Add(this.btDOS);
            this.Controls.Add(this.btUNO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUNO;
        private System.Windows.Forms.Button btDOS;
        private System.Windows.Forms.Button btTRES;
        private System.Windows.Forms.Label lblMensaje;
    }
}

