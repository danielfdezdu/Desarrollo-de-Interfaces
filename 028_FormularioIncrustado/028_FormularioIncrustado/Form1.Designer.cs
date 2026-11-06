namespace _028_FormularioIncrustado
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
            this.mn = new System.Windows.Forms.MenuStrip();
            this.mnArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoGuardarXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoGuardarPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoGuardarTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBt = new System.Windows.Forms.ToolStrip();
            this.mnBtAbrir = new System.Windows.Forms.ToolStripButton();
            this.mnBtImprimir = new System.Windows.Forms.ToolStripButton();
            this.mnBtSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.mn.SuspendLayout();
            this.mnBt.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn
            // 
            this.mn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArchivo,
            this.mnEdicion,
            this.mnSalir});
            this.mn.Location = new System.Drawing.Point(0, 0);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(734, 24);
            this.mn.TabIndex = 0;
            this.mn.Text = "menuStrip1";
            // 
            // mnArchivo
            // 
            this.mnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArchivoAbrir,
            this.mnArchivoGuardar,
            this.mnArchivoCerrar,
            this.mnArchivoSalir});
            this.mnArchivo.Name = "mnArchivo";
            this.mnArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnArchivo.Text = "Archivo";
            // 
            // mnArchivoAbrir
            // 
            this.mnArchivoAbrir.Name = "mnArchivoAbrir";
            this.mnArchivoAbrir.Size = new System.Drawing.Size(116, 22);
            this.mnArchivoAbrir.Text = "Abrir";
            // 
            // mnArchivoGuardar
            // 
            this.mnArchivoGuardar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArchivoGuardarXML,
            this.mnArchivoGuardarPDF,
            this.mnArchivoGuardarTXT});
            this.mnArchivoGuardar.Name = "mnArchivoGuardar";
            this.mnArchivoGuardar.Size = new System.Drawing.Size(116, 22);
            this.mnArchivoGuardar.Text = "Guardar";
            // 
            // mnArchivoGuardarXML
            // 
            this.mnArchivoGuardarXML.Name = "mnArchivoGuardarXML";
            this.mnArchivoGuardarXML.Size = new System.Drawing.Size(98, 22);
            this.mnArchivoGuardarXML.Text = "XML";
            // 
            // mnArchivoGuardarPDF
            // 
            this.mnArchivoGuardarPDF.Name = "mnArchivoGuardarPDF";
            this.mnArchivoGuardarPDF.Size = new System.Drawing.Size(98, 22);
            this.mnArchivoGuardarPDF.Text = "PDF";
            // 
            // mnArchivoGuardarTXT
            // 
            this.mnArchivoGuardarTXT.Name = "mnArchivoGuardarTXT";
            this.mnArchivoGuardarTXT.Size = new System.Drawing.Size(98, 22);
            this.mnArchivoGuardarTXT.Text = "TXT";
            // 
            // mnArchivoCerrar
            // 
            this.mnArchivoCerrar.Name = "mnArchivoCerrar";
            this.mnArchivoCerrar.Size = new System.Drawing.Size(116, 22);
            this.mnArchivoCerrar.Text = "Cerrar";
            // 
            // mnArchivoSalir
            // 
            this.mnArchivoSalir.Name = "mnArchivoSalir";
            this.mnArchivoSalir.Size = new System.Drawing.Size(116, 22);
            this.mnArchivoSalir.Text = "Salir";
            // 
            // mnEdicion
            // 
            this.mnEdicion.Name = "mnEdicion";
            this.mnEdicion.Size = new System.Drawing.Size(58, 20);
            this.mnEdicion.Text = "Edición";
            // 
            // mnSalir
            // 
            this.mnSalir.Name = "mnSalir";
            this.mnSalir.Size = new System.Drawing.Size(41, 20);
            this.mnSalir.Text = "Salir";
            this.mnSalir.Click += new System.EventHandler(this.mnSalir_Click);
            // 
            // mnBt
            // 
            this.mnBt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBtAbrir,
            this.mnBtImprimir,
            this.mnBtSair,
            this.toolStripComboBox1});
            this.mnBt.Location = new System.Drawing.Point(0, 24);
            this.mnBt.Name = "mnBt";
            this.mnBt.Size = new System.Drawing.Size(734, 25);
            this.mnBt.TabIndex = 1;
            this.mnBt.Text = "toolStrip1";
            // 
            // mnBtAbrir
            // 
            this.mnBtAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnBtAbrir.Image = ((System.Drawing.Image)(resources.GetObject("mnBtAbrir.Image")));
            this.mnBtAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnBtAbrir.Name = "mnBtAbrir";
            this.mnBtAbrir.Size = new System.Drawing.Size(23, 22);
            this.mnBtAbrir.Text = "Abrir archivo";
            // 
            // mnBtImprimir
            // 
            this.mnBtImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnBtImprimir.Image = ((System.Drawing.Image)(resources.GetObject("mnBtImprimir.Image")));
            this.mnBtImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnBtImprimir.Name = "mnBtImprimir";
            this.mnBtImprimir.Size = new System.Drawing.Size(23, 22);
            this.mnBtImprimir.Text = "Imprimir";
            // 
            // mnBtSair
            // 
            this.mnBtSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnBtSair.Image = ((System.Drawing.Image)(resources.GetObject("mnBtSair.Image")));
            this.mnBtSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnBtSair.Name = "mnBtSair";
            this.mnBtSair.Size = new System.Drawing.Size(23, 22);
            this.mnBtSair.Text = "Cerrar";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 563);
            this.Controls.Add(this.mnBt);
            this.Controls.Add(this.mn);
            this.MainMenuStrip = this.mn;
            this.Name = "Form1";
            this.Text = "Formulario principal";
            this.mn.ResumeLayout(false);
            this.mn.PerformLayout();
            this.mnBt.ResumeLayout(false);
            this.mnBt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn;
        private System.Windows.Forms.ToolStripMenuItem mnArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoGuardarXML;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoGuardarPDF;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoGuardarTXT;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoCerrar;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem mnEdicion;
        private System.Windows.Forms.ToolStripMenuItem mnSalir;
        private System.Windows.Forms.ToolStrip mnBt;
        private System.Windows.Forms.ToolStripButton mnBtAbrir;
        private System.Windows.Forms.ToolStripButton mnBtImprimir;
        private System.Windows.Forms.ToolStripButton mnBtSair;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

