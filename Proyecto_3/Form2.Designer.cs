
namespace Proyecto_3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pbimg1 = new System.Windows.Forms.PictureBox();
            this.cmdregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbimg1
            // 
            this.pbimg1.Image = ((System.Drawing.Image)(resources.GetObject("pbimg1.Image")));
            this.pbimg1.Location = new System.Drawing.Point(113, 12);
            this.pbimg1.Name = "pbimg1";
            this.pbimg1.Size = new System.Drawing.Size(373, 234);
            this.pbimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg1.TabIndex = 0;
            this.pbimg1.TabStop = false;
            // 
            // cmdregresar
            // 
            this.cmdregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdregresar.Location = new System.Drawing.Point(201, 269);
            this.cmdregresar.Name = "cmdregresar";
            this.cmdregresar.Size = new System.Drawing.Size(192, 73);
            this.cmdregresar.TabIndex = 1;
            this.cmdregresar.Text = "Regresar";
            this.cmdregresar.UseVisualStyleBackColor = false;
            this.cmdregresar.Click += new System.EventHandler(this.cmdregresar_Click_1);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(630, 392);
            this.Controls.Add(this.cmdregresar);
            this.Controls.Add(this.pbimg1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdsalir;
        private System.Windows.Forms.PictureBox pbimg1;
        private System.Windows.Forms.Button cmdregresar;
    }
}