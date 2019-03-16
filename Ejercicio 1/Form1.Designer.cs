namespace Ejercicio_1
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
            this.txtvelocidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmulta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvelocidad
            // 
            this.txtvelocidad.Location = new System.Drawing.Point(280, 148);
            this.txtvelocidad.Name = "txtvelocidad";
            this.txtvelocidad.Size = new System.Drawing.Size(102, 20);
            this.txtvelocidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la velocidad a la que se dirigia";
            // 
            // lblmulta
            // 
            this.lblmulta.AutoSize = true;
            this.lblmulta.Location = new System.Drawing.Point(280, 199);
            this.lblmulta.Name = "lblmulta";
            this.lblmulta.Size = new System.Drawing.Size(13, 13);
            this.lblmulta.TabIndex = 2;
            this.lblmulta.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio a pagar";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(400, 148);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(36, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 387);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblmulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvelocidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvelocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnok;
    }
}

