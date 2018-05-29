namespace Cairo_Editor.Controls
{
    partial class ColorPickerButton
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
            this.gclButton2 = new GEV.Layouts.GCLButton();
            this.gclButton1 = new GEV.Layouts.GCLButton();
            this.SuspendLayout();
            // 
            // gclButton2
            // 
            this.gclButton2.BackColor = System.Drawing.Color.White;
            this.gclButton2.Checked = false;
            this.gclButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gclButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gclButton2.FlatAppearance.BorderSize = 0;
            this.gclButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.gclButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.gclButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gclButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gclButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gclButton2.Location = new System.Drawing.Point(22, 0);
            this.gclButton2.Margin = new System.Windows.Forms.Padding(2);
            this.gclButton2.Name = "gclButton2";
            this.gclButton2.Size = new System.Drawing.Size(8, 24);
            this.gclButton2.TabIndex = 1;
            this.gclButton2.Text = "▼";
            this.gclButton2.UseThemeColors = false;
            this.gclButton2.UseVisualStyleBackColor = false;
            this.gclButton2.Click += new System.EventHandler(this.gclButton2_Click);
            // 
            // gclButton1
            // 
            this.gclButton1.BackColor = System.Drawing.Color.White;
            this.gclButton1.Checked = false;
            this.gclButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gclButton1.FlatAppearance.BorderSize = 0;
            this.gclButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.gclButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.gclButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gclButton1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gclButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gclButton1.Location = new System.Drawing.Point(0, 0);
            this.gclButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gclButton1.Name = "gclButton1";
            this.gclButton1.Size = new System.Drawing.Size(22, 24);
            this.gclButton1.TabIndex = 0;
            this.gclButton1.Text = "";
            this.gclButton1.UseThemeColors = false;
            this.gclButton1.UseVisualStyleBackColor = false;
            this.gclButton1.Click += new System.EventHandler(this.gclButton1_Click);
            // 
            // ColorPickerButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gclButton1);
            this.Controls.Add(this.gclButton2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColorPickerButton";
            this.Size = new System.Drawing.Size(30, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private GEV.Layouts.GCLButton gclButton1;
        private GEV.Layouts.GCLButton gclButton2;
    }
}
