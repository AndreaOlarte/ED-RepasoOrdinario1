namespace ED___Programa.Repaso_Ordi1_NumAmigos
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
            this.btnObtener = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(12, 12);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(104, 77);
            this.btnObtener.TabIndex = 0;
            this.btnObtener.Text = "Obtener números amigos";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(132, 12);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(282, 327);
            this.txtMostrar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 359);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnObtener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.TextBox txtMostrar;
    }
}

