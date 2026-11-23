namespace Seguro
{
    partial class fOutrosDatos
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
            this.btSair = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbxEdade = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtMuller = new System.Windows.Forms.RadioButton();
            this.rbtHome = new System.Windows.Forms.RadioButton();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(69, 178);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(81, 29);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "gardar e saír";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(138, 18);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "edade";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEdade
            // 
            this.tbxEdade.Location = new System.Drawing.Point(11, 25);
            this.tbxEdade.MaxLength = 2;
            this.tbxEdade.Name = "tbxEdade";
            this.tbxEdade.Size = new System.Drawing.Size(139, 20);
            this.tbxEdade.TabIndex = 6;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtMuller);
            this.gbxSexo.Controls.Add(this.rbtHome);
            this.gbxSexo.Location = new System.Drawing.Point(12, 63);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(138, 93);
            this.gbxSexo.TabIndex = 5;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtMuller
            // 
            this.rbtMuller.AutoSize = true;
            this.rbtMuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMuller.Location = new System.Drawing.Point(41, 54);
            this.rbtMuller.Name = "rbtMuller";
            this.rbtMuller.Size = new System.Drawing.Size(62, 20);
            this.rbtMuller.TabIndex = 1;
            this.rbtMuller.TabStop = true;
            this.rbtMuller.Text = "Muller";
            this.rbtMuller.UseVisualStyleBackColor = true;
            // 
            // rbtHome
            // 
            this.rbtHome.AutoSize = true;
            this.rbtHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHome.Location = new System.Drawing.Point(41, 28);
            this.rbtHome.Name = "rbtHome";
            this.rbtHome.Size = new System.Drawing.Size(63, 20);
            this.rbtHome.TabIndex = 0;
            this.rbtHome.TabStop = true;
            this.rbtHome.Text = "Home";
            this.rbtHome.UseVisualStyleBackColor = true;
            // 
            // fOutrosDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 219);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tbxEdade);
            this.Controls.Add(this.gbxSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fOutrosDatos";
            this.Text = "outros datos";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btSair;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbxEdade;
        internal System.Windows.Forms.GroupBox gbxSexo;
        internal System.Windows.Forms.RadioButton rbtMuller;
        internal System.Windows.Forms.RadioButton rbtHome;
    }
}