namespace _015_Array2D
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
            this.btCargar = new System.Windows.Forms.Button();
            this.pbBarra = new System.Windows.Forms.ProgressBar();
            this.btContido = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblColocar = new System.Windows.Forms.Label();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btCargar
            // 
            this.btCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargar.Location = new System.Drawing.Point(139, 29);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(97, 45);
            this.btCargar.TabIndex = 0;
            this.btCargar.Text = "Cargar Array";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // pbBarra
            // 
            this.pbBarra.Location = new System.Drawing.Point(30, 90);
            this.pbBarra.Maximum = 30;
            this.pbBarra.Name = "pbBarra";
            this.pbBarra.Size = new System.Drawing.Size(315, 45);
            this.pbBarra.TabIndex = 1;
            // 
            // btContido
            // 
            this.btContido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContido.Location = new System.Drawing.Point(139, 215);
            this.btContido.Name = "btContido";
            this.btContido.Size = new System.Drawing.Size(97, 52);
            this.btContido.TabIndex = 2;
            this.btContido.Text = "Contido Array";
            this.btContido.UseVisualStyleBackColor = true;
            this.btContido.Click += new System.EventHandler(this.btContido_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.BackColor = System.Drawing.Color.LightSalmon;
            this.lblIntentos.Location = new System.Drawing.Point(257, 39);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(88, 25);
            this.lblIntentos.TabIndex = 3;
            // 
            // lblColocar
            // 
            this.lblColocar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblColocar.Location = new System.Drawing.Point(30, 152);
            this.lblColocar.Name = "lblColocar";
            this.lblColocar.Size = new System.Drawing.Size(315, 48);
            this.lblColocar.TabIndex = 4;
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(375, 29);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(267, 238);
            this.lbxLista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 310);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.lblColocar);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.btContido);
            this.Controls.Add(this.pbBarra);
            this.Controls.Add(this.btCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.ProgressBar pbBarra;
        private System.Windows.Forms.Button btContido;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblColocar;
        private System.Windows.Forms.ListBox lbxLista;
    }
}

