namespace Seguro
{
    partial class fTelefonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTelefonos));
            this.btSair = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbxTelefonos = new System.Windows.Forms.ListBox();
            this.btEngadirTelefono = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(200, 243);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(79, 24);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "gardar e saír";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(267, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "telefonos do asegurado (máx. 5 )";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxTelefonos
            // 
            this.lbxTelefonos.FormattingEnabled = true;
            this.lbxTelefonos.Location = new System.Drawing.Point(12, 90);
            this.lbxTelefonos.Name = "lbxTelefonos";
            this.lbxTelefonos.Size = new System.Drawing.Size(267, 147);
            this.lbxTelefonos.TabIndex = 13;
            // 
            // btEngadirTelefono
            // 
            this.btEngadirTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btEngadirTelefono.Image")));
            this.btEngadirTelefono.Location = new System.Drawing.Point(234, 16);
            this.btEngadirTelefono.Name = "btEngadirTelefono";
            this.btEngadirTelefono.Size = new System.Drawing.Size(45, 32);
            this.btEngadirTelefono.TabIndex = 12;
            this.btEngadirTelefono.UseVisualStyleBackColor = true;
            this.btEngadirTelefono.Click += new System.EventHandler(this.btEngadirTelefono_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "telefonos";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(104, 22);
            this.tbxTelefono.MaxLength = 9;
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(125, 20);
            this.tbxTelefono.TabIndex = 10;
            this.tbxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 289);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbxTelefonos);
            this.Controls.Add(this.btEngadirTelefono);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbxTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTelefonos";
            this.Text = "teléfonos do asegurado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btSair;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lbxTelefonos;
        internal System.Windows.Forms.Button btEngadirTelefono;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbxTelefono;
    }
}