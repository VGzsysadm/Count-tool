namespace Crypter
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.resum = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.incDirs = new System.Windows.Forms.CheckBox();
            this.Dir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(249, 214);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(337, 23);
            this.progressBar.TabIndex = 0;
            // 
            // resum
            // 
            this.resum.AutoSize = true;
            this.resum.Location = new System.Drawing.Point(249, 197);
            this.resum.Name = "resum";
            this.resum.Size = new System.Drawing.Size(0, 13);
            this.resum.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(249, 266);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // incDirs
            // 
            this.incDirs.AutoSize = true;
            this.incDirs.Location = new System.Drawing.Point(252, 243);
            this.incDirs.Name = "incDirs";
            this.incDirs.Size = new System.Drawing.Size(129, 17);
            this.incDirs.TabIndex = 3;
            this.incDirs.Text = "Include subdirectories";
            this.incDirs.UseVisualStyleBackColor = true;
            // 
            // Dir
            // 
            this.Dir.Location = new System.Drawing.Point(168, 174);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(75, 23);
            this.Dir.TabIndex = 4;
            this.Dir.Text = "Examine";
            this.Dir.UseVisualStyleBackColor = true;
            this.Dir.Click += new System.EventHandler(this.Dir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "%UserProfile%\\Downloads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dir);
            this.Controls.Add(this.incDirs);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.resum);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label resum;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox incDirs;
        private System.Windows.Forms.Button Dir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

