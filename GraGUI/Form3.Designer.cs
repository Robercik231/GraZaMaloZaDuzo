namespace GraGUI
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.historia = new System.Windows.Forms.DataGridView();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odpowiedzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.historia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odpowiedzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historia
            // 
            this.historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historia.Location = new System.Drawing.Point(12, 12);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(555, 283);
            this.historia.TabIndex = 0;
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(ModelGry.Gra.State);
            // 
            // odpowiedzBindingSource
            // 
            this.odpowiedzBindingSource.DataSource = typeof(ModelGry.Gra.Odpowiedz);
            // 
            // graBindingSource
            // 
            this.graBindingSource.DataSource = typeof(ModelGry.Gra);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 316);
            this.Controls.Add(this.historia);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.historia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odpowiedzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historia;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.BindingSource graBindingSource;
        private System.Windows.Forms.BindingSource odpowiedzBindingSource;
    }
}