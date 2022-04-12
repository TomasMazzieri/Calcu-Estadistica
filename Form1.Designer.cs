
namespace matematica
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnModa = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(138, 92);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(75, 23);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 1;
            // 
            // lblMedia
            // 
            this.lblMedia.Location = new System.Drawing.Point(150, 69);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(49, 20);
            this.lblMedia.TabIndex = 2;
            // 
            // btnModa
            // 
            this.btnModa.Location = new System.Drawing.Point(31, 92);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(75, 23);
            this.btnModa.TabIndex = 3;
            this.btnModa.Text = "Moda";
            this.btnModa.UseVisualStyleBackColor = true;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(246, 92);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(75, 23);
            this.btnMediana.TabIndex = 4;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // lblMediana
            // 
            this.lblMediana.Location = new System.Drawing.Point(257, 68);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(49, 20);
            this.lblMediana.TabIndex = 5;
            // 
            // lblModa
            // 
            this.lblModa.Location = new System.Drawing.Point(43, 68);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(49, 20);
            this.lblModa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 178);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.btnModa);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnModa;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblModa;
    }
}

