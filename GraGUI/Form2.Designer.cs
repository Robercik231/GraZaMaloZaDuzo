namespace GraGUI
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
            this.nazwa = new System.Windows.Forms.Label();
            this.wersja = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazwa
            // 
            this.nazwa.AutoSize = true;
            this.nazwa.Location = new System.Drawing.Point(201, 24);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(38, 13);
            this.nazwa.TabIndex = 0;
            this.nazwa.Text = "nazwa";
            this.nazwa.Click += new System.EventHandler(this.Label1_Click);
            // 
            // wersja
            // 
            this.wersja.AutoSize = true;
            this.wersja.Location = new System.Drawing.Point(201, 52);
            this.wersja.Name = "wersja";
            this.wersja.Size = new System.Drawing.Size(37, 13);
            this.wersja.TabIndex = 1;
            this.wersja.Text = "wersja";
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Location = new System.Drawing.Point(201, 81);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(50, 13);
            this.copy.TabIndex = 2;
            this.copy.Text = "copyright";
            this.copy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(201, 108);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(31, 13);
            this.autor.TabIndex = 3;
            this.autor.Text = "autor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 217);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.wersja);
            this.Controls.Add(this.nazwa);
            this.Name = "Form2";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwa;
        private System.Windows.Forms.Label wersja;
        private System.Windows.Forms.Label copy;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}