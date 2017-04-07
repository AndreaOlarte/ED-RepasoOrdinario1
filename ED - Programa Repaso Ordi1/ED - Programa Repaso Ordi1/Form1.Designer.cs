namespace ED___Programa_Repaso_Ordi1
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
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnevVector = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(12, 12);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 26);
            this.txtTamaño.TabIndex = 0;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(12, 64);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(128, 44);
            this.btnLlenar.TabIndex = 1;
            this.btnLlenar.Text = "Crear y llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 123);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(128, 44);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnevVector
            // 
            this.btnevVector.Location = new System.Drawing.Point(12, 189);
            this.btnevVector.Name = "btnevVector";
            this.btnevVector.Size = new System.Drawing.Size(128, 44);
            this.btnevVector.TabIndex = 3;
            this.btnevVector.Text = "Evaluar vector";
            this.btnevVector.UseVisualStyleBackColor = true;
            this.btnevVector.Click += new System.EventHandler(this.btnevVector_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(173, 28);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(253, 205);
            this.txtMostrar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnevVector);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.txtTamaño);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnevVector;
        private System.Windows.Forms.TextBox txtMostrar;
    }
}

