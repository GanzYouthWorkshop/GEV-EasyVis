namespace Cairo_Editor.Controls
{
    partial class ColorButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gclPanel1 = new GEV.Layouts.GCLPanel();
            this.SuspendLayout();
            // 
            // gclPanel1
            // 
            this.gclPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.gclPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gclPanel1.Location = new System.Drawing.Point(2, 2);
            this.gclPanel1.Name = "gclPanel1";
            this.gclPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.gclPanel1.Size = new System.Drawing.Size(16, 16);
            this.gclPanel1.TabIndex = 0;
            this.gclPanel1.UseThemeColors = false;
            this.gclPanel1.Click += new System.EventHandler(this.gclPanel1_Click);
            this.gclPanel1.MouseEnter += new System.EventHandler(this.gclPanel1_MouseEnter);
            this.gclPanel1.MouseLeave += new System.EventHandler(this.gclPanel1_MouseLeave);
            // 
            // ColorButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gclPanel1);
            this.Name = "ColorButton";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private GEV.Layouts.GCLPanel gclPanel1;
    }
}
