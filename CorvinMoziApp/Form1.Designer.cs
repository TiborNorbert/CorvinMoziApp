namespace CorvinMoziApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mentes = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.Button();
            this.job = new System.Windows.Forms.Button();
            this.Baloldal = new System.Windows.Forms.Button();
            this.kep = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.bal = new System.Windows.Forms.Button();
            this.jobb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            this.SuspendLayout();
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(249, 297);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(117, 32);
            this.mentes.TabIndex = 0;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            // 
            // stat
            // 
            this.stat.Location = new System.Drawing.Point(436, 298);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(112, 31);
            this.stat.TabIndex = 1;
            this.stat.Text = "Statisztika";
            this.stat.UseVisualStyleBackColor = true;
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(563, 334);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(122, 56);
            this.job.TabIndex = 3;
            this.job.UseVisualStyleBackColor = true;
            this.job.Click += new System.EventHandler(this.jobb_Click);
            // 
            // Baloldal
            // 
            this.Baloldal.Location = new System.Drawing.Point(57, 334);
            this.Baloldal.Name = "Baloldal";
            this.Baloldal.Size = new System.Drawing.Size(128, 57);
            this.Baloldal.TabIndex = 2;
            this.Baloldal.UseVisualStyleBackColor = true;
            this.Baloldal.Click += new System.EventHandler(this.baloldal_Click);
            // 
            // kep
            // 
            this.kep.Location = new System.Drawing.Point(52, 54);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(120, 154);
            this.kep.TabIndex = 4;
            this.kep.TabStop = false;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(260, 44);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(368, 163);
            this.panel.TabIndex = 5;
            // 
            // bal
            // 
            this.bal.Location = new System.Drawing.Point(57, 334);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(128, 57);
            this.bal.TabIndex = 2;
            this.bal.UseVisualStyleBackColor = true;
            // 
            // jobb
            // 
            this.jobb.Location = new System.Drawing.Point(563, 334);
            this.jobb.Name = "jobb";
            this.jobb.Size = new System.Drawing.Size(122, 56);
            this.jobb.TabIndex = 3;
            this.jobb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.kep);
            this.Controls.Add(this.job);
            this.Controls.Add(this.Baloldal);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.mentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Terem";
            this.Load += new System.EventHandler(this.Terem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button stat;
        private System.Windows.Forms.Button Baloldal;
        private System.Windows.Forms.Button job;
        private System.Windows.Forms.PictureBox kep;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bal;
        private System.Windows.Forms.Button jobb;
    }
}

