
namespace Proyecto_3
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.lblresul = new System.Windows.Forms.Label();
            this.cmdresultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(78, 103);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(136, 96);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(178, 20);
            this.txtpeso.TabIndex = 1;
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(78, 160);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(46, 13);
            this.lblEstatura.TabIndex = 2;
            this.lblEstatura.Text = "Estatura";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(136, 153);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(178, 20);
            this.txtestatura.TabIndex = 3;
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Location = new System.Drawing.Point(220, 219);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(13, 13);
            this.lblresul.TabIndex = 4;
            this.lblresul.Text = "0";
            // 
            // cmdresultado
            // 
            this.cmdresultado.Location = new System.Drawing.Point(136, 267);
            this.cmdresultado.Name = "cmdresultado";
            this.cmdresultado.Size = new System.Drawing.Size(167, 46);
            this.cmdresultado.TabIndex = 5;
            this.cmdresultado.Text = "Resultado";
            this.cmdresultado.UseVisualStyleBackColor = true;
            this.cmdresultado.Click += new System.EventHandler(this.cmdresultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(441, 398);
            this.Controls.Add(this.cmdresultado);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblPeso);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.Button cmdresultado;
    }
}

